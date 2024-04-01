namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private int _width = 900;
        private int _height = 800;
        public int _sizePlane = 40;
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

            model.StartProgram(this);
            view.CreateMap(this, _width, _height, _sizePlane);

            timer.Tick += new EventHandler(model.SnakeMove);
            timer.Interval = 500;
            timer.Start();

            this.KeyDown += new KeyEventHandler(controller.CheckKey);
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
