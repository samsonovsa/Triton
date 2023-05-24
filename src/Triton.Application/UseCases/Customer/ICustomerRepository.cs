using Triton.Application.Common.Repositories;

namespace Triton.Application.UseCases.Customer
{
    public interface ICustomerRepository : IRepository<Domain.Customer, int>
    {
    }
}
