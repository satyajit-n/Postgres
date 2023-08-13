﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalksVersioning.Models.DTO_s;

namespace NZWalksVersioning.Controllers
{
    [Route("api/v{version:ApiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class CountriesController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
        {
            var countryDomainModel = CountriesData.Get();

            var response = new List<CountryDtoV1>();
            foreach(var countryDomain in  countryDomainModel)
            {
                response.Add(new CountryDtoV1
                {
                    Id = countryDomain.Id,
                    Name = countryDomain.Name,
                });
            }
            return Ok(response);
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
        {
            var countryDomainModel = CountriesData.Get();

            var response = new List<CountryDtoV2>();
            foreach (var countryDomain in countryDomainModel)
            {
                response.Add(new CountryDtoV2
                {
                    Id = countryDomain.Id,
                    CountryName = countryDomain.Name,
                });
            }
            return Ok(response);
        }
    }
}
