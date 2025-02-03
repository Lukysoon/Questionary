using Microsoft.EntityFrameworkCore;
using RecordManagemant.Entities;
using RecordManagemant.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace RecordManagemant.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Record> Records { get; set; }
        DbSet<Nationality> Nationalities { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();
    }
}
