

double a, b, c,buyuk;
Console.Write("İlk sayiyi giriniz:");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("İkinci sayiyi giriniz:");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Ucuncu sayiyi giriniz:");
c = Convert.ToDouble(Console.ReadLine());
buyuk = a;
if (b >= buyuk && b >= c)
    Console.WriteLine("Buyuk sayi: " + b);
else if (c >= buyuk && c > b)
    Console.WriteLine("Buyuk sayi: " + c);
else
    Console.WriteLine("Büyük sayi:" + a);

