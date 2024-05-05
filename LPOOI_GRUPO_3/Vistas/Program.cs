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
            Login formLogin = new Login();
            Application.Run(formLogin); // Se lanza la pantalla para login

            if (formLogin.AutenticacionCorrecta == true) // Si la autenticacion fue exitosa
            {
                Application.Run(new Inicio()); // Se lanza la pantalla inicial
            }
        }
    }
}
