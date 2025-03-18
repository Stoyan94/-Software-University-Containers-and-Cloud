English Version:

Docker Layered File System – Image Layer Sharing
Docker uses a layered file system to optimize storage and speed up container builds.
This allows image layers to be shared across different images and containers, reducing duplication and improving efficiency.

🔹 How Does Docker’s Layered File System Work?
Every Docker image consists of multiple layers

Each layer represents a change (diff) compared to the previous layer.
Layers are immutable, meaning they cannot be changed once created.

Sharing layers across images
If multiple images use the same layer, Docker stores it only once.
This minimizes disk usage and speeds up build times.

Containers add a writable layer (container layer)
When a container is started from an image, Docker adds a read-write layer.
Any modifications inside the container are stored in this layer and do not affect the original image.

🔹 Example: Image Layers in Docker
Consider the following Dockerfile:

dockerfile

FROM ubuntu:20.04          # Base image (Layer 1)
RUN apt update && apt install -y curl # Install curl (Layer 2)
COPY app /app              # Copy application files (Layer 3)
CMD ["python3", "/app/main.py"]  # Execution command (Layer 4)

When this Dockerfile is built:
Layer 1 – ubuntu:20.04 is the base layer (pulled from Docker Hub if not cached).
Layer 2 – Installing curl creates a new layer.
Layer 3 – Copying files(app/) adds another layer.
Layer 4 – Defines the execution command.
👉 If we create another image based on ubuntu:20.04, Docker will not download it again, since it is already stored locally.

🔹 Image Layer Sharing
📌 Example: Sharing Layers Across Images
Consider these two Dockerfile definitions:

Image 1:

dockerfile

FROM ubuntu:20.04
RUN apt update && apt install -y curl

Image 2:
dockerfile

FROM ubuntu:20.04
RUN apt update && apt install -y wget
If both images are built, the first layer (ubuntu:20.04) is shared, reducing disk space usage.


🔹 Layer Caching in Docker
Docker uses caching to reuse unchanged layers when rebuilding images. If only the last layer changes, Docker reuses cached layers from previous builds.

Example:

Building this Dockerfile:
dockerfile
FROM python:3.9
COPY requirements.txt /app/
RUN pip install -r /app/requirements.txt
COPY . /app/
If only the last line (COPY. /app/) changes, Docker will not rebuild the previous layers, using cached versions instead.


🔹 Summary
Docker uses a layered file system to optimize storage and builds.
Each layer is immutable and can be shared between images.
Containers add a writable layer, which is deleted when the container is removed.
Docker caches layers, reducing rebuild times and improving efficiency.
This makes Docker a powerful tool for development and deployment! 🚀







БГ Версия:

Docker използва layered file system (слоеста файлова система), за да оптимизира използването на пространство и да ускори изграждането на контейнери.
Това позволява споделяне на слоеве между различни изображения и контейнери, като така се намалява дублирането на данни и се подобрява ефективността.

🔹 Как работи Docker Layered File System?
Всеки Docker образ (image) се състои от множество слоеве (layers)

Всеки слой представлява промяна (diff) спрямо предишния слой.
Слоевете са неизменяеми (immutable) – след като бъдат създадени, не могат да бъдат променяни.

Споделяне на слоеве между изображения
Ако няколко образа използват един и същи слой, Docker го съхранява само веднъж.
Това намалява използваното дисково пространство и ускорява процеса на билдване.

Контейнерите добавят допълнителен слой (container layer)
Когато стартираш контейнер от image, Docker добавя един допълнителен записваем слой (read-write layer).
Всички промени, направени в контейнера, остават в този слой и не променят оригиналния образ.

🔹 Пример със слоеве в Docker Image
Да разгледаме следния Dockerfile:

dockerfile
FROM ubuntu:20.04          # Базов образ (Layer 1)
RUN apt update && apt install -y curl # Инсталиране на curl (Layer 2)
COPY app /app              # Копиране на файлове (Layer 3)
CMD ["python3", "/app/main.py"]  # Команда за изпълнение (Layer 4)

При билдване на този Dockerfile:

Layer 1 – ubuntu:20.04 е базовият слой (изтегля се от Docker Hub, ако не е наличен локално).
Layer 2 – Инсталира curl, създавайки нов слой.
Layer 3 – Копира app/ в контейнера, добавяйки друг слой.
Layer 4 – Определя командата за изпълнение.
👉 Ако създадем нов образ, базиран на ubuntu:20.04, той няма да свали повторно този слой, защото вече е наличен локално.

🔹 Image Layer Sharing (Споделяне на слоеве)
📌 Пример за споделяне на слоеве между образи:
Имаме два Dockerfile:

Образ 1:

dockerfile
FROM ubuntu:20.04
RUN apt update && apt install -y curl

Образ 2:

dockerfile

FROM ubuntu:20.04
RUN apt update && apt install -y wget
Ако ги билднем, първият слой (ubuntu:20.04) ще бъде споделен между двата образа, което значително намалява дисковото пространство.

🔹 Layer Caching (Кеширане на слоеве)
Docker използва кеширане, за да избегне повторното изграждане на неизменени слоеве. 
Ако промениш само последния слой, Docker ще използва кеша за предходните.

Пример:

Билдваме този Dockerfile:
dockerfile

FROM python:3.9
COPY requirements.txt / app /
RUN pip install -r /app/requirements.txt
COPY . /app/
Ако само последният ред (COPY . /app/) се промени, Docker няма да преизгради предишните слоеве, а ще използва кеша.

🔹 Заключение
Docker използва layered file system, за да оптимизира съхранението и изграждането на контейнери.
Всеки слой е неизменяем и може да бъде споделян между различни образи.
Контейнерите добавят записваем слой, който изчезва при изтриването на контейнера.
Docker кешира слоеве, за да ускори изграждането на образи.
Това прави Docker много ефективен за разработка и деплоймент на приложения! 🚀
