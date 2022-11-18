FROM mcr.microsoft.com/dotnet/runtime:6.0 AS nwsinventaire
ENV PATH $PATH:/root/.dotnet/tools
WORKDIR /home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/
COPY . /app
WORKDIR /home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/app
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server --urls=\"http://0.0.0.0:5000\""]