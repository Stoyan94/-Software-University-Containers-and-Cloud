В Linux можеш да добавиш текст към вече съществуващ файл по няколко начина.

🔹 Добавяне на текст към файл с cat
Използвай >>, за да добавиш (append) съдържание, без да изтриваш старото:
cat >> filename.txt
📌 Въведи желания текст и натисни Ctrl + D, за да запазиш промените.


🔹 Добавяне на текст чрез echo
Ако искаш да добавиш един ред, използвай:
echo "This is a new line" >> filename.txt
📌 Това ще добави This is a new line в края на filename.txt.


🔹 Добавяне на няколко реда с echo и printf
С echo и -e за нов ред:
echo -e "First line\nSecond line" >> filename.txt


С printf:
printf "Line 1\nLine 2\n" >> filename.txt


🔹 Използване на sed за добавяне на текст на определено място
Ако искаш да добавиш текст на определен ред (например на 3-ти ред):
sed -i '3i This is the inserted line' filename.txt
📌 Това ще вмъкне "This is the inserted line" на третия ред на файла.

🔹 Добавяне на текст в края на файла с tee
echo "Another line" | tee -a filename.txt
📌 Работи като >>, но също така показва добавения текст в терминала.

