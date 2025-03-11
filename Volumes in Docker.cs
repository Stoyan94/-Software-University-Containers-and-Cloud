ENG Version:

To add a volume to an already existing Docker container, you can't do it directly with a command like docker run. 

Instead, you need to use the following approach:

Create a new container with the same settings as the old one, but with an added volume: 
You can create a new container from the same image and add a volume using the docker run command with the -v parameter.

Example:

docker run -d --name new_container -v c:\ST:/ stoyancontainer < image_name >

Copy data from the old container to the new one: If you have data in the old container, you can copy it to the new container using docker cp or other mechanisms.

Use docker exec to add a volume: To mount a directory into a container that is already running, you can use the docker exec command, 
but keep in mind that this will not create a permanent volume, and it will only create a link to the directory for the current session.

Example:
docker exec -it <container_id_or_name> bash
mount --bind c:\ST / stoyancontainer
This will only apply for the current execution of the container and won't create a permanent volume. 
If you want a permanent link, you need to create a new container with the necessary volume settings.




Volumes in Docker
Volumes in Docker are used to manage data outside of containers.
They allow data to persist even when containers are deleted or recreated, while also providing a way to share data between different containers. 
This is very useful for storing configuration files, databases, log files, and other important data.

Here�s a real-world example:

Example: Using a volume for a database
Imagine you want to run a MySQL container with a database, and you want to store the data in a separate volume so that it�s not lost when the container is removed.

Create a MySQL container with a volume:

You will create a container that uses a volume to store data related to MySQL.

docker run -d \
  --name mysql-container \
  -e MYSQL_ROOT_PASSWORD=rootpassword \
  -v mysql-data:/ var / lib / mysql \
  mysql: latest

Here:

-v mysql - data:/ var / lib / mysql creates a volume named mysql-data, which will be used to store the database in the /var/lib/mysql directory inside the container.
MYSQL_ROOT_PASSWORD=rootpassword sets the root password for MySQL.

What does the volume do?

Data persistence: The volume mysql-data will store all database data, and it will persist even if the container is removed.
Data migration: If you decide to migrate to a new container or MySQL version, you can start a new container and attach the same volume to access the old data.

Create a new container with access to the existing volume:

If you want to create a new container with access to the same volume, you can do it like this:

docker run -d \
  --name new- mysql - container \
  -e MYSQL_ROOT_PASSWORD = newpassword \
  -v mysql - data:/ var / lib / mysql \
  mysql: latest

In this case, the new container will use the same volume and have access to the data from the old container.

Advantages of using volumes:

Data persistence: Data doesn�t get lost when containers are removed.
Easy sharing of data between containers: You can link the same volume to multiple containers.
Easy backup and restore: You can back up data from a volume and restore it to another machine or container.

Example with log files
Another real-world example could be a container that generates log files.
For instance, if you have a container that generates logs for a web server(like Nginx or Apache), 
you can use a volume to store those logs on the host while still keeping them outside the container.


docker run - d \
  --name nginx - container \
  -v / path / to / logs:/ var / log / nginx \
  nginx

Here, the log files will be stored on the host in the / path / to / logs directory, allowing easy access to them and keeping them outside the container.

Conclusion:
Volumes are very useful for storing data that needs to be persistent and accessible outside of containers, such as databases, configuration files, logs, and others.
They allow easy management of data and provide better isolation and compatibility between containers and the host machine.







 BG Version:



�� �� ������� volume ��� ���� ����������� Docker ���������, �� ����� �������� �� �� �������� � ������� ���� docker run.
������ ����, ������ �� ��������� ������� ������:

��������� �� ��� ��������� ��� ������ ��������� ���� ������, �� � ������� volume: 
����� �� �������� ��� ��������� �� ����� ����� � �� ������� volume, ����������� ��������� docker run � ��������� - v.

��������:

docker run - d--name ���_��������� - v c:\ST:/ stoyancontainer < �����_��_���������� >
����������� �� ����� �� ������ ��������� ��� �����: ��� ���� ����� � ������ ���������, ����� �� �� ������� ��� ����� ��������� ���� docker cp ��� ����� ���������.

���������� �� docker exec �� �������� �� volume:
�� �� �������� ���������� � ���������, ����� ���� ������, ����� �� ��������� ��������� docker exec, �� ���� �������, 
�� ���� ���� �� ���� ��������� volume, � ���� �� ������� ������ � ������������ �� �������� �����.

������:

docker exec - it < container_id_or_name > bash
mount--bind c:\ST / stoyancontainer
���� � ���� �� �������� ���������� �� ���������� � �� ������� ��������� volume.
��� ����� ��������� ������, ������ �� �������� ��� ��������� � ������������ volume ���������.



Volumes � Docker �� ��������� �� ���������� �� ����� ����� ������������.
�� ���������� ������� �� �� ��������, ���� ������ ������������ �� �������� ��� �����������, ���� ������������ ����������� �������� �� ��������� �� ����� ����� �������� ����������.
���� � ����� ������� �� ���������� �� ��������������� �������, ���� �����, ��� ������� � ����� ����� �����.

��� ���� ������ ������:

������: ���������� �� volume �� ���� �����
��������� ��, �� ����� �� ��������� MySQL ��������� � ���� ����� � ����� �� ���������� ������� � ������� volume, �� �� �� �� �������, ��� ����������� ���� ���������.

��������� �� MySQL ��������� � volume:

�� �������� ���������, ����� �������� volume �� ���������� �� �����, �������� � MySQL.

docker run - d \
  --name mysql - container \
  -e MYSQL_ROOT_PASSWORD = rootpassword \
  -v mysql - data:/ var / lib / mysql \
  mysql:latest

���:

-v mysql - data:/ var / lib / mysql ������� volume � ����� mysql - data, ����� �� �� �������� �� ���������� �� ������ ����� � ������������ / var / lib / mysql �� ����������.
MYSQL_ROOT_PASSWORD = rootpassword ������ ������ �� root ����������� �� MySQL.

����� ����� volume:

���������� �� �����: Volume mysql - data �� ������ ������ ����� �� ������ �����, ���� �� �� �� ������� ���� ��� ����������� ���� ���������.
�������� �� �����: ��� ����� �� �������� ��� ��� ��������� ��� ������ �� MySQL, ����� �� ��������� ��� ��������� � �� ������� ������ volume, �� �� ��������� ������� �����.

�������� �� ��� ��������� � ������ �� ������������� volume:

��� ����� �� �������� ��� ��������� � ������ �� ������ volume, ����� �� �� �������� �� ������� �����:

docker run - d \
  --name new- mysql - container \
  -e MYSQL_ROOT_PASSWORD = newpassword \
  -v mysql - data:/ var / lib / mysql \
  mysql:latest

� ���� ������ ������ ��������� �� �������� ������ volume � �� ��� ������ �� ������� �� ������ ����� �� ������ ���������.

���������� �� ������������ �� volumes:

����������� �� �����: ������� �� �� �����, ������ ������������ �� ���������.
����� ��������� �� ����� ����� ����������: ����� �� ������� ���� � ���� volume ��� �������� ����������.
����� ���������� � ��������������: ����� �� ��������� ����� �� volume � �� �� ����������� �� ����� ������ ��� ���������.

������ � ��� �������
���� ������ ������ ���� �� ���� ���������, ����� �������� ��� �������.
��������, ��� ���� ���������, ����� �������� ������ �� ��� ������(���� Nginx ��� Apache), ����� �� ��������� volume, 
�� �� ���������� ���� ������ �� �����, ���� ������������ �� �� ������� ����� ����������.

docker run - d \
  --name nginx - container \
  -v / path / to / logs:/ var / log / nginx \
  nginx

��� ��� ��������� �� �� ���������� �� ����� � ������������ / path / to / logs, ����� ��������� ����� ������ �� ��� � ��������� ����� ����������.

����������:
Volumes �� ����� ������� �� ��������� �� �����, ����� ������ �� ����� ����������� � �������� ����� ������������, 
���� ���� �����, ��������������� �������, ������ � �����.
�� ���������� ����� ���������� �� ����� � ���������� �� - ����� �������� � ������������ ����� ������������ � ���� ��������.