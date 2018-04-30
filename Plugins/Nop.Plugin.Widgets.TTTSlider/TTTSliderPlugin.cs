using Microsoft.AspNetCore.Routing;
using Nop.Core.Plugins;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.TTTSlider
{
    public class TTTSliderPlugin : BasePlugin, IAdminMenuPlugin
    {
        private readonly Data.TTTSliderContext _context;

        public TTTSliderPlugin(Data.TTTSliderContext context)
        {
            _context = context;
        }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "TTTSlider",
                Title = "TTT Sliders",
                ControllerName = "TTTSlider",
                ActionName = "Configure",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", "Admin" } },
            };
            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "TTT Slider plugins");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }
    }
}
