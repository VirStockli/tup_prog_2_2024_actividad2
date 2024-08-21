using Comisaría.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comisaría
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comisaria destacamento;
        private void btnCrearComisaria_Click(object sender, EventArgs e)
        {
            //int dni=;
            //string nombre= ;
            //int placa = ;
            Policia Juan = new Policia(15915912, "Juan", 4569);

            Policia Ana = new Policia(14715856, "Ana", 8541);

            destacamento.AsignarPolicia(Juan);
            destacamento.AsignarPolicia(Ana);

        }
    }
}
