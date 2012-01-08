using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kPhone
{
    public partial class calcInterface : UserControl
    {

        public string mode = "null";
        public float total = 0;
        public int holder = 0;
        public int holder2 = 0;
        public int memory;
        public calcInterface()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                holder2 = Int32.Parse(result.Text);
            } catch
            {
                ;
            }
            if (mode == "add")
            {
                total += holder2;
            }
            else if (mode == "sub")
                total = (total - holder2);
            else if (mode == "mul")
                total *= holder2;
            else if (mode == "div")
                total /= holder2;

            result.Text = total.ToString();
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "1";
            else result.Text += 1;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            mode = "add";
            holder = Int32.Parse(result.Text);
            total += holder;
            result.Text = "0";
            
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "2";
            else result.Text += 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "3";
            else result.Text += 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "4";
            else result.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "5";
            else result.Text += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "6";
            else result.Text += 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "7";
            else result.Text += 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "8";
            else result.Text += 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                result.Text = "9";
            else result.Text += 9;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            holder = Int32.Parse(result.Text);
            total = holder;
            mode = "sub"; 
            result.Text = "0";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            total = 0;
            holder = 0;
            holder2 = 0;
            result.Text = "0";
            mode = "null";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            mode = "mul";
            holder = Int32.Parse(result.Text);            
            if (total == 0)
                total = holder;
            else total *= holder;
            result.Text = "0";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            mode = "div";
            holder = Int32.Parse(this.result.Text);
            if (total == 0)
                total = holder;
            else total /= holder;
            this.result.Text = "0";
        }

        private void mcBtn_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void mrBtn_Click(object sender, EventArgs e)
        {
            this.result.Text = memory.ToString();
            total = 0;
            holder = 0;
            holder2 = 0;            
            mode = "null";
        }

        private void mplusBtn_Click(object sender, EventArgs e)
        {
            memory = Int32.Parse(this.result.Text);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (result.Text.IndexOf("0") == 0)
                ;
            else result.Text += 0;
        }

        private void dec_Click(object sender, EventArgs e)
        {
            this.result.Text += ",";
        }

        private void negBtn_Click(object sender, EventArgs e)
        {
            int value = (Int32.Parse(this.result.Text));
            value *= (-1);
            this.result.Text = value.ToString();
        }
    }
}
