using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Font guno;

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
            controller = new Controller(model, this, view);

            this.Width = _width;
            this.Height = _height;

            Start();
            
            view.PaintHeadSnake();
            model.CreateFood();

            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(controller.Form1_KeyDown);

            LoadFont();
            buttonStart.Font = guno;
            buttonMenu.Font = guno;

            GamePad();
        }

        public void Start()
        {
            model.StartProgram();
            view.CreateMap(_width, _height, _sizePlane);
        }

        public void Timer()
        {
            timer.Tick += new EventHandler(model.SnakeMove);
            timer.Interval = 250;
            timer.Start();

            SoundPlayer sndPlayer = new SoundPlayer();
            sndPlayer.Stream = Properties.Resources.snake;
            sndPlayer.PlayLooping();

            buttonStart.Enabled = false;
        }

        public void GamePad()
        {
            buttonRight.Click += (sender, args) => controller.CheckKey(sender, "D");
            buttonLeft.Click += (sender, args) => controller.CheckKey(sender, "A");
            buttonUp.Click += (sender, args) => controller.CheckKey(sender, "W");
            buttonDown.Click += (sender, args) => controller.CheckKey(sender, "S");
            buttonExit.Click += (sender, args) => controller.buttonEXIT_Click(sender, args);
            buttonStart.Click += (sender, args) => Timer();
        }

        protected override void OnFormClosing(FormClosingEventArgs eventArgs)
        {
            var result = MessageBox.Show("¬ы действительно хотиите закрыть игру?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                eventArgs.Cancel = true;
        }

        private void LoadFont()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("guno.otf");
            guno = new Font(custom_font.Families[0], 10);
        }
    }
}
