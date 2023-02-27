/*   Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  
[{"hello"}, {"2"}, {"world"}, {":-)"}]   ->   [{"2"}, {":-)"}] 
[{"1234"}, {"1567"}, {"-2"}, {"computer science"}]   ->   [{"-2"}]
[{"Russia"}, {"Denmark"}, {"Kazan"}]   ->   []
*/

string [] array = {"hello", "2", "world", ":-)"};

string[] NewArray(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i].Length < 4) 
        count++;
    }
    string[] newArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] newArray)
{
    Console.Write($"[");
    if(newArray.Length > 0)
    {
        for (int i = 0; i < newArray.Length-1; i++)
            Console.Write($"{newArray[i]}, "); 
        for (int i = newArray.Length-1; i < newArray.Length; i++)
            Console.Write($"{newArray[newArray.Length-1]}");     
    }
    Console.Write($"]"); 
}

string[] newArray = NewArray(array);
PrintArray(newArray);