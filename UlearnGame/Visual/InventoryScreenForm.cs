
using System.Data.SqlTypes;
using UlearnGame.Model;
using UlearnGame.Model.Resources;


namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class InventoryScreenForm : Form
    {
        private PictureBox InventoryPanel;
        private PictureBox SelectedItemPanel;
        private PictureBox SelectedItemImage;
        private Label UpperNamePanel;
        private Label SelectedItemName;
        private Label SelectedItemDescription;
        private Button BackInventoryButton;
        private Button LeftSwitch;
        private Button RightSwitch;
        private Button[] InventoryButtons = new Button[40];

        private Game Game { get; set; }

        public InventoryScreenForm(Game game)
        {
            Game = game;
            SetFormBaseParameteres();
            InitializeInventoryScreen();
        }

        public void ShowResourcesInInvetory(Resource[] storage)
        {
            for (var i = 0; i < storage.Length; i++)
            {
                var index = i;
                var button = InventoryButtons[index];
                button.BackgroundImage = Texture.CellButton2;
                button.Image = storage[index].ImagePath;
                button.Text = "x" + storage[index].Amount.ToString();
                button.Click += (sender, eventArgs) =>
                {
                    SelectedItemName.Text = storage[index].Name;
                    SelectedItemDescription.Text = storage[index].Description;
                    SelectedItemImage.Image = storage[index].ImagePath2;
                    SelectedItemImage.Controls[0].Text = "x" + storage[index].Amount.ToString();
                    SelectedItemName.Visible = true;
                    SelectedItemDescription.Visible = true;
                    SelectedItemImage.Visible = true;
                };
            }
        }

        private void InitializeInventoryScreen()
        {
            SetInventoryPanel();
            SetSelectedItemPanel();
            SetInventoryBackButton();
        }
        private void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += InventoryForm_Load;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Texture.Background;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void SetInventoryPanel()
        {
            SetUpperNamePanel();
            SetInventoryButtons();
            SetInventorySwitchers();
            var invenoryPanel = new PictureBox()
            {
                Location = new Point(57, 32),
                BackColor = Color.Transparent,
                Image = Texture.HugePanel,
                Width = 975,
                Height = 1015,
            };
            InventoryPanel = invenoryPanel;
            Controls.Add(InventoryPanel);
        }

        private void SetInventorySwitchers()
        {
            SetRightSwitch();
            SetLeftSwitch();
        }

        private void SetRightSwitch()
        {
            var button = new Button()
            {
                Location = new Point(939, 964),
                Width = 50,
                Height = 50,
                BackgroundImage = Texture.RightSwitch,
            };
            button.Click += (sender, eventArgs) =>
            {
                for(var i = 0; i < InventoryButtons.Length; i++)
                {
                    if (i < 20)
                        InventoryButtons[i].Visible = false;
                    else
                        InventoryButtons[i].Visible = true;
                }
            };
            RightSwitch = button;
            Controls.Add(RightSwitch);
        }

        private void SetLeftSwitch()
        {
            var button = new Button()
            {
                Location = new Point(872, 964),
                Width = 50,
                Height = 50,
                BackgroundImage = Texture.LeftSwitch,
            };
            button.Click += (sender, eventArgs) =>
            {
                for (var i = 0; i < InventoryButtons.Length; i++)
                {
                    if (i >= 20)
                        InventoryButtons[i].Visible = false;
                    else
                        InventoryButtons[i].Visible = true;
                }
            };
            LeftSwitch = button;
            Controls.Add(LeftSwitch);
        }

        private void SetUpperNamePanel()
        {
            var namePanel = new Label()
            {
                Location = new Point(83, 68),
                Width = 924,
                Height = 114,
                BackgroundImage = Texture.UpperNamePanel,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 48, FontStyle.Bold),
                Text = "ИНВЕНТАРЬ"
            };
            UpperNamePanel = namePanel;
            Controls.Add(UpperNamePanel);
        }
        private void SetSelectedItemPanel()
        {
            SetSelectedItemName();
            SetSelectedItemImage();
            SetSelectedItemDescription();
            var selectedItemPanel = new PictureBox()
            {
                Location = new Point(1213, 169),
                BackColor = Color.Transparent,
                Image = Texture.SelectedItemPanel,
                Width = 975,
                Height = 1015,
            };
            SelectedItemPanel = selectedItemPanel;
            Controls.Add(SelectedItemPanel);
        }

        private void SetInventoryBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(1383, 931),
                BackgroundImage = Texture.DefaultButton,
                Width = 308,
                Height = 116,
                Text = "Назад",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 32, FontStyle.Bold),
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ResetInventory(Game.Inventory.GetStorage());
                ProgramInitials.ShowScreen("Main");
                //ProgramInitials.MainScreenForm.Show();
                //Hide();
            };
            BackInventoryButton = backButton;
            Controls.Add(BackInventoryButton);
            BackInventoryButton.BringToFront();
        }

        private void SetSelectedItemName()
        {
            var selectedItemName = new Label()
            {
                Location = new Point(1307, 199),
                BackColor = Color.Transparent,
                Image = Texture.SelectedItemName,
                Width = 460,
                Height = 82,
                Visible = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 24, FontStyle.Bold),
            };
            SelectedItemName = selectedItemName;
            Controls.Add(SelectedItemName);
        }

        private void SetSelectedItemImage()
        {
            var selectedItemImage = new PictureBox()
            {
                Location = new Point(1367, 298),
                Width = 340,
                Height = 340,
                Visible = false,
                BackgroundImage = Texture.SelectedItemImage,
            };
            var text = new Label()
            {
                Width = 325,
                Height = 325,
                TextAlign = ContentAlignment.BottomRight,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(string.Empty, 24, FontStyle.Bold),
            };
            selectedItemImage.Controls.Add(text);
            selectedItemImage.Controls.SetChildIndex(text, 0);
            SelectedItemImage = selectedItemImage;
            Controls.Add(SelectedItemImage);
        }

        private void SetSelectedItemDescription()
        {
            var selectedItemDescription = new Label()
            {
                Location = new Point(1307, 655),
                Image = Texture.SelectedItemDescription,
                Width = 460,
                Height = 132,
                Visible = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 16, FontStyle.Bold),
            };
            SelectedItemDescription = selectedItemDescription;
            Controls.Add(SelectedItemDescription);
        }

        private void SetInventoryButtons()
        {
            for (var i = 0; i < InventoryButtons.Length; i++)
            {
                var button = new Button();
                CustomizeInventoryButton(button, i);
                InventoryButtons[i] = button;
                Controls.Add(InventoryButtons[i]);
            }
        }

        private void CustomizeInventoryButton(Button button, int index)
        {
            button.Size = new Size(157, 157);
            button.BackgroundImage = Texture.CellButton;
            button.Location = SetInventoryButtonPosition(index % 20, 157);
            button.TextAlign = ContentAlignment.BottomRight;
            button.ForeColor = Color.White;
            button.Font = new Font(string.Empty, 16, FontStyle.Bold);
            if (index >= 20)
                button.Visible = false;
        }

        private Point SetInventoryButtonPosition(int number, int buttonSize)
        {
            var xposOffset = number % 5;
            var yposOffset = number / 5;
            var xpos = 100 + (buttonSize + 26) * xposOffset;
            var ypos = 235 + (buttonSize + 26) * yposOffset;
            return new Point(xpos, ypos);
        }

        private void ResetInventory(Resource[] storage)
        {
            SelectedItemName.Visible = false;
            SelectedItemDescription.Visible = false;
            SelectedItemImage.Visible = false;
            for (var i = 0; i < storage.Length; i++)
            {
                var index = i;
                var button = InventoryButtons[index];
                button.Image = null;
                button.BackgroundImage = Texture.CellButton;
                button.Text = null;
            }
        }
    }
}
