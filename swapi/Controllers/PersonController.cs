using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using swapi.Models;
using System.Text.Json;

namespace swapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PersonController : ControllerBase
  {

    private readonly HttpClient _httpClient;

        public PersonController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

    [HttpGet(Name = "GetPersons")]
    public async Task<IEnumerable<Person>> Get() 
    {
      var response = await _httpClient.GetAsync("https://swapi.dev/api/people/");
      response.EnsureSuccessStatusCode();

      var responseContent = await response.Content.ReadAsStringAsync();
      var apiResponse = JsonSerializer.Deserialize<SwapiResponse>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

      return apiResponse.Results;
    }
  }
}
