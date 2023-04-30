

using static System.Net.Mime.MediaTypeNames;
using UlearnGame.Model;
using UlearnGame.Model.Resources;

namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class CraftScreenForm : Form
    {
        private Button BackCraftButton;
        private PictureBox CraftPanel;
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
            BackgroundImage = ProgramInitials.GetImage("Background.jpg");
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
        }

        private void SetCraftPanel()
        {
            SetCraftButtons();
            var craftPanel = new PictureBox()
            {
                Location = new Point(472, 32),
                BackColor = Color.Transparent,
                Image = ProgramInitials.GetImage("HugePanel.png"),
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
                BackgroundImage = ProgramInitials.GetImage("BackInventoryButton.jpg"),
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
            button.BackgroundImage = ProgramInitials.GetImage("CellButton.jpg");
            button.Location = SetCraftButtonPosition(index, 157);
            button.TextAlign = ContentAlignment.BottomRight;
            button.ForeColor = Color.White;
            button.Font = new Font(string.Empty, 16, FontStyle.Bold);
        }

        private Point SetCraftButtonPosition(int number, int buttonSize)
        {
            var xposOffset = number % 5;
            var yposOffset = number / 5;
            var xpos = 100 + (buttonSize + 26) * xposOffset;
            var ypos = 235 + (buttonSize + 26) * yposOffset;
            return new Point(xpos, ypos);
        }

        public void ShowResourcesInInvetory(Resource[] storage)
        {
            for (var i = 0; i < storage.Length; i++)
            {
                var index = i;
                var button = CraftButtons[index];
                button.BackgroundImage = ProgramInitials.GetImage("InventoryCellButton2.jpg");
                button.Image = storage[index].ImagePath;
                button.Text = "x" + storage[index].Amount.ToString();
                button.Click += (sender, eventArgs) =>
                {
                    
                };
            }
        }
    }
}
