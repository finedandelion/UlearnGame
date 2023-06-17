using System.Runtime.CompilerServices;

namespace UlearnGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            new ProgramInitials();
        }
    }
}