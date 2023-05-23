using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Infrastructure.UseCases.Common;

namespace Triton.Infrastructure.UseCases.Address
{
    public interface IAddressRepository : IRepository<Domain.Address, int>
    {
    }
}
