using System;
using System.Windows.Forms;

namespace Sistema_Gestion_Electrica
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaginaPrincipal());
        }
    }
}
