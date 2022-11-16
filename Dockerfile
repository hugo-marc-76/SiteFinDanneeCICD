FROM mcr.microsoft.com/dotnet/sdk:6.0 AS nwsinventaire
RUN echo $(ls -1)
WORKDIR /src
COPY ./home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/ .
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server"]