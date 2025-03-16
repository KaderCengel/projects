

using Entities;
namespace Business;

public interface ITechnologyService
{
    void AddTechnology(int id, string name, ProgrammingLanguage language);
    void ListTechnologies();
}
