


double a;
Console.Write("Sayiyi giriniz:");
a=Convert.ToDouble(Console.ReadLine());
if (a < 0)
{
    Console.WriteLine("Sayi negatiftir.");
}
else if (a == 0)
{
    Console.WriteLine("Sayi sifirdir.");
}
else if (a > 0)
{
    Console.WriteLine("Sayi pozitiftir.");
}
