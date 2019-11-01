echo off

docker-compose run --rm nodejs npm install
docker-compose run --rm nodejs npm run e2e