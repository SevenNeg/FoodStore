using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Snapfoodsystem
{
    public partial class takeaway_rules : Form
    {
        public takeaway_rules()
        {
            InitializeComponent();
        }


        private void donebutton_Click(object sender, EventArgs e)
        {
            Restaurant takeaway = new Restaurant();
            takeaway.CartPrice = Min_items_textbox.Text;

            if (string.IsNullOrEmpty(Min_items_textbox.Text) || string.IsNullOrEmpty(ExceptionDisTxt.Text))
            {
                MessageBox.Show("Don't keep any box blank");
                return;
            }
            int cartprice;
            bool number = int.TryParse(Min_items_textbox.Text, out cartprice);
            if (number == false)
            {
                MessageBox.Show("Insert a valid number for Price");
                return;
            }
        }

        private void CopyDirectButton_Click(object sender, EventArgs e)
        {
            string source = @"C:\Users\NoteBook\Documents\source\";
            string destination = @"C:\Users\NoteBook\Documents\copyto\";
            if (File.Exists(destination))
            {
                File.Delete(destination);
            }
            File.Copy(source + "Sourcetext.txt", destination + "NewtxtFile");

            if (File.Exists(destination))
            {
                MessageBox.Show("Your informatinon has been copied");
            }

        }

        private void SaveInfButton_Click(object sender, EventArgs e)
        {
            List<Restaurant> Clients = new List<Restaurant>();


            Clients.Add(new Restaurant { CartPrice = Min_items_textbox.Text, sort_options = domainUpDown1.Text, Exceptions = ExceptionDisTxt.Text, URL = URLTxt.Text });

            string json = JsonSerializer.Serialize(Clients);
            File.WriteAllText(@"C:\Users\NoteBook\Desktop\PR\Classes\Snapfoodsystem\Adding_data.json", json);


        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }
    }
}
