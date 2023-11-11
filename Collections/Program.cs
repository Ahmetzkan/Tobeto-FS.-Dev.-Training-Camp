using System.Collections.Generic;
using System.Collections.ObjectModel;

//string[] names = new string[] { "ahmet", "engin", "murat", "kerem", "halil" };
//console.writeline(names[0]);
//console.writeline(names[1]);
//console.writeline(names[2]);
//console.writeline(names[3]);

//names = new string[5];
//names[4] = "ilker";
//console.writeline(names[4]);
//console.writeline(names[0]);

//String listeleri yani koleksiyonlar.

List<string> names2 = new List<string>(){ "Ahmet", "Engin", "Murat", "Kerem", "Halil" };
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);
Console.WriteLine(names2[4]);
names2.Add("İlker");
Console.WriteLine(names2[5]);
Console.WriteLine(names2[0]);


