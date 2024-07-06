using Core.v1.Entities;
using Core.v1.Interfaces.Base;

namespace Core.v1.Interfaces
{
    public interface ITripRepository : IGetRepository<Trip>, IAddRepository<Trip>, IUpdateRespository<Trip>, IDeleteRepository<Trip>
    {
    }
}
