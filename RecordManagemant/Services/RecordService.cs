using AutoMapper;
using RecordManagemant.Entities;
using RecordManagemant.Models.Dto;
using RecordManagemant.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace RecordManagemant.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        private readonly IMapper _mapper;

        public RecordService(IRecordRepository recordRepository, IMapper mapper)
        {
            _recordRepository = recordRepository;
            _mapper = mapper;
        }

        public async Task<RecordDto> CreateRecordAsync(RecordDto recordDto)
        {
            var record = new Record();
            try
            {
                recordDto.PersonalIdentificationNumber = record.PersonalIdentificationNumber.Replace("/", "");
                record = _mapper.Map<Record>(recordDto);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error in parsing record", ex);
            }
            var createdRecord = await _recordRepository.CreateRecord(record);
            return _mapper.Map<RecordDto>(createdRecord);
        }
    }
}
