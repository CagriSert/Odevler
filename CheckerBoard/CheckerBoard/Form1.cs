using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int top=0;
            int left=0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int k = 0; k < buttons.GetUpperBound(1); k++)
                {
                    buttons[i, k] = new Button();
                    buttons[i, k].Width = 50;
                    buttons[i, k].Height = 50;
                    buttons[i, k].Left = left;
                    buttons[i, k].Top = top;
                    left += 50;
                    if ((i + k) % 2 == 0)
                    {
                        buttons[i, k].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, k].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,k]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}
