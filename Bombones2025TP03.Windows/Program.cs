using Bombones2025TP03.Servicios;

namespace Bombones2025TP03.Windows
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            TipoDePagoServicio tipoDePagoServicio=new TipoDePagoServicio();
            Application.Run(new FrmTiposDePago(tipoDePagoServicio));
        }
    }
}