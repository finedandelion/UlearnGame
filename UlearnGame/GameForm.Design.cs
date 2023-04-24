using System;
using System.Collections.Generic;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UlearnGame.Resources;
using static System.Windows.Forms.AxHost;

namespace UlearnGame
{
    public partial class GameForm
    {
        private PictureBox MainPanel;
        private PictureBox UpperPanel;
        private PictureBox InventoryPanel;
        private PictureBox SelectedItemPanel;
        private PictureBox SelectedItemImage;
        private Label SelectedItemName;
        private Label SelectedItemDescription;
        private Button BackInventoryButton;
        private Button UpgradeButton;
        private Button SettingsButton;
        private Button ExitButton;
        private Button ToCharacterButton;
        private Button ToInventoryButton;
        private Button ToCraftButton;
        private Button ToTotemButton;
        private Label GameTimer;
        private Button[] InventoryButtons = new Button[20];
        private List<Button> FieldButtons = new List<Button>();

        private void InitializeForm()
        {
            SetFormBaseParameteres();
            InitializeMainScreen();
            InitializeInventoryScreen();
        }
        #region
        private void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += MainForm_Load;
            FormClosing += MainForm_Close;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Image.FromFile("D:\\GitHub Repository\\UlearnGame\\UlearnGame\\Images\\Background.jpg");
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void MainForm_Close(object sender, EventArgs e)
        {
            ApplicationInProccess = false;
            Thread.Sleep(1000);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplicationInProccess = true;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ChangeMainScreenVisibility(true);
            PutControlsToFront();
            StartGenerationTimer();
        }
        #endregion
        #region
        private void InitializeMainScreen()
        {
            SetGenerationTimer();
            SetFieldButtons(Game.field);
            SetMainPanel();
            SetUpperPanel();
        }

        private void SetGenerationTimer()
        {
            var timer = new Label()
            {
                Location = new Point(20, 886),
                Width = 217,
                Height = 168,
                Image = GetImage("Timer.png"),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                ForeColor = GetHtmlColor("#F4B41B"),
                Font = new Font(String.Empty, 48, FontStyle.Bold),
                Visible = false,
            };
            GameTimer = timer;
            Controls.Add(GameTimer);
        }

        private void SetMainPanel()
        {
            SetMainPanelButtons();
            var mainPanel = new PictureBox()
            {
                Location = new Point(1200, 25),
                Width = 700,
                Height = 1029,
                BackColor = Color.Transparent,
                Image = GetImage("MainPanel.png"),
                Visible = false,
            };
            MainPanel = mainPanel;
            Controls.Add(MainPanel);
        }

        private void SetMainPanelButtons()
        {
            SetToCharacterButton();
            SetToInventoryButton();
            SetToCraftButton();
            SetToTotemButton();
        }

        private void SetToCharacterButton()
        {
            var characterButton = new Button()
            {
                Location = new Point(1262, 85),
                Image = GetImage("CharacterButton.jpg"),
                Width = 256,
                Height = 256,
                Visible = false,
            };
            characterButton.Click += (sender, eventArgs) => { };
            ToCharacterButton = characterButton;
            Controls.Add(ToCharacterButton);
        }

        private void SetToInventoryButton()
        {
            var inventoryButton = new Button()
            {
                Location = new Point(1581, 85),
                Image = GetImage("InventoryButton.jpg"),
                Width = 256,
                Height = 256,
                Visible = false,
            };
            inventoryButton.Click += (sender, eventArgs) =>
            {
                ChangeMainScreenVisibility(false);
                ShowResourcesInInvetory(Game.inventory.GetStorage());
                ChangeInventoryScreenVisibility(true);
            };
            ToInventoryButton = inventoryButton;
            Controls.Add(ToInventoryButton);
        }

        private void SetToCraftButton()
        {
            var craftButton = new Button()
            {
                Location = new Point(1262, 412),
                Image = GetImage("CraftButton.jpg"),
                Width = 256,
                Height = 256,
                Visible = false,
            };
            craftButton.Click += (sender, eventArgs) =>
            {
            };
            ToCraftButton = craftButton;
            Controls.Add(ToCraftButton);
        }

        private void SetToTotemButton()
        {
            var totemButton = new Button()
            {
                Location = new Point(1581, 412),
                Image = GetImage("TotemButton.jpg"),
                Width = 256,
                Height = 256,
                Visible = false,
            };
            totemButton.Click += (sender, eventArgs) => { };
            ToTotemButton = totemButton;
            Controls.Add(ToTotemButton);
        }

        private void SetUpperPanel()
        {
            SetUpperPanelButtons();
            var upperPanel = new PictureBox()
            {
                Location = new Point(20, 25),
                Width = 1160,
                Height = 150,
                BackColor = Color.Transparent,
                Image = GetImage("UpperPanel.png"),
                Visible = false,
            };
            UpperPanel = upperPanel;
            Controls.Add(UpperPanel);
        }

        private void SetUpperPanelButtons()
        {
            SetExitButton();
            SetSettingsButton();
            SetUpgradeButton();
        }

        private void SetExitButton()
        {
            var exitButton = new Button()
            {
                Location = new Point(1053, 50),
                Image = GetImage("ExitButton.jpg"),
                Width = 100,
                Height = 100,
                Visible = false,
            };
            exitButton.Click += (sender, eventArgs) => Close();
            ExitButton = exitButton;
            Controls.Add(ExitButton);
        }

        private void SetSettingsButton()
        {
            var settingsButton = new Button()
            {
                Location = new Point(932, 50),
                Image = GetImage("SettingsButton.jpg"),
                Width = 100,
                Height = 100,
                Visible = false,
            };
            settingsButton.Click += (sender, eventArgs) => { };
            SettingsButton = settingsButton;
            Controls.Add(SettingsButton);
        }

        private void SetUpgradeButton()
        {
            var upgradeButton = new Button()
            {
                Location = new Point(811, 50),
                Image = GetImage("UpgradeButton.jpg"),
                Width = 100,
                Height = 100,
                Visible = false,
            };
            upgradeButton.Click += (sender, eventArgs) => { };
            UpgradeButton = upgradeButton;
            Controls.Add(UpgradeButton);
        }

        private void SetFieldButtons(GameField field)
        {
            FieldButtons.Clear();
            for (var i = 0; i < field.FieldCap + 1; i++)
            {
                var button = new Button();
                CustomizeFieldButton(button);
                FieldButtons.Add(button);
            }
            UpdateFieldButtons();
        }

        private void CustomizeFieldButton(Button button)
        {
            button.Size = new Size(256, 256);
            button.ForeColor = Color.White;
            button.Font = new Font("Arial", 16, FontStyle.Bold);
            button.TextAlign = ContentAlignment.TopRight;
            button.BackgroundImage = GetImage("Terrain.png");
            button.Visible = false;
        }

        private void UpdateFieldButtons()
        {
            for (var i = 0; i < Game.field.FieldCap + 1; i++)
            {
                var index = i;
                FieldButtons[index].Location = SetFieldButtonPosition(index, FieldButtons[index].Width);
                FieldButtons[index].Click += (sender, eventargs) =>
                {
                    FieldButtonClick(sender, eventargs, index);

                };
                Controls.Add(FieldButtons[index]);
            }
        }

        private Point SetFieldButtonPosition(int number, int buttonSize)
        {
            var xposOffset = (number) / 2;
            var yposOffset = (number + 1) % 2 > 0 ? 0 : buttonSize / 4 + buttonSize;
            var xpos = 312 + (buttonSize + buttonSize / 4) * xposOffset;
            var ypos = 257 + yposOffset;
            return new Point(xpos, ypos);
        }

        private void FieldButtonClick(object sender, EventArgs e, int fieldCell)
        {
            var button = sender as Button;
            if (Game.field.UpdateObjectState(Game.ClickPower, fieldCell, Game.inventory))
            {
                button.Image = null;
                button.Text = null;
            }
            else if (Game.field.Field[fieldCell] != null)
            {
                var capacity = Game.field.Field[fieldCell].Capacity.ToString();
                var startCap = Game.field.Field[fieldCell].StartCapacity.ToString();
                button.Text = capacity + "/" + startCap;
            }
        }
        #endregion
        #region
        private void InitializeInventoryScreen()
        {
            SetInventoryPanel();
            SetSelectedItemPanel();
            SetInventoryBackButton();
        }

        private void SetInventoryPanel()
        {
            SetInventoryButtons();
            var invenoryPanel = new PictureBox()
            {
                Location = new Point(57, 32),
                BackColor = Color.Transparent,
                Image = GetImage("InventoryPanel.png"),
                Width = 975,
                Height = 1015,
                Visible = false,
            };
            InventoryPanel = invenoryPanel;
            Controls.Add(InventoryPanel);
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
                Image = GetImage("SelectedItemPanel.png"),
                Width = 975,
                Height = 1015,
                Visible = false,
            };
            SelectedItemPanel = selectedItemPanel;
            Controls.Add(SelectedItemPanel);
        }

        private void SetInventoryBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(1383, 931),
                BackgroundImage = GetImage("BackInventoryButton.jpg"),
                Width = 308,
                Height = 116,
                Visible = false,
                Text = "Назад",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = GetHtmlColor("#CFC6B8"),
                Font = new Font("Arial", 32, FontStyle.Bold),
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ChangeInventoryScreenVisibility(false);
                ResetInventory(Game.inventory.GetStorage());
                ChangeMainScreenVisibility(true);
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
                Image = GetImage("SelectedItemName.jpg"),
                Width = 460,
                Height = 82,
                Visible = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 32, FontStyle.Bold),
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
                BackgroundImage = GetImage("SelectedItemImage.jpg"),
                Visible = false,
            };
            var text = new Label()
            {
                Width = 325,
                Height = 325,
                TextAlign = ContentAlignment.BottomRight,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(String.Empty, 24, FontStyle.Bold),
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
                Image = GetImage("SelectedItemDescription.jpg"),
                Width = 460,
                Height = 132,
                Visible = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 16, FontStyle.Bold),
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
            button.ForeColor = Color.White;
            button.Font = new Font(String.Empty, 16, FontStyle.Bold);
            button.TextAlign = ContentAlignment.BottomRight;
            button.BackgroundImage = GetImage("InventoryCellButton.jpg");
            button.Visible = false;
            button.Location = SetInventoryButtonPosition(index, 157);
        }

        private Point SetInventoryButtonPosition(int number, int buttonSize)
        {
            var xposOffset = number % 5;
            var yposOffset = number / 5;
            var xpos = 100 + (buttonSize + 26) * xposOffset;
            var ypos = 235 + (buttonSize + 26) * yposOffset;
            return new Point(xpos, ypos);
        }

        private void ShowResourcesInInvetory(Resource[] storage)
        {
            for (var i = 0; i < storage.Length; i++)
            {
                var index = i;
                var button = InventoryButtons[index];
                button.BackgroundImage = GetImage("InventoryCellButton2.jpg");
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

        private void ResetInventory(Resource[] storage)
        {
            for (var i = 0; i < storage.Length; i++)
            {
                var index = i;
                var button = InventoryButtons[index];
                button.Image = null;
                button.BackgroundImage = GetImage("InventoryCellButton.jpg");
                button.Text = null;
            }
        }

        #endregion

        private void ChangeInventoryScreenVisibility(bool state)
        {
            InventoryPanel.Visible = state;
            SelectedItemPanel.Visible = state;
            BackInventoryButton.Visible = state;
            SelectedItemName.Visible = false;
            SelectedItemDescription.Visible = false;
            SelectedItemImage.Visible = false;
            foreach (var cell in InventoryButtons)
                cell.Visible = state;
        }

        private void ChangeMainScreenVisibility(bool state)
        {
            UpperPanel.Visible = state;
            MainPanel.Visible = state;
            ExitButton.Visible = state;
            SettingsButton.Visible = state;
            UpgradeButton.Visible = state;
            ToCharacterButton.Visible = state;
            ToInventoryButton.Visible = state;
            ToCraftButton.Visible = state;
            ToTotemButton.Visible = state;
            GameTimer.Visible = state;
            FieldButtons.ForEach(button => button.Visible = state);
        }

        private void PutControlsToFront()
        {
            ToTotemButton.BringToFront();
            ToCraftButton.BringToFront();
            ToInventoryButton.BringToFront();
            ToCharacterButton.BringToFront();
        }

        private void DisableField()
        {
            FieldButtons.ForEach(button => button.Enabled = false);
        }

        private void EnableField()
        {
            FieldButtons.ForEach(button => button.Enabled = true);
        }
    }
}
