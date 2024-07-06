using Core.v1.Entities;
using Core.v1.Interfaces.Base;

namespace Core.v1.Interfaces
{
    public interface IRegistrationRepository :
        IGetRepository<Registration>,
        IAddRepository<Registration>,
        IUpdateRespository<Registration>,
        IDeleteRepository<Registration>
    {

        Task<Registration> GetByNameAsync(string Name);
    }
}
