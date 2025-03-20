ENG Version:

1. * *Create a Docker image**:
   If you haven’t created your image yet, do so using the following command:
   ```bash
   docker build -t <your-dockerhub-username>/<repository-name>:< tag > .
   ```
   For example:
   ```bash
   docker build -t stojanmarinov/myapp:latest.
   ```

2. * *Log in to Docker Hub**:
   Use the `docker login` command to log into your Docker Hub account:
   ```bash
   docker login
   ```
   You will need to enter your Docker Hub username and password.

3. **Push the image to Docker Hub**:
   Use the `docker push` command to upload the image to Docker Hub:
   ```bash
   docker push <your-dockerhub-username>/<repository-name>:< tag >
   ```
   For example:
   ```bash
   docker push stojanmarinov/myapp:latest
   ```

4. **Check Docker Hub**:
   Go to[Docker Hub](https://hub.docker.com/) and verify that your image has been uploaded to your repository.







BG Version:

За да качиш изображение в Docker Hub, следвай тези стъпки:

1. * *Създай Docker изображение**:
   Ако още не си създал изображението си, направи го с командата:
   ```bash
   docker build -t <your-dockerhub-username>/<repository-name>:< tag > .
   ```
   Например:
   ```bash
   docker build -t stojanmarinov/myapp:latest.
   ```

2. * *Логни се в Docker Hub**:
   Използвай командата `docker login`, за да се логнеш в своя Docker Hub акаунт:
   ```bash
   docker login
   ```
   Трябва да въведеш своето потребителско име и парола за Docker Hub.

3. **Публикувай изображението**:
   Използвай командата `docker push`, за да качиш изображението в Docker Hub:
   ```bash
   docker push <your-dockerhub-username>/<repository-name>:< tag >
   ```
   Например:
   ```bash
   docker push stojanmarinov/myapp:latest
   ```

4. **Провери Docker Hub**:
   Отиди на[Docker Hub](https://hub.docker.com/) и провери дали изображението е качено в твоя репозиториум.