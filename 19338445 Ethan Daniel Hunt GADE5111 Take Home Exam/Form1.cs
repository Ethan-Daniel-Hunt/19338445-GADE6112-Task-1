using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19338445_Ethan_Daniel_Hunt_GADE5111_Take_Home_Exam
{
    public partial class Form1 : Form
    {

        int grid_x_size;
        int grid_y_size;

        int num_mines;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_game_button_Click(object sender, EventArgs e)
        {

            

            grid_x_size = int.Parse(grid_width_text_box.Text);

            grid_y_size = int.Parse(grid_height_text_box.Text);

            num_mines = int.Parse(num_mines_text_box.Text);



            Minesweeper ms = new Minesweeper();

            ms.AcceptData(grid_x_size , grid_y_size, num_mines);


            ms.Show();


        }

        private void grid_width_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (Char.IsLetter(chr)) { e.Handled = true; MessageBox.Show("Item price flield will only accept numbers"); }
        }

        private void grid_height_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (Char.IsLetter(chr)) { e.Handled = true; MessageBox.Show("Item price flield will only accept numbers"); }
        }

        private void num_mines_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (Char.IsLetter(chr)) { e.Handled = true; MessageBox.Show("Item price flield will only accept numbers"); }
        }
    }
}
