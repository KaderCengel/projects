

int number1, number2;
string operant;
Console.Write("İslem yapmak istediginiz ilk sayiyi giriniz:");
number1=Convert.ToInt16(Console.ReadLine());
Console.Write("İslem yapmak istediginiz ikinci sayiyi giriniz:");
number2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Yapmak istediginiz islemi seciniz: toplama=(+), cikarma=(-), carpma=(*), bolme=(/), mod alma=(%)");
operant = Console.ReadLine();
switch (operant)
{
    case "+":
        Console.WriteLine(number1 + number2);
        break;
    case "-":
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;
    case "/":
        Console.WriteLine(number1 / number2);
        break;
    case "%":
        Console.WriteLine(number1 % number2);
        break;
}
