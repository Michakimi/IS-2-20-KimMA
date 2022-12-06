using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        accessories vasya;
        public class accessories
        {
            public int Price;
            public string Yearofissue;

            public accessories(int Price, string Yearofissue)
            {
                this.Price = Price;
                this.Yearofissue = Yearofissue;

            }
            public void Display()
            {
                MessageBox.Show($"Цена: {Price},Годвыпуска{Yearofissue}");

            }
        }
        public class HDD : accessories
        {
            public int rmp;
            public string Interface;
            public int volume;
            public HDD(int Price, string Yearofissue, int rmp, string Interface, int volume) : base(Price, Yearofissue)
            {
                this.rmp = rmp;
                this.Interface = Interface;
                this.volume = volume;
            }
            public new void Display()
            {
                MessageBox.Show($"Скорость шпинделя : {rmp},{Interface},{volume}");
            }
            public class GPU : accessories
            {
                public int frequency;
                public string manufacture;
                public int capacitymemory;
                public GPU(int Price, string Yearofissue, int frequency, string manufacture, int capacitymemory) : base(Price, Yearofissue)
                {
                    this.frequency = frequency;
                    this.manufacture = manufacture;
                    this.capacitymemory = capacitymemory;
                }
                public new void Display()
                {
                    MessageBox.Show($"параметры видеокарты : {frequency},{manufacture},{capacitymemory}");


                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            string b = textBox2.Text;
            listBox1.Items.Add(a);
            listBox1.Items.Add(b);







            vasya = new accessories(a, b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vasya.Display();
        }
    }
}