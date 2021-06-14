using isolutions.GrillMaster.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace isolutions.GrillMaster.Services
{
    public class GrillMenuService : IGrillMenuService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public GrillMenuService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<List<GrillMenu>> GetGrillMenus()
        {
            var httpClient = httpClientFactory.CreateClient();

            var responseString = await httpClient.GetStringAsync("http://isol-grillassessment.azurewebsites.net/api/GrillMenu");
            var menus = JsonConvert.DeserializeObject<List<GrillMenu>>(responseString);

            return menus;
        }
    }
}
