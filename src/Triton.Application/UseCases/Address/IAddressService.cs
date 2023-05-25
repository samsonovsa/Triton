using Triton.Application.UseCases.Address.Models;

namespace Triton.Application.UseCases.Address
{
    public interface IAddressService
    {
        Task<AddressViewModel> GetAdressById(int id);
    }
}
