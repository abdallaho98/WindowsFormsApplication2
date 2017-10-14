using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Vector V = new Vector();
        public Vector V2 = new Vector();
        public string Textbox1, Textbox2, Textbox3;
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            string[] fonction = { "+", "-", "/", "*"};
            comboBox1.Items.AddRange(fonction);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Textbox1 = textBox1.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Textbox1 = textBox1.Text;
            try
            {
                V.initiate(Textbox1);
            }catch (VectorNullException nil) {  MessageBox.Show(nil.Message); }
            V.TriezVector();
            textBox1.Text = V.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            Textbox1 = textBox1.Text;
            try
            {
                V.initiate(Textbox1);
            }
            catch (VectorNullException nil) { MessageBox.Show(nil.Message); }
            V.Inverse();
            textBox1.Text = V.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Textbox1 = textBox1.Text;
            double max, min;
            try
            {
                V.initiate(Textbox1);
                max = V.Max();
                min = V.Vecteur.Min();
                textBox2.Text = "MAX :" + max + " MIN :" + min;
            }
            catch (VectorNullException nil) { MessageBox.Show(nil.Message); }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Textbox1 = textBox1.Text;
            try
            {
                V.initiate(Textbox1);
               textBox2.Text= V.Application(comboBox1.Text, Convert.ToDouble(textBox4.Text)).ToString();
            }
            catch (VectorNullException nil) { MessageBox.Show(nil.Message); }
            catch (DivideByZeroException zero) { MessageBox.Show(zero.Message); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           Textbox3 = textBox3.Text;
        }



        private void button2_Click(object sender, EventArgs e)
        {
           
            if ( textBox3.Enabled == false) { textBox3.Enabled = true; }
            else
            {
                try
                {
                    Textbox1 = textBox1.Text;
                    Textbox3 = textBox3.Text;
                    V.initiate(Textbox1);
                    V2.initiate(Textbox3);
                    textBox2.Text = V.Sommet(V2).ToString();
                }
                catch (VectorNullException nil) { MessageBox.Show("Vector Null"); }
                catch (TailleDefferentException taill) {MessageBox.Show("Error:Taille Defferante"); }
            }
        }
      }
} 
