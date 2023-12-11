namespace WinForms_BTap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void selectedIndexChanged(object sender, EventArgs e)
        {
            float so1, so2;
            if (!float.TryParse(textBox1.Text, out so1))
            {
                so1 = 0;
            }
            if (!float.TryParse(textBox2.Text, out so2))
            {
                so2 = 0;
            }
            switch ((sender as Control).Text)
            {
                case "+":
                    lblResult.Text = (so1 + so2).ToString();
                    break;
                case "-":
                    lblResult.Text = (so1 - so2).ToString();
                    break;
                case "x":
                    lblResult.Text = (so1 * so2).ToString();
                    break;
                case "/":
                    if (so2 == 0)
                    {
                        so2 = 1;
                    }
                    lblResult.Text = (so1 / so2).ToString();
                    break;
            }
        }
    }
}