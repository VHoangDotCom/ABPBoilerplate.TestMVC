FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/CompanyManagement.Web.Mvc/CompanyManagement.Web.Mvc.csproj", "src/CompanyManagement.Web.Mvc/"]
COPY ["src/CompanyManagement.Web.Core/CompanyManagement.Web.Core.csproj", "src/CompanyManagement.Web.Core/"]
COPY ["src/CompanyManagement.Application/CompanyManagement.Application.csproj", "src/CompanyManagement.Application/"]
COPY ["src/CompanyManagement.Core/CompanyManagement.Core.csproj", "src/CompanyManagement.Core/"]
COPY ["src/CompanyManagement.EntityFrameworkCore/CompanyManagement.EntityFrameworkCore.csproj", "src/CompanyManagement.EntityFrameworkCore/"]
WORKDIR "/src/src/CompanyManagement.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CompanyManagement.Web.Mvc", "src/CompanyManagement.Web.Mvc"]
COPY ["src/CompanyManagement.Web.Core", "src/CompanyManagement.Web.Core"]
COPY ["src/CompanyManagement.Application", "src/CompanyManagement.Application"]
COPY ["src/CompanyManagement.Core", "src/CompanyManagement.Core"]
COPY ["src/CompanyManagement.EntityFrameworkCore", "src/CompanyManagement.EntityFrameworkCore"]
WORKDIR "/src/src/CompanyManagement.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CompanyManagement.Web.Mvc.dll"]
