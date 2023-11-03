using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp5


{

    public class ConectarBD
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;

        public String nombreTabla;



        public ConectarBD(String server, String bd, String user, String pwd, String Tabla)
        {
            conexion = new MySqlConnection();

            conexion.ConnectionString = "Server=" + server + ";Port=3306;DataBase=" + bd + ";Uid=" + user + ";Pwd=" + pwd;
            nombreTabla = Tabla;
        }
        public ConectarBD(String server, String bd, String user, String pwd)
        {
            conexion = new MySqlConnection();

            conexion.ConnectionString = "Server=" + server + ";Port=3306;DataBase=" + bd + ";Uid=" + user + ";Pwd=" + pwd;

        }

        public ConectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=localhost;" +
             "DataBase=dam2023;user=root;Pwd=''";
        }
        public List<String> listarCabeceras(String cadenaSql)
        {
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            List<String> listaCampos = new List<String>();

             datos = comando.ExecuteReader();
            //while (datos.Read()) para contenidos
            //para metadatos : datos.VisibleFieldCount y datos.GetName(i)
            //1º contar cuántas columnas hay
            int nColumnas = datos.VisibleFieldCount;
            String cadena = "";
            //recorre cada columna
            for (int i = 0; i < nColumnas; i++)
            {
                //GetName(i): nombre de cada columbna
                cadena = cadena + (datos.GetName(i)) + ";";
            }

            listaCampos.Add(cadena);
            conexion.Close();
            return listaCampos;
        }
        public List<String> listarContenidos(String cadenaSql)
        {

            //  String cadenaSql = "select * from usuario where nombre=?us and contrasenia=?pwd";
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            List<String> listaCampos = new List<String>();
            List<String> listaContenidos = new List<String>();


            datos = comando.ExecuteReader();
            int nColumnas = datos.VisibleFieldCount;
            int nFilas = datos.RecordsAffected;
            for (int i = 0; i < nColumnas; i++)
            {
                listaCampos.Add(datos.GetName(i));
            }

            String filaCompleta = "";

            while (datos.Read())
            {
                for (int posicion = 0; posicion < nColumnas; posicion++)
                    filaCompleta += datos[posicion] + ";";
                listaContenidos.Add(filaCompleta);
                filaCompleta = "";

            }
            conexion.Close();
            return listaContenidos;
        }
        internal List<String> CargaContenidoTabla(string nombreTabla)
        {
            List<String> listaContenido = new List<String>();
            String cadenaSql = "select * from " + nombreTabla;
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            int nColumnas = datos.VisibleFieldCount;
            int nFilas = datos.RecordsAffected;
            String filaCompleta = "";

            while (datos.Read())
            {
                for (int posicion = 0; posicion < nColumnas; posicion++)
                    filaCompleta += datos[posicion] + ";";
                listaContenido.Add(filaCompleta);
                filaCompleta = "";

            }
            conexion.Close();
            return listaContenido;


        }

        internal List<String> CargarCabeceradeTabla(string nombreTabla)
        {
            List<String> listaCampos = new List<String>();
            String cadenaSql = "select * from " + nombreTabla;
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            int nColumnas = datos.VisibleFieldCount;
            int nFilas = datos.RecordsAffected;
            listaCampos.Clear();
            for (int i = 0; i < nColumnas; i++)
            {
                listaCampos.Add(datos.GetName(i));
            }

            conexion.Close();
            return listaCampos;
        }

        internal void ExportarDB(string nombreFichero)
        {
            comando = new MySqlCommand();

            using (MySqlBackup mb = new MySqlBackup(comando))
            {


                comando.Connection = conexion;
                conexion.Open();
                mb.ExportInfo.AddCreateDatabase = true;
                mb.ExportToFile(nombreFichero);
                System.IO.File.AppendAllText("C:\\seguridad\\total.sql", System.IO.File.ReadAllText(nombreFichero));

                conexion.Close();
            }
        }

        internal void ImportarBD(string nombreFichero)
        {

            comando = new MySqlCommand();

            using (MySqlBackup mb = new MySqlBackup(comando))
            {
                comando.Connection = conexion;
                conexion.Open();
                mb.ImportFromFile(nombreFichero);

                conexion.Close();
            }
        }

        internal List<string> listarBD()
        {

            List<String> listaNombreTablas = new List<String>();
            String cadenaSql = "show databases";
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                listaNombreTablas.Add((String)(datos[0]));
            }
            conexion.Close();
            return listaNombreTablas;
        }

        internal List<String> listarTablas()
        {
            List<String> listaNombreTablas = new List<String>();
            String cadenaSql = "show tables";
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                listaNombreTablas.Add((String)(datos[0]));
            }
            conexion.Close();
            return listaNombreTablas;
        }

        internal int cargarBD(string cadenaSql)
        {
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            int resultado=comando.ExecuteNonQuery();
            return resultado;
        }
    }


}



