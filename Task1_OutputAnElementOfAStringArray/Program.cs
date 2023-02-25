// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равна 3 символам.
// (Write a program that, from an existing array of strings, 
// forms an array of strings whose length is less than or equal to 3 characters)


int n = new Random().Next(2, 5);
Console.WriteLine($"Создадим строчный массив из {n} слов:");
string[] words = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите любое слово №{i + 1}: ");
    words[i] = Console.ReadLine();
}
int characters = 3;
Console.Write($"Выведем только слова с количеством символов <= {characters}:");
// string[] newWords=new string[n];
Console.Write("[");
for (int i = 0; i < words.Length; i++)
{
    int count = 0;
    for (int j = 0; j < words[i].Length; j++)
    {
        count++;
    }
    // Console.Write($"Длина слова {item} - {count} ");
    if (count <= characters) Console.Write($" {words[i]} ");
    else Console.Write("");
}
Console.Write("]");

