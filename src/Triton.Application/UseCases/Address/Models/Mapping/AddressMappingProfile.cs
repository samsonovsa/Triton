using AutoMapper;

namespace Triton.Application.UseCases.Address.Models.Mapping
{
    public class AddressMappingProfile: Profile
    {
        public AddressMappingProfile()
        {
            CreateMap<Domain.Address, AddressViewModel>();
        }
    }
}
