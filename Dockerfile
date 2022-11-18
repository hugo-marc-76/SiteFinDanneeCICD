FROM mcr.microsoft.com/dotnet/sdk:6.0 AS nwsinventaire
WORKDIR /home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/
COPY . /app
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server"]