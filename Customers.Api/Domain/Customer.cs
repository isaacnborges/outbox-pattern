using Customers.Api.Contracts.Requests;

namespace Customers.Api.Domain;

public class Customer
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public string FullName { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public DateOnly DateOfBirth { get; private set; } = default;

    public Customer()
    { }

    public Customer(CustomerRequest request)
    {
        FullName = request.FullName;
        Email = request.Email;
        DateOfBirth = request.DateOfBirth;
    }

    public void Update(UpdateCustomerRequest request)
    {
        Email = request.Customer.Email;
        FullName = request.Customer.FullName;
        DateOfBirth = request.Customer.DateOfBirth;
    }
}
