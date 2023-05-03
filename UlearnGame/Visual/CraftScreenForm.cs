

using static System.Net.Mime.MediaTypeNames;
using UlearnGame.Model;
using UlearnGame.Model.Resources;
using UlearnGame.Model.Crafts;

namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class CraftScreenForm : Form
    {
        private Button BackCraftButton;
        private PictureBox CraftPanel;
        private PictureBox RecipePanel;
        private Label[] RecipeItems = new Label[3];
        private Label RecipeResult;
        private Label RecipeDescription;
        private Button BackButton;
        private Button[] AcceptButtons = new Button[20];
        private Button[] CraftButtons = new Button[20];

        private Game Game { get; set; }
        public CraftScreenForm(Game game)
        {
            Game = game;
            SetFormBaseParameteres();
            InitializeCraftScreen();
        }
        private void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += CraftForm_Load;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Texture.BackGround;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void CraftForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void InitializeCraftScreen()
        {
            SetCraftBackButton();
            SetCraftPanel();
            SetRecipePanel();
            SetRecipes(Game.CraftStation);
        }

        private void SetRecipePanel()
        {
            SetRecipeButtons();
            SetRecipeResult();
            SetRecipeDescription();
            SetRecipeItems();
            var recipePanel = new PictureBox()
            {
                Location = new Point(437, 202),
                Width = 1046,
                Height = 675,
                BackgroundImage = Texture.RecipePanel,
                Visible = false,
            };
            RecipePanel = recipePanel;
            Controls.Add(RecipePanel);
        }

        private void SetRecipeDescription()
        {
            var recipeDescription = new Label()
            {
                Location = new Point(526, 540),
                Image = Texture.RecipeDescription,
                Width = 878,
                Height = 244,
                Visible = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 16, FontStyle.Bold),
            };
            RecipeDescription = recipeDescription;
            Controls.Add(RecipeDescription);
        }

        private void SetRecipeButtons()
        {
            SetBackButton();
            SetAcceptButton();
        }

        private void SetBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(42, 359),
                Width = 340,
                Height = 340,
                BackgroundImage = Texture.BackCraftButton,
                Visible = false,
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ChangeCraftPanelVisibility(true);
                foreach(var item in RecipeItems)
                {
                    item.Text = null;
                    item.BackgroundImage = ProgramInitials.GetImage("CraftCell.jpg");
                    item.Image = null;
                }
            };
            BackButton = backButton;
            Controls.Add(BackButton);
        }

        private void SetAcceptButton()
        {
            for (var i = 0; i < AcceptButtons.Length; i++)
            {
                var index = i;
                var acceptButton = new Button()
                {
                    Location = new Point(1538, 359),
                    Width = 340,
                    Height = 340,
                    BackgroundImage = Texture.AcceptCraftButton,
                    Visible = false,
                    Enabled = false,
                };
                AcceptButtons[index] = acceptButton;
                Controls.Add(AcceptButtons[index]);
            }
        }

        private void SetRecipeItems()
        {
            for (var i = 0; i < RecipeItems.Length; i++)
            {
                var index = i;
                var box = new Label()
                {
                    Location = new Point(526 + 210 * index,300),
                    Width = 157,
                    Height = 157,
                    BackgroundImage = Texture.CraftCell,
                    Visible = false,
                    TextAlign = ContentAlignment.BottomRight,
                    ForeColor = Color.White,
                    Font = new Font(string.Empty, 16, FontStyle.Bold),
                };
                RecipeItems[index] = box;
                Controls.Add(RecipeItems[index]);
            }
        }

        private void SetRecipeResult()
        {
            var box = new Label()
            {
                Location = new Point(1247, 300),
                Width = 157,
                Height = 157,
                BackgroundImage = Texture.CraftCell,
                Visible = false,
                TextAlign = ContentAlignment.BottomRight,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 16, FontStyle.Bold),
            };
            RecipeResult = box;
            Controls.Add(RecipeResult);
        }

        private void SetCraftPanel()
        {
            SetCraftButtons();
            var craftPanel = new PictureBox()
            {
                Location = new Point(472, 32),
                BackColor = Color.Transparent,
                Image = Texture.HugePanel,
                Width = 975,
                Height = 1015,
            };
            CraftPanel = craftPanel;
            Controls.Add(CraftPanel);
        }

        private void SetCraftBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(1563, 931),
                BackgroundImage = Texture.BackButton,
                Width = 308,
                Height = 116,
                Text = "Назад",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = ProgramInitials.GetHtmlColor("#CFC6B8"),
                Font = new Font("Arial", 32, FontStyle.Bold),
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.MainScreenForm.Show();
                Hide();
            };
            BackCraftButton = backButton;
            Controls.Add(BackCraftButton);
        }

        private void SetCraftButtons()
        {
            for (var i = 0; i < CraftButtons.Length; i++)
            {
                var button = new Button();
                CustomizeCraftButton(button, i);
                CraftButtons[i] = button;
                Controls.Add(CraftButtons[i]);
            }
        }

        private void CustomizeCraftButton(Button button, int index)
        {
            button.Size = new Size(157, 157);
            button.BackgroundImage = Texture.CraftCell;
            button.Location = SetCraftButtonPosition(index, 157);
            button.TextAlign = ContentAlignment.BottomRight;
            button.ForeColor = Color.White;
            button.Font = new Font(string.Empty, 16, FontStyle.Bold);
        }

        private Point SetCraftButtonPosition(int number, int buttonSize)
        {
            var xposOffset = number % 5;
            var yposOffset = number / 5;
            var xpos = 515 + (buttonSize + 26) * xposOffset;
            var ypos = 235 + (buttonSize + 26) * yposOffset;
            return new Point(xpos, ypos);
        }

        public void SetRecipes(CraftStation station)
        {
            var crafts = station.Crafts;
            for (var i = 0; i < station.Count; i++)
            {
                var index = i;
                var craft = crafts[index];
                var button = CraftButtons[index];
                button.BackgroundImage = Texture.CraftCell2;
                button.Image = craft.CraftResult.ImagePath;
                button.Text = "x" + craft.CraftResult.Amount.ToString();
                button.Click += (sender, eventArgs) =>
                {
                    ShowRecipe(sender, eventArgs, craft);
                    AcceptButtons[index].Show();
                    if (craft.IsPossibleToCraft(Game.Inventory))
                    {
                        AcceptButtons[index].Enabled = true;
                        AcceptButtons[index].BackgroundImage = Texture.AcceptCraftButton2;
                    }
                };
                AcceptButtons[index].Click += (sender, eventArgs) =>
                {
                    AcceptButtons[index].Enabled = false;
                    station.DoCraft(index, Game.Inventory);
                    UpdateRecipe(craft, index);
                };
            }
        }

        private void ChangeCraftPanelVisibility(bool state)
        {
            foreach (var item in RecipeItems)
                item.Visible = !state;
            if (state)
                foreach(var button in AcceptButtons)
                    button.Visible = !state;
            RecipeResult.Visible = !state;
            RecipePanel.Visible = !state;
            RecipeDescription.Visible = !state;
            BackButton.Visible = !state;
            foreach (var button in CraftButtons)
                button.Visible = state;
            CraftPanel.Visible = state;
            BackCraftButton.Visible = state;
        }

        private void ShowRecipe(object sender, EventArgs args, Craft craft)
        {
            var inventory = Game.Inventory;
            ChangeCraftPanelVisibility(false);
            for (var i = 0; i < craft.CraftResources.Length; i++)
            {
                var index = i;
                var craftResource = craft.CraftResources[index];
                RecipeItems[index].Image = craftResource.ImagePath;
                RecipeItems[index].BackgroundImage = Texture.CraftCell2;
                RecipeItems[index].Text = inventory.AmountOf(craftResource).ToString() + " / " + craftResource.Amount.ToString();

            }
            RecipeDescription.Text = craft.Description;
            RecipeResult.Image = craft.CraftResult.ImagePath;
            RecipeResult.BackgroundImage = Texture.CraftCell2;
            RecipeResult.Text = "x" + craft.CraftResult.Amount.ToString();
        }

        private void UpdateRecipe(Craft craft, int index)
        {
            var inventory = Game.Inventory;
            for (var i = 0; i < craft.CraftResources.Length; i++)
            {
                var index2 = i;
                var craftResource = craft.CraftResources[index2];
                RecipeItems[index2].Text = inventory.AmountOf(craftResource).ToString() + " / " + craftResource.Amount.ToString();
            }
            if (craft.IsPossibleToCraft(Game.Inventory))
                AcceptButtons[index].Enabled = true;
            else
                AcceptButtons[index].BackgroundImage = Texture.AcceptCraftButton;
        }
    }
}
