using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.TTTSlider.Domain
{
    public class TTTSlider: BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Hint { get; set; }
        public string Description { get; set; }
        public string UrlActionClick { get; set; }
        public bool IsActive { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime ExpiredOnUtc { get; set; }

        public Product Product { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
    }
}
