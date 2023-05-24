using System.Diagnostics;

Console.WriteLine(@"1. Ввести первоначальный массив с клавиатуры в консоли
2. Задать первоначальный массив через файл");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine(@"Введите элементы массива через запятую и пробел
Напр. 1, 2, 3");
    string text = Console.ReadLine();
    string[] array = text.Split(", ");

    Console.WriteLine("Задан массив: ");
    foreach (var i in array)
    {
        Console.Write(i + ", ");
    }
    Console.WriteLine();

    int c = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            c++;
        }
    }

    string[] arrayOut = new string[c];
    c = 0;
    foreach (var k in array)
    {
        if (k.Length <= 3)
        {
            arrayOut[c] = k;
            c++;
        }
    }

    Console.WriteLine("Итоговый массив: ");
    foreach (var l in arrayOut)
    {
        Console.Write(l + ", ");
    }
}

if (choice == 2)
{
    Console.WriteLine(@"Введите элементы массива в 1 строку через запятую и пробел в файл input.txt
Напр. 1, 2, 3");
    Console.Write("Для продолжения нажмите любую клавишу...");
    Console.ReadKey();
    Console.WriteLine();

    string text = File.ReadAllText("input.txt");
    string[] array = text.Split(", ");

    Console.WriteLine("Задан массив: ");
    foreach (var i in array)
    {
        Console.Write(i + ", ");
    }
    Console.WriteLine();

    int c = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            c++;
        }
    }

    string[] arrayOut = new string[c];
    c = 0;
    foreach (var k in array)
    {
        if (k.Length <= 3)
        {
            arrayOut[c] = k;
            c++;
        }
    }

    Console.WriteLine("Итоговый массив: ");
    foreach (var l in arrayOut)
    {
        Console.Write(l + ", ");
    }
}