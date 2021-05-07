using System;
using System.Threading.Tasks;

namespace isolutions.GrillMaster.Services
{
    public class GrillMasterResolver : IGrillMasterResolver
    {
        private readonly IGrillMenuService grillMenuService;

        public GrillMasterResolver(IGrillMenuService grillMenuService)
        {
            this.grillMenuService = grillMenuService;
        }

        public async Task Resolve()
        {
            var menus = await grillMenuService.GetGrillMenus();

            // TODO: Implement algorithm and show results.

            throw new NotImplementedException();
        }
    }
}
