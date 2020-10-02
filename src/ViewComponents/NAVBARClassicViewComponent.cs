using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace src.ViewComponents
{
    public class NAVBARClassicViewComponent : ViewComponent
    {
       
        public NAVBARClassicViewComponent()
        {           
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
