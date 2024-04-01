namespace SnakeGame
{
    public partial class Form1 : Form
    {

        /* параметры */
        private int _width = 496;
        private int _height = 700;
        private int _sizeHead = 20;
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
            view.CreateMap(this, _width, _height, _sizeHead);
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
