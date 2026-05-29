using OnthatileMashego_Project_PM04;
using System;
using System.Windows.Forms;

namespace OnthatileMashego_Project_PM04
{
    internal static class Program
    {
        
        //  The main entry point for the application.
       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}


