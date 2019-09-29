using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Lib
{
    public class CarTestFactory : ICarFactory
    {
        public ICarsListLoader CreateCarListLoader()
        {
           return new LoadCarListTest();
        }

        public ICarListSaver CreateCarListSaver()
        {
            return null;
        }
    }
}
