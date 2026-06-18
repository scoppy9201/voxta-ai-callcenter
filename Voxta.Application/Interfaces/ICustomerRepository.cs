using Voxta.Domain.Entities;

namespace Voxta.Application.Interfaces;

public interface ICustomerRepository
{
    Task<Customer> CreateAsync(Customer customer);

    Task<List<Customer>> GetAllAsync();

    Task<Customer?> GetByIdAsync(Guid id);

    Task<Customer?> UpdateAsync(Customer customer);

    Task<bool> DeleteAsync(Guid id);
}
