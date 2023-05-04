using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Visual
{
    public static class Texture
    {
        public static readonly Image BackGround = GetImage("Background.jpg");
        public static readonly Image Timer = GetImage("Timer.png");
        public static readonly Image MainPanel = GetImage("MainPanel.png");
        public static readonly Image CharacterButton = GetImage("CharacterButton.jpg");
        public static readonly Image InventoryButton = GetImage("InventoryButton.jpg");
        public static readonly Image CraftButton = GetImage("CraftButton.jpg");
        public static readonly Image TotemButton = GetImage("TotemButton.jpg");
        public static readonly Image UpperPanel = GetImage("UpperPanel.png");
        public static readonly Image ExperienceBar = GetImage("ExperienceBar.jpg");
        public static readonly Image ExitButton = GetImage("ExitButton.jpg");
        public static readonly Image SettingsButton = GetImage("SettingsButton.jpg");
        public static readonly Image UpgradeButton = GetImage("UpgradeButton.jpg");
        public static readonly Image HugePanel = GetImage("HugePanel.png");
        public static readonly Image UpperNamePanel = GetImage("UpperNamePanel.jpg");
        public static readonly Image SelectedItemPanel = GetImage("SelectedItemPanel.png");
        public static readonly Image SelectedItemName = GetImage("SelectedItemName.jpg");
        public static readonly Image SelectedItemImage = GetImage("SelectedItemImage.jpg");
        public static readonly Image SelectedItemDescription = GetImage("SelectedItemDescription.jpg");
        public static readonly Image BackButton = GetImage("BackButton.jpg");
        public static readonly Image CellButton = GetImage("CellButton.jpg");
        public static readonly Image CellButton2 = GetImage("CellButton2.jpg");
        public static readonly Image RecipePanel = GetImage("RecipePanel.png");
        public static readonly Image RecipeDescription = GetImage("RecipeDescription.jpg");
        public static readonly Image BackCraftButton = GetImage("DenyCraftButton.jpg");
        public static readonly Image AcceptCraftButton = GetImage("AcceptCraftButtonFalse.jpg");
        public static readonly Image AcceptCraftButton2 = GetImage("AcceptCraftButtonTrue.jpg");
        public static readonly Image CraftCell = GetImage("CraftCell.jpg");
        public static readonly Image CraftCell2 = GetImage("CraftCell2.jpg");
        public static readonly Image UpgradePanel = GetImage("UpgradePanel.png");
        public static readonly Image UpgradeCell = GetImage("UpgradeCell.jpg");
        public static readonly Image AcceptUpgradeButton = GetImage("AcceptUpgradeButtonFalse.jpg");
        public static readonly Image AcceptUpgradeButton2 = GetImage("AcceptUpgradeButtonTrue.jpg");
        public static readonly Image UpgradeCardPanel = GetImage("UpgradeCardPanel.png");
        public static readonly Image UpgradeTitle = GetImage("UpgradeTitle.jpg");
        public static readonly Image UpgradeDescription = GetImage("UpgradeDescription.jpg");
        public static readonly Image UpgradeIcon= GetImage("UpgradeIcon.jpg");

        public static readonly Image Terrain = GetImage("Terrain.png");
        public static readonly Image Tree = GetImage("Tree.png");
        public static readonly Image Stone = GetImage("Stone.png");
        public static readonly Image Bush = GetImage("Bush.png");
        public static readonly Image Gold = GetImage("Gold.png");
        public static readonly Image Iron = GetImage("Iron.png");
        public static readonly Image Coal = GetImage("Coal.png");
        public static readonly Image Slime = GetImage("Slime.png");
        public static readonly Image Flower1 = GetImage("Flower1.png");
        public static readonly Image Flower2 = GetImage("Flower2.png");
        public static readonly Image Flower3 = GetImage("Flower3.png");
        public static readonly Image Flower4 = GetImage("Flower4.png");
        public static readonly Image Flower5 = GetImage("Flower5.png");

        public static readonly Image Berries = GetImage("Berries.png");
        public static readonly Image Berries2 = GetImage("SelectedBerries.png");
        public static readonly Image Bowl = GetImage("Bowl.png");
        public static readonly Image Bowl2 = GetImage("SelectedBowl.png");
        public static readonly Image DullTotem = GetImage("DullTotem.png");
        public static readonly Image DullTotem2 = GetImage("SelectedDullTotem.png");
        public static readonly Image Fiber = GetImage("Fiber.png");
        public static readonly Image Fiber2 = GetImage("SelectedFiber.png");
        public static readonly Image GoldenIngot = GetImage("GoldenIngot.png");
        public static readonly Image GoldenIngot2 = GetImage("SelectedGoldenIngot.png");
        public static readonly Image IronIngot = GetImage("IronIngot.png");
        public static readonly Image IronIngot2 = GetImage("SelectedIronIngot.png");
        public static readonly Image Leaf = GetImage("Leaf.png");
        public static readonly Image Leaf2 = GetImage("SelectedLeaf.png");
        public static readonly Image Petals = GetImage("Petals.png");
        public static readonly Image Petals2 = GetImage("SelectedPetals.png");
        public static readonly Image Plank = GetImage("Plank.png");
        public static readonly Image Plank2 = GetImage("SelectedPlank.png");
        public static readonly Image Rock = GetImage("Rock.png");
        public static readonly Image Rock2 = GetImage("SelectedRock.png");
        public static readonly Image Salad = GetImage("Salad.png");
        public static readonly Image Salad2 = GetImage("SelectedSalad.png");
        public static readonly Image SharpenedRock = GetImage("SharpenedRock.png");
        public static readonly Image SharpenedRock2 = GetImage("SelectedSharpenedRock.png");
        public static readonly Image SlimeDrop = GetImage("SlimeDrop.png");
        public static readonly Image SlimeDrop2 = GetImage("SelectedSlimeDrop.png");
        public static readonly Image Wood = GetImage("Wood.png");
        public static readonly Image Wood2 = GetImage("SelectedWood.png");

        public static readonly Image GathererIcon = GetImage("GathererIcon.png");
        public static readonly Image GathererIcon2 = GetImage("SelectedGathererIcon.png");
        public static readonly Image AdventurerIcon = GetImage("AdventurerIcon.png");
        public static readonly Image AdventurerIcon2 = GetImage("SelectedAdventurerIcon.png");

        private static Image GetImage(string imageName)
        {
            var imagePath = Path.Combine(ProgramInitials.GameDirectory, "Visual", "Images", imageName);
            return Image.FromFile(imagePath);
        }
    }
}
