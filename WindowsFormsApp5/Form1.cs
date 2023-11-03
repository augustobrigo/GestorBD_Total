using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        ConectarBD cnx;
        List<String> listadeTablas = new List<String>();
        List<String> listadeBD = new List<String>();
        List<String> listadeCabeceras = new List<String>();
        List<String> listaContenidoUnaTabla = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Salir??", "^Proyecto 5", MessageBoxButtons.YesNo);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String servidor = Interaction.InputBox("Teclea nombre del servidor","Conexión con el servidor");
            txtServidor.Text = servidor;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String BD = Interaction.InputBox("Teclea nombre de BD", "Conexión con el servidor");
            txtBD.Text = BD;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String usuario = Interaction.InputBox("Teclea nombre Usuario", "Conexión con el servidor");
            txtUser.Text = usuario;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String pwd = Interaction.InputBox("Teclea Password", "Conexión con el servidor","");
            txtPwd.Text = pwd;
            btnExportar.Enabled = true;
            btnImportar.Enabled = true;
            verUnaBD.Enabled = true;
            btn_TodasBD.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String consultaSQL = Interaction.InputBox("Teclea consulta SQL", "Conexión con el servidor");
            if (consultaSQL.Contains("show") || consultaSQL.Contains("Select") )

            textBox5.Text = consultaSQL;
            else
                textbox6.Text = consultaSQL;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != string.Empty)
            {
                try
                {
                    List<String> listadoCabecera = new List<String>();
                    List<String> listadoContenidos = new List<String>();
                    cnx = new ConectarBD(txtServidor.Text, txtBD.Text, txtUser.Text, txtPwd.Text);
                    listadoCabecera = cnx.listarCabeceras(textBox5.Text);
                    listadoContenidos = cnx.listarContenidos(textBox5.Text);
                    Form2 f2 = new Form2();
                    f2.listadoCabecera = listadoCabecera;
                    f2.listadoContenidos = listadoContenidos;
                    f2.Show();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de conexión BD");
                }
            }else
            {
                cnx = new ConectarBD(txtServidor.Text, txtBD.Text, txtUser.Text, txtPwd.Text);
                int resultado=cnx.cargarBD(textbox6.Text);
                if (resultado == 1)
                    MessageBox.Show("Consulta OK");
            }


        }

        private void btn_TodasBD_Click(object sender, EventArgs e)
        {
            
            foreach (String bd in listadeBD)
            {
                ConectarBD cnx = new ConectarBD(txtServidor.Text, bd, txtUser.Text, txtPwd.Text);
               
                String nombreFichero = @"c:/seguridad/" + bd + ".sql";
              
                cnx.ExportarDB(nombreFichero);
            
            }
          //  copiaCompleta();
        }

        private void copiaCompleta()
        {
            string connstr = "server=localhost;user=root;pwd='';database=dam2020;sslmode=none;";
            string backupfile = @"c:\\ticket\\backup.sql";

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        conn.Open();
                        cmd.Connection = conn;

                        mb.ExportToFile(backupfile);

                        conn.Close();
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
         
             cnx = new ConectarBD(txtServidor.Text, txtBD.Text, txtUser.Text, txtPwd.Text);
            btnExportar.Enabled = true;
            listadeBD = cnx.listarBD();
            listBoxBD.DataSource = listadeBD;
            listadeTablas = cnx.listarTablas();

            listaTabla.DataSource = listadeTablas;
            groupBox2.Text = txtBD.Text;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listaTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posicion = 0;
            listadeCabeceras.Clear();
            dataGridView1.Controls.Clear();
            if (listaTabla.SelectedIndex != -1)
            {
                 posicion = listaTabla.SelectedIndex;
            }
                
    //        MessageBox.Show(listadeTablas[posicion]);

            listadeCabeceras = cnx.CargarCabeceradeTabla(listadeTablas[posicion]);
            ListContenidos.DataSource = listadeCabeceras;
            listaContenidoUnaTabla = cnx.CargaContenidoTabla(listadeTablas[posicion]);
            listContenidosTotal.DataSource = listaContenidoUnaTabla;

            dataGridView1.ColumnCount = 0;
           // dataGridView1.ColumnCount = listadeCabeceras.Count;
            
            for (int i = 0; i < listadeCabeceras.Count; i++)
            {
                dataGridView1.Columns.Add(listadeCabeceras[i], listadeCabeceras[i]);
            }
            for (int i = 0; i < listaContenidoUnaTabla.Count; i++)
            {
                String[] cadena = listaContenidoUnaTabla[i].Split(';');
                 dataGridView1.Rows.Add();
                for (int j = 0; j < cadena.Length-1; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = cadena[j].ToString();
                }
            }
            
             
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirFichero = new OpenFileDialog();
            abrirFichero.Title = "Seleccionar un fichero(.sql)para la copia seguridad";
            abrirFichero.Filter = "Sql fichero|*.sql";
            if (abrirFichero.ShowDialog() == DialogResult.OK)
            {
                String nombreFichero = abrirFichero.FileName;
                cnx.ExportarDB(nombreFichero);


            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirFichero = new OpenFileDialog();
            abrirFichero.Title = "Seleccionar un fichero(.sql)para la copia seguridad";
            abrirFichero.Filter = "Sql fichero|*.sql";
            if (abrirFichero.ShowDialog() == DialogResult.OK)
            {
                String nombreFichero = abrirFichero.FileName;
                cnx.ImportarBD(nombreFichero);



            }
        }

        private void listBoxBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posiSeleccionada = listBoxBD.SelectedIndex;
            String bd = listBoxBD.Items[posiSeleccionada].ToString();
            MessageBox.Show("BD: " + bd);
            ConectarBD cnx = new ConectarBD(txtServidor.Text, bd, txtUser.Text, txtPwd.Text);
            listaTabla.DataSource = null;
            listadeTablas = cnx.listarTablas();
          //  listadeCabeceras = cnx.car
            listaTabla.DataSource = listadeTablas;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }
    }
}
