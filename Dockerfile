FROM ubuntu:focal AS nwsinventaire
RUN export DEBIAN_FRONTEND=noninteractive \
    apt-get update \
    # Install prerequisites
    && apt-get install -y --no-install-recommends \
       wget \
       ca-certificates \
    \
    # Install Microsoft package feed
    && wget -q https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && rm packages-microsoft-prod.deb \
    \
    # Install .NET
    && apt-get update \
    && apt-get install -y --no-install-recommends \
        dotnet-runtime-6.0 \
    \
    # Cleanup
    && rm -rf /var/lib/apt/lists/*

WORKDIR /home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/
COPY . /app
WORKDIR /home/runner/work/SiteFinDanneeCICD/SiteFinDanneeCICD/Server/bin/Release/net6.0/publish/app
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server --urls=\"http://0.0.0.0:5000\""]