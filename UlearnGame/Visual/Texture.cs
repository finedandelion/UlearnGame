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
        public static readonly Image DefaultButton = GetImage("DefaultButton.jpg");
        public static readonly Image LeftSwitch = GetImage("LeftSwitch.jpg");
        public static readonly Image RightSwitch = GetImage("RightSwitch.jpg");
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
        public static readonly Image CharacterPanel = GetImage("CharacterPanel.png");
        public static readonly Image UpperShortNamePanel = GetImage("UpperShortNamePanel.jpg");
        public static readonly Image CharacterIconPanel = GetImage("CharacterIcon.jpg");
        public static readonly Image CharacterIcon = GetImage("CharacterIcon.png");
        public static readonly Image CharacterTitle = GetImage("CharacterTitle.jpg");
        public static readonly Image StatisticsPanel = GetImage("StatisticsPanel.jpg");
        public static readonly Image TotemBackButton = GetImage("TotemBackButton.jpg");
        public static readonly Image AscendButton = GetImage("AscendButtonFalse.jpg");
        public static readonly Image AscendButton2 = GetImage("AscendButtonTrue.jpg");
        public static readonly Image Totem = GetImage("Totem.png");
        public static readonly Image TotemPanel = GetImage("TotemPanel.png");
        public static readonly Image OfferingCell = GetImage("OfferingCell.jpg");
        public static readonly Image OfferingCell2 = GetImage("OfferingCell2.jpg");
        public static readonly Image BlessingTitle = GetImage("BlessingTitle.jpg");
        public static readonly Image BlessingDescription = GetImage("BlessingDescription.jpg");
        public static readonly Image ChoiceBox = GetImage("ChooseBox.jpg");

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
        public static readonly Image Bat = GetImage("Bat.png");
        public static readonly Image Sandstone = GetImage("Sandstone.png");
        public static readonly Image LivingTree = GetImage("LivingTree.png");
        public static readonly Image Remains = GetImage("Remains.png");
        public static readonly Image Star = GetImage("Star.png");
        public static readonly Image Deer = GetImage("Deer.png");
        public static readonly Image Crystal = GetImage("Crystal.png");
        public static readonly Image Slate = GetImage("Slate.png");

        public static readonly Image Terrain2 = GetImage("TinyTerrain.png");

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
        public static readonly Image CoalLump = GetImage("CoalLump.png");
        public static readonly Image CoalLump2 = GetImage("SelectedCoalLump.png");
        public static readonly Image Sand = GetImage("Sand.png");
        public static readonly Image Sand2 = GetImage("SelectedSand.png");
        public static readonly Image CrystalShard = GetImage("CrystalShard.png");
        public static readonly Image CrystalShard2 = GetImage("SelectedCrystalShard.png");
        public static readonly Image Essence = GetImage("Essence.png");
        public static readonly Image Essence2 = GetImage("SelectedEssence.png");
        public static readonly Image Leather = GetImage("Lether.png");
        public static readonly Image Leather2 = GetImage("SelectedLether.png");
        public static readonly Image Bone = GetImage("Bone.png");
        public static readonly Image Bone2 = GetImage("SelectedBone.png");
        public static readonly Image Meat = GetImage("Meat.png");
        public static readonly Image Meat2 = GetImage("SelectedMeat.png");
        public static readonly Image Rope = GetImage("Rope.png");
        public static readonly Image Rope2 = GetImage("SelectedRope.png");
        public static readonly Image HardenedRope = GetImage("HardenedRope.png");
        public static readonly Image HardenedRope2 = GetImage("SelectedHardenedRope.png");
        public static readonly Image Necklace = GetImage("Necklace.png");
        public static readonly Image Necklace2 = GetImage("SelectedNecklace.png");
        public static readonly Image FilledTotem = GetImage("FilledTotem.png");
        public static readonly Image FilledTotem2 = GetImage("SelectedFilledTotem.png");
        public static readonly Image Dish = GetImage("Dish.png");
        public static readonly Image Dish2 = GetImage("SelectedDish.png");
        public static readonly Image FilledCrystal = GetImage("FilledCrystal.png");
        public static readonly Image FilledCrystal2 = GetImage("SelectedFilledCrystal.png");


        public static readonly Image GathererIcon = GetImage("GathererIcon.png");
        public static readonly Image GathererIcon2 = GetImage("SelectedGathererIcon.png");
        public static readonly Image AdventurerIcon = GetImage("AdventurerIcon.png");
        public static readonly Image AdventurerIcon2 = GetImage("SelectedAdventurerIcon.png");
        public static readonly Image ArcheologistIcon = GetImage("ArcheologistIcon.png");
        public static readonly Image ArcheologistIcon2 = GetImage("SelectedArcheologistIcon.png");
        public static readonly Image ExplorerIcon = GetImage("ExplorerIcon.png");
        public static readonly Image ExplorerIcon2 = GetImage("SelectedExplorerIcon.png");
        public static readonly Image HunterIcon = GetImage("HunterIcon.png");
        public static readonly Image HunterIcon2 = GetImage("SelectedHunterIcon.png");
        public static readonly Image SpelunkerIcon = GetImage("SpelunkerIcon.png");
        public static readonly Image SpelunkerIcon2 = GetImage("SelectedSpelunkerIcon.png");
        public static readonly Image MagicianIcon = GetImage("MagicianIcon.png");
        public static readonly Image MagicianIcon2 = GetImage("SelectedMagicianIcon.png");
        public static readonly Image PriestIcon = GetImage("PriestIcon.png");
        public static readonly Image PriestIcon2 = GetImage("SelectedPriestIcon.png");
        public static readonly Image CraftsmanIcon = GetImage("CraftsmanIcon.png");
        public static readonly Image CraftsmanIcon2 = GetImage("SelectedCraftsmanIcon.png");
        public static readonly Image Master1Icon = GetImage("Master1Icon.png");
        public static readonly Image Master1Icon2 = GetImage("SelectedMaster1Icon.png");
        public static readonly Image Master2Icon = GetImage("Master2Icon.png");
        public static readonly Image Master2Icon2 = GetImage("SelectedMaster2Icon.png");
        public static readonly Image Master3Icon = GetImage("Master3Icon.png");
        public static readonly Image Master3Icon2 = GetImage("SelectedMaster3Icon.png");


        private static Image GetImage(string imageName)
        {
            var imagePath = Path.Combine(ProgramInitials.GameDirectory, "Visual", "Images", imageName);
            return Image.FromFile(imagePath);
        }
    }
}
