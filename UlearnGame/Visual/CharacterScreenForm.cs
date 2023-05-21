using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using UlearnGame.Model;
using UlearnGame.Model.Objects;

namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class CharacterScreenForm : Form
    {
        private PictureBox LeftPanel;
        private PictureBox RightPanel;
        private Button BackButton;
        private Label UpperLeftNamePanel;
        private Label UpperRightNamePanel;
        private PictureBox CharacterIcon;
        private Label CharacterTitle;
        private Label StatisticsPanel;

        private Game Game { get; set; }
        public CharacterScreenForm(Game game)
        {
            Game = game;
            SetFormBaseParameteres();
            InitializeCharacterScreen();
        }
        public void UpdateScreenState()
        {
            StatisticsPanel.Text = $"\n\n  УРОВЕНЬ: {Game.Level + 1} ур.\n" +
                $"  ОПЫТА ВСЕГО: {(int)Game.TotalExperience} хр.\n" +
                $"  СИЛА КЛИКА: {Game.ClickPower} пр. за клик.\n" +
                $"  КОЛ-ВО КЛИКОВ: {Game.TotalClickTimes} раз.\n" +
                $"  ОБЪЕКТ. ДОБЫТО: {Game.TotalObjectDestruction} шт.\n" +
                $"  РЕСУРСОВ ДОБЫТО: {Game.TotalResourcesDrop} шт.\n" +
                $"  РЕСУРСОВ СОЗДАНО: {Game.TotalResourcesCraft} шт. \n" +
                $"  РЕС-ОВ В ИНВЕНТАРЕ: {Game.Inventory.GetResourcesAmount()} шт. \n" +
                $"  ПРОИЗВ. КРАФТОВ: {Game.TotalCraftTimes} раз.\n" +
                $"  ПОДНОШЕНИЙ ВСЕГО: {Game.TotalAscendingTimes} / 8 раз.\n" +
                $"  МНОЖИТЕЛЬ ПРОЧНОСТИ: x{Game.CapacityHardnessMultiplier}\n" +
                $"  МНОЖИТЕЛЬ ОПЫТА: x{Game.ExperienceMultiplier}\n" +
                $"  ШАНС ДОП. ОБЪЕКТА: {Game.Field.DoubleGenrationChances * 100}%\n" +
                $"  ТАЙМЕР: {Game.FieldUpdateRate} сек.\n" +
                $"  ";
            CharacterTitle.Text = Game.UpgradeSystem.Titles[Game.Level];
        }

        private void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += CharacterForm_Load;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Texture.BackGround;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void InitializeCharacterScreen()
        {
            SetLeftPanel();
            SetRightPanel();
            SetBackButton();
        }

        private void SetLeftPanel()
        {
            SetUpperNamePanel(new Point(151, 68), UpperLeftNamePanel, "СТАТИСТИКА");
            SetStatisticsPanel();
            SetMainPanel(new Point(32, 25), LeftPanel);

        }

        private void SetRightPanel()
        {
            SetUpperNamePanel(new Point(1307, 68), UpperRightNamePanel, "ПЕРСОНАЖ");
            SetCharacterIcon();
            SetCharacterTitle();
            SetMainPanel(new Point(1188, 25), RightPanel);
        }

        private void SetMainPanel(Point location, PictureBox control)
        {
            var mainPanel = new PictureBox()
            {
                Location = location,
                Width = 700,
                Height = 1029,
                BackColor = Color.Transparent,
                Image = Texture.CharacterPanel,
            };
            control = mainPanel;
            Controls.Add(control);
        }

        private void SetUpperNamePanel(Point location, Label control, string title)
        {
            var namePanel = new Label()
            {
                Location = location,
                Width = 462,
                Height = 114,
                BackgroundImage = Texture.UpperShortNamePanel,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 32, FontStyle.Bold),
                Text = title
            };
            control = namePanel;
            Controls.Add(control);
        }

        private void SetCharacterIcon()
        {
            var characterIcon = new PictureBox()
            {
                Location = new Point(1307, 217),
                Width = 462,
                Height = 462,
                BackgroundImage = Texture.CharacterIconPanel,
                Image = Texture.CharacterIcon
            };
            CharacterIcon = characterIcon;
            Controls.Add(CharacterIcon);
        }

        private void SetCharacterTitle()
        {
            var characterTitle = new Label()
            {
                Location = new Point(1307, 727),
                BackColor = Color.Transparent,
                Image = Texture.CharacterTitle,
                Width = 462,
                Height = 114,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 24, FontStyle.Bold),
            };
            CharacterTitle = characterTitle;
            Controls.Add(CharacterTitle);
        }

        private void SetStatisticsPanel()
        {
            var statistics = new Label()
            {
                Location = new Point(72, 217),
                Image = Texture.StatisticsPanel,
                Width = 619,
                Height = 778,
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.White,
                Font = new Font(string.Empty, 16, FontStyle.Bold),
            };
            StatisticsPanel = statistics;
            Controls.Add(StatisticsPanel);
        }

        private void SetBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(806, 931),
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
                ProgramInitials.MainScreenForm.Show();
                Hide();
            };
            BackButton = backButton;
            Controls.Add(BackButton);
        }
    }
}
