using Microsoft.AspNetCore.Mvc;

namespace Lumia.Presentation.AspNetMvc.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "Hello from the Nav View Component";
        }
    }
}
