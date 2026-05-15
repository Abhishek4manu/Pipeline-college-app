# ── STAGE 1: BUILD ──────────────────────────────────────
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

# Set working folder inside the build container
WORKDIR /src

# Copy project file first — so NuGet restore is cached separately
COPY ["CollegeApp.csproj", "."]

# Download all NuGet packages (Scalar, OpenApi)
RUN dotnet restore

# Copy all your source code
COPY . .

# Compile and publish to /app/publish
RUN dotnet publish -c Release -o /app/publish

# ── STAGE 2: RUN ────────────────────────────────────────
# Stage 2: Run
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Development
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CollegeApp.dll"]