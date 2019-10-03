

using System.Threading.Tasks;

namespace CruisersApi.Persistence.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}