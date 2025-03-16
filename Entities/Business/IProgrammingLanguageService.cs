
using Entities;
namespace Business;

public interface IProgrammingLanguageService
{
    void AddLanguage(int id, string name);
    void ListLanguages();
}
