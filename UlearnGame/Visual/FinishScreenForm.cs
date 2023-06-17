using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UlearnGame.Model;
using static System.Net.Mime.MediaTypeNames;

namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class FinishScreenForm : Form
    {
        private Label FinishPanel;
        private Button BackButton;
        private Button CloseButton;

        public FinishScreenForm()
        {
            SetFormBaseParameteres();
            InitializeScreen();
        }

        public void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += FinishForm_Load;
            FormClosing += FinishForm_Close;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Texture.Background;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void FinishForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void FinishForm_Close(object sender, EventArgs e)
        {
            ProgramInitials.Screens["Main"].Close();
        }

        private void InitializeScreen()
        {
            SetBackButton();
            SetCloseButton();
            SetFinishPanel();
        }

        private void SetBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(608, 823),
                BackgroundImage = Texture.DefaultButton,
                Width = 308,
                Height = 116,
                Text = "ПРОДОЛЖИТЬ",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 16, FontStyle.Bold),
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.ShowScreen("Main");
                Hide();
            };
            BackButton = backButton;
            Controls.Add(BackButton);
        }

        private void SetCloseButton()
        {
            var closeButton = new Button()
            {
                Location = new Point(1005, 823),
                BackgroundImage = Texture.DefaultButton,
                Width = 308,
                Height = 116,
                Text = "ВЫЙТИ",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 16, FontStyle.Bold),
            };
            closeButton.Click += (sender, eventArgs) =>
            {
                Close();
            };
            CloseButton = closeButton;
            Controls.Add(CloseButton);
        }

        private void SetFinishPanel()
        {
            var label = new Label()
            {
                Location = new Point(610, 304),
                Image = Texture.FinishPanel,
                Width = 700,
                Height = 450,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(string.Empty, 48, FontStyle.Bold),
                Text = "ПОЗДРАВЛЯЕМ!\nИГРА\nПРОЙДЕНА!"
            };
            FinishPanel = label;
            Controls.Add(FinishPanel);
        }
    }
}
