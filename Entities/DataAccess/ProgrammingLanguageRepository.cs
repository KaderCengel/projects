using Core;
using Entities;
namespace DataAccess;

public class ProgrammingLanguageRepository: IRepository<ProgrammingLanguage>
{
    private List<ProgrammingLanguage> _languages = new List<ProgrammingLanguage>();

    public void Add(ProgrammingLanguage entity) => _languages.Add(entity);
    public void Delete(int id) => _languages.RemoveAll(l => l.Id == id);
    public void Update(ProgrammingLanguage entity)
    {
        var language = GetById(entity.Id);
        if (language != null) language.Name = entity.Name;
    }
    public List<ProgrammingLanguage> GetAll() => _languages;
    public ProgrammingLanguage GetById(int id) => _languages.FirstOrDefault(l => l.Id == id);
}

