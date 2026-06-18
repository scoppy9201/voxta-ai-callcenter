namespace Voxta.Application.DTOs.Customers;

public class CreateCustomerDto
{
    public string FullName { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string CompanyName { get; set; } = string.Empty;

    public string Position { get; set; } = string.Empty;

    public string Source { get; set; } = string.Empty;

    public string Note { get; set; } = string.Empty;
}
