using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model;

namespace UlearnGame.Visual
{
    [System.ComponentModel.DesignerCategory("")]
    public class TutorialScreenForm : Form
    {
        private const string First = "Об игре:\nМир природы настиг дисбаланс. Возьмите на себя роль маленького духа и добейтесь милости божества.\n\n" +
            "Игровая цель:\nДобывайте ресурсы и делайте подношения божеству. Чтобы победить, нужно осуществить 8 подношений.\n\n" +
            "Игровое поле:\nПоле, на котором появляются игровые объекты. У каждого объекта есть прочность, клик по объекту уменьшает его прочность." +
            " Разрушая объект, вы получаете ресурсы.\n\nИгрвой таймер:\nТаймер, ведущий отсчёт обновления поля. После сброса таймера на поле появляется" +
            " объект.";
        private const string Second = "Подношения:\nСобирайте заданный набор ресурсов, чтобы получать благословения. Благословения дают дополнительные" +
            " бонусы. После пожертвования последнего набора ресурсов вы побеждаете в игре.\n\nИгровой опыт:\nЗа разрушение объектов помимо ресурсов" +
            " вы получаете опыт и копите уровень.\n\nСистема навыков:\nВ игре есть дерево улучшений, открывающее новые объекты и облегчающее игру." +
            " Все навыки открываются последовательно начиная с центра в любом направлении и требуют для своего открытия очко навыков. Их можно" +
            " получить при переходе на новый уровень.\n\n";
        private const string Third = "Инвентарь:\nМесто, куда помещаюстя добытые ресурсы. Можно подробнее узнать о их количестве и прочитать описание.\n\n" +
            "Меню персонажа:\nМесто, где вы можете посмотреть на игровую статистику и своего персонажа.\n\nСистема крафтов:\nМесто, где вы можете" +
            " создавать новые ресурсы и преобразовывать одни ресурсы в другие.\n\nИндикаторы:\nНа некоторых кнопках можно заметить два индикатора" +
            " \"✓\" и \"×\", которые указывают на возможность и невозможность выполнения действия соотсветственно.";    
        private Label FirstTutorialPanel;
        private Label SecondTutorialPanel;
        private Label ThirdTutorialPanel;
        private Button BackButton;
        private Label NamePanel;

        public TutorialScreenForm()
        {
            SetFormBaseParameteres();
            InitializeScreen();
        }

        public void SetFormBaseParameteres()
        {
            SuspendLayout();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Load += TutorailForm_Load;
            Width = 1920;
            Height = 1080;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackgroundImage = Texture.Background;
            Name = "Essence of Gathering";
            Text = "Essence of Gathering";
            ResumeLayout(false);
        }

        private void TutorailForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void InitializeScreen()
        {
            SetTutorialPanel(FirstTutorialPanel, First, new Point(256, 56));
            SetTutorialPanel(SecondTutorialPanel, Second, new Point(734, 56));
            SetTutorialPanel(ThirdTutorialPanel, Third, new Point(1213, 56));
            SetNamePanel();
            SetBackButton();
        }

        private void SetTutorialPanel(Label panel, string text, Point location)
        {
            var label = new Label()
            {
                Location = location,
                Image = Texture.TutorialPanel,
                Width = 450,
                Height = 791,
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font(string.Empty, 16, FontStyle.Bold),
                Text = text,
            };
            panel = label;
            Controls.Add(panel);
        }

        private void SetNamePanel()
        {
            var namePanel = new Label()
            {
                Location = new Point(729, 911),
                Width = 462,
                Height = 114,
                BackgroundImage = Texture.UpperShortNamePanel,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 32, FontStyle.Bold),
                Text = "СПРАВКА"
            };
            NamePanel = namePanel;
            Controls.Add(NamePanel);
        }

        private void SetBackButton()
        {
            var backButton = new Button()
            {
                Location = new Point(1534, 915),
                BackgroundImage = Texture.DefaultButton,
                Width = 308,
                Height = 116,
                Text = "НАЗАД",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font(String.Empty, 32, FontStyle.Bold),
            };
            backButton.Click += (sender, eventArgs) =>
            {
                ProgramInitials.ShowScreen("Main");
            };
            BackButton = backButton;
            Controls.Add(BackButton);
        }
    }
}
