namespace WinForm_BT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCreate.Click += new EventHandler(btn_Click);
        }
        void btn_Click(object sender, EventArgs e)
        {
            int cot, dong;
            if (!int.TryParse(txtCot.Text, out cot))
            {
                cot = 0;
            }
            if (!int.TryParse(txtDong.Text, out dong))
            {
                dong = 0;
            }
            cot = int.Parse(txtCot.Text);
            dong = int.Parse(txtDong.Text);
            Form2 frm2 = new Form2(dong, cot);
            frm2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}