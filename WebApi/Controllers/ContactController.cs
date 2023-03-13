using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using ViewModel;

namespace WebApi.Controllers
{
    [Route("api/contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly string _endPoint;
        private readonly IHttpClientFactory _httpClient;

        public ContactController(IConfiguration configuration, IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
            _endPoint = configuration["GraphQLURI"];
        }


        [HttpPost("get-all")]
        public async Task<ContactRoot> GetAll([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<ContactRoot>(resultContent);
            return accountList;
        }

        [HttpPost("create")]
        public async Task<CreateContactRoot> Create([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<CreateContactRoot>(resultContent);
            return accountList;
        }

        [HttpPost("update")]
        public async Task<UpdateContactRoot> Update([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<UpdateContactRoot>(resultContent);
            return accountList;
        }

        [HttpPost("delete")]
        public async Task<DeleteContactRoot> Delete([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<DeleteContactRoot>(resultContent);
            return accountList;
        }

    }
}
