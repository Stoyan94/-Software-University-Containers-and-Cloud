ENG Version:

1. * *Create a Docker image**:
   If you haven�t created your image yet, do so using the following command:
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

�� �� ����� ����������� � Docker Hub, ������� ���� ������:

1. * *������ Docker �����������**:
   ��� ��� �� �� ������ ������������� ��, ������� �� � ���������:
   ```bash
   docker build -t <your-dockerhub-username>/<repository-name>:< tag > .
   ```
   ��������:
   ```bash
   docker build -t stojanmarinov/myapp:latest.
   ```

2. * *����� �� � Docker Hub**:
   ��������� ��������� `docker login`, �� �� �� ������ � ���� Docker Hub ������:
   ```bash
   docker login
   ```
   ������ �� ������� ������ ������������� ��� � ������ �� Docker Hub.

3. **���������� �������������**:
   ��������� ��������� `docker push`, �� �� ����� ������������� � Docker Hub:
   ```bash
   docker push <your-dockerhub-username>/<repository-name>:< tag >
   ```
   ��������:
   ```bash
   docker push stojanmarinov/myapp:latest
   ```

4. **������� Docker Hub**:
   ����� ��[Docker Hub](https://hub.docker.com/) � ������� ���� ������������� � ������ � ���� ������������.