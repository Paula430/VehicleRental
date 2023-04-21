using Microsoft.AspNetCore.Identity;
using System.Data.Entity;

namespace BikeRentalSystem.Models
{
    public class CustomerStore : IUserStore<Customer>
    {
        private readonly BikeRentalContext _context;

        public CustomerStore(BikeRentalContext context)
        {
            _context = context;
        }

        public async Task<IdentityResult> CreateAsync(Customer user, CancellationToken cancellationToken)
        {
            _context.Customers.Add(user);
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteAsync(Customer user, CancellationToken cancellationToken)
        {
            _context.Customers.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }

        public void Dispose()
        {
            // nothing to dispose
        }

        public async Task<Customer> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            return await _context.Customers.FindAsync(int.Parse(userId), cancellationToken);
        }

        public async Task<Customer> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return await _context.Customers.FirstOrDefaultAsync(u => u.NormalizedUserName == normalizedUserName, cancellationToken);
        }

        public Task<string> GetNormalizedUserNameAsync(Customer user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string> GetUserIdAsync(Customer user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id.ToString());
        }

        public Task<string> GetUserNameAsync(Customer user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task SetNormalizedUserNameAsync(Customer user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        public Task SetUserNameAsync(Customer user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public async Task<IdentityResult> UpdateAsync(Customer user, CancellationToken cancellationToken)
        {
            _context.Customers.Update(user);
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }
    }
}
