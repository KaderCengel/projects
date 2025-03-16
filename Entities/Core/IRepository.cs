

namespace Core;

public interface IRepository<T>
{
    void Add(T entity);
    void Delete(int id);
    void Update(T entity);
    List<T> GetAll();
    T GetById(int id);
}
