using WinForms5bnew;

namespace WinForms5Bnew
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //IPersonDataSource ds = new PersonContextDataSource();
            IPersonDataSource ds = new PersonListDataSource();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Assignment5Bnew(ds));
        }
    }
}