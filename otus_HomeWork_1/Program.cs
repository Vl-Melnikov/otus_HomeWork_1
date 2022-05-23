using System.Collections;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch(); // счётчик для коллекций
Stopwatch stopwatchAll = new Stopwatch();   // общий счётчик

var n = 496753; // контрольный элемент списка для проверки
var d = 777; // для деления
var x = 1000000; // элементов в массиве
var list = new List<int>();
var arrayList = new ArrayList();
var linkedList = new LinkedList<int>();

stopwatchAll.Start();
#region Collection
Console.WriteLine("-----------------------  Заполнить коллекции, вывести длительность -----------------------");

Console.WriteLine("List");
stopwatch.Start();
for (int i = 0; i < x; i++)
{
    list.Add(i);
}
Console.WriteLine($"Длительность заполнения коллекции: {stopwatch.ElapsedMilliseconds} мс");

Console.WriteLine("ArrayList");
stopwatch.Restart();
for (var s = 0; s <= x; s++)
{
    arrayList.Add(s);
}
Console.WriteLine($"Длительность заполнения коллекции: {stopwatch.ElapsedMilliseconds} мс");

Console.WriteLine("LinkedList");
stopwatch.Restart();
for (var l = 0; l <= x-1; l++)
{
    linkedList.AddLast(l); 
}
Console.WriteLine($"Длительность заполнения коллекции: {stopwatch.ElapsedMilliseconds} мс");
#endregion Collection

#region Search
Console.WriteLine("-----------------------  Найти элемент {0}, вывести длительность  -----------------------", n);

stopwatch.Restart();
Console.WriteLine("List");
Console.WriteLine($"Затрачено для поиска элемента {list[n]}: {stopwatch.ElapsedMilliseconds} мс");

stopwatch.Restart();
Console.WriteLine("ArrayList");
Console.WriteLine($"Затрачено для поиска элемента {arrayList[n]}: {stopwatch.ElapsedMilliseconds} мс");

stopwatch.Restart();
Console.WriteLine("LinkedList");
var value = linkedList.ElementAt(n);
Console.WriteLine($"Затрачено для поиска элемента {value}: {stopwatch.ElapsedMilliseconds} мс");
#endregion Search

#region Remainder
Console.WriteLine("-----------------------  Найти элемент, который делится без остатка на {0}, вывести длительность  -----------------------", d);
Console.WriteLine("List");
stopwatch.Restart();
foreach (int i in list)
{
    if (i % d == 0)
    {
        Console.WriteLine($"{i} без остатка делится на {d}");
    }
}
Console.WriteLine($"Затрачено милисекунд для поиска операции деления без остатка: {stopwatch.ElapsedMilliseconds}");

Console.WriteLine("ArrayList");
stopwatch.Restart();
foreach (int i in arrayList)
{
    if (i % d == 0)
    {
        Console.WriteLine($"{i} без остатка делится на {d}");
    }
}
Console.WriteLine($"Затрачено милисекунд для поиска операции деления без остатка: {stopwatch.ElapsedMilliseconds}");

Console.WriteLine("LinkedList");
stopwatch.Restart();
foreach (int i in linkedList)
{
    if (i % d == 0)
    {
        Console.WriteLine($"{i} без остатка делится на {d}");
    }
}
stopwatch.Stop();
Console.WriteLine($"Затрачено милисекунд для поиска операции деления без остатка: {stopwatch.ElapsedMilliseconds}");

stopwatchAll.Stop();
#endregion
Console.WriteLine($"Затрачено милисекунд для работы программы: {stopwatchAll.ElapsedMilliseconds}");
