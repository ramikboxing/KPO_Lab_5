//using Kpo4381_nmv.Lib.source.Cars;
using Kpo4381_nmv.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Utility
{
  public  class CarsList
    {
        public CarsList()
        {
             this._carsList = null;
        }
        //private readonly string _dataFileName = "";
        private List<Car> _carsList = null;

        public List<Car> Carslist { get { return _carsList; } }

        public void Execute()
        {
            _carsList = new List<Car>();

            try
            {
                {
                    Car car = new Car()
                    {
                        Mark = "Ралина",
                        Model = "MarkII ",
                        Price = "350000"
                    };

                    _carsList.Add(car);
                }
                {
                    Car car = new Car()
                    {
                        Mark = "BMW ",
                        Model = "X5 ",
                        Price = "3500000"
                    };

                    _carsList.Add(car);
                }
                {
                    Car car = new Car()
                    {
                        Mark = "BMW ",
                        Model = "X3 ",
                        Price = "3200000"
                    };
                   
                    _carsList.Add(car);
                }
                Console.WriteLine("HelloList");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("NotImplementedException");
                LogUtility.ErrorLog(ex.Message);
            }
            //Обработка остальных исключений
            catch (Exception ex)
            {
                Console.WriteLine("Exception ex");
                LogUtility.ErrorLog(ex.Message);
            }
        }
    }
}
