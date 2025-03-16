


using DataAccess;
using Business;

var languageRepo = new ProgrammingLanguageRepository();
IProgrammingLanguageService languageManager = new ProgrammingLanguageManager(languageRepo);
var technologyRepo = new TechnologyRepository();
ITechnologyService technologyManager = new TechnologyManager(technologyRepo);

while (true)
{
    Console.WriteLine("1- Programlama Dili Ekle\n2- Programlama Dillerini Listele\n3- Teknoloji Ekle\n4- Teknolojileri Listele\n5- Çıkış");
    var choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("İsim: ");
        string name = Console.ReadLine();
        languageManager.AddLanguage(id, name);
    }
    else if (choice == "2")
    {
        languageManager.ListLanguages();
    }
    else if (choice == "3")
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("İsim: ");
        string name = Console.ReadLine();
        Console.Write("Programlama Dili ID: ");
        int langId = int.Parse(Console.ReadLine());
        var lang = languageRepo.GetById(langId);
        if (lang != null)
        {
            technologyManager.AddTechnology(id, name, lang);
        }
        else
        {
            Console.WriteLine("Geçersiz Programlama Dili ID");
        }
    }
    else if (choice == "4")
    {
        technologyManager.ListTechnologies();
    }
    else if (choice == "5")
    {
        break;
    }
}
