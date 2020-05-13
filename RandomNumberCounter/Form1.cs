using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random myRand = new Random();

        private void btn_cal_num_Click(object sender, EventArgs e)
        {
            int[] myArray = new int[101];
            textBox1.Clear();
            int randomCount = 1;
            int randomStorage = 1;
            textBox1.Text = "Random Number \t Frequency" + Environment.NewLine;

            while (randomCount < 101)
            {
                randomStorage = myRand.Next(1, 101);
                myArray[randomStorage] = myArray[randomStorage] + 1;
                randomCount++;
            }

            for (int i = 0; i < 101; i++)
            {
                if (myArray[i] != 0)
                {
                    textBox1.Text += i + "\t" + "\t" + myArray[i].ToString() + Environment.NewLine;
                }
                i++;
            }
        }
    }
}
