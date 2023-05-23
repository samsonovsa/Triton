using Triton.Infrastructure.UseCases.Common;

namespace Triton.Infrastructure.UseCases.Customer
{
    public interface ICustomerRepository : IRepository<Domain.Customer, int>
    {
    }
}
