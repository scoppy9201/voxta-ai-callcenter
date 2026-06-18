using Voxta.Application.DTOs.Customers;
using Voxta.Application.Interfaces;

namespace Voxta.Application.Services;

public class CustomerService : ICustomerService
{
    public Task<CustomerDto> CreateAsync(CreateCustomerDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<CustomerDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDto?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDto?> UpdateAsync(Guid id, UpdateCustomerDto dto)
    {
        throw new NotImplementedException();
    }
}
