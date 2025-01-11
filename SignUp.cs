using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

        }

        private void InitializeCustomDateTimePicker()
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            start startForm = new start();
            startForm.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.None, // Remove panel border
                BackColor = this.BackColor,    // Match the form's background
               // Set to match DateTimePicker's location
                Size = dateTimePicker1.Size          // Match the DateTimePicker's size
            };

            // Move DateTimePicker inside the panel
            this.Controls.Add(panel); // Add the panel to the form
            panel.Controls.Add(dateTimePicker1); // Move DateTimePicker into the panel
            dateTimePicker1.Dock = DockStyle.Fill; // Fill the panel with the DateTimePicker
        }
    }
}
