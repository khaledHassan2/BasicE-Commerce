namespace BasicE_Commerce.Application.IServices.GenericInterfaces
{
    public interface IRemoveItem<TEntity>
    {
         void RemoveItem(TEntity entity);

    }
}
