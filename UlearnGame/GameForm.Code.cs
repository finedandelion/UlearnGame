using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace UlearnGame
{
    public partial class GameForm
    {
        private void Run()
        {
            InitializeGame();
            InitializeForm();
        }
        
        private void InitializeGame()
        {
            Game = new Game();
        }

        private void GenerationTimer()
        {
            var thread = new Thread(() => 
            {
                while (true)
                {
                    BeginInvoke(new Action(() => GameTimer.Text = Game.FieldUpdateRate.ToString()));
                    var count = Game.FieldUpdateRate;
                    while (count > 0)
                    {
                        Thread.Sleep(1000);
                        BeginInvoke(new Action(() => GameTimer.Text = count.ToString()));
                        count--;
                    }

                    var field = Game.field.GenerateResource();
                    if (field != null)
                    {
                        var cell = (int) field;
                        BeginInvoke(new Action(() => fieldButtons[cell].Image = Game.field.Field[cell].ImagePath));

                    }
                }
            });
            thread.Start();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerationTimer();
        }
    }
}
