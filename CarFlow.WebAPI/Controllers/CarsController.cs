using CarFlow.DomainServices.Interfaces;
using CarFlow.WebAPI.Mappers;
using CarFlow.WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.WebAPI.Controllers;

[Authorize(Policy = "AdminPolicy")]
[ApiController]
[Route("[controller]")]
public class CarsController(ICarService carService) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<CarContract>> Get()
    {
        var cars = await carService.GetAllAsync();

        return cars.ToContract();
    }
}