// See https://aka.ms/new-console-template for more information
using PrimjerDecorator;

Console.WriteLine("Hello!");

Kahva h = new Espresso();
Console.WriteLine("Narucili ste: {0}", h.dajOpis());
Console.WriteLine("Iznos za naplatu: {0}", h.dajCijenu());

h = new MlijekoDekorater(h);
Console.WriteLine("Narucili ste: {0}", h.dajOpis());
Console.WriteLine("Iznos za naplatu: {0}", h.dajCijenu());

h = new SecerDekorater(h);
Console.WriteLine("Narucili ste: {0}", h.dajOpis());
Console.WriteLine("Iznos za naplatu: {0}", h.dajCijenu());