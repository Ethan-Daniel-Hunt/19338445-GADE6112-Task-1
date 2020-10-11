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
    public partial class Minesweeper : Form
    {

        int grid_x_size;
        int grid_y_size;

        int num_mines;

        Cell[,] mine_field;

        bool pick_mine_bool = false;




        public Minesweeper()
        {
            InitializeComponent();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            GenerateMineField();
        }

        public void AcceptData (int x_grid_size, int y_grid_size, int mines_num)
        {

            grid_x_size = x_grid_size; grid_y_size = y_grid_size; num_mines = mines_num;

            mine_field = new Cell[grid_x_size, grid_y_size];

            mine_field_lable.Text = "";
            
        }

        int PickMine ()
        {
            Random random_generator = new Random();

            return random_generator.Next(0, 2);//generate a random number 

            

        }


        void GenerateMineField ()
        {


            for (int x = 0; x < +grid_x_size; x++)
            {
               

                for (int y = 0; y < +grid_y_size; y++)
                {

                    mine_field[x, y] = new Cell(" . ", " M ", false);


                    if (PickMine() >= 2)
                    {


                        mine_field_lable.Text += string.Format("{0}", mine_field[0, y].mine_exposed);

                    }
                    else { mine_field_lable.Text += string.Format("{0}", mine_field[0, y].cell_hidden); }

                    }


                if (PickMine() >= 2)
                {


                    mine_field_lable.Text += string.Format("{0}", mine_field[0, x].mine_exposed);

                }
                else { mine_field_lable.Text += string.Format("{0}", mine_field[0, x].cell_hidden); }



                mine_field_lable.Text += "\n";


            }

        }

    }

    public class Cell
    {
        
        public string cell_hidden;
        public string mine_exposed;
        public bool is_mine;
        

        public Cell(string cell_hidden_string , string mine_exposed_string, bool is_mine_bool)
        {


           



            cell_hidden = cell_hidden_string;
            mine_exposed = mine_exposed_string;
            is_mine = is_mine_bool;

            

            

        }

    }

}
