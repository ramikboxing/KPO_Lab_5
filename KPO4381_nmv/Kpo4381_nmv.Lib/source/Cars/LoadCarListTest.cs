using Kpo4381_nmv.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Lib
{
    public class LoadCarListTest : ICarsListLoader
    {
        public LoadCarListTest()
        {
            /*список будет создаваться при вызове Execute() для Теста*/
            //this._carsList = new List<Car>();
        }
        private List<Car> _carsList = null; //Обьевляем список
        public List<Car> carsList // При вызове вернет список из Execute();
        {
            get { return _carsList; }
        } 
        public LoadStatus status => throw new NotImplementedException();

        public void Execute()
        {
            this._carsList = new List<Car>();

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
               
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("NotImplementedException"+ex);             
            }
            //Обработка остальных исключений
            catch (Exception ex)
            {
                Console.WriteLine("Exception ex"+ex);
            }
        }
    }
}
