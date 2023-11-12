using GenericsIntro;

MyList<string> names = new MyList<string>();
names.Add("Ahmet");
Console.WriteLine(names.Length);

names.Add("Engin");
Console.WriteLine(names.Length);

foreach (var name in names.Items)
{
    Console.WriteLine(name);
}

//List<string> list = new List<string>();
//Console.WriteLine(list.Count);

