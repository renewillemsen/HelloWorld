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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void HelloWorldForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form Shown");
        }
    }
}
