using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zoo
{
    public partial class Animal_list : Form
    {
        public Animal_list()
        {
            InitializeComponent();
           
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            Lions cl = new Lions();
            cl._name = textBox_name_Lion.Text;
            cl._age = num_age_Lion.Value;
            cl._gender = textBox_gender_Lion.Text;
            cl._roar_volume = roar_lvl.Value;
            string text = String.Join(" ", cl._name, cl._type, cl._age, cl._food, cl._gender,cl._roar_volume);
            Animals.Items.Add(text);
        }
        private void remove_single_Click(object sender, EventArgs e)
        {
            Animals.Items.Remove(Animals.SelectedItem);
        }
        private void count_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Animals.Items.Count.ToString());
        }
        private void roar_lvl_ValueChanged(object sender, EventArgs e)
        {

        }
        private void add_elephant_Click(object sender, EventArgs e)
        {
            Elephants cl = new Elephants();
            cl._name = textBox_name_Elpehant.Text;
            cl._age = elephant_age.Value;
            cl._gender = textBox_gen_elephant.Text;
            cl._len_trunk = numeric_Trunk_len.Value;
            string text = String.Join(" ", cl._name, cl._type, cl._age, cl._food, cl._gender, cl._len_trunk);
            Animals.Items.Add(text);
        }
        private void butt_alligator_Click(object sender, EventArgs e)
        {
            Alligator cl = new Alligator();
            cl._name = textBox_name_alligator.Text;
            cl._age = age_alligator.Value;
            cl._gender = textBox_gen_alligator.Text;
            string text = String.Join(" ", cl._name, cl._type, cl._age, cl._food, cl._gender);
            Animals.Items.Add(text);
        }
        private void butt_pea_Click(object sender, EventArgs e)
        {
            Peacocks cl = new Peacocks();
            cl._name = textBox_name_pea.Text;
            cl._age = age_pea.Value;
            cl._gender = textBox_gen_pea.Text;
            cl._range_tail=pea_len.Value;
            string text = String.Join(" ", cl._name, cl._type, cl._age, cl._food, cl._gender);
            Animals.Items.Add(text);
        }
        private void butt_save_list_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines("C:\\Users\\33344\\OneDrive\\Desktop\\rotem's project\\Zoo\\Zoo\\Resources\\Animal_list.txt", Animals.Items.Cast<string>().ToArray());

        }
        private void butt_load_list_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\33344\OneDrive\Desktop\rotem's project\Zoo\Zoo\Resources\Animal_list.txt");
            foreach(string line in lines)
            {
                Animals.Items.Add(line);
            }
        }
    }
}
