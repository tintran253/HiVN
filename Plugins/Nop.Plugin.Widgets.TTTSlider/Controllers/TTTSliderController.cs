using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.TTTSlider.Domain;
using Nop.Plugin.Widgets.TTTSlider.Services;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Kendoui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.TTTSlider.Controllers
{
    [Area(AreaNames.Admin)]
    public class TTTSliderController: BasePluginController
    {
        private readonly IPermissionService _permissionService;
        private readonly ITTTSliderService _TTTSliderService;
        public TTTSliderController(IPermissionService permissionService, ITTTSliderService TTTSliderService)
        {
            _permissionService = permissionService;
            _TTTSliderService = TTTSliderService;
        }
        public IActionResult Configure()
        {
            //if (!_permissionService.Authorize(StandardPermissionProvider.ManageProducts))
            //    return AccessDeniedView();
            return View("~/Plugins/Widgets.TTTSlider/Views/Configure.cshtml");
        }

        public IActionResult List()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageProducts))
                return AccessDeniedView();
            var slides = _TTTSliderService.GetAll();
            var gridModel = new DataSourceResult
            {
                Data = slides,
                Total = slides.Count()
            };

            return Json(gridModel);
        }

        public IActionResult AddNew()
        {
            return View();
        }
    }
}
