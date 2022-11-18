FROM mcr.microsoft.com/dotnet/runtime:6.0 AS nwsinventaire
ENV PATH $PATH:/root/.dotnet/tools
RUN ls -lah ./Server/bin/Release/net6.0/publish/
COPY ./Server/bin/Release/net6.0/publish/ /app
WORKDIR /app
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server", "--urls=\"http://0.0.0.0:5000\""]