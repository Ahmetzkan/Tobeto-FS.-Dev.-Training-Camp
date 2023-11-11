int number1 = 10;
int number2 = 30;
number1 = number2;
number2 = 65;
Console.WriteLine(number1);

//int,decimal,float,double,bool = Değer tip = Stack
//Array,class,interface = Referans tip = Heap
//number1 = number2 kısmında number2 eşitler ve number2 yi siler.
//.Net'in Garbage Collector = number1 in ilk değerini stack ve heapte tutan olmadığı için yok eder.  




