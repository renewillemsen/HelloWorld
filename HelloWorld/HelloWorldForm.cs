﻿using System;
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

        private void btnSqlite_Click(object sender, EventArgs e)
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
