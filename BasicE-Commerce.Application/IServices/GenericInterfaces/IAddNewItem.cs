namespace BasicE_Commerce.Application.IServices.GenericInterfaces
{
    public interface IAddNewItem<TEntity>
    {
         void AddNewItem(TEntity entity);

    }
}
