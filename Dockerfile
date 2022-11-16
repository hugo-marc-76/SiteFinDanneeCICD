FROM mcr.microsoft.com/dotnet/sdk:6.0 AS nwsinventaire
WORKDIR /src
COPY /Server/bin/Release/net6.0/publish/ .
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server"]