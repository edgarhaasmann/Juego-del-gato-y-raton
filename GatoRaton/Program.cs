namespace GatoRaton
{
    internal static class Program
    {
        /// <summary>
        /// progrma hecho por Edgar Haasmann
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new  MainMenuForm());
        }
    }
}