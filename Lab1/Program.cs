namespace Lab1
{
    public class Zadanie1
    {
        float A = 12.5f;
        const int B = 1;
        byte[] C = {1,2,3,4,5};

        enum D: long
        {
            VALUE1 = 1,
            VALUE2 = 2
        }

        public Zadanie1()
        {
            int Zxc = B * (int)C[1];
        }

    }
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
            Application.Run(new Form1());
        }
    }
}