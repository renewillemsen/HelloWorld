using System;
using System.Windows.Forms;
using Tekla.Structures.Dialog;

namespace HelloWorld
{
    public partial class HelloWorldForm : PluginFormBase
    {
        public HelloWorldForm()
        {
            InitializeComponent();

            MessageBox.Show("Hello Constructor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}
