using System;
using Kpo4381_nmv.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace UnitTestProject
namespace Kpo4381_nmv
{
    [TestClass]
    public class UnitTest
    {
        private CarNewLoad_lab4 newLoader;
             
        public UnitTest()
        {
            newLoader = new CarNewLoad_lab4("Lab4Cars.txt");
        }
        //Test 1
        /*Проверка имени файла для загрузки*/
        [TestMethod]
        public void TestFileName()
        {
            var target = newLoader.getFileName;
            Assert.AreEqual("Lab4Cars.txt", target);
        }
        //Тест 2
        /*Проверка марки первой ммашины в получаемом списке*/
        [TestMethod]
        public void TestExecuteMethodCarModel()
        {
            newLoader.Execute();
            var targetCarModel = newLoader.carsList[0].Mark;
            Console.WriteLine("TestTest"+ newLoader.carsList[0].Mark);
            Assert.AreEqual("Mersedes", targetCarModel);
        }
        //Тест3
        /*Проверка на возврат не путого списка*/
        [TestMethod]
        public void CheckListNotNull_Class()
        {
            LoadCarListTest list = new LoadCarListTest();
            list.Execute(); //Вывзвать метот создающий и заполняющий список
            Assert.IsNotNull(list.carsList); //Если срисок есть то ОК
        }
        //Тест 4
        /*Проверка пустой список из класса или нет*/
        [TestMethod]
        public void ChekListNotNull_File()
        {
            ICarFactory loader = new CarTestFactory(); // обращение к объектам через интер-с
            ICarsListLoader Loader = loader.CreateCarListLoader();
            Loader.Execute();// Заполнение списка
            Assert.IsNotNull(Loader.carsList);// Проверка списка на пустату          
        }
        //Тест 5
        /**/
        [TestMethod]
        public void ChekListWithStatusSuccess_TestFileLoad()
        {   
            ICarFactory loader = new CarSplitFileFactory(); // обращение к объекту через интерфейс
            ICarsListLoader Loader = loader.CreateCarListLoader();
            /*Список удачно читается когда в классе CarSplitFileFactory явно передано имя файла
            для чтения, при передачи имени файла через AppGlobalSettin возникает исключения
            "Файл не найден" т.к. имя файла прочитываеться из App.config в переменную _dataFileName*/
            Loader.Execute();
            /*Если файл найден стуст Succes иначе ReadingError*/
            if (Loader.status == LoadStatus.Succes)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}

