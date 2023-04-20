using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame
{
    public partial class GameForm
    {
        private static Label GameTimer;
        private static List<Button> fieldButtons = new List<Button>();
        private void InitializeForm()
        {
            SetFormBaseParameteres();
            SetGenerationTimer();
            SetFieldButtons(Game.field);
        }
        private void SetFormBaseParameteres()
        {
            SuspendLayout();
            Load += MainForm_Load;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.Manual;
            BackgroundImage = Image.FromFile("D:\\GitHub Repository\\UlearnGame\\UlearnGame\\Images\\Background.jpg");
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }
        private void SetGenerationTimer()
        {
            var timer = new Label();
            timer.Width = 230;
            timer.Height = 230;
            timer.Location = new Point(0, Height - timer.Height);
            timer.Text = Game.FieldUpdateRate.ToString();
            timer.BackColor = Color.Transparent;
            timer.ForeColor = Color.Yellow;
            timer.Font = new Font("Arial", 72, FontStyle.Bold);
            GameTimer = timer;
            Controls.Add(GameTimer);
        }
        #region
        private void CustomizeFieldButton(Button button)
        {
            button.Size = new Size(256, 256);
            button.BackgroundImage = Image.FromFile("D:\\GitHub Repository\\UlearnGame\\UlearnGame\\Images\\Terrain.png");
        }
        private void SetFieldButtons(GameField field)
        {
            fieldButtons.Clear();
            for (var i = 0; i < field.FieldCap + 1; i++)
            {
                var button = new Button();
                CustomizeFieldButton(button);
                fieldButtons.Add(button);
            }
            UpdateFieldButtons(fieldButtons);
        }

        private void UpdateFieldButtons(List<Button> buttons)
        {
            for (var i = 0; i < Game.field.FieldCap + 1; i++)
            {
                var index = i;
                buttons[index].Location = SetFieldButtonPosition(index, buttons[index].Width);
                buttons[index].Click += (sender, eventargs) =>
                {
                    var button = sender as Button;
                    var indexofButton = fieldButtons.IndexOf(button);
                    FieldButtonClick(sender, eventargs, indexofButton);
                };
                Controls.Add(buttons[index]);
            }
        }

        private Point SetFieldButtonPosition(int number, int buttonSize)
        {
            var xposOffset = (number) / 2;
            var yposOffset = (number + 1) % 2 > 0 ? 0 : buttonSize / 4 + buttonSize;
            var xpos = 227 + (buttonSize + buttonSize / 4) * xposOffset;
            var ypos = 257 + yposOffset;
            return new Point(xpos, ypos);
        }

        private void FieldButtonClick(object sender, EventArgs e, int fieldCell)
        {
             if (Game.field.UpdateObjectState(Game.ClickPower, fieldCell, Game.inventory))
             {
                var button = sender as Button;
                button.Image = null;
             }
        }
        #endregion
    }
}
