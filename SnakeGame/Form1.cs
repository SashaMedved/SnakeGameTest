namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private int _width = 496;
        private int _height = 700;
        public int _sizePlane = 20;
        private View view;
        private Controller controller;
        private Model model;
        public Form1()
        {
            InitializeComponent();

            model = new Model(this);
            controller = new Controller(model);
            view = new View();

            this.Width = _width;
            this.Height = _height;

            Start();

            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(controller.CheckKey);
            
            GamePad();
        }

        public void Start()
        {
            model.StartProgram(this);
            view.CreateMap(this, _width, _height, _sizePlane);

            timer.Tick += new EventHandler(model.SnakeMove);
            timer.Interval = 500;
            timer.Start();
        }

        public void GamePad()
        {
            //buttonRight.Click += (sender, args) => controller.CheckKey(sender, "Right");
            //buttonLeft.Click += (sender, args) => controller.CheckKey(sender, "Left");
            //buttonUp.Click += (sender, args) => controller.CheckKey(sender, "Up");
            //buttonDown.Click += (sender, args) => controller.CheckKey(sender, "Down");
        }

        protected override void OnFormClosing(FormClosingEventArgs eventArgs)
        {
            var result = MessageBox.Show("�� ������������� ������� ������� ����?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                eventArgs.Cancel = true;
        }
    }
}
