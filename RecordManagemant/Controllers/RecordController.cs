using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecordManagemant.Models.Dto;
using RecordManagemant.Services;
using RecordManagemant.Repositories;
using RecordManagemant.Entities;

namespace RecordManagemant.Controllers
{
    public class RecordController : Controller
    {
        private readonly IRecordService _recordService;
        private readonly IRecordRepository _recordRepository;

        public RecordController(IRecordService recordService, IRecordRepository recordRepository)
        {
            _recordService = recordService;
            _recordRepository = recordRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<Nationality> nationalities = await _recordRepository.GetAllNationalities();
            
            var recordDto = new RecordDto(){
                NationalityList = nationalities
                    .Select(n => new SelectListItem(n.Name, n.Id.ToString()))
                    .ToList()
            };

            return View(recordDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RecordDto recordDto)
        {
            if (!ModelState.IsValid)
            {
                List<Nationality> nationalities = await _recordRepository.GetAllNationalities();

                recordDto.NationalityList = nationalities
                    .Select(n => new SelectListItem(n.Name, n.Id.ToString()))
                    .ToList();
                    
                return View(recordDto);
            }

            await _recordService.CreateRecordAsync(recordDto);
            return View("Result", recordDto);
        }
    }
}
