using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            gunaP1.Items.AddRange(new object[] { "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            guna2P2.Items.AddRange(new object[] { "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            guna2P3.Items.AddRange(new object[] { "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            gunaGg1.Items.AddRange(new object[] { "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            guna2Gg2.Items.AddRange(new object[] { "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            guna2Gg3.Items.AddRange(new object[] { "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pf1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pf1.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pf2.Visible = true;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pf3.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pf2.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pf3.Visible = false;
        }

        private void guna2CustomRadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton16.Checked)
            {
                gunaG3.Checked = true; GunaG1.Checked = true; GunaG2.Checked = true;
                gunaGg1.Enabled = true; guna2Gg2.Enabled = true; guna2Gg3.Enabled = true;
                gunaP1.Enabled = true; guna2P2.Enabled = true; guna2P3.Enabled = true;
                pictureBox6.Enabled = true; pictureBox7.Enabled = true; pictureBox8.Enabled = true;
            }
            else
            {
                gunaG3.Checked = false; GunaG1.Checked = false; GunaG2.Checked = false;
                gunaGg1.Enabled = false; guna2Gg2.Enabled = false; guna2Gg3.Enabled = false;
                gunaP1.Enabled = false; guna2P2.Enabled = false; guna2P3.Enabled = false;
                pictureBox6.Enabled = false; pictureBox7.Enabled = false; pictureBox8.Enabled = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = string.Empty;
            guna2TextBox1.Visible = true;
            this.Size = new Size(856, 399);
            guna2GroupBox4.Location = new Point(12, 234);
            guna2GroupBox3.Location = new Point(12, 294);
            guna2GroupBox4.Size = new Size(810, 54);
            guna2GroupBox3.Size = new Size(810, 54);
            guna2GroupBox3.CustomBorderThickness = new Padding(0, 50, 0, 0);
            guna2GroupBox4.CustomBorderThickness = new Padding(0, 50, 0, 0);
            guna2TextBox2.Visible = false;
            guna2TextBox3.Visible = false;
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
            guna2GroupBox2.Size = new Size(810, 94);
            guna2GroupBox2.CustomBorderThickness = new Padding(0, 90, 0, 0);
            guna2Button1.Visible = true;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = string.Empty;
            guna2TextBox2.Visible = true;
            this.Size = new Size(856, 399);
            guna2GroupBox4.Location = new Point(12, 294);
            guna2GroupBox2.Size = new Size(810, 54);
            guna2GroupBox3.Size = new Size(810, 54);
            guna2GroupBox2.CustomBorderThickness = new Padding(0, 50, 0, 0);
            guna2GroupBox3.CustomBorderThickness = new Padding(0, 50, 0, 0);
            guna2TextBox1.Visible = false;
            guna2TextBox3.Visible = false;
            guna2Button1.Visible = false;
            guna2Button3.Visible = false;
            guna2GroupBox3.Size = new Size(810, 94);
            guna2GroupBox3.CustomBorderThickness = new Padding(0, 90, 0, 0);
            guna2Button2.Visible = true;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Text = string.Empty;
            guna2TextBox3.Visible = true;
            this.Size = new Size(856, 399);
            guna2GroupBox3.Size = new Size(810, 54);
            guna2GroupBox2.Size = new Size(810, 54);
            guna2GroupBox3.CustomBorderThickness = new Padding(0, 50, 0, 0);
            guna2GroupBox2.CustomBorderThickness = new Padding(0, 50, 0, 0);
            guna2TextBox1.Visible = false;
            guna2TextBox2.Visible = false;
            guna2Button1.Visible = false;
            guna2Button2.Visible = false;
            guna2GroupBox4.Size = new Size(810, 94);
            guna2GroupBox4.CustomBorderThickness = new Padding(0, 90, 0, 0);
            guna2Button3.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Visible = false;
            guna2Button1.Visible = false;
            this.Size = new Size(856, 358);
            guna2GroupBox2.Size = new Size(810, 54);
            guna2GroupBox3.Location = new Point(12, 198);
            guna2GroupBox4.Location = new Point(12, 258);
            guna2GroupBox2.CustomBorderThickness = new Padding(0, 50, 0, 0);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Visible = false;
            guna2Button2.Visible = false;
            this.Size = new Size(856, 358);
            guna2GroupBox3.Size = new Size(810, 54);
            guna2GroupBox4.Location = new Point(12, 258);
            guna2GroupBox3.CustomBorderThickness = new Padding(0, 50, 0, 0);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Visible = false;
            guna2Button3.Visible = false;
            this.Size = new Size(856, 358);
            guna2GroupBox4.Size = new Size(810, 54);
            guna2GroupBox4.CustomBorderThickness = new Padding(0, 50, 0, 0);
        }

        private void GunaG1_CheckedChanged(object sender, EventArgs e)
        {
            var s = sender as Guna.UI2.WinForms.Guna2CustomRadioButton;
            if (s.Checked)
            {
                gunaGg1.Enabled = true; gunaP1.Enabled = true; pictureBox6.Enabled = true;
            }
            else
            {
                gunaGg1.Enabled = false; gunaP1.Enabled = false; pictureBox6.Enabled = false;
            }
        }
        private void GunaG2_CheckedChanged(object sender, EventArgs e)
        {
            var s = sender as Guna.UI2.WinForms.Guna2CustomRadioButton;
            if (s.Checked)
            {
                guna2Gg2.Enabled = true; guna2P2.Enabled = true; pictureBox7.Enabled = true;
            }
            else
            {
                guna2Gg2.Enabled = false; guna2P2.Enabled = false; pictureBox7.Enabled = false;
            }
        }
        private void GunaG3_CheckedChanged(object sender, EventArgs e)
        {
            var s = sender as Guna.UI2.WinForms.Guna2CustomRadioButton;
            if (s.Checked)
            {
                guna2Gg3.Enabled = true; guna2P3.Enabled = true; pictureBox8.Enabled = true;
            }
            else
            {
                guna2Gg3.Enabled = false; guna2P3.Enabled = false; pictureBox8.Enabled = false;
            }
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var s = sender as Guna.UI2.WinForms.Guna2RadioButton;
            if (s.Checked)
            {
                guna2CustomRadioButton16.Enabled = true; GunaG1.Enabled = true; GunaG2.Enabled = true; gunaG3.Enabled = true;
                gunaY1.Enabled = true; gunaY2.Enabled = true; gunaY3.Enabled = true;
                guna2R1.Enabled = true; guna2R2.Enabled = true; guna2R3.Enabled = true;
                sc.Visible = true; pen.Visible = true;
            }
        }

        private void pen_Click(object sender, EventArgs e)
        {
            subject.Visible = true; save.Visible = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            s2.Text = subject.Text;
            s2.Visible = true; subject.Visible = false; save.Visible = false;
            
        }
    }
}
