


using System.Runtime.Intrinsics.X86;

string password;
string specialcharacters = "!@#$%^&*()_+-=[]{}|;:',.<>?/";
string uppercase = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
Console.Write("Lutfen sifrenizi giriniz:");
password = Console.ReadLine();
if (password.Length >= 8)
{
    if (password.IndexOfAny(specialcharacters.ToCharArray()) != -1)
    {
        if (password.IndexOfAny(uppercase.ToCharArray()) != -1)
        {
            Console.WriteLine("Sifreniz yeterince gucludur.");
        }
        else
            Console.WriteLine("Sifreniz yeterince guclu degil.");
    }
    else
        Console.WriteLine("Sifreniz yeterince guclu degil.");
}
else
    Console.WriteLine("Şifreniz yeterince güçlü değil.");
