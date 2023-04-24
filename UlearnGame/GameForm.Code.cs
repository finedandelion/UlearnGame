using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace UlearnGame
{
    public partial class GameForm
    {
        public readonly static string GameDirectory = GetGameDirectory();
        private bool ApplicationInProccess;
        private void Run()
        {
            InitializeGame();
            InitializeForm();
        }
        
        private void InitializeGame()
        {
            Game = new Game();
        }

        private void StartGenerationTimer()
        {
            var thread = new Thread(() => 
            {
                while (ApplicationInProccess)
                {
                    BeginInvoke(new Action(() => GameTimer.Text = Game.FieldUpdateRate.ToString()));
                    var count = Game.FieldUpdateRate;
                    while (count > 0)
                    {
                        if (!ApplicationInProccess)
                            break;
                        Thread.Sleep(1000);
                        BeginInvoke(new Action(() => GameTimer.Text = count.ToString()));
                        count--;
                    }
                    if (!ApplicationInProccess)
                        break;
                    var field = Game.field.GenerateResource();
                    if (field != null)
                    {
                        var cell = (int) field;
                        var capacity = Game.field.Field[cell].StartCapacity.ToString();
                        BeginInvoke(new Action(() => FieldButtons[cell].Image = Game.field.Field[cell].ImagePath));
                        BeginInvoke(new Action(() => FieldButtons[cell].Text = capacity + "/" + capacity));
                    }
                }
            });
            thread.Start();
        }

        public static Image GetImage(string imageName)
        {
            var imagePath = Path.Combine(GameDirectory, "Images", imageName);
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
