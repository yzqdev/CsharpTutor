using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csconsoletest2
{
    public partial class Diedai : Form
    {
        public Diedai()
        {
            InitializeComponent();
        }

        private void Diedai_Load(object sender, EventArgs e)
        {
            Banks banks = new Banks();
            //
            foreach (string str in banks)
            {
                textBox1.Text += str + "\n";
            }
        }
    }

    public class Banks : IEnumerable
    {
        //
        private string[] strArray = { "中国银行", "工商银行", "农业银行", "建设银行" };

        //
        public IEnumerator GetEnumerator()
        {
            //
            for (int i = 0; i < strArray.Length; i++)
            {
                //
                yield return strArray[i];
            }
        }
    }
}