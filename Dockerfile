# ==========================================
# 1. ETAPA DE COMPILACIÓN (Usa el SDK pesado)
# ==========================================
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Truco de rendimiento: Copiamos SOLO el .csproj primero.
# Esto le dice a Docker que guarde las dependencias descargadas en caché.
# Si solo cambiás código de C#, este paso se lo saltea y compila al instante.
COPY ["EZBook.Api/EZBook.Api.csproj", "EZBook.Api/"]
RUN dotnet restore "EZBook.Api/EZBook.Api.csproj"

# Ahora sí, copiamos el resto de los archivos
COPY . .

# Nos paramos en la carpeta del proyecto y publicamos
WORKDIR "/src/EZBook.Api"
RUN dotnet publish "EZBook.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ==========================================
# 2. ETAPA DE PRODUCCIÓN (Imagen liviana y segura)
# ==========================================
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

# .NET por defecto en Linux expone el puerto 8080 para usuarios no root
EXPOSE 8080

# Seguridad: Ejecutamos la app con un usuario sin privilegios (no root)
USER app

# Copiamos ÚNICAMENTE los archivos compilados (.dll) de la etapa anterior
COPY --from=build /app/publish .

# Comando de arranque de la aplicación
ENTRYPOINT ["dotnet", "EZBook.Api.dll"]
