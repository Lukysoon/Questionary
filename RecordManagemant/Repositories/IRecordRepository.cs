using Microsoft.AspNetCore.Mvc.Rendering;
using RecordManagemant.Entities;
using RecordManagemant.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace RecordManagemant.Repositories
{
    public interface IRecordRepository
    {
        Task<Record> CreateRecord(Record record);
        Task<List<Nationality>> GetAllNationalities();
    }
}
