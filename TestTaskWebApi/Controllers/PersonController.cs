using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestTaskWebApi.Dto;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestTaskWebApi.Controllers
{
    [Route("api/v1/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        //Get a character by ID
        [HttpGet]
        public async Task<PersonDto> GetPerson([FromQuery] string id)
        {

            var endpoint = new Uri("https://rickandmortyapi.com/api/character/" + $"{id}");
            using (var _httpClient = new HttpClient())
            {

                var request = await _httpClient.GetStringAsync(endpoint);
                PersonDto personDto = JsonConvert.DeserializeObject<PersonDto>(request);
                return personDto;

            }



        }

        //POST api/v1
        //[HttpPost]
        // public Task<bool> CheckPerson([FromBody] string name, string episode)
        // {
        //     return _characterHttpService.CheckPersonAsync(name:name,episode:episode);
        // }

    }
}
