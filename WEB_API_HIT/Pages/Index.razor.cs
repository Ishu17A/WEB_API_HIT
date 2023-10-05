using Microsoft.AspNetCore.Components;
using WEB_API_HIT.Model;

namespace WEB_API_HIT.Pages
{
    public partial class Index
    {
        [Inject] HttpClient httpClient { get; set; }

        public Model.Random RandomResponse = new();




        public async Task GetData()
        {
            RandomResponse = await httpClient.GetFromJsonAsync<Model.Random>("https://animechan.vercel.app/api/random");


             var obj = RandomResponse;


        }
    }
}
