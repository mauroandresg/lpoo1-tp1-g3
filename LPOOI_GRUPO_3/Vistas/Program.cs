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
            FrmLogin frmLogin = new FrmLogin();
            Application.Run(frmLogin); // Se lanza la vista FrmLogin

            if (frmLogin.AutenticacionRealizada == true)
            {
                FrmInicio frmInicio = new FrmInicio();
                frmInicio.CodigoRol = frmLogin.CodigoRol; // FrmInicio recupera el Codigo de Rol del usuario autenticado
                Application.Run(frmInicio); // Se lanza la vista FrmInicio solo si la autenticación se realizó
            }
        }
    }
}
