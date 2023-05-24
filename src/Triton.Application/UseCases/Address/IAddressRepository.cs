using Triton.Application.Common.Repositories;

namespace Triton.Application.UseCases.Address
{
    public interface IAddressRepository : IRepository<Domain.Address, int>
    {
    }
}
