using Voxta.Application.DTOs.Customers;

namespace Voxta.Application.Interfaces;

public interface ICustomerService
{
    Task<CustomerDto> CreateAsync(CreateCustomerDto dto);

    Task<List<CustomerDto>> GetAllAsync();

    Task<CustomerDto?> GetByIdAsync(Guid id);

    Task<CustomerDto?> UpdateAsync(Guid id, UpdateCustomerDto dto);

    Task<bool> DeleteAsync(Guid id);
}
