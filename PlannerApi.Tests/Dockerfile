FROM mcr.microsoft.com/dotnet/sdk:6.0

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'
ENV Sns_LocalMode='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./PlannerApi.sln ./
COPY ./PlannerApi/PlannerApi.csproj ./PlannerApi/
COPY ./PlannerApi.Tests/PlannerApi.Tests.csproj ./PlannerApi.Tests/

RUN dotnet restore ./PlannerApi/PlannerApi.csproj
RUN dotnet restore ./PlannerApi.Tests/PlannerApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug

CMD dotnet test