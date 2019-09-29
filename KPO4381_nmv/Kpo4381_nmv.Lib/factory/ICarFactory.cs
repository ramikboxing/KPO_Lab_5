using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Lib
{
   public enum LoaderType {SPLIT, TEST}
   public  interface ICarFactory
    {
        ICarsListLoader CreateCarListLoader();
        ICarListSaver CreateCarListSaver();
    }
}
