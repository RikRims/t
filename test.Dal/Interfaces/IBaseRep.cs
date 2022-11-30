namespace test.Dal.Interfaces
{
    public interface IBaseRep<T>
    {
        bool Create(T entity);

        T Get(int id);

        Task<List<T>> Select();

        bool Delete(T entity);


    }
}
