  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;
namespace Zoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Price_Click(object sender, EventArgs e)
        {
            Menu_Click(null, null);
            Adult_text.Visible = true;
            child_text.Visible = true;
            Adult_price.Visible = true;
            Price_child.Visible = true;
            Price_lock.Visible = true;
            save.Visible = true;
            load.Visible = true;
        }
        private void Map_Click(object sender, EventArgs e)
        {
            Menu_Click(null, null);
            map_pic.Visible = true;
            map_pic.BringToFront();

        }
        private void Menu_Click(object sender, EventArgs e)
        {
            //hide map
            map_pic.Visible = false;
            //hide price
            Adult_text.Visible = false;
            child_text.Visible = false;
            Adult_price.Visible = false;
            Price_child.Visible = false;
            Price_lock.Visible = false;
            save.Visible = false;
            load.Visible = false;   
        }
        private void Price_lock_Click(object sender, EventArgs e)
        {
            if (Adult_price.ReadOnly == true)
            {
                Adult_price.ReadOnly = false;
                Price_child.ReadOnly = false;
            }
            else
            {
                Adult_price.ReadOnly = true;
                Price_child.ReadOnly = true;
            }
        }
        private void Animals_Click(object sender, EventArgs e)
        {
            Menu_Click(null, null);
            Animal_list popup = new Animal_list();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();

        }
        private void Adult_price_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void Price_child_ValueChanged(object sender, EventArgs e)
        {
          
        }
        private void save_Click(object sender, EventArgs e)
        {

            //will save money price change
            TextWriter txt = new StreamWriter("C:\\Users\\33344\\OneDrive\\Desktop\\rotem's project\\Zoo\\Zoo\\Resources\\Prices.txt");
            txt.Write(Adult_price.Value);
            txt.Write("\n");
            txt.Write(Price_child.Value);
            txt.Close();
        }
        private void load_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\33344\OneDrive\Desktop\rotem's project\Zoo\Zoo\Resources\Prices.txt");
        
              decimal price_adult = Convert.ToDecimal(lines[0]);
              Adult_price.Value = price_adult;
            decimal price_childS = Convert.ToDecimal(lines[1]);
            Price_child.Value = price_childS;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
 
            
        }
        //polymorphisam trial
        string fun_fuc(Lions s)
        {
            string fuct = ("the only cats that live in groups!");
            return fuct;
        }
        string fun_fuc(Elephants s)
        {
            string fuct = ("they are the largest land animal!");
            return fuct;
        }
        string fun_fuc(Peacocks s)
        {
            string fuct = ("Peacocks take three years to develop their tail plumage!");
            return fuct;
        }
        string fun_fuc(Alligator s)
        {
            string fuct = ("They Can't Survive in Salt Water!");
            return fuct;
        }
        private void fun_fuc_display_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox_test_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox_test.Text;
            if(type == "Lion")
            {
                Lions s = new Lions();
                fun_fuc_display.Text = fun_fuc(s);

            }
            else if(type == "Elephant")
            {
                Elephants s = new Elephants();
                fun_fuc_display.Text = fun_fuc(s);
            }
            else if(type=="Peacock")
            {
                Peacocks s = new Peacocks();
                fun_fuc_display.Text = fun_fuc(s);
            }
            else if(type =="Alligator")
            {
                Alligator s = new Alligator();
                fun_fuc_display.Text = fun_fuc(s);
            }
        }
    }  
}

