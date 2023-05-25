using AutoMapper;


namespace Triton.Application.UseCases.Customer.Queries
{
    public class CustomersMappingProfile: Profile
    {
        public CustomersMappingProfile()
        {
            CreateMap<Domain.Customer, CustomersOutput>();
        }
    }
}
