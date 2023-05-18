using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model;
using UlearnGame.Model.Crafts;
using static System.Windows.Forms.AxHost;

namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class TotemScreenForm : Form
    {
        private PictureBox TotemPanel;
        private Label UpperNamePanel;
        private Button BackButton;
        private Button AscendButton;
        private PictureBox Totem;
        private Label[] OfferingCells = new Label[6];
        private Button LeftChoiceButton;
        private Button RightChoiceButton;
        private PictureBox ChoiceBox;
        private Label BlessingNamePanel;

        private Game Game { get; set; }
        public TotemScreenForm(Game game)
        {
            Game = game;
            SetFormBaseParameteres();
            InitializeTotemScreen();
        }

        public void UpdateTotemForm()
        {
            ChangeAscendButtonState(Game.AscendingSystem.IsAscendable());
            ShowOffering();
        }

        private void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += TotemForm_Load;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Texture.BackGround;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void TotemForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void InitializeTotemScreen()
        {
            InitializeMain();
            InitializeBlessingsScreen();
        }

        private void InitializeMain()
        {
            SetTotemPanel();
            SetUpperNamePanel();
            SetTotemPicture();
            SetBackButton();
            SetAscendButton();
        }

        private void InitializeBlessingsScreen()
        {
            SetLeftChoiceButton();
            SetRightChoiceButton();
            SetBlessingNamePanel();
            SetChoiceBox();
        }

        private void SetBlessingNamePanel()
        {
            var namePanel = new Label()
            {
                Location = new Point(499, 62),
                Width = 924,
                Height = 114,
                Visible = false,
                BackgroundImage = Texture.UpperNamePanel,
                ForeColor = Color.White,
                Font = new Font("Arial", 32, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "ВЫБЕРИТЕ БЛАГОСЛОВЕНИЕ!"
            };
            BlessingNamePanel = namePanel;
            Controls.Add(BlessingNamePanel);
        }

        private void SetLeftChoiceButton()
        {
            var blessingChanges = Game.AscendingSystem.CurrentBlessing.LeftBlessingChanges;
            var button = new Button()
            {
                Location = new Point(262, 289),
                Width = 480,
                Height = 480,
                BackgroundImage = Texture.BlessingDescription,
                Visible = false,
                Font = new Font("Arial", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Text = Game.AscendingSystem.CurrentBlessing.LeftDescription,
            };
            button.Click += (sender, eventArgs) => ChoiceButton_OnClick(blessingChanges);
            LeftChoiceButton = button;
            Controls.Add(LeftChoiceButton);
        }

        private void SetRightChoiceButton()
        {
            var blessingChanges = Game.AscendingSystem.CurrentBlessing.RightBlessingChanges;
            var button = new Button()
            {
                Location = new Point(1180, 289),
                Width = 480,
                Height = 480,
                BackgroundImage = Texture.BlessingDescription,
                Visible = false,
                Font = new Font("Arial", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Text = Game.AscendingSystem.CurrentBlessing.RightDescription,
            };
            button.Click += (sender, eventArgs) => ChoiceButton_OnClick(blessingChanges);
            RightChoiceButton = button;
            Controls.Add(RightChoiceButton);
        }

        private void SetChoiceBox()
        {
            var choiceBox = new PictureBox()
            {
                Location = new Point(798, 375),
                Width = 308,
                Height = 308,
                BackgroundImage = Texture.ChoiceBox,
                Visible = false,
            };
            Controls.Add(choiceBox);
            ChoiceBox = choiceBox;
        }

        private void SetTotemPanel()
        {
            SetOfferingCells();
            var totemPanel = new PictureBox()
            {
                Location = new Point(404, 277),
                BackColor = Color.Transparent,
                Image = Texture.TotemPanel,
                Width = 700,
                Height = 642,
            };
            TotemPanel = totemPanel;
            Controls.Add(TotemPanel);
        }

        private void SetUpperNamePanel()
        {
            var namePanel = new Label()
            {
                Location = new Point(122, 68),
                Width = 924,
                Height = 114,
                BackgroundImage = Texture.UpperNamePanel,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 48, FontStyle.Bold),
                Text = "ПОДНОШЕНИЯ"
            };
            UpperNamePanel = namePanel;
            Controls.Add(UpperNamePanel);
        }

        private void SetTotemPicture()
        {
            var totem = new PictureBox()
            {
                Location = new Point(1145, 10),
                BackgroundImage = Texture.Totem,
                Width = 736,
                Height = 1070,
                BackColor = Color.Transparent,
            };
            Totem = totem;
            Controls.Add(Totem);
        }

        private void SetOfferingCells()
        {
            for (var i = 0; i < OfferingCells.Length; i++)
            {
                var index = i;
                var box = new Label()
                {
                    Location = SetOfferingCellsPosition(index, 157),
                    Width = 157,
                    Height = 157,
                    BackgroundImage = Texture.OfferingCell,
                    TextAlign = ContentAlignment.BottomRight,
                    ForeColor = Color.White,
                    Font = new Font(string.Empty, 16, FontStyle.Bold),
                };
                OfferingCells[index] = box;
                Controls.Add(OfferingCells[index]);
            }    
        }

        private void SetBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(68, 609),
                BackgroundImage = Texture.TotemBackButton,
                Width = 308,
                Height = 308,
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.MainScreenForm.Show();
                Hide();
            };
            BackButton = backButton;
            Controls.Add(BackButton);
            BackButton.BringToFront();
        }

        private void SetAscendButton()
        {
            var ascendButton = new Button()
            {
                Location = new Point(68, 277),
                BackgroundImage = Texture.AscendButton,
                Width = 308,
                Height = 308,
                Enabled = false,
            };
            ascendButton.Click += (sender, eventArgs) =>
            {   
                ChangeVisibilityState(true);
            };
            AscendButton = ascendButton;
            Controls.Add(AscendButton);
        }

        private Point SetOfferingCellsPosition(int number, int buttonSize)
        {
            var xposOffset = number % 3;
            var yposOffset = number / 3;
            var xpos = 461 + (buttonSize + 57) * xposOffset;
            var ypos = 396 + (buttonSize + 57) * yposOffset;
            return new Point(xpos, ypos);
        }

        private void ShowOffering()
        {
            var offering = Game.AscendingSystem.CurrentResources;
            var inventory = Game.Inventory;
            for (var i = 0; i < offering.Length; i++)
            {
                var index = i;
                var resource = offering[index];
                OfferingCells[index].Image = resource.ImagePath;
                OfferingCells[index].BackgroundImage = Texture.CraftCell2;
                OfferingCells[index].Text = inventory.AmountOf(resource).ToString() + " / " + resource.Amount.ToString();
            }
        }

        private void ChangeAscendButtonState(bool state)
        {
            AscendButton.Enabled = state;
            if (state)
                AscendButton.BackgroundImage = Texture.AscendButton2;
            else 
                AscendButton.BackgroundImage = Texture.AscendButton;
        }

        private void ChangeVisibilityState(bool state)
        {
            TotemPanel.Visible = !state;
            UpperNamePanel.Visible = !state;
            BackButton.Visible = !state;
            AscendButton.Visible = !state;
            Totem.Visible = !state;
            foreach(var cell in OfferingCells)
                cell.Visible = !state;
            LeftChoiceButton.Visible = state;
            RightChoiceButton.Visible = state;
            ChoiceBox.Visible = state;
            BlessingNamePanel.Visible = state;
        }

        private void ChangeBlessingChoiceButtons()
        {
            SetLeftChoiceButton();
            SetRightChoiceButton();
            LeftChoiceButton.Update();
            RightChoiceButton.Update();
        }

        private void ChoiceButton_OnClick(Action blessingChanges)
        {
            blessingChanges();
            Game.AscendingSystem.Ascend();
            ChangeVisibilityState(false);
            ChangeBlessingChoiceButtons();
            ShowOffering();
        }
    }
}
