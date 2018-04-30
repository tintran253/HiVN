using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.TTTSlider.Services
{
    public interface ITTTSliderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="slider"></param>
        void Add(Domain.TTTSlider slider);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="slider"></param>
        IEnumerable<Domain.TTTSlider> GetAll();
    }
}
