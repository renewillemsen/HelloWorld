using System;
using System.Windows.Forms;
using Tekla.Structures.Dialog;

namespace HelloWorld
{
    public partial class HelloWorldForm : PluginFormBase
    {
        private static bool _started = false;

        public HelloWorldForm()
        {
            if (!_started)
            {
                _started = true;
                return;
            }

            InitializeComponent();

            if (_started)
            {
                MessageBox.Show("Hello Constructor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}
