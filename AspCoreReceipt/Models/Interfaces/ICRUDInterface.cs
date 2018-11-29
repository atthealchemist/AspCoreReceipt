using System.Collections.Generic;

namespace App.Backend.Interfaces
{
    public interface ICRUDInterface<T>
    {
        void Create(T entity);

        T Get(int id);

        List<T> All();

        void Update(int id, T entity);

        void Delete(T entity);
        void Delete(int id);
    }
}