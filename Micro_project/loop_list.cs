using System;

List<int> dummyList = new List<int> {1,2,4,7,3,5};

// Console.WriteLine(string.Join(",",dummyList));

// foreach (var i in dummyList)
// {
//     Console.WriteLine(i);
// }

foreach (var numb in dummyList)
{
    Console.WriteLine(numb);
}

Console.WriteLine(dummyList.Max());