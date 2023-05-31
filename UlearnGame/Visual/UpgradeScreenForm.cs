using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Upgrades;
using UlearnGame.Model;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.AxHost;
using UlearnGame.Model.Crafts;

namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class UpgradeScreenForm : Form
    {
        private Game Game { get; set; }
        private Dictionary<int, Upgrade> Upgrades => Game.UpgradeSystem.upgrades;

        private PictureBox HideScreen;
        private PictureBox UpgradePanel;
        private PictureBox UpgradeCardPanel;
        private PictureBox UpgradeIcon;
        private Label UpgradeTitle;
        private Label UpgradeDescription;
        private Label UpgradePointsBar;
        private Label UpperNamePanel;
        private Button BackUpgradeButton;
        private Button BackButton;
        private Button[] AcceptButtons = new Button[13];
        private Button[] UpgradeButtons = new Button[13];
        public UpgradeScreenForm(Game game)
        {
            Game = game;
            SetFormBaseParameteres();
            InitializeUpgradeScreen();
            BringControlsToFront();
        }

        public void UpdatePointsBar()
        {
            UpgradePointsBar.Text = $"Ур. {Game.Level + 1} |" +
                $" Очков доступно: {Game.UpgradeSystem.AvailableUpgradePoints} / {Game.Level}";
        }
        private void InitializeUpgradeScreen()
        {
            SetHideScreen();
            SetUpgradeCard();
            SetUpgradePanel();
            SetUpgradePointsBar();
            SetUpgradeBackButton();
        }

        private void SetHideScreen()
        {
            var hideScreen = new PictureBox()
            {
                Location = new Point(0, 0),
                Width = 1920,
                Height = 1080,
                BackColor = Color.Transparent,
                Visible = false,
            };
            HideScreen = hideScreen;
            Controls.Add(HideScreen);
        }

        private void SetUpgradeCard()
        {
            SetUpgradeCardPanel();
            SetBackButton();
            SetAcceptButtons();
            SetUpgradeTitle();
            SetUpgradeDescription();
            SetUpgradeIcon();
        }

        private void SetUpgradeTitle()
        {
            var upgradeTitle = new Label()
            {
                Location = new Point(510, 293),
                Width = 470,
                Height = 111,
                BackgroundImage = Texture.UpgradeTitle,
                Visible = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 24, FontStyle.Bold),
            };
            UpgradeTitle = upgradeTitle;
            Controls.Add(UpgradeTitle);
        }

        private void SetUpgradeDescription()
        {
            var upgradeDescription = new Label()
            {
                Location = new Point(510, 439),
                Width = 470,
                Height = 325,
                BackgroundImage = Texture.UpgradeDescription,
                Visible = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 16, FontStyle.Bold),
            };
            UpgradeDescription = upgradeDescription;
            Controls.Add(UpgradeDescription);
        }

        private void SetUpgradeIcon()
        {
            var upgradeIcon = new PictureBox()
            {
                Location = new Point(1064, 359),
                Width = 340,
                Height = 340,
                BackgroundImage = Texture.UpgradeIcon,
                Visible = false,
            };
            UpgradeIcon = upgradeIcon;
            Controls.Add(UpgradeIcon);
        }

        private void SetUpgradeCardPanel()
        {
            var upgradePanel = new PictureBox()
            {
                Location = new Point(437, 202),
                Width = 1046,
                Height = 675,
                BackgroundImage = Texture.UpgradeCardPanel,
                BackColor = Color.Transparent,
                Visible = false,
            };
            UpgradeCardPanel = upgradePanel;
            Controls.Add(UpgradeCardPanel);
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
                ChangeUpgradePanelVisibility(true);
                UpdatePointsBar();
                foreach (var button in AcceptButtons)
                {
                    button.Enabled = false;
                    button.BackgroundImage = Texture.AcceptUpgradeButton;
                }
            };
            BackButton = backButton;
            Controls.Add(BackButton);
        }

        private void SetAcceptButtons()
        {
            for (var i = 0; i < AcceptButtons.Length; i++)
            {
                var index = i;
                var acceptButton = new Button()
                {
                    Location = new Point(1538, 359),
                    Width = 340,
                    Height = 340,
                    BackgroundImage = Texture.AcceptUpgradeButton,
                    Visible = false,
                    Enabled = false,
                };
                AcceptButtons[index] = acceptButton;
                Controls.Add(AcceptButtons[index]);
            }
        }

        private void SetUpgradePanel()
        {
            SetUpperNamePanel();
            InitializeUpgradeButtons();
            var upgradePanel = new PictureBox()
            {
                Location = new Point(218, 32),
                Width = 1483,
                Height = 1015,
                BackColor = Color.Transparent,
                BackgroundImage = Texture.UpgradePanel
            };
            UpgradePanel = upgradePanel;
            Controls.Add(UpgradePanel);
        }

        private void SetUpgradePointsBar()
        {
            var upgradePointsBar = new Label()
            {
                Location = new Point(610, 919),
                Width = 700,
                Height = 100,
                BackgroundImage = Texture.ExperienceUpgradeBar,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = ProgramInitials.GetHtmlColor("#F7AC37"),
                Font = new Font(string.Empty, 24, FontStyle.Bold),
                Text = $"Ур. {Game.Level + 1} | Очков доступно: {Game.UpgradeSystem.AvailableUpgradePoints} / {Game.Level}"
            };
            UpgradePointsBar = upgradePointsBar;
            Controls.Add(UpgradePointsBar);
            UpgradePointsBar.BringToFront();
        }

        private void SetUpperNamePanel()
        {
            var namePanel = new Label()
            {
                Location = new Point(498, 68),
                Width = 924,
                Height = 114,
                BackgroundImage = Texture.UpperNamePanel,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 48, FontStyle.Bold),
                Text = "НАВЫКИ"
            };
            UpperNamePanel = namePanel;
            Controls.Add(UpperNamePanel);
        }

        private void InitializeUpgradeButtons()
        {
            SetUpgradeButtons();
            ConnectButtons();
        }

        private void ConnectButtons()
        {
            for (var i = 0; i < UpgradeButtons.Length; i++)
            {
                var index = i;
                var upgrade = Upgrades[index];
                var button = UpgradeButtons[index];
                button.Image = upgrade.ImagePath1;
                button.Click += (sender, eventArgs) =>
                {
                    ShowUpgradeCard(upgrade);
                    AcceptButtons[index].Show();
                    AcceptButtons[index].BringToFront();
                    if (upgrade.IsObtainable())
                    {
                        AcceptButtons[index].Enabled = true;
                        AcceptButtons[index].BackgroundImage = Texture.AcceptUpgradeButton2;
                    }
                };

                AcceptButtons[index].Click += (sender, eventArgs) =>
                {
                    upgrade.ObtainUpgrade();
                    if (index == 5)
                    {
                        var preset = MainScreenForm.FieldButtonPositionPreset2;
                        var preset2 = MainScreenForm.CustomizeFieldButtonPreset1;
                        var mainScreen = ProgramInitials.Screens["Main"] as MainScreenForm;
                        mainScreen.SetFieldButtons(preset, preset2);
                    }
                    if (index == 6)
                    {
                        var preset = MainScreenForm.FieldButtonPositionPreset3;
                        var preset2 = MainScreenForm.CustomizeFieldButtonPreset2;
                        var mainScreen = ProgramInitials.Screens["Main"] as MainScreenForm;
                        mainScreen.SetFieldButtons(preset, preset2);
                    }
                    if (index == 9)
                    {
                        var preset = MainScreenForm.FieldButtonPositionPreset4;
                        var preset2 = MainScreenForm.CustomizeFieldButtonPreset2;
                        var mainScreen = ProgramInitials.Screens["Main"] as MainScreenForm;
                        mainScreen.SetFieldButtons(preset, preset2);
                    }
                    AcceptButtons[index].BackgroundImage = Texture.AcceptUpgradeButton;
                    AcceptButtons[index].Enabled = false;
                };
            }
        }

        private void ShowUpgradeCard(Upgrade upgrade)
        {
            ChangeUpgradePanelVisibility(false);
            UpgradeIcon.Image = upgrade.ImagePath2;
            UpgradeTitle.Text = upgrade.Title;
            UpgradeDescription.Text = upgrade.Description;
        }

        private void SetUpgradeButtons()
        {
            UpgradeButtons[0] = SetGathererButton();
            UpgradeButtons[1] = SetCraftsmanButton();
            UpgradeButtons[2] = SetMaster1Button();
            UpgradeButtons[3] = SetMaster2Button();
            UpgradeButtons[4] = SetMaster3Button();
            UpgradeButtons[5] = SetAdventurerButton();
            UpgradeButtons[6] = SetArcheologistButton();
            UpgradeButtons[7] = SetHunterButton();
            UpgradeButtons[8] = SetSpelunkerButton();
            UpgradeButtons[9] = SetExplorerButton();
            UpgradeButtons[10] = SetMagicianButton();
            UpgradeButtons[11] = SetPriestButton();
            UpgradeButtons[12] = SetChronomanserButton();
        }

        private Button SetGathererButton()
        {
            return UpgradeButtonExample(new Point(881, 461), Texture.UpgradeCell);
        }

        private Button SetCraftsmanButton()
        {
            return UpgradeButtonExample(new Point(1153, 461), Texture.UpgradeCell);
        }

        private Button SetMaster1Button()
        {
            return UpgradeButtonExample(new Point(1153, 695), Texture.UpgradeCell);
        }

        private Button SetMaster2Button()
        {
            return UpgradeButtonExample(new Point(1425, 695), Texture.UpgradeCell);
        }

        private Button SetMaster3Button()
        {
            return UpgradeButtonExample(new Point(1425, 461), Texture.UpgradeCell);
        }

        private Button SetAdventurerButton()
        {
            return UpgradeButtonExample(new Point(881, 227), Texture.UpgradeCell);
        }

        private Button SetArcheologistButton()
        {
            return UpgradeButtonExample(new Point(609, 227), Texture.UpgradeCell);
        }

        private Button SetHunterButton()
        {
            return UpgradeButtonExample(new Point(609, 461), Texture.UpgradeCell);
        }

        private Button SetSpelunkerButton()
        {
            return UpgradeButtonExample(new Point(337, 461), Texture.UpgradeCell);
        }

        private Button SetExplorerButton()
        {
            return UpgradeButtonExample(new Point(337, 227), Texture.UpgradeCell);
        }

        private Button SetMagicianButton()
        {
            return UpgradeButtonExample(new Point(881, 695), Texture.UpgradeCell);
        }

        private Button SetPriestButton()
        {
            return UpgradeButtonExample(new Point(609, 695), Texture.UpgradeCell);
        }

        private Button SetChronomanserButton()
        {
            return UpgradeButtonExample(new Point(337, 695), Texture.UpgradeCell);
        }

        private Button UpgradeButtonExample(Point point, Image image)
        {
            var button = new Button()
            {
                Location = point,
                Width = 157,
                Height = 157,
                BackgroundImage = image,
            };
            Controls.Add(button);
            return button;
        }

        private void SetUpgradeBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(1350, 903),
                Width = 308,
                Height = 116,
                BackgroundImage = Texture.DefaultButton,
                Text = "Назад",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 32, FontStyle.Bold)
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.ShowScreen("Main");
            };
            BackUpgradeButton = backButton;
            Controls.Add(BackUpgradeButton);
            BackUpgradeButton.BringToFront();
        }

        private void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += UpgradeForm_Load;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Texture.Background;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void UpgradeForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void ChangeUpgradePanelVisibility(bool state)
        {
            HideScreen.Visible = !state;
            if (state)
                foreach (var button in AcceptButtons)
                    button.Visible = !state;
            UpgradeDescription.Visible = !state;
            UpgradeTitle.Visible = !state;
            UpgradeIcon.Visible = !state;
            UpgradeCardPanel.Visible = !state;
            BackButton.Visible = !state;
            BackUpgradeButton.Visible = state;
            UpgradePointsBar.Visible = state;
        }

        private void BringControlsToFront()
        {
            UpgradeCardPanel.BringToFront();
            foreach (var button in AcceptButtons)
                button.BringToFront();
            UpgradeDescription.BringToFront();
            UpgradeTitle.BringToFront();
            UpgradeIcon.BringToFront();
            BackButton.BringToFront();
        }
    }
}
