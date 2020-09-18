using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave9._5
{
    public partial class Form1 : Form
    {
        int[] testArray = { 2, 3, 5, 7, 1, 44, 7 }; // making it global, cause were using it twice.
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < testArray.Length; i++) // listing the array
                listBox1.Items.Add(testArray[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testArray.Max(); // this could actually accomplish the same as below.
            int max = 0;
            
            for (int i = 0; i < testArray.Length; i++) // running through the length of the array
            {
                if (testArray[i] > max) // checking for each spot in the array if its bigger than 'max'
                {
                    max = testArray[i]; // if true change max to the spot in the array that we got to.
                }
            }
            label1.Text = Convert.ToString(max); // write out the max value
        }
    }
}
