using AutoMapper;
using Triton.Application.UseCases.Address.Models;

namespace Triton.Application.UseCases.Address.Services
{
    public class AddressService: IAddressService
    {
        private readonly IAddressRepository _repository;
        private readonly IMapper _mapper;

        public AddressService(IAddressRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AddressViewModel> GetAdressById(int id)
        {
            var address =  await _repository.GetAsync(id);
            return _mapper.Map<AddressViewModel>(address);
        }
    }
}
