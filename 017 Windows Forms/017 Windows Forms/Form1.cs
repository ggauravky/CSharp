using System;
using System.Windows.Forms;

// Namespace
namespace WindowsFormsAllInOne
{
    // Main Program Class
    static class Program
    {
        // Entry point of application
        [STAThread]
        static void Main()
        {
            // Enable modern UI design
            Application.EnableVisualStyles();

            // Set text rendering default
            Application.SetCompatibleTextRenderingDefault(false);

            // Start application with Form1
            Application.Run(new Form1());
        }
    }

    // Main Form Class
    public class Form1 : Form
    {
        // Declare controls globally
        TextBox txtName, txtNum1, txtNum2;
        Button btnGreet, btnAdd;
        Label lblMessage, lblResult;

        // Constructor
        public Form1()
        {
            // Form properties
            this.Text = "All-in-One Windows Form App";
            this.Width = 500;
            this.Height = 400;

            // Attach Form Load Event
            this.Load += new EventHandler(Form_Load);

            // ===== NAME INPUT =====
            txtName = new TextBox();
            txtName.Left = 50;
            txtName.Top = 30;
            txtName.Width = 200;
            txtName.PlaceholderText = "Enter your name";

            // Greet Button
            btnGreet = new Button();
            btnGreet.Text = "Greet";
            btnGreet.Left = 270;
            btnGreet.Top = 30;

            // Attach event
            btnGreet.Click += new EventHandler(GreetUser);

            // Label for greeting
            lblMessage = new Label();
            lblMessage.Left = 50;
            lblMessage.Top = 70;
            lblMessage.Width = 300;

            // ===== CALCULATOR SECTION =====
            txtNum1 = new TextBox();
            txtNum1.Left = 50;
            txtNum1.Top = 120;
            txtNum1.Width = 100;

            txtNum2 = new TextBox();
            txtNum2.Left = 170;
            txtNum2.Top = 120;
            txtNum2.Width = 100;

            // Add Button
            btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Left = 290;
            btnAdd.Top = 120;

            // Attach event
            btnAdd.Click += new EventHandler(AddNumbers);

            // Result Label
            lblResult = new Label();
            lblResult.Left = 50;
            lblResult.Top = 160;
            lblResult.Width = 300;

            // Add all controls to form
            this.Controls.Add(txtName);
            this.Controls.Add(btnGreet);
            this.Controls.Add(lblMessage);
            this.Controls.Add(txtNum1);
            this.Controls.Add(txtNum2);
            this.Controls.Add(btnAdd);
            this.Controls.Add(lblResult);
        }

        // ===== FORM LOAD EVENT =====
        private void Form_Load(object sender, EventArgs e)
        {
            // Runs when form opens
            MessageBox.Show("Application Started Successfully!");
        }

        // ===== GREET BUTTON EVENT =====
        private void GreetUser(object sender, EventArgs e)
        {
            // Get name input
            string name = txtName.Text;

            // Display greeting
            lblMessage.Text = "Hello, " + name + " 👋";
        }

        // ===== ADD BUTTON EVENT =====
        private void AddNumbers(object sender, EventArgs e)
        {
            try
            {
                // Convert input to integer
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);

                // Perform addition
                int sum = num1 + num2;

                // Show result
                lblResult.Text = "Result = " + sum;
            }
            catch (Exception)
            {
                // Handle invalid input
                MessageBox.Show("Please enter valid numbers!");
            }
        }
    }
}