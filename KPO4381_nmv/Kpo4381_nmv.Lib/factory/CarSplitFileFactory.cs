using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Lib
{
   public class CarSplitFileFactory : ICarFactory
    {
        public ICarsListLoader CreateCarListLoader()
        {
            return new CarsListSplitFileLoader(AppGlobalSetting.dataFileName);
            //return new CarsListSplitFileLoader("Cars.txt");

        }

        public ICarListSaver CreateCarListSaver()
        {
            return null;
        }
    }
}
