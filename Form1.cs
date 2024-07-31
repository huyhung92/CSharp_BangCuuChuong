namespace CSharp_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bcc_TextChanged(object sender, EventArgs e)
        {
            bcc.Text = number.Value.ToString();
        }

        private void number_ValueChanged(object sender, EventArgs e)
        {
            bcc.Text = number.Value.ToString();
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(bcc.Text);
            for (int i = 1; i <= 10; i++)
            {
                kq.Text += Environment.NewLine + a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString();
                listBox1.Items.Add(a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            kq.Text = "";
            if (rbo1.Checked)
            {
                int a = 1;
                for (int i = 1; i <= 10; i++)
                {
                    kq.Text += Environment.NewLine + a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString());
                }
            }
            listBox1.Items.Clear();
            kq.Text = "";
            if (rbo2.Checked)
            {
                int a = 2;
                for (int i = 1; i <= 10; i++)
                {
                    kq.Text += Environment.NewLine + a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString());
                }
            }
            listBox1.Items.Clear();
            kq.Text = "";
            if (rbo3.Checked)
            {
                int a = 3;
                for (int i = 1; i <= 10; i++)
                {
                    kq.Text += Environment.NewLine + a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString());
                }
            }
            listBox1.Items.Clear();
            kq.Text = "";
            if (rbo4.Checked)
            {
                int a = 4;
                for (int i = 1; i <= 10; i++)
                {
                    kq.Text += Environment.NewLine + a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString());
                }
            }
        }
        private void kiemtraRDO(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            kq.Text = "";
            RadioButton r = (RadioButton)sender;

            int a = Convert.ToInt32(r.Text);
            for (int i = 1; i <= 10; i++)
            {
                kq.Text += Environment.NewLine + a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString();
                listBox1.Items.Add(a.ToString() + " x " + i.ToString() + " = " + (a * i).ToString());
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            bcc.Text = trackBar1.Value.ToString();
        }
    }
}   


