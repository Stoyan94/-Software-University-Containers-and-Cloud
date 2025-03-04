In Linux and Unix-based systems, there are several ways to combine commands into one line. Here are a few examples with explanations:

1.Using; (semicolon)
This allows you to execute multiple commands sequentially, regardless of whether the previous command was successful or not.

Example:
echo "Start"; ls; echo "End"

Explanation:
This will output:

"Start"
Execute the ls command, which lists the files in the current directory
And then output "End"


2. Using && (logical AND)
This will execute the second command only if the first command was successful (i.e., it returns an exit code of 0).

Example:
mkdir new_folder && cd new_folder

Explanation:
This will create a new directory new_folder and then change into it, but only if the directory is successfully created. 
If the directory creation fails (e.g., due to lack of permissions), the second command won't execute.

3. Using || (logical OR)
This will execute the second command only if the first command fails (i.e., it returns a non-zero exit code).

Example:
cd /nonexistent || echo "Directory does not exist"

Explanation:
This will attempt to change into the non-existent directory /nonexistent. If it fails (e.g., the directory doesn't exist), it will print "Directory does not exist".

4. Combining && and ||
You can combine && and || to create complex logical expressions.

Example:
mkdir new_folder && echo "Directory created" || echo "Error creating directory"

Explanation:
This will create the new_folder directory, and if the command is successful, it will output "Directory created". 
If the directory cannot be created, it will output "Error creating directory".

5. Using | (pipe)
This allows you to take the output of one command and pass it as input to another command.

Example:
ls | grep "file"

Explanation:
This will list all the files in the current directory with ls, and then filter out only those that contain the word "file" using grep.

6.Using tee
This allows you to write the output of a command to both a file and the standard output (screen).

Example:
echo "Hello" | tee hello.txt

Explanation:
This will output "Hello" to the screen and simultaneously write it to hello.txt.

7. Using {} (grouping commands)
This allows you to group multiple commands into a block that is executed in the same process.

Example:
{ echo "Hello"; echo "World"; }

Explanation:
This will output:

"Hello"
"World"
Both commands will execute in the same shell.

These are just a few ways to combine commands in Linux. Depending on your needs and conditions for execution, you can use different combinations to achieve the desired behavior!