using Core;
using Entities;
namespace DataAccess;

public class TechnologyRepository : IRepository<Technology>
{
    private List<Technology> _technologies = new List<Technology>();

    public void Add(Technology entity) => _technologies.Add(entity);
    public void Delete(int id) => _technologies.RemoveAll(t => t.Id == id);
    public void Update(Technology entity)
    {
        var tech = GetById(entity.Id);
        if (tech != null) tech.Name = entity.Name;
    }
    public List<Technology> GetAll() => _technologies;
    public Technology GetById(int id) => _technologies.FirstOrDefault(t => t.Id == id);
}
