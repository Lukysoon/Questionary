using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecordManagemant.Entities;
using RecordManagemant.Data;
using RecordManagemant.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace RecordManagemant.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        private readonly IApplicationDbContext _context;

        public RecordRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Record> CreateRecord(Record record)
        {
            _context.Records.Add(record);
            await _context.SaveChangesAsync();
            return record;
        }

        public async Task<List<Nationality>> GetAllNationalities()
        {
            return await _context.Nationalities.ToListAsync();
        }
    }
}
