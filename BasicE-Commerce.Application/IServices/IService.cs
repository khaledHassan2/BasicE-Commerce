namespace BasicE_Commerce.Application.IServices
{
    public interface IService<TEntity,TKey,TEntityDto,TEntityCreatedDto,TRepository>
    {
        public ICollection<TEntityDto> GetAll();
        public TEntityDto GetItemById();
    }
}
