using System.Drawing.Text;
using System.Media;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public PictureBox[] snakeBody = new PictureBox[400];
        public int score = 0;

        Font guno;

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
            controller = new Controller(model, this);
            view = new View();


            this.Width = _width;
            this.Height = _height;

            LoadFont();
            buttonStrat.Font = guno;
            buttonMenu.Font = guno;


            snakeBody[0] = new PictureBox();
            snakeBody[0].Location = new Point(200, 200);
            snakeBody[0].Size = new Size(_sizePlane, _sizePlane);
            snakeBody[0].Image = Properties.Resources.snakeHead;
            snakeBody[0].BackColor = Color.Transparent;

            this.Controls.Add(snakeBody[0]);

            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(controller.Form1_KeyDown);

            Start();

            GamePad();

            model.CreateFood();
        }

        public void Start()
        {
            model.StartProgram();
            view.CreateMap(this, _width, _height, _sizePlane);

        }

        public void Timer()
        {
            timer.Tick += new EventHandler(model.SnakeMove);
            timer.Interval = 500;
            timer.Start();
        }

        public void GamePad()
        {
            buttonRight.Click += (sender, args) => controller.CheckKey(sender, "D");
            buttonLeft.Click += (sender, args) => controller.CheckKey(sender, "A");
            buttonUp.Click += (sender, args) => controller.CheckKey(sender, "W");
            buttonDown.Click += (sender, args) => controller.CheckKey(sender, "S");
            buttonExit.Click += (sender, args) => controller.buttonEXIT_Click(sender, args);
            buttonMenu.Click += (sender, args) => controller.buttonMenu_Click(sender, args);
        }
        

        private void LoadFont()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("guno.otf");
            guno = new Font(custom_font.Families[0], 10);
        }

        /*окно подтвержени€ выхода */
        protected override void OnFormClosing(FormClosingEventArgs eventArgs)
        {
            var result = MessageBox.Show("¬ы действительно хотиите закрыть игру?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                eventArgs.Cancel = true;
        }


        /* таймер и музыка */
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Timer();

            SoundPlayer sndPlayer = new SoundPlayer();
            sndPlayer.Stream = Properties.Resources.snake;
            sndPlayer.PlayLooping();
        }

        /* закрытие на esc*/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
