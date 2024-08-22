using swapi.Models;

namespace swapi.Services
{
  public class PersonService
  {

    private readonly HttpClient _httpClient;

    public PersonService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    //public async Task<IEnumerable<Person>> FetchAndProcessPersonsAsync()
    //{
    //  var response = await _httpClient.GetAsync("https://swapi.dev/api/people/");
    //  response.EnsureSuccessStatusCode();

    //  var responseContent = await response.Content.ReadAsStringAsync();

    //  var apiResponse  = _httpClient.GetFromJsonAsync<>

    //}
  }
}
