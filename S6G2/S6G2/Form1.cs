using System;
using System.Windows.Forms;

namespace S6G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add a button dynamically
            Button insertButton = new Button();
            insertButton.Text = "Insert Data";
            insertButton.Width = 100;
            insertButton.Height = 30;
            insertButton.Top = 20;
            insertButton.Left = 20;
            insertButton.Click += InsertButton_Click;

            this.Controls.Add(insertButton);
        }

        // Event handler for button click
        private void InsertButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper.InsertTestData();
        }

        // Optional: Form Load event (can be empty)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to run when form loads
        }
    }
}
