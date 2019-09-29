using Kpo4381_nmv.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Lib
{
   public  class CarsListSplitFileLoader : ICarsListLoader
    {
        public CarsListSplitFileLoader(string dataFileName)
        {
            _dataFileName = dataFileName;
        }
        private readonly string _dataFileName = "";
        private List<Car> _carsList;
        private LoadStatus _status = LoadStatus.None;

        public List<Car> carsList
        {
            get { return _carsList; }
        }
 
        public LoadStatus status
        {
            get { return _status; }
        }

        public void Execute()
        {
            //Статус выполнения чтения данных
            _status = LoadStatus.ReadingData;
            try
            {
                if (_dataFileName == string.Empty)
                {
                    Console.WriteLine("Имя файла не указано");
                    throw new Exception("Имя файла не указано");
                }
                if (!(File.Exists(@"C:\Users\Ram\Desktop\КАИ\Конструирование ПО\" + _dataFileName)))
                {
                    Console.WriteLine("Файла не существует");
                    throw new Exception("Файла " + _dataFileName+" не существует!");
                }
                //Создание нового списка
                 _carsList = new List<Car>();

                //Чтение данных 
                 StreamReader sr = null;

        using (sr = new StreamReader(@"C:\Users\Ram\Desktop\КАИ\Конструирование ПО\" + _dataFileName)  )
            {
                while (!sr.EndOfStream)
                {
                //Прочитать очередную строку
                 string str = sr.ReadLine();
          //Console.WriteLine(str);
                 string[] arr = str.Split('|');
                    //Создать новый объект
                     Car car = new Car()
                      {
                           Mark = arr[0],
                           Model = arr[1],
                           Price = arr[2]
                      };
                  _carsList.Add(car);
                }
            }
                //Статус чтения данных успешно
                _status = LoadStatus.Succes;
            }
            catch (Exception ex)
            {
                _status = LoadStatus.ReadingError;
                Console.WriteLine("ExecuteError");
                LogUtility.ErrorLog(ex);
            }
        }
    }
    public  enum LoadStatus
    {
        None =-1,
        ReadingData = 0,
        Succes = 1,
        ReadingError =2
    }
}
