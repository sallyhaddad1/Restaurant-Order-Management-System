using Ass2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ass2
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
        }
        string ingrediant;
        string Beef , chieken , kids;
        string GrillHarley, WhiteMushroom, maxican , happy;
        string Papper , Onions , Paprika , Cheese;
        string sandwish ,meal;
        int quantity;
        double total , price;

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex == 0)
            {
                GrillHarley = "Grill Harley";
            }
            else if (listBox1.SelectedIndex == 1)
            {
                WhiteMushroom = "White Mushroom";
            }
            else if (listBox1.SelectedIndex == 2)
            {
                maxican = "Maxican";
            }
            else if (listBox1.SelectedIndex == 3)
            {
                happy = "Happy Meal";
            }
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "GIF |*.gif|PNG |*.png|JPEG |*.jpeg|JPG|*.jpg";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image= Image.FromFile(openFileDialog.FileName);
            }
        }

        private void bSaveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "GIF |*.gif|PNG |*.png|JPEG |*.jpeg|JPG|*.jpg";
            saveFileDialog.FileName = "NewImage";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog.FileName);
            } 
            }
            else
            { MessageBox.Show("Please enter an image"); }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:\tSamer Salam Haddad \n Id:\t152564");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch(index) 
            {
                    case 0:
                    {  Beef = "Beef";
                        comboBox2.Enabled = true;
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Grill Harley");
                        listBox1.SelectedItem = GrillHarley;
                        listBox1.Items.Add("White Mushroom");
                        listBox1.SelectedItem = WhiteMushroom;
                        listBox1.Items.Add("Maxican");
                        listBox1.SelectedItem = maxican;
                        comboBox2.Text = "Choose Meal / Sandwish";
                        break;
                    }
                    case 1:
                    { chieken = "Chieken";
                        comboBox2.Enabled = true;
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Grill Harley");
                        listBox1.SelectedItem = GrillHarley;
                        listBox1.Items.Add("White Mushroom");
                        listBox1.SelectedItem = WhiteMushroom;
                        listBox1.Items.Add("Maxican");
                        listBox1.SelectedItem = maxican;
                        comboBox2.Text = "Choose Meal / Sandwish";

                        break;
                    }
                    case 2:
                    {  kids = "kids";
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Happy Meal");
                        listBox1.SelectedIndex = 0;
                        comboBox2.Enabled = false;
                        comboBox2.Text = "Happy Meal";
                        break;
                    }

            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            
        }
        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace (textBox3.Text) )
            {
                MessageBox.Show("CLEAR ");
            }
           else if (!IsNumeric(textBox3.Text))
            {
                MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox3.Clear();
            }
            else 
            {
                 quantity = int.Parse(textBox3.Text);

                if (quantity < 0)
                {
                    MessageBox.Show("Enter positive quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox3.Clear();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            switch (index)
            {
                case 0:
                    {
                        meal = "Meal";
                        break;
                    }
                case 1:
                    {
                        sandwish = "Sandwish";
                        break;
                    }
                default:
                   
                    break;
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    label1.ForeColor = Color.Green;
                    break;
                case 2:
                    label1.ForeColor = Color.Red;
                    break;
                case 3:
                    label1.ForeColor = Color.Purple;
                    break;
                default:
                    label1.ForeColor = SystemColors.ControlText;
                    break;
            }
            string imagePath = @"C:\Users\samer\OneDrive\Desktop\ass2\Ass2\Resources\";

            switch (randomNumber)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(Path.Combine(imagePath, "burger.jpg")); 
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(Path.Combine(imagePath, "burger1.jpg"));
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(Path.Combine(imagePath, "burger2.jpg"));
                    break;
                default:
                    pictureBox1.Image = Image.FromFile(Path.Combine(imagePath, "burger.jpg")); ;
                    break;
            }
        }
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

        }

        private void printOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing type");
                return;
            }
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing flavour");
                return;
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Missing ingrediants");
                return;
            }
            if (textBox3.Text==null )
                {
                    MessageBox.Show("Missing quantity");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Missing name");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Missing phone number");
                    return;
                }
                if (!IsNumeric(textBox3.Text))
                {
                    MessageBox.Show("Invalid Format");
                    return;
                }

                quantity = int.Parse(textBox3.Text);
                if (quantity < 0)
                {
                    MessageBox.Show("Enter positive quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    ingrediant += item.ToString() + "+";
                }
                if (!string.IsNullOrEmpty(ingrediant))
                {
                    ingrediant = ingrediant.Remove(ingrediant.Length - 2);
                }
             string selected = comboBox2.Text;

            total = CalculatePrice(comboBox1.SelectedItem.ToString(), listBox1.SelectedItem.ToString(), selected, quantity);

            dataGridView1.Rows.Add(textBox1.Text, DateTime.Now, comboBox1.SelectedItem.ToString(), listBox1.SelectedItem.ToString(), ingrediant, selected, quantity, total + " JD", textBox2.Text);

                MessageBox.Show("Order entered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ingrediant = "";
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private double CalculatePrice(string type, string flavor, string option, int quantity)
        {
            double beefPrice = 0.0;
            double chickenPrice = 0.0;
            double happyMealPrice = 2.5;
            
            if (type == "Beef")
            {
                switch (flavor)
                {
                    case "Grill Harley":
                        beefPrice = (option == "Meal") ? 6.75 : 6.0;
                        break;
                    case "White Mushroom":
                        beefPrice = (option == "Meal") ? 5.75 : 5.0;
                        break;
                    case "Maxican":
                        beefPrice = (option == "Meal") ? 5.25 : 4.75;
                        break;
                    default:
                        break;
                }
            }

            if (type == "Chicken")
            {
                switch (flavor)
                {
                    case "Grill Harley":
                        chickenPrice = (option == "Meal") ? 5.75 : 4.75;
                        break;
                    case "White Mushroom":
                        chickenPrice = (option == "Meal") ? 4.75 : 4.25;
                        break;
                    case "Maxican":
                        chickenPrice = (option == "Meal") ? 4.25 : 4.00;
                        break;
                    default:
                        break;
                }
            }
            if (type == "Kids")
            {
                switch (flavor)
                {
                    case "Happy Meal":
                          chickenPrice = 2.5;
                            break;
                    default:
                        break;
                }
            }

            total = quantity * (beefPrice + chickenPrice + happyMealPrice);

            return total;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            switch (index)
            {
                case 1:
                    {
                        Papper = "Papper";
                        break;
                    }
                case 2:
                    {
                        Onions = "Onions";
                        break;
                    }
                case 3:
                    {
                        Paprika = "Paprika";
                        break;
                    }
                case 4:
                    {
                        Cheese = "Cheese";
                        break;
                    }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)c).Clear();
                }
                else if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }
        private void ResetFlavorListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Grill Harley");
            listBox1.Items.Add("White Mushroom");
            listBox1.Items.Add("Maxican");

        }
        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);

            comboBox1.Text="Choose Type" ;
          

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }


           // listBox1.Items.Clear();

            total = 0;


            comboBox2.Text = "Choose Meal / Sandwish";
            comboBox2.Enabled = true;


            ResetFlavorListBox();

            textBox3.Text = "";

            MessageBox.Show("CLEAR");
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }
    }
}
