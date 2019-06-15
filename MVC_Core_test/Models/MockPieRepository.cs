using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_test.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null) {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie> {
                new Pie { Id = 1, Name = "Apple pie", Price=3.50M, LongDescription="nothing", ShortDescription="nothing much", ImageUrl="#", ImageThumbnailUrl="#", IsPieOfTheWeek=true},
                new Pie { Id = 1, Name = "Pear pie", Price=7M, LongDescription="nothing", ShortDescription="nothing much", ImageUrl="#", ImageThumbnailUrl="#", IsPieOfTheWeek=true}
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
