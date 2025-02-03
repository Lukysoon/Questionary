using RecordManagemant.Entities;
using RecordManagemant.Models.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace RecordManagemant.Services
{
    public interface IRecordService
    {
        Task<RecordDto> CreateRecordAsync(RecordDto recordDto);
    }
}
