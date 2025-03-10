Working with Containers
docker run <image>

Starts a new container from the specified Docker image.

Example:
docker run -d -p 8080:80 nginx
(Starts a container with the Nginx web server, accessible on port 8080.)


docker ps
Displays a list of running containers.


Add -a to see stopped containers as well:
docker ps -a

docker stop <container_id>
Stops a running container.


docker start <container_id>
Starts a stopped container.


docker restart <container_id>
Restarts a container.


docker rm <container_id>
Deletes a stopped container.


docker logs <container_id>
Displays the logs of a container.



docker exec -it <container_id> bash
Enters a running container in interactive mode.


For Alpine or lightweight Linux distributions, use sh instead of bash.

Working with Images


docker images
Lists locally available Docker images.


docker pull <image>
Downloads a Docker image from Docker Hub.

Example:

docker pull ubuntu
docker build -t <image_name>


Creates a Docker image from the Dockerfile in the current directory.

Example:
docker build -t myapp .


docker rmi <image>
Deletes a Docker image.



Networks and Volumes

docker network ls
Lists Docker networks.

docker network create <network_name>
Creates a new Docker network.

docker volume ls
Lists Docker volumes.

docker volume create<volume_name>
Creates a new Docker volume.


Additional Useful Commands


docker system prune
Cleans up unused containers, images, and networks.

docker stats
Displays real-time resource usage statistics for containers.


docker inspect <container_id>
Shows detailed information about a container.


docker-compose up -d
Starts containers defined in docker-compose.yml in the background.


docker-compose down
Stops and removes all containers from docker-compose.yml.


If you want to learn more about a specific command, you can always use:
docker <command> --help




docker run -d --name ngxdemo nginx
🔹 Explanation:

docker run → starts a new container
- d → runs in "detached" mode (in the background)
--name ngxdemo → assigns the name "ngxdemo" to the container
nginx → uses the Nginx Docker image

To check if the container is running:
docker ps


To stop the container:
docker stop ngxdemo


To remove it after stopping:
docker rm ngxdemo



Работа с контейнери
docker run <image>

Стартира нов контейнер от посочения Docker image.
Пример:
docker run -d -p 8080:80 nginx
(Стартира контейнер с уеб сървър Nginx, достъпен на порт 8080)


docker ps
Показва списък на работещите контейнери.
Добави -a, за да видиш и спрени контейнери
docker ps -a


docker stop <container_id>
Спира работещ контейнер.


docker start <container_id>
Стартира спрян контейнер.


docker restart <container_id>
Рестартира контейнер.


docker rm <container_id>
Изтрива спрян контейнер.


docker logs <container_id>
Показва логовете на контейнера.


docker exec -it <container_id> bash
Влиза в работещ контейнер в интерактивен режим.
За контейнер с Alpine или по-лека Linux дистрибуция използвай sh вместо bash.


🏗 Работа с изображения

docker images
Списък на локално наличните Docker images.


docker pull <image>
Изтегля Docker image от Docker Hub.
Пример:
docker pull ubuntu


docker build -t <image_name> .
Създава Docker image от Dockerfile в текущата директория.

Пример:
docker build -t myapp


docker rmi <image>
Изтрива Docker image.


🔌 Мрежи и обеми

docker network ls
Списък на Docker мрежите.


docker network create <network_name>
Създава нова Docker мрежа.


docker volume ls
Списък на Docker обемите (volumes).


docker volume create <volume_name>
Създава нов Docker volume.


🛠 Допълнителни полезни команди

docker system prune
Изчиства неактивни контейнери, изображения и мрежи.


docker stats
Показва в реално време статистики за използването на ресурси от контейнерите.

docker inspect <container_id>
Показва детайлна информация за контейнер.


docker-compose up -d
Стартира контейнери, дефинирани в docker-compose.yml, в бекграунд.


docker-compose down
Спира и премахва всички контейнери от docker-compose.yml.


Ако искаш да разбереш повече за конкретна команда, винаги можеш да използваш:
docker <command> --help




docker run -d --name ngxdemo nginx
🔹 Обяснение:

docker run → стартира нов контейнер
-d → работи в "detached" режим (на заден план)
--name ngxdemo → задава име "ngxdemo" на контейнера
nginx → използва Docker image с Nginx

След изпълнение на командата можеш да провериш дали контейнерът работи 
docker ps

Ако искаш да го спреш:
docker stop ngxdemo


Ако искаш да го изтриеш след спиране:
docker rm ngxdemo