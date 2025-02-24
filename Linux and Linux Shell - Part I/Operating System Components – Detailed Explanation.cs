Обяснение на български – Компоненти на операционната система
Операционната система (OS) управлява хардуера и софтуера на компютъра, осигурява потребителски интерфейс и поддържа изпълнението на приложенията. 
Основните компоненти на една OS са:

1.Ядро(Kernel)
Ядрото е най-важният компонент, който се зарежда първи и остава в паметта.

Основни функции на ядрото:
Управление на процесите – Създава, планира и прекратява процеси.
Управление на паметта – Разпределя RAM за различни задачи.
Управление на устройствата – Комуникира с хардуера чрез драйвери.
Файлова система – Чете и записва файлове на диска.
Сигурност и достъп – Управлява разрешенията и автентикацията.
Видове ядра:
Монолитно ядро – Всички услуги работят в ядрото (Linux, Windows NT).
Микроядро – Само основните функции са в ядрото (Minix, QNX).
Хибридно ядро – Смес между двете (Windows, macOS).


2. Обвивка (Shell)
Обвивката е интерфейсът за комуникация между потребителя и операционната система.

Видове обвивки:
Команден ред(CLI) – Позволява текстови команди (Bash, PowerShell, CMD).
Графичен интерфейс (GUI) – Позволява визуално управление (Windows Explorer, Finder, GNOME).
Функции на обвивката:
Изпълнява команди, подадени от потребителя.
Позволява автоматизация чрез скриптове (особено CLI).
Управлява файлове и програми.


3. Помощни програми (Utilities)
Помощните програми са малки софтуерни инструменти, които разширяват възможностите на операционната система.

Примери за помощни програми:
Управление на файлове – Файлови мениджъри, команди като ls и cd.
Компресиране на файлове – ZIP, RAR, tar, gzip.
Мрежови инструменти – SSH (отдалечен достъп), FTP, ping, traceroute.
Мониторинг на системата – Task Manager, top в Linux.
Архивиране и възстановяване – Системно възстановяване, облачно архивиране.

4. Други компоненти на OS
4.1. Файлова система
Операционната система управлява файловете чрез файлова система, която ги организира в директории. Примери: NTFS(Windows), ext4(Linux), HFS + (macOS).

4.2.Драйвери на устройства
Драйверите осигуряват комуникацията между операционната система и хардуерните компоненти (принтери, видеокарти, USB устройства).

4.3. Системни извиквания (API)
Системните извиквания са интерфейси, чрез които приложенията заявяват услуги от ядрото. Примери: open(), read(), write() в Unix.



Operating System Components – Detailed Explanation
An operating system (OS) is responsible for managing hardware and software resources, providing a user interface, and ensuring the execution of applications. It consists of several core components:

1.Kernel
The kernel is the core of the operating system. It is the first component loaded into memory when the computer starts and remains active throughout operation.

Key Responsibilities of the Kernel:
Process Management – Creates, schedules, and terminates processes.
Memory Management – Allocates and deallocates RAM for processes.
Device Management – Communicates with hardware via drivers.
File System Management – Organizes, reads, and writes files.
System Security & Access Control – Implements authentication and permissions.
Types of Kernels:
Monolithic Kernel – All OS services run in kernel space (e.g., Linux, Windows NT).
Microkernel – Only essential functions run in kernel space, while others run in user space (e.g., Minix, QNX).
Hybrid Kernel – A mix of monolithic and microkernel approaches (e.g., Windows, macOS).


2. Shell
The shell is the user interface for interacting with the operating system.It acts as a bridge between the user and the kernel.

Types of Shells:
Command - Line Interface(CLI) – Users interact through text - based commands(e.g., Bash, PowerShell, Command Prompt).
Graphical User Interface(GUI) – Users interact through visual elements(e.g., Windows Explorer, GNOME, macOS Finder).
Functions of the Shell:
Accepts user commands and passes them to the kernel.
Allows script automation(especially CLI shells).
Can execute programs and manage files.


3.Utilities(System Tools & Services)
Utilities are small programs that extend the capabilities of the operating system.

Examples of Common Utilities:
File Management – File explorers, command - line file tools.
Compression Utilities – ZIP, RAR, tar, gzip.
Networking Tools – SSH(remote access), FTP, ping, traceroute.
System Monitoring – Task Manager, Process Explorer, top(Linux).
Backup & Recovery – System restore, disk cloning, cloud backups.


4.Other OS Components(Additional Details)
4.1.File System
The OS manages file storage using a structured file system, which organizes files into directories. Examples: NTFS(Windows), ext4(Linux), HFS + (macOS).

4.2.Device Drivers
Drivers allow communication between the OS and hardware components (e.g., printers, graphics cards, USB devices).

4.3. System Calls (APIs)
System calls provide an interface for programs to request services from the kernel.Examples: open(), read(), write() in Unix - based systems.
