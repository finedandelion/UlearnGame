
using UlearnGame.Model;
using static System.Collections.Specialized.BitVector32;


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
        private Label GameExperienceBar;
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
            BackgroundImage = Texture.BackGround;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        public void SetFieldButtons(Func<int, int, Point> fieldButtonPosition, Action<Button> buttonCustomizer)
        {
            foreach(var button in FieldButtons)
                Controls.Remove(button);
            FieldButtons.Clear();
            for (var i = 0; i < Game.Field.FieldCap + 1; i++)
            {
                var button = new Button();
                buttonCustomizer(button);
                FieldButtons.Add(button);
            }
            UpdateFieldButtons(fieldButtonPosition);
        }

        public void CustomizeFieldButtonPreset1(Button button)
        {
            button.Size = new Size(256, 256);
            button.ForeColor = Color.White;
            button.Font = new Font("Arial", 16, FontStyle.Bold);
            button.TextAlign = ContentAlignment.BottomCenter;
            button.BackgroundImage = Texture.Terrain;
        }

        public void CustomizeFieldButtonPreset2(Button button)
        {
            button.Size = new Size(192, 192);
            button.ForeColor = Color.White;
            button.Font = new Font("Arial", 14, FontStyle.Bold);
            button.TextAlign = ContentAlignment.BottomCenter;
            button.BackgroundImage = Texture.Terrain2;
        }

        public Point FieldButtonPositionPreset1(int number, int buttonSize)
        {
            var xposOffset = number / 2;
            var yposOffset = (number + 1) % 2 > 0 ? 0 : buttonSize / 4 + buttonSize;
            var xpos = 312 + (buttonSize + buttonSize / 4) * xposOffset;
            var ypos = 257 + yposOffset;
            return new Point(xpos, ypos);
        }

        public Point FieldButtonPositionPreset2(int number, int buttonSize)
        {
            var xposOffset = number / 2;
            var yposOffset = (number + 1) % 2 > 0 ? 0 : buttonSize / 4 + buttonSize;
            var xpos = 154 + (buttonSize + buttonSize / 4) * xposOffset;
            var ypos = 257 + yposOffset;
            return new Point(xpos, ypos);
        }

        public Point FieldButtonPositionPreset3(int number, int buttonSize)
        {
            var xposOffset = number % 3;
            var yposOffset = number / 3;
            var xpos = 244 + (buttonSize + buttonSize / 4) * xposOffset;
            var ypos = 189 + (buttonSize + buttonSize / 4) * yposOffset;
            return new Point(xpos, ypos);
        }

        public Point FieldButtonPositionPreset4(int number, int buttonSize)
        {
            var xposOffset = number % 4;
            var yposOffset = number / 4;
            var xpos = 160 + (buttonSize + buttonSize / 4) * xposOffset;
            var ypos = 189 + (buttonSize + buttonSize / 4) * yposOffset;
            return new Point(xpos, ypos);
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
            SetFieldButtons(FieldButtonPositionPreset1, CustomizeFieldButtonPreset1);
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
                Image = Texture.Timer,
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
                Image = Texture.MainPanel,
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
                Image = Texture.CharacterButton,
                Width = 256,
                Height = 256,
            };
            characterButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.CharacterForm.UpdateScreenState();
                ProgramInitials.CharacterForm.Show();
                Hide();
            };
            ToCharacterButton = characterButton;
            Controls.Add(ToCharacterButton);
        }

        private void SetToInventoryButton()
        {
            var inventoryButton = new Button()
            {
                Location = new Point(1581, 85),
                Image = Texture.InventoryButton,
                Width = 256,
                Height = 256,
            };
            inventoryButton.Click += async (sender, eventArgs) =>
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
                Image = Texture.CraftButton,
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
                Image = Texture.TotemButton,
                Width = 256,
                Height = 256,
            };
            totemButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.TotemForm.Show();
                ProgramInitials.TotemForm.UpdateTotemForm();
                Hide();
            };
            ToTotemButton = totemButton;
            Controls.Add(ToTotemButton);
        }

        private void SetUpperPanel()
        {
            SetExperienceBar();
            SetUpperPanelButtons();
            var upperPanel = new PictureBox()
            {
                Location = new Point(20, 25),
                Width = 1160,
                Height = 150,
                BackColor = Color.Transparent,
                Image = Texture.UpperPanel,
            };
            UpperPanel = upperPanel;
            Controls.Add(UpperPanel);
        }

        private void SetExperienceBar()
        {
            var experienceBar = new Label()
            {
                Location = new Point(72, 50),
                Width = 700,
                Height = 100,
                BackgroundImage = Texture.ExperienceBar,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = ProgramInitials.GetHtmlColor("#F7AC37"),
                Font = new Font(string.Empty, 24, FontStyle.Bold),
                Text = $"Ур. {Game.Level + 1} | Опыт: {(int) Game.Experience} / {Game.LevelExperienceCap}"
            };
            GameExperienceBar = experienceBar;
            Controls.Add(GameExperienceBar);
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
                Image = Texture.ExitButton,
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
                Image = Texture.SettingsButton,
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
                Image = Texture.UpgradeButton,
                Width = 100,
                Height = 100,
            };
            upgradeButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.UpgradeForm.UpdatePointsBar();
                ProgramInitials.UpgradeForm.Show();
                Hide();
            };
            UpgradeButton = upgradeButton;
            Controls.Add(UpgradeButton);
        }

        private void UpdateFieldButtons(Func<int, int, Point> SetFieldButtonPosition)
        {
            var field = Game.Field.Field;
            for (var i = 0; i < Game.Field.FieldCap + 1; i++)
            {
                var index = i;
                if (field[index] != null)
                {
                    var capacity = field[index].Capacity.ToString();
                    var startCap = field[index].StartCapacity.ToString();
                    FieldButtons[index].Text = capacity + "/" + startCap;
                    FieldButtons[index].Image = field[index].ImagePath;
                }
                FieldButtons[index].Location = SetFieldButtonPosition(index, FieldButtons[index].Width);
                FieldButtons[index].Click += (sender, eventargs) =>
                {
                    FieldButtonClick(sender, eventargs, index);

                };
                Controls.Add(FieldButtons[index]);
            }
        }

        private void FieldButtonClick(object sender, EventArgs e, int fieldCell)
        {
            var button = sender as Button;
            if (Game.Field.UpdateObjectState(fieldCell, Game))
            {
                var exp = (int)Game.Experience;
                GameExperienceBar.Text = $"Ур. {Game.Level + 1} | Опыт: {exp} / {Game.LevelExperienceCap}";
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

        private async void StartGenerationTimer()
        {
            var thread = new Thread(() =>
            {
                while (ProgramInitials.ApplicationInProccess)
                {
                    var count = Game.FieldUpdateRate > 0 ? Game.FieldUpdateRate : 1;
                    BeginInvoke(new Action(() => GameTimer.Text = count.ToString()));
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
                    for (var i = 0; i < Game.Field.GenerationTimes; i++)
                    {
                        var field = Game.Field.GenerateResource();
                        if (field != null)
                        {
                            var cell = (int)field;
                            var capacity = Game.Field.Field[cell].StartCapacity.ToString();
                            BeginInvoke(new Action(() => FieldButtons[cell].Image = Game.Field.Field[cell].ImagePath));
                            BeginInvoke(new Action(() => FieldButtons[cell].Text = capacity + "/" + capacity));
                        }
                    }
                }
            });
            thread.Start();
        }
    }
}
