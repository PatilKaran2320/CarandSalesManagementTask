using CarandSalesManagement.DTOs;
using CarandsalemanagementMVC.Services.IServices;
using CarandsalemanagementMVC.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace CarandSalesManagement.Controllers
{
    public class CarModelsController : Controller
    {

        private readonly ICarModelService _carModelService;
        private readonly IMapper _mapper;

        public CarModelsController(ICarModelService carModelService, IMapper mapper)
        {
            _carModelService = carModelService ?? throw new ArgumentNullException(nameof(carModelService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarModelDto>>> GetCarModels()
        {
            var carModels = await _carModelService.GetAllCarModelsAsync();
            var carModelDtos = _mapper.Map<IEnumerable<CarModelDto>>(carModels);
            return Ok(carModelDtos);
        }

    }
}
