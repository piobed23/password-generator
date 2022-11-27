using System;
using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            listBox1.Items.Add(GeneratePassword((int)numericUpDown1.Value)); 
        }

        public StringBuilder GeneratePassword(int passwordLenght)
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.@#$%&!";

            StringBuilder newPassword = new StringBuilder();

            Random random = new Random();

            do
            {  
                newPassword.Append(characters[random.Next(characters.Length)]);                     
            }
            while (newPassword.Length<passwordLenght);

            return newPassword;
        }

       

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(listBox1.Items.Count>0)
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}