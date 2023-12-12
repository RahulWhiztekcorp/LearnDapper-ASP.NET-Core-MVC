using NPOI.SS.Formula.Functions;


namespace DAL
{
    public interface IDapperServices<T>
    {
        //IEnumerable<T> GetAll(string sp_name, T entity);
        //bool Add(string sp_name, T entity);
        //bool Update(string sp_name, T entity);
        //bool Delete(string sp_name, T entity);
        //    Task CreateAsync(T entity);
        Task<IEnumerable<T>> ReadAllAsync();
        //    Task<T> ReadAsync(int id);
        //    Task UpdateAsync(T entity);
        //    Task DeleteAsync(int id);
    }
}
