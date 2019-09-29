using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Lib
{
    public class CarNewLoad_lab4 : ICarsListLoader
    {
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
        // Получить ссылку на файл для чтения
        public CarNewLoad_lab4(string filename)
        {
            _dataFileName = filename;
        }
        public String  getFileName
        {
            get { return _dataFileName; }
        }
        /*Инициализировать чтение данных*/
        public void Execute()
        {
            /*Статус выполнения чтения данных*/
            _status = LoadStatus.ReadingData;

            //Если < нет ссылки на файл >              
            if (_dataFileName == string.Empty)
            {
                //то
                /*Отписать в консоли*/
                Console.WriteLine("Имя файла не указано");
                //вызвать исключение
                throw new Exception("Имя файла не указано");
            }
            //Если <по ссылке нет нужного файла>
            if (!(File.Exists(@"C:\Users\Ram\Desktop\КАИ\Конструирование ПО\" + _dataFileName)))
            {
                //то
                /*Отписать в консоли*/
                Console.WriteLine("Файла не существует");
                //<Вызвать исключение>
                throw new Exception("Файла не существует!");
            }
            //Все Если.

            /*Создать  список*/
            _carsList = new List<Car>();

            //Чтение данных файла
            StreamReader sr = null;
            using (sr = new StreamReader(@"C:\Users\Ram\Desktop\КАИ\Конструирование ПО\" + _dataFileName))
            {
                //Цикл пока <Не достигнут конец текста>
                while (!sr.EndOfStream)
                {
                    //Прочитать очередную строку
                    string str = sr.ReadLine();
                   
            /*Test*///Console.WriteLine(str);

                    //из строки первые 10 сим-в это (Марка авто)
                    string markavto = str.Substring(0,10).Trim();

                    //из строки вторая десятка символов это (Модель авто)
                    string modelavto = str.Substring(11,10).Trim();

                    //из строки третья десятка символов это (Стоимость авто)
                    string priceavto = str.Substring(21,10).Trim();

                    //Добавить авто с прочитанными характеристиками в список
                    _carsList.Add(new Car()
                    {
                        Mark = markavto,
                        Model = modelavto,
                        Price = priceavto
                    });
                }
                //Все цикл
            }
        }
    }
}
