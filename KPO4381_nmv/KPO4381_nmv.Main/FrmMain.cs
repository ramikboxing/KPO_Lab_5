using Kpo4381_nmv;
using Kpo4381_nmv.Lib;
using Kpo4381_nmv.Utility;
using KPO4381_nmv.Main.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPO4381_nmv.Main
{
    public partial class FrmMain : Form
    {
        private BindingSource bsCars = new BindingSource();
        CarNewLoad_lab4 newLoader; // Lab4


        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }
       
        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {   /******Lab2 Interface******/
                /*  Чтение из файла Lab2  */
                // ICarsListLoader loader = new CarsListSplitFileLoader(AppGlobalSetting.dataFileName);
                /*  *  *  *  *  *  *  *  */
                /*  Чтение из класса LoadCarListTest Lab2  */
                // ICarsListLoader loader = new LoadCarListTest();
                /*  *  *  *  *  *  *  *  */

                /********Lab3 Factory*******************/
                /** Чтение из файла Lab 3 * */
                ICarFactory carsFactor = new CarSplitFileFactory();
                /*  *  *  *  *  *  *  *  *  */
                /**Lab3 Чтение из класса **/
                // ICarFactory carsFactor = new CarTestFactory();
                /*  *  *  *  *  *  *  *  */

                /**** Использование для абстракной фабрики ****/
                 ICarsListLoader loader = carsFactor.CreateCarListLoader();
                /*****общее использование Lab2 Lab3*********/
                loader.Execute();
                bsCars.DataSource = loader.carsList;
                dgvCarList.DataSource = bsCars;
                /****************************************/
                /**** Lab 4 Чтение из файла ****/
                
              //newLoader = new CarNewLoad_lab4("Lab4Cars.txt"); // явная передача параметра
    //            newLoader = new CarNewLoad_lab4(AppGlobalSetting.dataFileName2); // параметр считпется из App.config 
              //Получить список авто из файла
     //           newLoader.Execute();
              //Вывести список авто на экране  
    //            bsCars.DataSource = newLoader.carsList;
    //            dgvCarList.DataSource = bsCars;
                /*****     end Lab4       *****/
            }
            //Обработка исключения "Метод не реализован
            catch(NotImplementedException ex)
            {  
                MessageBox.Show("Ошибка №1:" + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
            //Обработка остальных исключений
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2:" + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }

        private void mnOpenCars_Click(object sender, EventArgs e)
        {
            try
            {
                //Создать экземпляр формы
                FrmCar frmCar = new FrmCar();
                //Задать ссылку на текущий объект в таблице
                Car car = (bsCars.Current as Car);
                Car carm = new Car();
                frmCar.SetCar(car);

                //Open Form2
                frmCar.ShowDialog();
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №3:" + ex.Message);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
