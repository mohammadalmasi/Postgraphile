using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using ViewModel;

namespace WebApi.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly string _endPoint;
        private readonly IHttpClientFactory _httpClient;

        public AccountController(IConfiguration configuration, IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
            _endPoint = configuration["GraphQLURI"];

        }


        [HttpPost("get-all")]
        public async Task<AccountRoot> GetAll([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<AccountRoot>(resultContent);
            return accountList;
        }

        [HttpPost("create")]
        public async Task<CreateAccountRoot> Create([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<CreateAccountRoot>(resultContent);
            return accountList;
        }

        [HttpPost("update")]
        public async Task<UpdateAccountRoot> Update([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<UpdateAccountRoot>(resultContent);
            return accountList;
        }

        [HttpPost("delete")]
        public async Task<DeleteAccountRoot> Delete([FromBody] Input query)
        {
            var content = new StringContent(query.Query, Encoding.UTF8, "application/graphql");
            HttpResponseMessage response = await _httpClient.CreateClient().PostAsync(_endPoint, content);
            string resultContent = await response.Content.ReadAsStringAsync();
            var accountList = JsonConvert.DeserializeObject<DeleteAccountRoot>(resultContent);
            return accountList;
        }

    }
}
