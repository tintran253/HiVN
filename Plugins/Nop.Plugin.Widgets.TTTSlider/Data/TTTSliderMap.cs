using Nop.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.TTTSlider.Data
{
    public class TTTSliderMap: NopEntityTypeConfiguration<Domain.TTTSlider>
    {
        public TTTSliderMap()
        {
            ToTable("TTTSlider");

            //Map the primary key
            HasKey(m => m.Id);
            //Map the additional properties
            Property(m => m.ProductId);
            //Avoiding truncation/failure 
            //so we set the same max length used in the product tame
        }
    }
}
