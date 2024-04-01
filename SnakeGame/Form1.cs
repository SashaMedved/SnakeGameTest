namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private int _width = 900;
        private int _height = 800;
        private int _sizePlane = 40;
        private View view;
        private Controller controller;
        private Model model;
        public Form1()
        {
            InitializeComponent();

            model = new Model();
            controller = new Controller();
            view = new View();

            this.Width = _width;
            this.Height = _height;
            model.StartProgram(this);
            view.CreateMap(this, _width, _height, _sizePlane);
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
