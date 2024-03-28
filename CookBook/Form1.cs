namespace CookBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_greet_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = tb_firstname.Text;
                string lastname = tb_lastname.Text;                

                MessageBox.Show("Hello " + firstname + " " + lastname + "");
            }
            catch(Exception a)
            {
                MessageBox.Show("Error while greeting" + a);
            }
        }
    }
}
