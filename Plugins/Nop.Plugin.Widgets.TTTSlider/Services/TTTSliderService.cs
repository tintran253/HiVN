using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Data;
using Nop.Plugin.Widgets.TTTSlider.Domain;

namespace Nop.Plugin.Widgets.TTTSlider.Services
{
    public class TTTSliderService : ITTTSliderService
    {
        private readonly IRepository<Domain.TTTSlider> _tttSliderRepository;

        public TTTSliderService(IRepository<Domain.TTTSlider> tttSliderRepository)
        {
            _tttSliderRepository = tttSliderRepository;
        }

        public void Add(Domain.TTTSlider slider)
        {
            _tttSliderRepository.Insert(slider);            
        }

        public IEnumerable<Domain.TTTSlider> GetAll()
        {
            return from s in _tttSliderRepository.Table
                   where s.IsActive == true
                   select s;                   
        }
    }
}
