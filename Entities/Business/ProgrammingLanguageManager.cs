
using Entities;
using Core;
namespace Business;

public class ProgrammingLanguageManager:IProgrammingLanguageService
{
    private readonly IRepository<ProgrammingLanguage> _repository;

    public ProgrammingLanguageManager(IRepository<ProgrammingLanguage> repository)
    {
        _repository = repository;
    }

    public void AddLanguage(int id, string name)
    {
        _repository.Add(new ProgrammingLanguage { Id = id, Name = name });
    }
    public void ListLanguages()
    {
        foreach (var lang in _repository.GetAll())
        {
            Console.WriteLine($"ID: {lang.Id}, Name: {lang.Name}");
        }
    }
}
