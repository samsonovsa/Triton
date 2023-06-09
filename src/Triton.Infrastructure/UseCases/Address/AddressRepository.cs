using Triton.Application.UseCases.Address;
using Triton.Infrastructure.DataProviders.EF;
using Triton.Infrastructure.UseCases.Common;


namespace Triton.Infrastructure.UseCases.Address
{
    public class AddressRepository : Repository<Domain.Address, int>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
