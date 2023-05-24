
using UlearnGame.Model;
using UlearnGame.Visual;
using Newtonsoft.Json;
using System.Web;

namespace UlearnGame
{
    public class ProgramInitials
    {
        private static Game Game;
        public readonly static string GameDirectory = GetGameDirectory();
        public static Dictionary<string, Form> Screens = new Dictionary<string, Form>();
        public static bool ApplicationInProccess;

        public ProgramInitials()
        {
            Run();
        }

        private void Run()
        {
            InitializeGame();
            InitializeForms();
            Application.Run(Screens["Main"]);
        }

        private void InitializeGame()
        {
            Game = new Game();
        }

        private void InitializeForms()
        {
            Screens = new Dictionary<string, Form>
            {
                {"Main", new MainScreenForm(Game)},
                {"Inventory", new InventoryScreenForm(Game)},
                {"Craft", new CraftScreenForm(Game)},
                {"Upgrade", new UpgradeScreenForm(Game)},
                {"Character", new CharacterScreenForm(Game)},
                {"Totem", new TotemScreenForm(Game)},
                {"Tutorial", new TutorialScreenForm()},
                {"Finish", new FinishScreenForm()},
            };
        }

        public static Color GetHtmlColor(string htmlcode)
        {
            return ColorTranslator.FromHtml(htmlcode);
        }

        private static string GetGameDirectory()
        {
            return Environment.CurrentDirectory;
        }

        public static void ShowScreen(string screen)
        {
            Screens[screen].BringToFront();
        }

        public static void SerializeGameData()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "GameData.json");
            var json = JsonConvert.SerializeObject(Game, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                TypeNameHandling = TypeNameHandling.All,
                NullValueHandling = NullValueHandling.Ignore,
            });
            File.WriteAllText(path, json);
        }

        public Game DeserializeGameData()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "GameData.json");
            if (!File.Exists(path))
                return null;
            var text = File.ReadAllText(path);
            var game = JsonConvert.DeserializeObject<Game>(text);
            File.Delete(path);
            return game;
        }
    }
}