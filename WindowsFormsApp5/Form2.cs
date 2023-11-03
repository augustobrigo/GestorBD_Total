using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
      public  List<String> listadoCabecera = new List<String>();
      public  List<String> listadoContenidos = new List<String>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox2.DataSource = listadoCabecera;
            listBox1.DataSource = listadoContenidos;
        }
    }
}
