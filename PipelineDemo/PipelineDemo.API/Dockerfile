#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PipelineDemo.API/PipelineDemo.API.csproj", "PipelineDemo.API/"]
RUN dotnet restore "PipelineDemo.API/PipelineDemo.API.csproj"
COPY . .
WORKDIR "/src/PipelineDemo.API"
RUN dotnet build "PipelineDemo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PipelineDemo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PipelineDemo.API.dll"]