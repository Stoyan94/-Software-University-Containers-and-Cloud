
cat fiel1.txt > fiel2.txt
What does it do?
Reads the content of the file fiel1.txt.
Overwrites the content of fiel2.txt with the content of fiel1.txt.
If fiel2.txt already exists, everything inside it will be deleted and replaced.
If fiel2.txt does not exist, it will be created.

⚠ Important:
If you misspelled the filename and meant to copy file1.txt instead of fiel1.txt, you will get an error if the file does not exist.
If you want to append the content instead of overwriting it, 
use >> instead of >:

cat fiel1.txt >> fiel2.txt


Command:
cat file1.txt 2> fiel2.txt
What does it do?
Attempts to read the content of file1.txt and displays it in the terminal (standard output).
Redirects all errors (stderr) to fiel2.txt.
If file1.txt does not exist, the error (e.g., "No such file or directory") will be written to fiel2.txt.
If file1.txt exists and can be read, fiel2.txt will remain empty because no errors occurred.

⚠ Important:
If you misspelled the filename (e.g., fiel2.txt instead of file2.txt), errors will be saved in the wrongly named file.
If you want to store both the standard output (stdout) and errors (stderr) in the same file, use:

cat file1.txt &> output.txt

or

cat file1.txt > output.txt 2>&1


Command:
cat file1.txt 1> uspeh.txt 2> greshka.txt
What does it do?
Attempts to read file1.txt.
Redirects standard output (stdout) to uspeh.txt:
If file1.txt exists and can be read, its content will be saved in uspeh.txt.
Redirects errors (stderr) to greshka.txt:
If file1.txt does not exist or there is an issue reading it, the error message will be saved in greshka.txt.

Examples:

1.file1.txt exists:
echo "Hello, world!" > file1.txt
cat file1.txt 1> uspeh.txt 2> greshka.txt
uspeh.txt will contain:
Hello, world!
greshka.txt will be empty.


2. file1.txt does not exist:
cat file1.txt 1> uspeh.txt 2> greshka.txt
uspeh.txt will be empty.
greshka.txt will contain an error message, e.g.:
cat: file1.txt: No such file or directory


⚠ Important:
If you want to store both successful output and errors in the same file, use:
cat file1.txt &> output.txt

or

cat file1.txt > output.txt 2>&1


Command:
cat file1.txt &> output.txt
What does it do?
Attempts to read the content of file1.txt.
Redirects both standard output (stdout) and errors (stderr) to output.txt.
This means:
If file1.txt exists and can be read, its content will be saved in output.txt.
If file1.txt does not exist or there is a permission issue, the error message will be written to output.txt.
Breakdown of &>:
> redirects only standard output (stdout).
2> redirects only errors (stderr).
&> is a shorthand for redirecting both stdout and stderr to the same file.


The same effect can be achieved with:

cat file1.txt > output.txt 2>&1


Examples:
1.file1.txt exists:
echo "Hello, world!" > file1.txt
cat file1.txt &> output.txt

output.txt will contain:
Hello, world!


2. file1.txt does not exist:
cat file1.txt &> output.txt
output.txt will contain an error message, e.g.:
cat: file1.txt: No such file or directory

⚠ Important Notes:
&> works only in Bash. It may not work in other shells like sh.
It overwrites output.txt. If you want to append instead of overwriting, use &>> instead of &>:

cat file1.txt &>> output.txt














cat fiel1.txt > fiel2.txt
ще направи следното:

Прочита съдържанието на файла fiel1.txt.
Презаписва (overwrite) съдържанието в fiel2.txt със съдържанието на fiel1.txt.
Ако fiel2.txt съществува, ще бъде изтрито всичко вътре и ще се презапише.
Ако fiel2.txt не съществува, ще бъде създаден.

⚠ Важно:
Ако си сгрешил името на файла и всъщност искаш да копираш file1.txt, а не fiel1.txt, ще получиш грешка, ако такъв файл не съществува.
Ако искаш да добавиш (append) съдържанието вместо да презаписваш, 
трябва да използваш >> вместо >:
cat fiel1.txt >> fiel2.txt



cat file1.txt 2> fiel2.txt
Командата
cat file1.txt 2> fiel2.txt

ще направи следното:
Опитва се да прочете съдържанието на file1.txt и да го изведе в стандартния изход (терминала).
Пренасочва всички грешки (stderr) към fiel2.txt.
Ако file1.txt не съществува, грешката (например „No such file or directory“) ще бъде записана в fiel2.txt.
Ако file1.txt съществува и може да се прочете, fiel2.txt ще остане празен, защото не са възникнали грешки.

⚠ Важно:
Ако си допуснал правописна грешка (fiel2.txt вместо file2.txt), грешките ще се запишат в грешно именувания файл.
Ако искаш да запишеш както стандартния изход (stdout), така и грешките (stderr) в един и същ файл, можеш да използваш:

cat file1.txt &> output.txt
или
cat file1.txt > output.txt 2>&1



cat file1.txt 1> uspeh.txt 2> greshka.txt 

Командата:
cat file1.txt 1> uspeh.txt 2> greshka.txt

ще направи следното:
Опитва се да прочете file1.txt.
Пренасочва стандартния изход (stdout) към uspeh.txt:
Ако file1.txt съществува и може да се прочете, съдържанието му ще бъде записано в uspeh.txt.
Пренасочва грешките (stderr) към greshka.txt:
Ако file1.txt не съществува или има проблем с четенето, грешката ще бъде записана в greshka.txt.


Примери:
1.file1.txt съществува
echo "Hello, world!" > file1.txt

cat file1.txt 1> uspeh.txt 2> greshka.txt

uspeh.txt ще съдържа:
Hello, world!
greshka.txt ще е празен.


2. file1.txt не съществува

cat file1.txt 1> uspeh.txt 2> greshka.txt
uspeh.txt ще е празен.
greshka.txt ще съдържа грешка, например:
cat: file1.txt: No such file or directory


⚠ Важно:

Ако искаш да съхраниш както успешния изход, така и грешките в един и същ файл, използвай:
cat file1.txt &> output.txt
или
cat file1.txt > output.txt 2>&1





cat file1.txt &> output.txt обясними тази команда

Командата:
cat file1.txt &> output.txt
Какво прави?
Опитва се да прочете съдържанието на file1.txt.
Пренасочва както стандартния изход (stdout), така и грешките (stderr) към output.txt.

Това означава, че:
Ако file1.txt съществува и може да се прочете, неговото съдържание ще бъде записано в output.txt.
Ако file1.txt не съществува или има проблеми с достъпа, съобщението за грешка ще бъде записано в output.txt.
Разбивка на &>:
> пренасочва само стандартния изход (stdout).
2> пренасочва само грешките (stderr).
&> е кратък запис за "пренасочи stdout и stderr към един и същи файл".

Същото може да се постигне и с:
cat file1.txt > output.txt 2>&1

Примери:
1.file1.txt съществува:
echo "Hello, world!" > file1.txt
cat file1.txt &> output.txt

output.txt ще съдържа:
Hello, world!


2. file1.txt не съществува:
cat file1.txt &> output.txt
output.txt ще съдържа грешка, например:
cat: file1.txt: No such file or directory


⚠ Важно:

&> работи само в Bash. В други shell-ове (като sh) може да не работи.
Презаписва output.txt. 
Ако искаш да добавяш към файла, използвай &>> вместо &>.
cat file1.txt &>> output.txt