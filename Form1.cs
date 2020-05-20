using com.Keys.SetKey.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.Keys.SetKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<String> myList = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateMethod1 generateMethod = new GenerateMethod1();
            foreach (var a in textBox1.Text)
            {
                myList.Add(a.ToString());

            }

            InterfaceManager manager = new InterfaceManager(generateMethod,new Basic(),myList.ToArray());
            richTextBox1.Text = manager.GeneratePassword();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
