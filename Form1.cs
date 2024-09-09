namespace CSharp_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(int.Parse(txt_n.Text));
            string kq = "";
            foreach (int i in list)
            {
                kq += i.ToString() + " ";
            }
            txt_nhap.Text = kq;
            txt_n.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int i in list)
            {
                if (i % 2 != 0)
                {
                    txt_le.Text += i.ToString() + " ";
                }

            }
        }
        public bool ktraSNT(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach(int i in list)
            {
                if(ktraSNT(i))
                {
                    txt_SNT.Text += i.ToString()+ " ";
                }    
            }    
        }
    }
}
