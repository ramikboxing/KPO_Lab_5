
using Kpo4381_nmv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPO4381_nmv.Main.source
{
    public partial class FrmCar : Form
    {
        public FrmCar()
        {
            InitializeComponent();           
            _car = null;    
        }
        //
        private Car _car = null;
        public Car car { get { return _car; } }

        public void SetCar(Car car)
        {
            this._car = car;

            this.tbMark.Text = _car.Mark;
            this.tbModel.Text = _car.Model;
            this.tbPrice.Text = _car.Price;
        }
        //
        private void FrmCar_Load(object sender, EventArgs e)
        {

        }

        private void lbMark_Click(object sender, EventArgs e)
        {

        }
    }
}
