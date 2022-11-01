namespace LoginScreen
{
    public partial class txtKullaniciAdi : Form
    {
        public txtKullaniciAdi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtUser.Text =="aysuiremçaylak" && txtSifre .Text =="aysu123")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tekrar Deneyin.");
                txtSifre.Clear();
                txtUser.Clear();
                txtUser.Focus();
            }
        }
    }
}