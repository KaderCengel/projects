
using Entities;
using Core;
namespace Business;

public class TechnologyManager:ITechnologyService
{
    private readonly IRepository<Technology> _repository;

    public TechnologyManager(IRepository<Technology> repository)
    {
        _repository = repository;
    }

    public void AddTechnology(int id, string name, ProgrammingLanguage language)
    {
        _repository.Add(new Technology { Id = id, Name = name, ProgrammingLanguage = language });
    }
    public void ListTechnologies()
    {
        foreach (var tech in _repository.GetAll())
        {
            Console.WriteLine($"ID: {tech.Id}, Name: {tech.Name}, Language: {tech.ProgrammingLanguage.Name}");
        }
    }
}

