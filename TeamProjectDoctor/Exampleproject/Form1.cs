using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exampleproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            
            SqlCom.SendMessege(580442656, "magaliti", "User1", "aaaasd");
            List<String> temp = new List<string>();
            temp=SqlCom.GetMesseges("User1");
            foreach (string x in temp)
            {
                richTextBox1.Text =Encrypte.Decrypt(temp[0]);
            }
            textBox1.Text = SqlCom.GetAmountM("User1");
        }
        public void test()
        {
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
