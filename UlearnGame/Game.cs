using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Objects;

namespace UlearnGame
{
    internal class Game
    {
        public static int clickPower;
        public static int expirience;
        public static int resourceRandomCap;
        public static int fieldUpdateTimerLimit;
        public static Random resourcesRandom = new Random();
        public static Random random = new Random();
        public GameField field;
        public Inventory inventory;

        public Game()
        {
            clickPower = 0;
            resourceRandomCap = 2;
            fieldUpdateTimerLimit = 10;
            field = new GameField();
            inventory = new Inventory();
        }


        public static void StartGame()
        {
            var game = new Game();
            
        }
    }
}
