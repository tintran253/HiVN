﻿using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
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

        public IActionResult Configure()
        {
            return View();
        }
    }
}
