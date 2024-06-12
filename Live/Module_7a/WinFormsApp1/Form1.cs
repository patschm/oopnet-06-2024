namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ClickMe(object? sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Parent.BackColor = Color.Red;
            b.Parent.Text = "Hoi";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
