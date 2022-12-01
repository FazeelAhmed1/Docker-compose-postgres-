##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
##Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
##For more information, please see https://aka.ms/containercompat
#
#FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /src
#COPY ["DockerTest.csproj", "DockerTest/"]
#RUN dotnet restore "DockerTest/DockerTest.csproj"
#COPY . .
#WORKDIR "/src/DockerTest"
#RUN dotnet build "DockerTest.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "DockerTest.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "/publish/DockerTest.dll"]




FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env

# Change Directory
WORKDIR /src

# Source to destination
COPY *.csproj .

RUN dotnet restore

COPY . .

RUN dotnet publish -c Release -o /publish 

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build-env /publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "DockerTest.dll"]