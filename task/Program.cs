// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.



void PrintArray (string [] array)
{
     string[] newArray = new string[array.Length];
     for (int i=0; i < array.Length; i++)
     {      
        if(array[i].Length <= 3)
        {
        newArray[i] = array[i];;
        Console.WriteLine(newArray[i]); 
        }
     }
        Console.WriteLine(); 
}

void Print(string [] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

string [] array = {"hello", "2", "world", ":-)"};

Print(array);
PrintArray(array);