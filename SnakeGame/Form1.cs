using System.Drawing.Text;

namespace SnakeGame
{
    public partial class s : Form
    {

        /* параметры */
        private int _width = 496;
        private int _height = 700;
        public int _sizeHead = 20;
        private View view;
        private Controller controller;
        private Model model;
        public s()
        {
            InitializeComponent();

            model = new Model(this);
            controller = new Controller(model);
            view = new View();

            this.Width = _width;
            this.Height = _height;

            Start();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(controller.CheckKey);

            GamePad();
        }

        public void Start()
        {
            model.StartProgram(this);
            view.CreateMap(this, _width, _height, _sizeHead);

            timer.Tick += new EventHandler(model.SnakeMove);
            timer.Interval = 500;
            timer.Start();
        }

        public void GamePad()
        {
            buttonRight.Click += (sender, args) => controller.GamePadCheck("Right");
            buttonLeft.Click += (sender, args) => controller.GamePadCheck("Left");
            buttonUp.Click += (sender, args) => controller.GamePadCheck("Up");
            buttonDown.Click += (sender, args) => controller.GamePadCheck("Down");
        }

        /* закрывание игра с подтверждением */
        protected override void OnFormClosing(FormClosingEventArgs eventArgs)
        {
            var result = MessageBox.Show("Вы действительно хотиите закрыть игру?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                eventArgs.Cancel = true;
        }
    }
}
