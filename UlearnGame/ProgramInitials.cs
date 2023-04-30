
using UlearnGame.Model;
using UlearnGame.Visual;

namespace UlearnGame
{
    public class ProgramInitials
    {
        private Game Game;
        public readonly static string GameDirectory = GetGameDirectory();
        public static bool ApplicationInProccess;
        public static InventoryScreenForm InventoryForm;
        public static MainScreenForm MainScreenForm;
        public static CraftScreenForm CraftForm;

        public ProgramInitials()
        {
            Run();
        }

        private void Run()
        {
            InitializeGame();
            InitializeForms();
            Application.Run(MainScreenForm);
        }

        private void InitializeGame()
        {
            Game = new Game();
        }

        private void InitializeForms()
        {
            MainScreenForm = new MainScreenForm(Game);
            InventoryForm = new InventoryScreenForm(Game);
            CraftForm = new CraftScreenForm(Game);
        }

        public static Image GetImage(string imageName)
        {
            var imagePath = Path.Combine(GameDirectory, "Visual", "Images", imageName);
            return Image.FromFile(imagePath);
        }

        public static Color GetHtmlColor(string htmlcode)
        {
            return ColorTranslator.FromHtml(htmlcode);
        }

        private static string GetGameDirectory()
        {
            return Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName;
        }
    }
}