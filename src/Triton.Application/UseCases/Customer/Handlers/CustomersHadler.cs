using MediatR;
using Triton.Application.UseCases.Customer.Queries;

namespace Triton.Application.UseCases.Customer.Handlers
{
    public class CustomersHadler : IRequestHandler<CustomersQuery, CustomersOutput>
    {
        private readonly ICustomerRepository _repository;

        public CustomersHadler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<CustomersOutput> Handle(CustomersQuery request, CancellationToken cancellationToken)
        {
            return  (CustomersOutput)(await _repository.GetAllAsync(new CancellationToken()));
        }
    }
}
