namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public PictureBox[] snakeBody = new PictureBox[400];
        public int score = 0;

        public int _width = 496;
        public int _height = 700;
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

            snakeBody[0] = new PictureBox();
            snakeBody[0].Location = new Point(200, 200);
            snakeBody[0].Size = new Size(_sizePlane, _sizePlane);
            snakeBody[0].Image = Properties.Resources.snakeHead;
            snakeBody[0].BackColor = Color.Transparent;
            this.Controls.Add(snakeBody[0]);

            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(controller.Form1_KeyDown);
            
            GamePad();

            model.CreateFood();
        }

        public void Start()
        {
            model.StartProgram();
            view.CreateMap(this, _width, _height, _sizePlane);

            timer.Tick += new EventHandler(model.SnakeMove);
            timer.Interval = 250;
            timer.Start();
        }

        public void GamePad()
        {
            buttonRight.Click += (sender, args) => controller.CheckKey(sender, "D");
            buttonLeft.Click += (sender, args) => controller.CheckKey(sender, "A");
            buttonUp.Click += (sender, args) => controller.CheckKey(sender, "W");
            buttonDown.Click += (sender, args) => controller.CheckKey(sender, "S");
            buttonExit.Click += (sender, args) => controller.buttonEXIT_Click(this, sender, args);
        }

        protected override void OnFormClosing(FormClosingEventArgs eventArgs)
        {
            var result = MessageBox.Show("¬ы действительно хотиите закрыть игру?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                eventArgs.Cancel = true;
        }
    }
}
