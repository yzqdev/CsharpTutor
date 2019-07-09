using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csform2
{
    public partial class Arrayli : Form
    {
        public Arrayli()
        {
            InitializeComponent();
        }

        private enum Color
        {
            Red, Green, Blue, Yellow
        }

        private int[] intArr = new int[2];
        private bool[] boolArr = new bool[2];
        private char[] charArr = new char[2];
        private string[] stringArr = new string[2];
        private Color[] colorArr = new Color[2];
        private Object[] objectArr = new object[2];

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                listBox1.Items.Add(intArr[i]);
                listBox1.Items.Add(boolArr[i]);
                //listBox1.Items.Add(charArr[i] == 0 "0" : charArr[i].ToString());
                //listBox1.Items.Add(stringArr[i]==null "null);
                listBox1.Items.Add(colorArr[i]);
                //listBox1.Items.Add(objectArr[i] == null "null" : object[i]);
                listBox1.Items.Add("\n");
            }
        }
    }
}