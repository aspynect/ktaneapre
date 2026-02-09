namespace ktaneapre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void profile2_ProfileChanged(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in this.tabControl1.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is not Reloadable reloadableControl) continue;
                    reloadableControl.reload();
                }
            }
            
        }
    }
}
