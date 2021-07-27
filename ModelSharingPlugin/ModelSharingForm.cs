using System;
using System.Windows.Forms;
using Tekla.Structures.Dialog;

namespace ModelSharingPlugin
{
    public partial class ModelSharingForm : PluginFormBase
    {
        public ModelSharingForm()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=:memory:;Version=3;New=True";
            using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                MessageBox.Show(System.Data.SQLite.SQLiteConnection.SQLiteVersion);

                connection.Open(); // here it will crash
            }
        }
    }
}
