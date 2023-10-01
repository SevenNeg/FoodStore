using System.Text;
using Newtonsoft;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.InteropServices.ComTypes;

namespace Snapfoodsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TypeCombobox.DataSource = Enum.GetValues(typeof(StoreType));
        }

        private void Addingbutton_Click(object sender, EventArgs e)
        {
            List<Restaurant> First_ones = new List<Restaurant>();

            First_ones.Add(new Restaurant { Name = "Vanilla", sort_options = "Will be added" });
            First_ones.Add(new Restaurant { Name = "Rasberry", description = "Will be added" });

            string json = JsonSerializer.Serialize(First_ones);
            //File.WriteAllText(@"C:\Users\NoteBook\Desktop\PR\Classes\Snapfoodsystem\initiale_data.json", json);


            if (string.IsNullOrEmpty(nametextbox.Text) || string.IsNullOrEmpty(Descriptiontextbox.Text) || string.IsNullOrEmpty(opensattextBox.Text) || string.IsNullOrEmpty(LongtextBox.Text) || string.IsNullOrEmpty(FullADdresstxt.Text))
            {
                MessageBox.Show("Don't keep any box blank");
                return;
            }



            //Number_Cheking.Cellphone_checking(TelephoneTxt.Text);


            Number_Cheking.IsNumber(LattextBox.Text, "Latitude");
            Number_Cheking.IsNumber(LongtextBox.Text, "Longitude");
            Number_Cheking.IsNumber(opensattextBox.Text, "Opening hours");
            if (Number_Cheking.IsNumber(opensattextBox.Text, "Opening hours") && Number_Cheking.IsNumber(LongtextBox.Text, "Longitude") && Number_Cheking.IsNumber(LattextBox.Text, "Latitude"))
            {
                if (do_or_does.Checked)
                {

                    takeaway_rules newform = new takeaway_rules();
                    this.Hide();
                    newform.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("The restaurant's information is Added Succesfully");
                }
            }




            //StreamWriter file = new StreamWriter(@"")
            //string fileP = @"Pictures";
            //if (File.Exists(fileP))
            //{
            //    File.Delete(fileP);
            //}

            //using (FileStream fs = File.Create(fileP))
            //{

            //    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
            //    fs.Write(title, 0, title.Length);
            //    byte[] author = new UTF8Encoding(true).GetBytes("New User");
            //    fs.Write(author, 0, author.Length);
            //}

        }


    }

}
