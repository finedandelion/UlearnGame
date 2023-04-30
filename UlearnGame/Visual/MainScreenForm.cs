
using UlearnGame.Model;


namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class MainScreenForm : Form
    {
        private PictureBox MainPanel;
        private PictureBox UpperPanel;
        private Button UpgradeButton;
        private Button SettingsButton;
        private Button ExitButton;
        private Button ToCharacterButton;
        private Button ToInventoryButton;
        private Button ToCraftButton;
        private Button ToTotemButton;
        private Label GameTimer;
        private List<Button> FieldButtons = new List<Button>();

        private Game Game { get; set; }
        public MainScreenForm(Game game)
        {
            Game = game;
            SetFormBaseParameteres();
            InitializeMainScreen();
        }
        public void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += MainForm_Load;
            FormClosing += MainForm_Close;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = ProgramInitials.GetImage("Background.jpg");
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void MainForm_Close(object sender, EventArgs e)
        {
            ProgramInitials.ApplicationInProccess = false;
            Thread.Sleep(1000);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProgramInitials.ApplicationInProccess = true;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            PutControlsToFront();
            StartGenerationTimer();
        }

        private void InitializeMainScreen()
        {
            SetGenerationTimer();
            SetFieldButtons(Game.Field);
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
                Image = ProgramInitials.GetImage("Timer.png"),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                ForeColor = ProgramInitials.GetHtmlColor("#F4B41B"),
                Font = new Font(string.Empty, 48, FontStyle.Bold),
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
                Image = ProgramInitials.GetImage("MainPanel.png"),
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
                Image = ProgramInitials.GetImage("CharacterButton.jpg"),
                Width = 256,
                Height = 256,
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
                Image = ProgramInitials.GetImage("InventoryButton.jpg"),
                Width = 256,
                Height = 256,
            };
            inventoryButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.InventoryForm.ShowResourcesInInvetory(Game.Inventory.GetStorage());
                ProgramInitials.InventoryForm.Show();
                Hide();
            };
            ToInventoryButton = inventoryButton;
            Controls.Add(ToInventoryButton);
        }

        private void SetToCraftButton()
        {
            var craftButton = new Button()
            {
                Location = new Point(1262, 412),
                Image = ProgramInitials.GetImage("CraftButton.jpg"),
                Width = 256,
                Height = 256,
            };
            craftButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.CraftForm.Show();
                Hide();
            };
            ToCraftButton = craftButton;
            Controls.Add(ToCraftButton);
        }

        private void SetToTotemButton()
        {
            var totemButton = new Button()
            {
                Location = new Point(1581, 412),
                Image = ProgramInitials.GetImage("TotemButton.jpg"),
                Width = 256,
                Height = 256,
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
                Image = ProgramInitials.GetImage("UpperPanel.png"),
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
                Image = ProgramInitials.GetImage("ExitButton.jpg"),
                Width = 100,
                Height = 100,
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
                Image = ProgramInitials.GetImage("SettingsButton.jpg"),
                Width = 100,
                Height = 100,
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
                Image = ProgramInitials.GetImage("UpgradeButton.jpg"),
                Width = 100,
                Height = 100,
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
            button.TextAlign = ContentAlignment.BottomCenter;
            button.BackgroundImage = ProgramInitials.GetImage("Terrain.png");
        }

        private void UpdateFieldButtons()
        {
            for (var i = 0; i < Game.Field.FieldCap + 1; i++)
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
            var xposOffset = number / 2;
            var yposOffset = (number + 1) % 2 > 0 ? 0 : buttonSize / 4 + buttonSize;
            var xpos = 312 + (buttonSize + buttonSize / 4) * xposOffset;
            var ypos = 257 + yposOffset;
            return new Point(xpos, ypos);
        }

        private void FieldButtonClick(object sender, EventArgs e, int fieldCell)
        {
            var button = sender as Button;
            if (Game.Field.UpdateObjectState(Game.ClickPower, fieldCell, Game))
            {
                button.Image = null;
                button.Text = null;
            }
            else if (Game.Field.Field[fieldCell] != null)
            {
                var capacity = Game.Field.Field[fieldCell].Capacity.ToString();
                var startCap = Game.Field.Field[fieldCell].StartCapacity.ToString();
                button.Text = capacity + "/" + startCap;
            }
        }

        private void PutControlsToFront()
        {
            ToTotemButton.BringToFront();
            ToCraftButton.BringToFront();
            ToInventoryButton.BringToFront();
            ToCharacterButton.BringToFront();
        }

        private void StartGenerationTimer()
        {
            var thread = new Thread(() =>
            {
                while (ProgramInitials.ApplicationInProccess)
                {
                    BeginInvoke(new Action(() => GameTimer.Text = Game.FieldUpdateRate.ToString()));
                    var count = Game.FieldUpdateRate;
                    while (count > 0)
                    {
                        if (!ProgramInitials.ApplicationInProccess)
                            break;
                        Thread.Sleep(1000);
                        BeginInvoke(new Action(() => GameTimer.Text = count.ToString()));
                        count--;
                    }
                    if (!ProgramInitials.ApplicationInProccess)
                        break;
                    var field = Game.Field.GenerateResource();
                    if (field != null)
                    {
                        var cell = (int)field;
                        var capacity = Game.Field.Field[cell].StartCapacity.ToString();
                        BeginInvoke(new Action(() => FieldButtons[cell].Image = Game.Field.Field[cell].ImagePath));
                        BeginInvoke(new Action(() => FieldButtons[cell].Text = capacity + "/" + capacity));
                    }
                }
            });
            thread.Start();
        }
    }
}
