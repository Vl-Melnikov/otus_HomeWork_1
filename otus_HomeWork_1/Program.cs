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

#region Collection
stopwatchAll.Start();
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
for (var l = 1; l <= x; l++)
{
    linkedList.AddLast(l); 
}
Console.WriteLine($"Длительность заполнения коллекции: {stopwatch.ElapsedMilliseconds} мс");
#endregion Collection

#region Search
Console.WriteLine("-----------------------  Найти элемент {0}, вывести длительность  -----------------------", n);
Console.WriteLine("List");
stopwatch.Restart();
foreach (var i in list)
{
    if (list[i] == n)
        Console.WriteLine($"Затрачено для поиска элемента {n}: {stopwatch.ElapsedMilliseconds} мс");
}

Console.WriteLine("ArrayList");
stopwatch.Restart();
foreach (var i in arrayList)
{
    var k = arrayList[n];

    if(i==k)
        Console.WriteLine($"Затрачено для поиска элемента {n}: {stopwatch.ElapsedMilliseconds} мс");
}

Console.WriteLine("LinkedList");
stopwatch.Restart();
foreach (var i in linkedList)
{
    if(i==n)
        Console.WriteLine($"Затрачено для поиска элемента {n}: {stopwatch.ElapsedMilliseconds} мс");
}

#endregion Search
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
Console.WriteLine($"Затрачено милисекунд для работы программы: {stopwatchAll.ElapsedMilliseconds}");
