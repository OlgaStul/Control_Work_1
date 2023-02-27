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





string[] newArray = NewArray(array);