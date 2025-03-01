pwd Command in Linux
The pwd (Print Working Directory) command displays the full absolute path of the current directory you are in.

Usage:
pwd
Example Output:
/home/user/Documents
This means you are currently inside the Documents folder, which is located in /home/user/.

Key Features of pwd:
Prints the absolute path (full path starting from the root /).
Useful in scripts to check where a script is running from.
Does not require any arguments, but has optional flags:

pwd - L → Prints the logical path (includes symlinks).
pwd -P → Prints the physical path (resolves symlinks).

Example with Symlinks
If you're inside a symbolic link folder, pwd -L may show:

/home/user/myshortcut
Whereas pwd -P will show:


/home/user/actual-folder
This helps when working with symbolic links.