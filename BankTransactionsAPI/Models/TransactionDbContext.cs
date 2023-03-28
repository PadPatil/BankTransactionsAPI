using Microsoft.EntityFrameworkCore;

namespace BankTransactionsAPI.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options):base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
