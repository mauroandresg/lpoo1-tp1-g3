using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin formLogin = new FrmLogin();
            Application.Run(formLogin); // Se lanza la pantalla para login

            if (formLogin.AutenticacionRealizada == true) // Si la autenticacion fue exitosa
            {
                Application.Run(new FrmInicio()); // Se lanza la pantalla inicial
            }
        }
    }
}
