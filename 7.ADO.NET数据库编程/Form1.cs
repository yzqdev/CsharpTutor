using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;database=mydb;Intergrated Security=True";
                con.Open();
                MessageBox.Show("已经建立了链接", "正确连接");
                con.Close();
            }
            catch (SqlException SQL)
            {
                MessageBox.Show(SQL.Message, "连接失败!");
            }
            finally
            {
                MessageBox.Show("对不起啊");
            }
        }
    }
}