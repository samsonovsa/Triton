using Triton.Application.UseCases.Customer;
using Triton.Infrastructure.DataProviders;
using Triton.Infrastructure.UseCases.Common;

namespace Triton.Infrastructure.UseCases.Customer
{
    public class CustomerRepository : Repository<Domain.Customer, int>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
