
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model;
using UlearnGame.Model.Objects;
using UlearnGame.Model.Resources;

namespace UlearnGame.Tests
{
    [TestFixture]
    public class GameFieldTests
    {
        private static Game Game;
        private static GameField Field;

        [SetUp]
        protected virtual void Setup()
        {
            Game = new Game();
            Field = Game.Field;
        }

        [Test] // При создании поле не пустое, содержит один объект
        public static void GameFieldInitializeTest()
        {
            Assert.IsNotNull(Field);
            var field = Field.GameCells;
            var fieldCounter = CheckNotEmptyFields(field);
            Assert.That(fieldCounter, Is.EqualTo(1));
        }

        [Test] //При генерации объекта занятых клеток становится больше
        public static void GameFieldGenerationTest()
        {
            var fieldCounter = 0;
            var gameCells = Field.GameCells;
            for (var i = 2; i < 5; i++)
            {
                Game.Field.GenerateResource();
                fieldCounter = CheckNotEmptyFields(gameCells);
                Assert.That(fieldCounter, Is.EqualTo(i));
            }
        }

        [Test] // При заполнении поля, генерация ничего не делает
        public static void GameFieldNotOverflowingTest()
        {
            var gameCells = Field.GameCells;
            for (var i = 0; i < 10; i++)
                Field.GenerateResource();
            var fieldCounter = CheckNotEmptyFields(gameCells);
            Assert.That(fieldCounter, Is.EqualTo(4));
        }

        [Test] // Объект можно разрушать. Когда кончается его прочность, клетка становится пустой.
        public static void ChangeObjectStateTest()
        {
            var gameCells = Field.GameCells;
            var notEmptyCell = TakeNotEmptyIndexes(gameCells).First();
            var resource = gameCells[notEmptyCell];
            Assert.That(resource.Capacity, Is.EqualTo(resource.StartCapacity));
            Field.UpdateObjectState(notEmptyCell);
            Assert.That(resource.Capacity, !Is.EqualTo(resource.StartCapacity));
            var currentCapacity = resource.Capacity;
            for (var i = 0; i < currentCapacity; i++)
                Field.UpdateObjectState(notEmptyCell);
            Assert.IsTrue(gameCells[notEmptyCell] == null);
        }

        [Test] // Проверка рандома генерации
        public static void RandomObjectsPlacementTest()
        {
            var coincidencesCount = 0;
            var object1Placement = TakeNotEmptyIndexes(Field.GameCells).First();
            for(var i = 0; i < 10; i++)
            {
                var object2Placement = TakeNotEmptyIndexes(new GameField(new Game(), 1).GameCells).First();
                if (object1Placement == object2Placement)
                {
                    coincidencesCount++;
                    continue;
                }
                break;
            }
            Assert.That(coincidencesCount, !Is.EqualTo(10));
        }

        [Test] // Есть возможность добавить в генератор новые объекты
        public static void UpdateObjectGeneratorTest()
        {
            var instance = typeof(GameField)
                .GetField("Generation", BindingFlags.NonPublic | BindingFlags.Instance)?
                .GetValue(Field) as Dictionary<int, Func<GameObject>>;
            Assert.That(instance.Count, Is.EqualTo(2));
            Field.GathererUpgrade();
            Assert.That(instance.Count, Is.EqualTo(4));
        }

        [Test] // При увеличении размеров поля, все его клетки доступны для заполнения
        public static void FieldCapChangedObjectPlacementTest()
        {
            Field.ExtendField(2);
            var gameCells = Field.GameCells;
            for (var i = 0; i < 10; i++)
                Field.GenerateResource();
            var fieldCounter = CheckNotEmptyFields(gameCells);
            Assert.That(fieldCounter, Is.EqualTo(6));
        }

        [Test] // Чем больше сила клика, тем быстрее разрушается объект
        public static void ClickPowerEfficienceTest()
        {
            var game = new Game();
            var field = new GameField(game, 0);
            field.GameCells[0] = new Tree(game);
            field.GameCells[1] = new Tree(game);
            var standardClickTimes = ObjectClickTimes(0, field);
            game.UpdateClickPower();
            var updatedClickTimes = ObjectClickTimes(1, field);
            Assert.That(standardClickTimes,Is.GreaterThan(updatedClickTimes));
        }

        [Test] // Проверка генерации больше одного объекта за раз
        public static void ObjectPerGenerationTest()
        {
            Field.GenerateResource();
            var notEmptyCellsCount = Field.GameCells.Where(cell => cell.Value != null).Count();
            Assert.That(notEmptyCellsCount, Is.EqualTo(2));
            Field.FormerUpgrade();
            Field.GenerateResource();
            notEmptyCellsCount = Field.GameCells.Where(cell => cell.Value != null).Count();
            Assert.That(notEmptyCellsCount, Is.EqualTo(4));
        }

        private static int ObjectClickTimes(int index, GameField field)
        {
            var count = 0;
            var resource = field.GameCells[index];
            while (field.GameCells[index] != null)
            {
                field.UpdateObjectState(index);
                count++;
            }
            return count;
        }

        private static List<int> TakeNotEmptyIndexes(Dictionary<int, GameObject?> field)
        {
            var indexes = new List<int>();
            for (var i = 0; i < field.Count; i++)
                if (field[i] != null)
                    indexes.Add(i);
            return indexes;
        }

        private static int CheckNotEmptyFields(Dictionary<int, GameObject?> field)
        {
            var fieldCounter = 0;
            foreach (var element in field)
            {
                if (element.Value != null)
                    fieldCounter++;
            }
            return fieldCounter;
        }
    }
}
