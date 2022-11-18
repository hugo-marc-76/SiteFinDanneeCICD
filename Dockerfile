FROM mcr.microsoft.com/dotnet/core/runtime:6.0 AS nwsinventaire
ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef --version 6.0
WORKDIR /home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/
COPY . /app
WORKDIR /home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/app
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server --urls=\"http://0.0.0.0:5000\""]