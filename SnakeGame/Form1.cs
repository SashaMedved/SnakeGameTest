namespace SnakeGame
{
    public partial class Form1 : Form
    {
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

            view = new View(this, model);
            model = new Model(this, view);
            controller = new Controller(model, this);

            this.Width = _width;
            this.Height = _height;

            Start();
            
            view.PaintHeadSnake();
            model.CreateFood();

            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(controller.Form1_KeyDown);
            
            GamePad();           
        }

        public void Start()
        {
            model.StartProgram();
            view.CreateMap(_width, _height, _sizePlane);

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
            buttonExit.Click += (sender, args) => controller.buttonEXIT_Click(sender, args);
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
