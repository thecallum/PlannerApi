FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'
ENV Sns_LocalMode='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./PlannerApi.sln ./
COPY ./PlannerApi/PlannerApi.csproj ./PlannerApi/
COPY ./PlannerApi.Tests/PlannerApi.Tests.csproj ./PlannerApi.Tests/

#COPY ../../TokenService/TokenService/dist/TokenService.dll ./

RUN dotnet restore ./PlannerApi/PlannerApi.csproj
RUN dotnet restore ./PlannerApi.Tests/PlannerApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug

# CMD ./PlannerApi.Tests/startup.sh

CMD dotnet test