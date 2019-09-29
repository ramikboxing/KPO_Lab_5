using System.Collections.Generic;

namespace Kpo4381_nmv.Lib
{
    public interface ICarsListLoader
    {
        List<Car> carsList { get; }
        LoadStatus status { get; }

        void Execute();
    }
}