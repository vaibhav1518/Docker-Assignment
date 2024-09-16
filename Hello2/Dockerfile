#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hello2/Hello2.csproj", "Hello2/"]
RUN dotnet restore "Hello2/Hello2.csproj"
COPY . .
WORKDIR "/src/Hello2"
RUN dotnet build "Hello2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hello2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hello2.dll"]