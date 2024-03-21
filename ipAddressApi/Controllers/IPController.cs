using ipAddressApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace ipAddressApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IPController : ControllerBase
    {
        private Dictionary<string, UserData> store = new Dictionary<string, UserData>();
        Initialize Initialize = new Initialize();
        private List<UserData> _GetAll;
        string baseAddress = "192.168.1.";
        int start = 1;
        
        public IPController()
        {
            _GetAll = Initialize.getData(); 
            foreach(var item in _GetAll)
            {
                store.Add(baseAddress+start.ToString(), item);
                start++;
            }
        }


        [HttpGet(Name = "GetUserInfo")]
        public IActionResult Get(string ipAddress)
        {
            if (ipAddress == null || !store.ContainsKey(ipAddress))
            {
                return NotFound(); 
            }

            return Ok(store[ipAddress]); 
        }

    }
}
