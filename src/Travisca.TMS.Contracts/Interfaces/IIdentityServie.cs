namespace Tavisca.TMS.Contracts.Interfaces
{
    public interface IIdentityService<T>
    {
        string Get(T entity);
    }
}
