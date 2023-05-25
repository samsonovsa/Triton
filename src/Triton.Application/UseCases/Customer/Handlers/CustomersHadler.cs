using AutoMapper;
using MediatR;
using Triton.Application.UseCases.Customer.Queries;

namespace Triton.Application.UseCases.Customer.Handlers
{
    public class CustomersHadler : IRequestHandler<CustomersQuery, CustomersOutput>
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomersHadler(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CustomersOutput> Handle(CustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _repository.GetAllAsync(new CancellationToken());
            return _mapper.Map<CustomersOutput>(customers);
        }
    }
}
