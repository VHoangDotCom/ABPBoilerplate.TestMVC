FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/CompanyManagement.Web.Host/CompanyManagement.Web.Host.csproj", "src/CompanyManagement.Web.Host/"]
COPY ["src/CompanyManagement.Web.Core/CompanyManagement.Web.Core.csproj", "src/CompanyManagement.Web.Core/"]
COPY ["src/CompanyManagement.Application/CompanyManagement.Application.csproj", "src/CompanyManagement.Application/"]
COPY ["src/CompanyManagement.Core/CompanyManagement.Core.csproj", "src/CompanyManagement.Core/"]
COPY ["src/CompanyManagement.EntityFrameworkCore/CompanyManagement.EntityFrameworkCore.csproj", "src/CompanyManagement.EntityFrameworkCore/"]
WORKDIR "/src/src/CompanyManagement.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CompanyManagement.Web.Host", "src/CompanyManagement.Web.Host"]
COPY ["src/CompanyManagement.Web.Core", "src/CompanyManagement.Web.Core"]
COPY ["src/CompanyManagement.Application", "src/CompanyManagement.Application"]
COPY ["src/CompanyManagement.Core", "src/CompanyManagement.Core"]
COPY ["src/CompanyManagement.EntityFrameworkCore", "src/CompanyManagement.EntityFrameworkCore"]
WORKDIR "/src/src/CompanyManagement.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CompanyManagement.Web.Host.dll"]
