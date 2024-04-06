using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Font guno;
        public SoundPlayer sndPlayer;

        public int score = 0;
        public int _width = 496;
        public int _height = 700;
        public int _sizePlane = 20;
        public bool flagMusic;

        private View view;
        private Controller controller;
        private Model model;
        private Form2 form2;
        private Form3 form3;

        public Form1()
        {
            InitializeComponent();

            form3 = new Form3(this);
            form2 = new Form2(this);
            view = new View(this, model);
            model = new Model(this, view);
            controller = new Controller(model, this, view, form2);
            sndPlayer = new SoundPlayer(Properties.Resources.snake);

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

            controller.GamePad();

            StartScreenMenu();
        }

        public void Start()
        {
            model.StartProgram();
            view.CreateMap(_width, _height, _sizePlane);
            timer.Tick += new EventHandler(model.SnakeMove);
            timer.Interval = 250;
        }

        public void Timer()
        {       
            timer.Start();
            
            if (flagMusic == false)
                sndPlayer.PlayLooping();

            buttonStart.Enabled = false;
        }      

        protected override void OnFormClosing(FormClosingEventArgs eventArgs)
        {
            timer.Stop();
            buttonStart.Enabled = true;
            var result = MessageBox.Show("¬ы действительно хотиите закрыть игру?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                eventArgs.Cancel = true;
        }

        public void OpenMenu()
        {
            var form2 = new Form2(this);
            form2.Show();          
            timer.Stop();
            sndPlayer.Stop();
            this.Enabled = false;
        }

        private void LoadFont()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("guno.otf");
            guno = new Font(custom_font.Families[0], 10);
        }

        public void StartScreenMenu()
        {
            var form3 = new Form3(this);
            form3.Show();
            form3.TopMost = true;
            this.Enabled = false;
        }
    }
}
