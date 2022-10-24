// See https://aka.ms/new-console-template for more information
Console.WriteLine("Derece degerini giriniz");
int derece=Convert.ToInt32(Console.ReadLine());
double radyan = derece * Math.PI / 180;
double gradyan = derece * 200 / 180;
Console.WriteLine("derecenın radyan degeri=" + radyan);
Console.WriteLine("derecenin gradyan degeri="+gradyan);
Console.ReadKey();
