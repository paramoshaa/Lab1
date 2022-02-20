namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                button1.BackColor = colorDialog1.Color;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            BackColor = colorDialog1.Color;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}