﻿// -----------------------------------------------------------------------
// ЗАДАЧА 1

// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

Console.Clear();


Console.Write("Введите размер матрицы (два числа через пробел): ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
char[,] matrix = new char[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);


// Функция заполняет матрицу случайными буквами 
// латинского алфавита (строчными):
void InputMatrix(char[,] matrix)
{
    Random rnd = new Random();
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
            for(int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = (char)('a' + rnd.Next(0, 26));
    }
}


// Функция осуществляет вывод матрицы:
void PrintMatrix(char[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


// Функция осуществляет вывод строки из символов массива:
void ReleaseMatrix(char[,] matrix)
{
    string res = "";

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            res += matrix[i, j];
    }
    Console.WriteLine($"=> {res}");
}


// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 2

// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Clear();


Console.WriteLine("Введите строку для преобразования, содержащую латинские буквы в обоих регистрах:");
string SomeLetters = Console.ReadLine();
string res = ConvertString(SomeLetters);
Console.WriteLine($"=> {res}");


// Функция формирует строку, в которой все заглавные буквы заменены на строчные:
string ConvertString(string StringToConvert)
{
    return StringToConvert.ToLower();
}


// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 3

// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

Console.Clear();


Console.WriteLine("Введите строку для проверки, является ли она палиндромом:");
string SomeChars = Console.ReadLine();
IsPalindrome(SomeChars);


// Функция переворачивает строку:
string ReverseString(string StringToReverse)
{
    string res = "";

    for(int i = StringToReverse.Length - 1; i >= 0; i--)
        res += StringToReverse[i];

    return res;
}


// Функция осуществляет проверку, является ли строка палиндромом:
void IsPalindrome(string StringToCheck)
{
    string ReversedString = ReverseString(StringToCheck.ToLower());
    if (StringToCheck.ToLower() == ReversedString)
        Console.WriteLine("=> Да, строка является палиндромом");
    else
        Console.WriteLine("=> Нет, строка НЕ является палиндромом");
}

// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 4* (не обязательная)

// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

Console.Clear();

Console.WriteLine("Введите строку из слов, разделенных пробелом:");
string SomeWords = Console.ReadLine();
ReverseWords(SomeWords);


// Функция создает массив из строковых значений - 
// слов, взятых из введенной пользователем строки:
string[] WordsArray(string StringWithWords)
{
    string[] words = StringWithWords.Split(' ');

    return words;
}


// Функция переворачивает слова в обратном порядке:
void ReverseWords(string StringWithWords)
{
    string[] WordsToChange = WordsArray(StringWithWords);

    for(int i = WordsToChange.Length - 1; i >= 0; i--)
    {
        Console.Write(WordsToChange[i]);

        if (i > 0)
            Console.Write(" ");
    }
        
}

// -----------------------------------------------------------------------
// -----------------------------------------------------------------------
