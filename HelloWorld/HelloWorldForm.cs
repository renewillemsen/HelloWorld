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

        private void btnSqlite_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=:memory:;Version=3;New=True";
            using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                connection.Open(); // here it will crash
            }
        }
    }
}
