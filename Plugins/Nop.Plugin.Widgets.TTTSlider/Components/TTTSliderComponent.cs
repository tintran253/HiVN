using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.TTTSlider.Components
{
    [ViewComponent(Name = "TTTSlider")]
    public class TTTSliderComponent: NopViewComponent
    {
        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {            
            return View("~/Plugins/Widgets.TTTSlider/Views/PublicInfo.cshtml", new TTTSlider.Domain.TTTSlider());
        }
    }
}
