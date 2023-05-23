using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Infrastructure.DataProviders;
using Triton.Infrastructure.UseCases.Common;
using Triton.Infrastructure.UseCases.Customer;

namespace Triton.Infrastructure.UseCases.Address
{
    public class AddressRepository : Repository<Domain.Address, int>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
