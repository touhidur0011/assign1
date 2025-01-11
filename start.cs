namespace Main
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
            //Application.Run(new SignUp());
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            signInForm.Show();
            this.Hide();
        }
    }
}
