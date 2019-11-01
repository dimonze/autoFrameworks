echo off

docker-compose run --rm --entrypoint "bash -c 'chmod +x composer.phar; ./composer.phar install; codecept build'" codecept
docker-compose run --rm codecept run "tests/acceptance/Login.feature:Login selenium test" --steps -o "modules: config: WebDriver: host: chrome"