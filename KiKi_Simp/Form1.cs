namespace KiKi_Simp
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //close app
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            createPage create = new createPage(); //go to next page
            create.Show(); //hide this page
            this.Hide();


        }
    }
}
