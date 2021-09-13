#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["Rantau/Rantau.csproj", "Rantau/"]
#RUN dotnet restore "Rantau/Rantau.csproj"
#COPY . .
#WORKDIR "/src/Rantau"
#RUN dotnet build "Rantau.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "Rantau.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Rantau.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./Rantau.csproj", "src/"]
RUN dotnet restore "src/Rantau.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Rantau.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "Rantau.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Rantau.dll"]
CMD ["dotnet", "Rantau.dll"]