using AutoMapper;
using RecordManagemant.Models.Dto;

namespace RecordManagemant.Entities
{
    public class RecordProfile : Profile
    {
        public RecordProfile()
        {
            CreateMap<Record, RecordDto>();
            CreateMap<RecordDto, Record>();
        }
    }
}
