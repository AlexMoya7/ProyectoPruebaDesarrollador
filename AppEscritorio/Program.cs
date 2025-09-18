using ProyectoPrueba.AccesoDatos;
using ProyectoPrueba.Escritorio;
using ProyectoPrueba.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrueba.Escritorio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string con = "Server=LAPTOP-KUFMMP46\\SQLEXPRESS01;Database=Proyecto_Prueba;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
            var sql = new SQLHelper(con);
            IProducto prod = new NProducto(sql);
            IVenta vta = new NVenta(sql);

            Application.Run(new Form1(prod,vta));
        }
    }
}
