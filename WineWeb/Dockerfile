FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /app
COPY ./WineWeb ./
RUN dotnet publish -c Release -o output

FROM nginx:alpine
WORKDIR /var/www/web
COPY --from=build /app/output/wwwroot .
COPY ./WineWeb/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80
EXPOSE 443