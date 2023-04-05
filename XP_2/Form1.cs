using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            radioButton1.Checked = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }
        Hrac hrac;
        NPC npc;
        private void button1_Click(object sender, EventArgs e)
        {
            hrac = new Hrac(textBox1.Text, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex);
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hrac.PridejXp((int)numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = hrac.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hrac.ZmenaPozice1();
            hrac.ZmenaPozice2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) npc = new NPC(textBox2.Text, (int)comboBox4.SelectedIndex, true);
            else npc = new NPC(textBox2.Text, (int)comboBox4.SelectedIndex);
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = npc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            npc.ZmenaPozice1();
            npc.ZmenaPozice2();
        }
    }
}
