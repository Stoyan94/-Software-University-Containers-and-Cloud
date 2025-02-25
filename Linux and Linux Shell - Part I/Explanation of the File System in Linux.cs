Обяснение за файловата система в Linux
Файловата система е ключов компонент на операционната система, който организира и управлява файловете и директориите на запаметяващо устройство (например SSD диск).

Популярни файлови системи в Linux:
ext4 – Най-често използваната файлова система в Linux дистрибуциите.
BTRFS – Модерна файлова система с поддръжка на моментни снимки (snapshots) и други разширени функции.
ZFS – Файлова система с висока надеждност и вградена защита срещу повреди на данните.
NTFS – Файлова система на Windows, която може да се използва в Linux чрез NTFS-3G драйвери.
Структура на файловата система:
Linux организира файловете в йерархична структура от директории (папки), които могат да съдържат файлове и други директории.

Типове файлове в Linux:
Обычни файлове – Текстови документи, изпълними бинарни файлове и др.
Специални файлове:
Символни връзки(symlinks) – Преки пътища към други файлове.
Пайпове (pipes) – Използват се за междупроцесна комуникация.
Сокети (sockets) – Подобни на пайповете, но позволяват комуникация по мрежа.
Основни системни директории в Linux

Наименования на английски:
Директория Описание
/	Root (основната директория на файловата система)
/bin	Основни изпълними файлове (binaries)
/boot	Файлове, необходими за стартиране на системата
/dev	Устройства (device files)
/etc	Конфигурационни файлове
/home	Потребителски директории
/lib	Библиотеки, необходими за основните програми
/media	Автоматично монтирани външни устройства
/mnt	Директория за ръчно монтиране на устройства
/opt	Допълнителен софтуер, инсталиран от потребителя
/proc	Виртуална файлова система с информация за процесите
/root	Домашната директория на root потребителя
/run	Временни файлове, свързани със стартирани процеси
/sbin	Системни изпълними файлове (superuser binaries)
/srv	Данни за услуги (services) като уеб сървъри
/sys	Виртуална файлова система с информация за ядрото
/tmp	Временни файлове
/usr	Допълнителни програми и библиотеки
/var	Променливи данни (log файлове, спулери и др.)


Наименования на български:
Директория Описание
/	Корен (основната директория на файловата система)
/bin	Основни изпълними файлове (бинарни файлове)
/boot	Файлове за стартиране на системата
/dev	Файлове на устройствата
/etc	Конфигурационни файлове
/home	Потребителски папки
/lib	Библиотеки, необходими за основните програми
/media	Автоматично монтирани външни устройства
/mnt	Директория за ръчно монтиране на устройства
/opt	Допълнителен софтуер, инсталиран от потребителя
/proc	Виртуална файлова система с информация за процесите
/root	Домашната директория на root потребителя
/run	Временни файлове за стартирани процеси
/sbin	Системни изпълними файлове (само за root)
/srv	Данни за услуги (напр. уеб сървъри)
/sys	Виртуална файлова система с информация за ядрото
/tmp	Временни файлове
/usr	Допълнителни програми и библиотеки
/var	Променливи данни (логове, временни файлове и др.)
Тази структура е стандартна за повечето Linux дистрибуции и следва принципите на Filesystem Hierarchy Standard (FHS).






Explanation of the File System in Linux
The file system is a key component of the operating system that organizes and manages files and directories on a storage device (e.g., SSD disk).

Popular File Systems in Linux:
ext4 – The most commonly used file system in Linux distributions.
BTRFS – A modern file system with support for snapshots and other advanced features.
ZFS – A file system with high reliability and built-in protection against data corruption.
NTFS – A Windows file system that can be used in Linux via NTFS-3G drivers.
File System Structure:
Linux organizes files in a hierarchical structure of directories (folders), which can contain files and other directories.

File Types in Linux:
Regular files – Text documents, executable binary files, etc.
Special files:
Symbolic links(symlinks) – Shortcuts to other files.
Pipes (pipes) – Used for interprocess communication.
Sockets (sockets) – Similar to pipes but allow network communication.
Main System Directories in Linux
Directory Names in English:
Directory Description
/	Root (the main directory of the file system)
/bin	Essential executable files (binaries)
/boot	Files required to boot the system
/dev	Device files
/etc	Configuration files
/home	User directories
/lib	Libraries required for essential programs
/media	Automatically mounted external devices
/mnt	Directory for manually mounting devices
/opt	Additional software installed by the user
/proc	Virtual file system with process information
/root	Home directory of the root user
/run	Temporary files related to running processes
/sbin	System executable files (superuser binaries)
/srv	Data for services (e.g., web servers)
/sys	Virtual file system with kernel information
/tmp	Temporary files
/usr	Additional programs and libraries
/var	Variable data (log files, spoolers, etc.)
This structure is standard for most Linux distributions and follows the Filesystem Hierarchy Standard (FHS).