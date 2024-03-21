using ipAddressApi.Model;

namespace ipAddressApi
{
    public class Initialize
    {
       private List<UserData> userdata;
        public Initialize()
        {
            userdata = new List<UserData>
            {

                new UserData { userId = "1212", location = "London" },
                new UserData { userId = "2323", location = "New York" },
                new UserData { userId = "3434", location = "Paris" },
                new UserData { userId = "4545", location = "Tokyo" },
                new UserData { userId = "5656", location = "Sydney" },
                new UserData { userId = "6767", location = "Berlin" },
                new UserData { userId = "7878", location = "Rome" },
                new UserData { userId = "8989", location = "Moscow" },
                new UserData { userId = "9090", location = "Madrid" },
                new UserData { userId = "1010", location = "Beijing" }
            };

        }
        public List<UserData> getData()
        {
            return userdata;
        } 
    }
}
    
