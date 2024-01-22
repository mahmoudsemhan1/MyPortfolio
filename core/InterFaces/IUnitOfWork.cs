namespace core.InterFaces
{
    public interface IUnitOfWork<T> where T : class
    {
        IGenricRepository<T> Entity { get; }
        void Save();
    }
}
