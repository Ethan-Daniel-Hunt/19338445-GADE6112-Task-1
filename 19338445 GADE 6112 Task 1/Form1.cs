using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _19338445_GADE_6112_Task_1
{

    public partial class Form1 : Form//The game engine class                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                po 7]i=[-ppoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
    {


        public Tile[,] game_tiles;//instance of the tile array in the Map object

        public Hero hero_player = new Hero(1, 1, 10, 2);//instance of the Hero object

        public Map game_map = new Map(/*num enemies ->*/3,/*num items ->*/ 6, 15, 18, 15, 18);//instance of the Map object




        public int total_hero_gold;// the integer to represent the total amount of matha fuckin gold we have #ballin


        public List<Label> la = new List<Label>();//Label list of all labels used to display the map

        public bool user_selected_item;

        int enemy_index_selected;//the int to represent the enemy index we selceted

        Shop shop;


        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

            SetUpGameComponents();


        }

        void SelectEnemy()//select enemy inisializes the drop down list with the enemies array
        {

            enemy_list.Items.AddRange(game_map.enemies);//adds the enemies array in game map to the enemy list on the form

            

        }


       


        void SetUpGameComponents()
        {

            game_map.hero = hero_player;// set the instance of the hero object in the Map class to the one declaired here in game engine

            shop = new Shop(hero_player);

            game_map.SetUpMapComponents();

            shop_items_list.Items.AddRange(shop.shop_weapons);
            

            DisplayMap();//Call the DisplayMap method 

            

            SelectEnemy();//call select enemy

            DisplayStats();

        }

        void DisplayStats ()// display all the states of the selected enemy and the hero
        {

            hero_health_label.Text = string.Format("Health: {0}/{1}", hero_player.current_hp ,  hero_player.max_hp);// display hero health

            total_hero_gold = 0;//reset gold

            total_hero_gold = hero_player.hero_gold.Sum();//assign the sum of all gold in the hero gold list

            hero_gold_label.Text = string.Format("Gold: {0}", total_hero_gold);// display gold

            hero_damage_label.Text = string.Format("Damage: {0}", hero_player.damage);// display hero damage

            hero_position_label.Text = string.Format("Location: {0}:{1}", hero_player.x, hero_player.y);

            hero_weapon_label.Text = string.Format("Weapon: {0}", hero_player.weapon.weapon_type);

            if (hero_player.weapon.durability_p == 12345) { hero_weapon_durability.Text = "Durability: Infinity"; }
            else
            {

                hero_weapon_durability.Text = string.Format("Durability: {0}", hero_player.weapon.durability_p);
            }


            hero_weapon_range.Text = string.Format("Range: {0}", hero_player.weapon.Range());


            enemy_index_selected = enemy_list.SelectedIndex;//assign the selected enemy index

            if (enemy_index_selected != -1) {// if we have selected an enemy


                if (game_map.enemies[enemy_index_selected] != null)
                {

                    enemy_health_label.Text = string.Format("Health: {0}/{1}", game_map.enemies[enemy_index_selected].max_hp, game_map.enemies[enemy_index_selected].current_hp);// displa enemy health

                    

                    enemy_damage_label.Text = string.Format("Damage: {0}", game_map.enemies[enemy_index_selected].damage);// display enemy damage

                    enemy_type_label.Text = string.Format("Type: {0}", game_map.enemies[enemy_index_selected].enemy_id);// display enemy type

                    enemy_weapon_label.Text = string.Format("Weapon: {0}", game_map.enemies[enemy_index_selected].weapon.weapon_type);

                    if (game_map.enemies[enemy_index_selected].weapon.durability_p == 12345) { enemy_weapon_durability.Text = "Durability: Infinity"; }
                    else
                    {

                        enemy_weapon_durability.Text = string.Format("Durability: {0}", game_map.enemies[enemy_index_selected].weapon.durability_p);
                    }

                }


            }

            UpdateMap();//update the map


        }

        void UpdateMap()//method that updates the map display by just changing the lable values instead of creating new ones
        {


            

            enemy_index_selected = enemy_list.SelectedIndex;//get the index of the selcted item and assign it to a local variable to be used



            hero_player.map = game_map;//sets the instance of the map object in the hero class to the instance declaired here in game engine

            int li = -1;//the index of the lable list

            game_tiles = game_map.GenMap();//assign the game_tiles 2 dimensional Tile array to the 2 dimensional Tile array GenMap in the Map class of instace game_map

            hero_player.Game_Tiles = game_tiles;

            




            for (int x = 0; x <= game_map.x_map_size - 1; x++)//nested for loop to loop through every index of the game_maps size in a grid fashion
            {
                for (int y = 0; y <= game_map.y_map_size - 1; y++)
                {



                    li += 1;//incrimenting the index of the label list

                    //Console.WriteLine(String.Format("li : {0}", li));

                    la.Add(new Label());//add a new lable object to the lable list


                    if (game_tiles[x, y].tile_type == Tile.TileType.Wall)//checking if game_tiles at the current index is of tile type wall

                    {

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "#";//set the text of the lable. used as a visual representation for what type of tile it is




                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Air)//checking if game_tiles at the current index is of tile type air
                    {



                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = ".";//set the text of the lable. used as a visual representation for what type of tile it is


                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Player)//checking if game_tiles at the current index is of tile type player
                    {



                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "H";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Goblin)//checking if game_tiles at the current index is of tile type player
                    {

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "G";//set the text of the lable. used as a visual representation for what type of tile it is


                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Mage)//checking if game_tiles at the current index is of tile type player
                    {

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "M";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Gold)//checking if game_tiles at the current index is of tile type player
                    {

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Yellow;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "O";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Dagger)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "D";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Longsword)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "L";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Longbow)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "B";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Rifel)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "R";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Leader)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Red;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "L";//set the text of the lable. used as a visual representation for what type of tile it is

                    }

                    if (user_selected_item == true) {

                        if (la[li].Left == SelectedEnemyData(enemy_index_selected).Item1 && la[li].Top == SelectedEnemyData(enemy_index_selected).Item2)//of the lable is associated with the selected enemy if so highlight it for the user to see
                        {

                            la[li].ForeColor = Color.Black;//set the front colour(the colour of the text)
                            la[li].BackColor = Color.White;//set the background colour of the lable


                        }
                    }

                }

            }










        }

        void DisplayMap()//method used to create the display for the map. this method creates the initial lables for the visual representation
        {

            

            enemy_index_selected = enemy_list.SelectedIndex;//get the index of the selcted item and assign it to a local variable to be used

            hero_player.map = game_map;//sets the instance of the map object in the hero class to the instance declaired here in game engine



            int li = -1;//the index of the lable list

            game_tiles = game_map.GenMap();//assign the game_tiles 2 dimensional Tile array to the 2 dimensional Tile array GenMap in the Map class of instace game_map

            enemy_index_selected = enemy_list.SelectedIndex;//get the index of the selcted item and assign it to a local variable to be used

            hero_player.Game_Tiles = game_tiles;//set the game tiles in the hero class to the game_tile her in the game engine class



            for (int x = 0; x <= game_map.x_map_size - 1; x++)//nested for loop to loop through every index of the game_maps size in a grid fashion
            {
                for (int y = 0; y <= game_map.y_map_size - 1; y++)
                {



                    li += 1;//incrimenting the index of the label list

                    //Console.WriteLine(String.Format("li : {0}", li));

                    la.Add(new Label());//add a new lable object to the lable list


                    if (game_tiles[x, y].tile_type == Tile.TileType.Wall)//checking if game_tiles at the current index is of tile type wall

                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form


                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "#";//set the text of the lable. used as a visual representation for what type of tile it is




                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Air)//checking if game_tiles at the current index is of tile type air
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = ".";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Player)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "H";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Goblin)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "G";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Mage)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "M";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Gold)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Yellow;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "O";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Dagger)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "D";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Longsword)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "L";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Longbow)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "B";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Rifel)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Pink;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "R";//set the text of the lable. used as a visual representation for what type of tile it is

                    }
                    else if (game_tiles[x, y].tile_type == Tile.TileType.Leader)//checking if game_tiles at the current index is of tile type player
                    {

                        this.Controls.Add(la[li]);//adding the lable from the lable array (at index li) to the form

                        la[li].Left = 20 * x;//set the lable x position
                        la[li].Top = 20 * y;//set the lable y position

                        la[li].ForeColor = Color.Red;//set the front colour(the colour of the text)
                        la[li].BackColor = Color.Black;//set the background colour of the lable

                        la[li].Font = new Font("Arial", 15f);//set the font and font size of the lable
                        la[li].AutoSize = true;//set whether or not the label should auto size to the display. In this case true
                        la[li].Text = "L";//set the text of the lable. used as a visual representation for what type of tile it is

                    }

                    if (user_selected_item == true)
                    {

                        if (la[li].Left == SelectedEnemyData(enemy_index_selected).Item1 && la[li].Top == SelectedEnemyData(enemy_index_selected).Item2)//of the lable is associated with the selected enemy if so highlight it for the user to see
                        {

                           

                            la[li].ForeColor = Color.Black;//set the front colour(the colour of the text)
                            la[li].BackColor = Color.White;//set the background colour of the lable
                        }
                    }


                }

            }



        }



        void DeconstructDisplay()//incase we need to remake the map / possibly create a new one or add to the existing one
        {

            for (int i = 0; i <= la.Count - 1; i++)//loop through every lable in the lable list
            {
                this.Controls.Remove(la[i]);//delete the lable from the form at th current index of the loop
            }

            la.Clear();//clear the lable array, remove all its data

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)//method that is called when a key is pressed and takes and object and keyeventargs("KeyEventArgs"this is what stores the key value pressed) as arguments
        {
            
            hero_player.GetKeys(e);//call the the GetKeys method in the Hero class and give is the "KeyEventArgs"(the value/id if the key pressed)

            game_map.hero = hero_player;//update the hero instance in the Map class as movement has changed 

            hero_player.PickUpItem(game_map.GetItemAtPosition(hero_player.x,hero_player.y));//call pick item and give it the get item at position with the heros x and y values 



            game_map.UpdateEnemies();//update da enemies

            EnemyAttack(true);//calllllllllll enemy attack....ghuifityuifvuiyhfdcuykg9op

            UpdateMap();//update the map

            DisplayStats();

            

        }

        private void enemy_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enemy_list.SelectedIndex > -1)//check if an item as been selected
            {

                user_selected_item = true;

                enemy_index_selected = enemy_list.SelectedIndex;//get the index of the selcted item and assign it to a local variable to be used

                int li = -1;//the index of the lable list


                for (int x = 0; x <= game_map.x_map_size - 1; x++)//nested for loop to loop through every index of the game_maps size in a grid fashion
                {
                    for (int y = 0; y <= game_map.y_map_size - 1; y++)
                    {



                        li += 1;//incrimenting the index of the label list

                        la.Add(new Label());//add a new lable object to the lable list


                        if (user_selected_item == true)
                        {

                            if (la[li].Left == SelectedEnemyData(enemy_index_selected).Item1 && la[li].Top == SelectedEnemyData(enemy_index_selected).Item2)//of the lable is associated with the selected enemy if so highlight it for the user to see
                            {
                              

                                la[li].ForeColor = Color.Black;//set the front colour(the colour of the text)
                                la[li].BackColor = Color.White;//set the background colour of the lable


                            }
                            else 
                            {

                                if (game_tiles[x, y].tile_type == Tile.TileType.Gold)
                                {

                                    la[li].ForeColor = Color.Yellow;//set the front colour(the colour of the text)
                                    la[li].BackColor = Color.Black;//set the background colour of the lable

                                }
                                else
                                {
                                    la[li].ForeColor = Color.White;//set the front colour(the colour of the text)
                                    la[li].BackColor = Color.Black;//set the background colour of the lable
                                }
                            }
                        }

                    }

                }

            }
            else
            {
                user_selected_item = false;
            }

            DisplayStats();

        }

        public (int,int) SelectedEnemyData (int enemy_index)//get the index of the enemy selceted and return its x and y postion in realation to its posiion
        {

            if (game_map.enemies[enemy_index] != null)
            {

                int enemy_x = game_map.enemies[enemy_index].x;

                int enemy_y = game_map.enemies[enemy_index].y;

                enemy_x *= 20;
                enemy_y *= 20;

                return (enemy_x, enemy_y);
            }

            return (0,0);
           
        }

        public void EnemyAttack (bool hero_stationary)
        {
            if (hero_stationary == true)//if we are not movin
            {

                for (int i = 0; i <= game_map.enemies.Length -1;i++)//loop through the enemies array
                {


                    if (game_map.enemies[i] != null)
                    {



                        if (game_map.enemies[i].enemy_id == "goblin")
                        {//if the current enemy is a goblin


                            bool goblin_attack = game_map.enemies[i].CheckRange((1, 1), hero_player, game_map.enemies[i]);//assign the chech range bool to a local variable

                            if (goblin_attack == true)//if the giblin is on range
                            {

                                game_map.enemies[i].Attack(game_map.enemies[i], hero_player);

                                //hero_player.current_hp -= game_map.enemies[i].damage;//he/she/they what ever it identifies as will subtracts its damage from the heros health

                                MessageBox.Show(string.Format("goblin attacked hero for {0} damage", game_map.enemies[i].damage));//display what just went down bruv

                                DisplayStats();//call this thing cause update values of character things... yeah
                            }


                        }
                        else if (game_map.enemies[i].enemy_id == "mage")
                        {
                            for (int j = 0; j <= game_map.enemies.Length - 1; j++)//do a seperate loop through the enemies array
                            {

                                if (game_map.enemies[j] != null)
                                {

                                    bool mage_attack_enemy = game_map.enemies[i].CheckRange((1, 1), game_map.enemies[j], game_map.enemies[i]);//check the range from the mage to what ever enemy is the current

                                    Console.WriteLine(string.Format("enemy x {0} , y {1}", game_map.enemies[j].x, game_map.enemies[j].y));

                                    Console.WriteLine(string.Format("my enemy x {0} , y {1}", game_map.enemies[i].x, game_map.enemies[i].y));

                                    if (mage_attack_enemy == true)//if the mage is in range
                                    {

                                        game_map.enemies[i].Attack(game_map.enemies[i], game_map.enemies[j]);

                                        //game_map.enemies[j].current_hp -= game_map.enemies[i].damage;//subtract the mage damage from the enemy current hp

                                        MessageBox.Show(string.Format("mage attacked {0} for {1} damage", game_map.enemies[j].enemy_id, game_map.enemies[i].damage));//show that we hit

                                        DisplayStats();//call display states cause gotta show that updates stats..............................
                                    }


                                }

                            }


                            //-------------------------------------------------SAME SHIZ BUT FOR MAGE AS GOBLIN---------------------------

                            bool mage_attack_hero = game_map.enemies[i].CheckRange((1, 1), hero_player, game_map.enemies[i]);

                            if (mage_attack_hero == true)
                            {

                                game_map.enemies[i].Attack(game_map.enemies[i], hero_player);

                                //hero_player.current_hp -= game_map.enemies[i].damage;

                                MessageBox.Show(string.Format("mage attacked hero for {0} damage", game_map.enemies[i].damage));

                                DisplayStats();
                            }

                            //-------------------------------------------------SAME SHIZ BUT FOR MAGE AS GOBLIN--------------------------
                        }




                    }

                }
            }
            else if (hero_stationary == false)//if we aret moving and its after player attack
            {

                //-------------------------------------------------------SAME AS ABOVE BUT JUST FIRES AFTER WE ATTACK-------------------------------------------------------------

                for (int i = 0; i <= game_map.enemies.Length - 1; i++)
                {

                    if (game_map.enemies[i] != null)
                    {





                        if (game_map.enemies[i].enemy_id == "goblin")
                        {


                            bool goblin_attack = game_map.enemies[i].CheckRange((1, 1), hero_player, game_map.enemies[i]);

                            if (goblin_attack == true)
                            {

                                game_map.enemies[i].Attack(game_map.enemies[i], hero_player);

                                //hero_player.current_hp -= game_map.enemies[i].damage;

                                MessageBox.Show(string.Format("goblin attacked hero for {0} damage", game_map.enemies[i].damage));

                                DisplayStats();
                            }


                        }
                        else if (game_map.enemies[i].enemy_id == "mage")
                        {
                            for (int j = 0; j <= game_map.enemies.Length - 1; j++)
                            {


                                if (game_map.enemies[j] != null)
                                {


                                    bool mage_attack_enemy = game_map.enemies[i].CheckRange((1, 1), game_map.enemies[j], game_map.enemies[i]);

                                    Console.WriteLine(string.Format("enemy x {0} , y {1}", game_map.enemies[j].x, game_map.enemies[j].y));

                                    Console.WriteLine(string.Format("my enemy x {0} , y {1}", game_map.enemies[i].x, game_map.enemies[i].y));

                                    if (mage_attack_enemy == true)
                                    {
                                        //game_map.enemies[j].current_hp -= game_map.enemies[i].damage;

                                        game_map.enemies[i].Attack(game_map.enemies[i], game_map.enemies[j]);

                                        MessageBox.Show(string.Format("mage attacked {0} for {1} damage", game_map.enemies[j].enemy_id, game_map.enemies[i].damage));

                                        DisplayStats();
                                    }


                                }


                            }


                            bool mage_attack_hero = game_map.enemies[i].CheckRange((1, 1), hero_player, game_map.enemies[i]);

                            if (mage_attack_hero == true)
                            {

                                game_map.enemies[i].Attack(game_map.enemies[i], hero_player);

                                //hero_player.current_hp -= game_map.enemies[i].damage;

                                MessageBox.Show(string.Format("mage attacked hero for {0} damage", game_map.enemies[i].damage));

                                DisplayStats();
                            }


                            //-------------------------------------------------------SAME AS ABOVE BUT JUST FIRES AFTER WE ATTACK-------------------------------------------------------------
                        }





                    }



                }
            }


            game_map.CheckEnemies();

            UpdateMap();//update the map

            DisplayStats();


        }

        private void attack_enemy_button_Click(object sender, EventArgs e)//method called when we press t he attack button
        {

            //enemy_list.Items.RemoveAt(1);

            //enemy_list.Items.RemoveAt(1);

            enemy_index_selected = enemy_list.SelectedIndex;//get the index of the selcted item and assign it to a local variable to be used

            if (enemy_index_selected != -1)//if the enemy selected index is not -1 i.e we havent selected an enemy
            {

                bool attack_check = hero_player.CheckRange((1, 1), game_map.enemies[enemy_index_selected], hero_player);//call the check range bool and store it


                if (attack_check == true)//if we are in range
                {

                    hero_player.Attack(hero_player, game_map.enemies[enemy_index_selected]);


                    //game_map.enemies[enemy_index_selected].current_hp -= hero_player.damage;//subtract the selected enemy curremt health by hero damage

                    
                    MessageBox.Show(string.Format ("Attack hit {0} for {1} damage!" , game_map.enemies[enemy_index_selected].enemy_id, hero_player.damage));//display that we hit

                    DisplayStats();

                }
                else if (attack_check == false) { MessageBox.Show(string.Format("Attack missed {0}. Out of range.", game_map.enemies[enemy_index_selected].enemy_id));/*display that we missed*/ }
            }else { MessageBox.Show("No enemy selected for attacking! Please select an enemy."); }


            EnemyAttack(false);//call enemy attack


            game_map.CheckEnemies();

            UpdateMap();//update the map

            DisplayStats();

        }




        public void DeleteEnemy(int index_remove)
        {

           
           


        }

        private void shop_items_list_SelectedIndexChanged(object sender, EventArgs e)
        {

           

            if (shop_items_list.SelectedIndex > -1)
            {

                display_weapon_message.Text = shop.DisplayString(shop_items_list.SelectedIndex);

            }
        }

        private void buy_item_button_Click(object sender, EventArgs e)
        {

            if (shop.CanBuy(shop_items_list.SelectedIndex) == true)
            {
                shop.Buy(shop_items_list.SelectedIndex);

                display_weapon_message.Text = shop.DisplayString(shop_items_list.SelectedIndex);

                DisplayStats();

            }



        }
    }



    public class Shop
    {

        public Weapon[] shop_weapons = new Weapon[3];

        public Random random_obj;

        public Character buyer;


        public Shop(Character the_buyer)
        {

            buyer = the_buyer;

            random_obj = new Random();

            for (int i = 0; i <= shop_weapons.Length - 1; i++)
            {
                shop_weapons[i] = RandomWeapon();

                Console.WriteLine(shop_weapons[i].weapon_type);

            }
        }

        private Weapon RandomWeapon()
        {

           

            int w_id = random_obj.Next(0, 4);

            

            switch (w_id)
            {
                case 0:
                    return new MeleeWeapon(0, 0, Weapon.WeaponType.Dagger);
                    break;

                case 1:
                    return new MeleeWeapon(0, 0, Weapon.WeaponType.Longsword);
                    break;

                case 2:
                    return new RangedWeapon(0, 0, Weapon.WeaponType.Longbow);
                    break;

                case 3:
                    return new RangedWeapon(0, 0, Weapon.WeaponType.Rifel);
                    break;

            }

            return new MeleeWeapon(0, 0, Weapon.WeaponType.BareHands);

        }


        public bool CanBuy(int weapon_index)
        {

            if (weapon_index != -1)
            {

              


                if (shop_weapons[weapon_index].cost_p <= buyer.gold_amt)
                {


                    MessageBox.Show("Can buy this weapon");

                    return true;



                }
                else
                {

                    MessageBox.Show("Can't buy this weapon");

                    return false;
                }

            }


            return false;

        }


        public void Buy (int weapon_index)
        {
            buyer.gold_amt -= shop_weapons[weapon_index].cost_p;

            buyer.Equip(shop_weapons[weapon_index]);

            shop_weapons[weapon_index] = RandomWeapon();

            MessageBox.Show("Bought weapon.");

        }



        public string DisplayString (int weapon_index)
        {
            return string.Format("Buy {0} for {1} Gold", shop_weapons[weapon_index].weapon_type, shop_weapons[weapon_index].cost_p);

        }

    }







    public class Tile/*the tile base class the defines what all tiles are at a base level, all classes exept from Map and game engine will inherit from this class*/ {

        public enum TileType {Player, Air, Wall, Goblin, Mage, Leader, Gold, Dagger, Longsword, Longbow, Rifel};//an enum to store the tiles type, used for checking and assigning tiles in game engine

        public int x;//an int to store the x position of the tile
        public int y;//an int to store the y position of the tile
        public TileType tile_type;//the enum to store the type pf the tile

        public Tile(int x_pos, int y_pos)//constructer for obsticle
        {
            x = x_pos;
            y = y_pos;

        }

        public  Tile (int x_pos, int y_pos, TileType tile_Type)//constructer for player
        {
            x = x_pos;
            y = y_pos;
            tile_type = tile_Type;

        }

        public Tile (TileType tile_Type)
        {
            tile_type = tile_Type;
        }


        public Tile() { }


    }

    public class Obsticle : Tile//sub-class of tile specifically for obsticles characters cannot pass through
    {

        public int obsticle_x;
        public int obsticle_y;


        public Obsticle(int o_x, int o_y) : base (o_x, o_y)
        {
            obsticle_x = o_x;
            obsticle_y = o_y;

        }


    }

    public abstract class Item : Tile
    {

        public string item_type;

        public Item (int i_x, int i_y)
        {
            x = i_x;
            y = i_y;
        }

        public Item() { }

        public abstract void ToString();


    }


    public class Gold : Item
    {
        private int gold_amt;

        Random rand_gold = new Random();

        public int gold_accsesor;

       

        public Gold (int g_x,int g_y):base (g_x,g_y)
        {

            gold_amt = rand_gold.Next(1,6);//set ranodom gold amount

            gold_accsesor = gold_amt;

            item_type = "gold";//set the item type to gold

        }


        public override void ToString()
        {

            throw new NotImplementedException();
        }
    }

    public abstract class Weapon : Item
    {

       


        public int weapon_damage_p;

        public int durability_p;

        public int cost_p;

        public string weapon_type;

        public int w_range;

        public enum WeaponType {Longsword, Dagger, BareHands, Longbow, Rifel, MagicalHands }

        public virtual int Range ()
        {

            return w_range;
        }


        public Weapon (int x, int y, WeaponType wp)
        {




        }


        public void Durability (string wp)
        {
            if (wp != "BareHands") { durability_p -= 1; }

        }

    }


    public class MeleeWeapon : Weapon
    {

        // public delegate MeleeWeapon callback(int c_x, int c_y, string c_symbol);

        public enum Types {Dagger, Longsword }

       
        public MeleeWeapon (int x_pos, int y_pos, WeaponType wp) : base (x_pos,y_pos,wp)
        {
            x = x_pos;

            y = y_pos;


            if (wp == WeaponType.Dagger)
            {

                durability_p = 10;
                weapon_damage_p = 3;
                cost_p = 3;
                weapon_type = "Dagger";

                item_type = "Dagger";
            }


            if (wp == WeaponType.Longsword)
            {
                 durability_p = 6;
                weapon_damage_p = 4;
                cost_p = 5;
                weapon_type = "Longsword";

                item_type = "Longsword";

            }

            if (wp == WeaponType.BareHands)
            {
                durability_p = 12345;
                weapon_damage_p = 1;
                cost_p = 0;
                weapon_type = "BareHands";

            }

            if (wp == WeaponType.MagicalHands)
            {
                durability_p = 12345;
                weapon_damage_p = 5;
                cost_p = 0;
                weapon_type = "Magical Hands";

            }



        }

       

       

        public override void ToString()
        {

            throw new NotImplementedException();
        }

        public override int Range()
        {
            return 1;
        }

       
    }


    public class RangedWeapon : Weapon
    {

        // public delegate MeleeWeapon callback(int c_x, int c_y, string c_symbol);

        public enum Types { Dagger, Longsword }


        public RangedWeapon(int x_pos, int y_pos, WeaponType wp) : base(x_pos, y_pos, wp)
        {
            x = x_pos;

            y = y_pos;


            if (wp == WeaponType.Longbow)
            {

                durability_p = 4;
                w_range = 2;
                weapon_damage_p = 4;
                cost_p = 6;
                weapon_type = "Longbow";

                item_type = "Longbow";
            }


            if (wp == WeaponType.Rifel)
            {
                durability_p = 3;
                w_range = 3;
                weapon_damage_p = 5;
                cost_p = 7;
                weapon_type = "Rifel";

                item_type = "Rifel";

            }


        }





        public override void ToString()
        {

            throw new NotImplementedException();
        }

        public override int Range()
        {

            return base.Range();
        }





    }


    public abstract class Character : Tile//abstrcact class for all things that move and interact with other thigs that move
    {

        

        public enum Movement { NoMovement, Up, Down, Left, Right };//an enum to store the direction of movement and the null of movement

        public Tile[,] charactar_vision;

        public int max_hp;//int to store the maximum health points
        public int current_hp;//int to store what our health points is currently at.
        public int damage;//int to store how much damage the charactar does

        public int attack_range;



        public string character_id;

        public Weapon weapon;

        public int gold_amt;


        public void Equip (Weapon w)
        {
            weapon = w;
            
            damage = w.weapon_damage_p;

            attack_range = w.Range();

            
        }

        public virtual void Attack(Character attacker, Character victum)//method that calculates the attack action, (ó ì_í)=óò=(ì_í ò)
        {



            weapon.Durability(this.weapon.weapon_type);

            victum.current_hp  -= attacker.damage;//subtract the attacker characters damage from the victum characters current hp 


            


        }

        public bool IsDead (Character c)//a bool method to check of the charactar has died
        {
            bool dead;

            if (c.current_hp <= 0) { dead = true; } else { dead = false; }//if the charactars current hp is zero or lower we return true if the charactars current hp is higher that zero we return false

            return dead;
        }

        private (int,int) DistanceTo (Character tracker, Character target)//a dual int method for checking the distance between two charactars
        {

            int x_distance;
            int y_distance;

            x_distance = tracker.x - target.x;//the distance x is the difference of the tracker x and the target x

            y_distance = tracker.y - target.y;//the distance y is the difference of the tracker y and the target y

            return (Math.Abs(x_distance),Math.Abs(y_distance));//we return the calculated distance
        }

        public virtual bool CheckRange((int, int) desired_range, Character tracker, Character target)//a bool method that checks if we are in range of a target
        {
            bool in_range;//bool to represent whether we are in the specified range


            (int, int) distance;//int to store the distance calculated in DistanceTo

            distance = DistanceTo(tracker, target);//assigning distance to DistanceTo

            desired_range.Item1 *= attack_range;

            desired_range.Item2 *= attack_range;

            MessageBox.Show(string.Format("x : {0} , y : {1}", distance.Item1, distance.Item2));

            if (desired_range.Item1 >= distance.Item1 && desired_range.Item2 >= distance.Item2)//if the desired range on x and y is less than are equal to the distance we return true if not then we are out of range and we return false
            {
                in_range = true;//sets the range bool to true
            }
            else { in_range = false;/*sets the range bool to false*/ }

            return in_range;//return the bool calculated for
        }


        public void Move (Movement move)//method that moves the character based in the movement enum provided
        {
           // MessageBox.Show("this is move");

            switch (move)
            {
                case Movement.Up: y -= 1; /*we are moving up and therefore decrease our y by 1 (- is up and + is down. Why?. who dafq knows...)  ¯\_(ツ)_/¯  */
                    break;

                case Movement.Down: y += 1; /*we are moving down and therefore increase our y by 1*/
                    break;

                case Movement.Left: x -= 1; /*we are moving left and therefore decrease our x by 1*/
                    break;

                case Movement.Right: x += 1; /*we are moving right and therefore increase our x by 1*/
                    break;

                case Movement.NoMovement: /*we do nothing/we dont move*/
                    break;

            }

        }


        public abstract void ReturnMove(Movement move);

    }



    public class Enemy : Character//the enemy class that provides base functionality to all enemy objects like goblin
    {

        public Tile[,] map_tiles;
        protected Random random_enemys_amt = new Random();//a random to gen some random nums
        static int instance_id;//an instance id to store which instance has been created
        int id;//an id of a specific instance represented in an instance number
        public string enemy_id;

        public int x_size;
        public int y_size;

        public override void ReturnMove(Movement move) { }


        public void CharacterVision()//the method that assignes the charactar vision array
        {


            charactar_vision = new Tile[x_size, y_size];//set the size of the array

            

            for (int x = 0; x <= x_size - 1; x++)
            {
                for (int y = 0; y <= y_size - 1; y++)
                {
                    if (map_tiles[x, y].tile_type == TileType.Air || map_tiles[x, y].tile_type == TileType.Goblin || map_tiles[x, y].tile_type == TileType.Mage)//if we loop through air tiles and gold tiles
                    {

                        charactar_vision[x, y] = map_tiles[x, y];//we assign them to the character vision array

                    }
                    else { charactar_vision[x, y] = null;/*every other value in the array should be null*/ }
                }

            }



        }


        public Enemy (int enemy_x, int enemy_y,int enemy_damage,int enemy_starting_hp)//enemy constructor that recieves x,y,dams and max hp
        {

            x = enemy_x;
            y = enemy_y;
            damage = enemy_damage;
            max_hp = enemy_starting_hp;

            id = ++instance_id;//incrimenting the instance 

            
        }


        public Enemy(int enemy_x, int enemy_y)
        {

            x = enemy_x;
            y = enemy_y;
           
        }


        public string Output ()//string that outputs informatio about the instance, its id,x,y and damage
        {
            string u_string;

            u_string = String.Format("enemy ID : {0} at enemy x : {1} , enemy y : {2} , enemy damage = {3}" , id,x,y,damage);

            return u_string;
        }



    }



    public class Goblin : Enemy//the goblin subclass of enemy
    {

        int goblin_damage = 1;
        int goblin_health = 10;

        public Goblin(int g_x, int g_y) : base(g_x, g_y)//set out hp, damage positions from recieved values you know how it goes...
        {
            x = g_x;
            y = g_y;

            damage = goblin_damage;
            max_hp = goblin_health;
            current_hp = goblin_health;

            enemy_id = "goblin";

            character_id = "enemy";

            this.Equip(new MeleeWeapon(0, 0, Weapon.WeaponType.Dagger));
        }

        public void DoGoblin()
        {

            //Console.WriteLine("DO GOBLINS!!!!");
        }


        public (int, int) RollDirection()//(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧ TRIPPLE!!! int method that that returns a predicted x and y as well as a direction id
        {



            // MessageBox.Show("this is roll direction");


            int future_y = y;

            int future_x = x;

            int direction_id = random_enemys_amt.Next(0, 4);//gen a random direction




            switch (direction_id)
            {
                case 0: future_y -= 1;/*Up*/ReturnMove(Movement.Up); //predict position based on direction id
                    break;

                case 1: future_y += 1;/*Down*/ReturnMove(Movement.Down); //predict position based on direction id
                    break;

                case 2: future_x -= 1;/*Left*/ReturnMove(Movement.Left); //predict position based on direction id
                    break;

                case 3: future_x += 1;/*Right*/ReturnMove(Movement.Right); //predict position based on direction id
                    break;
            }


            return (future_x, future_y);//return da calculated values(づ｡◕‿‿◕｡)づ, we gonna use'em later.



        }


        public override void ReturnMove(Movement move)//method that checks collision for enemy based on the predicted movement
        {



            CharacterVision();//call the character vision method so the assigning of the character vision array fires


            //MessageBox.Show("this is return move on goblin");

            int future_y = y;//this will store out predicted y

            int future_x = x;//this will store out predicted x

            if (move == Movement.Up)//if movement is up move predicted y up;
            {
                future_y -= 1;
            }
            else if (move == Movement.Down)//if movement is up move predicted y down;
            {
                future_y += 1;
            }

            if (move == Movement.Right)//if movement is up move predicted x right;
            {
                future_x += 1;
            }
            else if (move == Movement.Left)//if movement is up move predicted x left;
            {
                future_x -= 1;
            }

            if (charactar_vision[future_x, future_y] != null)//if the value we want to move to is NOT null accourding to the character vision array
            {
                Move(move);//we return our calculates movement

            } else if (charactar_vision[future_x, future_y] == null)//if the value we want to move to IS null
            {
                RollDirection();//then we call for roll direction to find a new position to move to

            }



        }


        private (int, int) DistanceTo(Character tracker, Character target)//a dual int method for checking the distance between two charactars
        {

            int x_distance;
            int y_distance;

            x_distance = tracker.x - target.x;//the distance x is the difference of the tracker x and the target x

            y_distance = tracker.y - target.y;//the distance y is the difference of the tracker y and the target y

            return (Math.Abs(x_distance), Math.Abs(y_distance));//we return the calculated distance
        }

        public override bool CheckRange((int, int) desired_range, Character tracker, Character target)
        {

            if (tracker.character_id == "hero") {//checking of the tracker for range is the hero

                bool in_range;//bool that will represent whether or not we are in range

                (int, int) distance;//int to store the distance calculated in DistanceTo

                distance = DistanceTo(tracker, target);//assigning distance to DistanceTo

                //MessageBox.Show(string.Format("goblin distance = x : {0} , y : {1}", distance.Item1, distance.Item2));

                if (desired_range.Item1 >= distance.Item1 && desired_range.Item2 >= distance.Item2)//if the desired range on x and y is less than are equal to the distance we return true if not then we are out of range and we return false
                {
                    in_range = true;//sets the range bool to true
                }
                else { in_range = false;/*sets the range bool to false*/ }

                return in_range;//return the bool calculated for
            }
            return false;//if the tracker character id is not either options checked for we return false
        }


    }

    public class Mage : Enemy//the goblin subclass of enemy
    {

        int mage_damage = 5;
        int mage_health = 5;

        

        public Mage(int m_x, int m_y) : base(m_x, m_y)//set out hp, damage positions from recieved values you know how it goes...
        {
            x = m_x;
            y = m_y;

            damage = mage_damage;
            max_hp = mage_health;
            current_hp = mage_health;

            enemy_id = "mage";

            character_id = "enemy";

            this.Equip(new MeleeWeapon(0, 0, Weapon.WeaponType.MagicalHands));

        }

        public override void ReturnMove(Movement move)//overwtitten return move
        {

            move = Movement.NoMovement;//we set the return movement value to no movement

            ReturnMove(move);//we return no movement
        }

        private (int, int) DistanceTo(Character tracker, Character target)//a dual int method for checking the distance between two charactars
        {

            int x_distance;
            int y_distance;

            x_distance = tracker.x - target.x;//the distance x is the difference of the tracker x and the target x

            y_distance = tracker.y - target.y;//the distance y is the difference of the tracker y and the target y

            return (Math.Abs(x_distance), Math.Abs(y_distance));//we return the calculated distance
        }

        public override bool CheckRange((int, int) desired_range, Character tracker, Character target)//Mages check range
        {

            if (tracker != null)
            {



                if (tracker.character_id == "enemy" || tracker.character_id == "hero")
                {//checking of the tracker for range is the hero or an enemy

                    bool in_range;//bool that will represent whether or not we are in range

                    (int, int) distance;//int to store the distance calculated in DistanceTo

                    distance = DistanceTo(tracker, target);//assigning distance to DistanceTo

                    //MessageBox.Show(string.Format("mage distance = x : {0} , y : {1}", distance.Item1, distance.Item2));

                    if (desired_range.Item1 >= distance.Item1 && desired_range.Item2 >= distance.Item2 && distance.Item1 != 0 && distance.Item2 != 0)//if the desired range on x and y is less than are equal to the distance we return true if not then we are out of range and we return false, and checking that the range is not zero otherwise we would attack ourself
                    {
                        in_range = true;//sets the range bool to true
                    }
                    else { in_range = false;/*sets the range bool to false*/ }

                    return in_range;//return the bool calculated for

                }



            }

            return false;//if the tracker character id is not either options checked for we return false

        }

    }





    public class Leader : Enemy//the goblin subclass of enemy
    {

        int leader_damage = 1;
        int leader_health = 10;

        public Leader(int g_x, int g_y) : base(g_x, g_y)//set out hp, damage positions from recieved values you know how it goes...
        {
            x = g_x;
            y = g_y;

            damage = leader_damage;
            max_hp = leader_health;
            current_hp = leader_health;

            enemy_id = "leader";

            character_id = "enemy";

            this.Equip(new MeleeWeapon(0, 0, Weapon.WeaponType.Longsword));
        }

        


        public (int, int) LeaderMovement()//(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧ TRIPPLE!!! int method that that returns a predicted x and y as well as a direction id
        {



            // MessageBox.Show("this is roll direction");


            int future_y = y;

            int future_x = x;

            int direction_id = random_enemys_amt.Next(0, 4);//gen a random direction




            switch (direction_id)
            {
                case 0:
                    future_y -= 1;/*Up*/ReturnMove(Movement.Up); //predict position based on direction id
                    break;

                case 1:
                    future_y += 1;/*Down*/ReturnMove(Movement.Down); //predict position based on direction id
                    break;

                case 2:
                    future_x -= 1;/*Left*/ReturnMove(Movement.Left); //predict position based on direction id
                    break;

                case 3:
                    future_x += 1;/*Right*/ReturnMove(Movement.Right); //predict position based on direction id
                    break;
            }


            return (future_x, future_y);//return da calculated values(づ｡◕‿‿◕｡)づ, we gonna use'em later.



        }


        public override void ReturnMove(Movement move)//method that checks collision for enemy based on the predicted movement
        {



            CharacterVision();//call the character vision method so the assigning of the character vision array fires


            //MessageBox.Show("this is return move on goblin");

            int future_y = y;//this will store out predicted y

            int future_x = x;//this will store out predicted x

            if (move == Movement.Up)//if movement is up move predicted y up;
            {
                future_y -= 1;
            }
            else if (move == Movement.Down)//if movement is up move predicted y down;
            {
                future_y += 1;
            }

            if (move == Movement.Right)//if movement is up move predicted x right;
            {
                future_x += 1;
            }
            else if (move == Movement.Left)//if movement is up move predicted x left;
            {
                future_x -= 1;
            }

            if (charactar_vision[future_x, future_y] != null)//if the value we want to move to is NOT null accourding to the character vision array
            {
                Move(move);//we return our calculates movement

            }
            else if (charactar_vision[future_x, future_y] == null)//if the value we want to move to IS null
            {
                LeaderMovement();//then we call for roll direction to find a new position to move to

            }



        }


        private (int, int) DistanceTo(Character tracker, Character target)//a dual int method for checking the distance between two charactars
        {

            int x_distance;
            int y_distance;

            x_distance = tracker.x - target.x;//the distance x is the difference of the tracker x and the target x

            y_distance = tracker.y - target.y;//the distance y is the difference of the tracker y and the target y

            return (Math.Abs(x_distance), Math.Abs(y_distance));//we return the calculated distance
        }

        public override bool CheckRange((int, int) desired_range, Character tracker, Character target)
        {

            if (tracker.character_id == "hero")
            {//checking of the tracker for range is the hero

                bool in_range;//bool that will represent whether or not we are in range

                (int, int) distance;//int to store the distance calculated in DistanceTo

                distance = DistanceTo(tracker, target);//assigning distance to DistanceTo

                //MessageBox.Show(string.Format("goblin distance = x : {0} , y : {1}", distance.Item1, distance.Item2));

                if (desired_range.Item1 >= distance.Item1 && desired_range.Item2 >= distance.Item2)//if the desired range on x and y is less than are equal to the distance we return true if not then we are out of range and we return false
                {
                    in_range = true;//sets the range bool to true
                }
                else { in_range = false;/*sets the range bool to false*/ }

                return in_range;//return the bool calculated for
            }
            return false;//if the tracker character id is not either options checked for we return false
        }


    }







    public class Hero : Character//the HERO ᕦ(ò_óˇ)ᕤ object that handles player controll, it derives from character... cause we wanna move..........
    {


        public Map map;//instance of the map object

        public Tile[,] Game_Tiles;

        public List<Item> hero_items = new List<Item>();//list stores hero items

        public List<int> hero_gold = new List<int>();//list stores hero gold

        public Hero (int hero_x, int hero_y, int hero_max_hp, int hero_damage)//constructor recieves and sets, yeah yeah... 
        {

            

            x = hero_x;
            y = hero_y;
            max_hp = hero_max_hp;
            damage = hero_damage;
            current_hp = hero_max_hp;

            character_id = "hero";

            this.Equip(new MeleeWeapon(0,0,Weapon.WeaponType.BareHands));

            gold_amt = hero_gold.Sum();

        }



        public void PickUpItem(Item item)//method that allows is to add an item to the characters inventory
        {
            if (item != null) {

                hero_items.Clear();

                hero_items.Add(item);//add the item to the hero items inventory(List)

                if (item.item_type == "gold")//if the item we add is gold
                {
                    
                    foreach (Gold gold in hero_items)//for every gold item in the hero items list
                    {

                        hero_gold.Add(gold.gold_accsesor);//we add the gold amount to the hero_gold list
                    }

                    gold_amt = hero_gold.Sum();

                }

                if (item.item_type == "Dagger")
                {
                    this.Equip(new MeleeWeapon(0, 0, Weapon.WeaponType.Dagger));

                }

                if (item.item_type == "Longsword")
                {
                    this.Equip(new MeleeWeapon(0, 0, Weapon.WeaponType.Longsword));

                }

                if (item.item_type == "Longbow")
                {
                    this.Equip(new RangedWeapon(0, 0, Weapon.WeaponType.Longbow));

                }

                if (item.item_type == "Rifel")
                {
                    this.Equip(new RangedWeapon(0, 0, Weapon.WeaponType.Rifel));

                }


            }
        

        }

        

                public void GetKeys (KeyEventArgs kea)//a method that recieves a key value"KeyEventArgs" and uses to te check for specific key movement, WSAD
        {
               

                    if (kea.KeyCode.Equals(Keys.W))//if we press W
                    {

                        //Console.WriteLine("W pressed");
                        ReturnMove(Movement.Up);//pass up to ReturnMove
                    }
                    else if (kea.KeyCode.Equals(Keys.A))//if we press A
            {
               
                        //Console.WriteLine("A pressed");
                        ReturnMove(Movement.Left);//pass left to ReturnMove
            }
                    else if (kea.KeyCode.Equals(Keys.S))//if we press S
            {
                
                        //Console.WriteLine("S pressed");
                        ReturnMove(Movement.Down);//pass down to ReturnMove
            }
                    else if (kea.KeyCode.Equals(Keys.D))//if we press D
            {
        
                        //Console.WriteLine("D pressed");
                        ReturnMove(Movement.Right);//pass down to ReturnMove
            }


                }

        void CharacterVision()//the method that assignes the charactar vision array
        {
            
            charactar_vision = new Tile[map.x_map_size, map.y_map_size];//set the size of the array

            for (int x = 0; x <= map.x_map_size - 1; x++)
            {
                for (int y = 0; y <= map.y_map_size - 1; y++)
                {
                    if (Game_Tiles[x, y].tile_type == TileType.Air || Game_Tiles[x, y].tile_type == TileType.Gold || Game_Tiles[x, y].tile_type == TileType.Dagger || Game_Tiles[x, y].tile_type == TileType.Longsword || Game_Tiles[x, y].tile_type == TileType.Longbow || Game_Tiles[x, y].tile_type == TileType.Rifel)//if we loop through air tiles and gold tiles
                    {
                        charactar_vision[x, y] = Game_Tiles[x, y];//we assign them to the character vision array

                    }
                    else { charactar_vision[x, y] = null;/*every other value in the array should be null*/ }
                }
            }
        }


        public override void ReturnMove(Movement ro_move)//a method that checks for collision and passes the final move enum back to move(☞ຈل͜ຈ)☞
        {
            CharacterVision();//call the character vision method so the assigning of the character vision array fires

            int future_y = y;//this will store out predicted y

                    int future_x = x;//this will store out predicted x

                if (ro_move == Movement.Up)//if movement is up move predicted y up;
                    {
                        future_y -= 1;
                    }
                    else if (ro_move == Movement.Down)//if movement is up move predicted y down;
            {
                        future_y += 1;
                    }

                    if (ro_move == Movement.Right)//if movement is up move predicted x right;
            {
                        future_x += 1;
                    }
                    else if (ro_move == Movement.Left)//if movement is up move predicted x left;
            {
                        future_x -= 1;
                    }

                    //Console.WriteLine(string.Format("future x : {0} , future y : {1}", future_x, future_y));

            if (charactar_vision[future_x,future_y] != null)//if the value we want to move to is NOT null accourding to the character vision array
            {

                Move(ro_move);//return movement up,down,left,right

            }
            else if (charactar_vision[future_x, future_y] == null)//if the value we want to move to IS null
            {

                Move(Movement.NoMovement);//if not we return the NoMovement enum ┬┴┬┴┤ ͜ʖ ͡°) ├┬┴┬┴

            }
            
            }


    }





    public class Map//the map class the generates our map we display in game engine, way up there! (°ロ°)☝
    {
        int min_map_size_x;//smallest the map x size can be
        int min_map_size_y;//smallest the map y size can be

        int max_map_size_x;//largest the map x size can be
        int max_map_size_y;//largest the map x size can be

        Random rand_num = new Random();//random thingy for random number genning

        public int x_map_size;//the actual x map size
        public int y_map_size;//the actual y map size

        public Hero hero;//instance of the hero object 

        int enemy_amt;//number of enemies we make

        int item_amt;//number of items are in the map

        public Enemy[] enemies;//the array of Enemy objects

        int num_goblins = 0;

        int num_mages = 0;

        int num_leaders = 0;

        public Tile[,] generated_map;

        public Item[] items;


        public Map() { }

        public Map(int num_enemies,int num_items , int mi_m_s_x, int ma_m_s_x, int mi_m_s_y, int ma_m_s_y)//the map constructor that revieces values for the min and max map sizes and amount of enemies
        {
            enemy_amt = num_enemies;

            item_amt = num_items;

            min_map_size_x = mi_m_s_x;
            max_map_size_x = ma_m_s_x;

            min_map_size_y = mi_m_s_y;
            max_map_size_y = ma_m_s_y;

            x_map_size = DecideMapSize().Item1;//actual map size x = the randomly generated map size x
            y_map_size = DecideMapSize().Item2;//actual map size y = the randomly generated map size y

            enemies = Enemies();//assign the enemies array

            items = Items();//assign the items array
            

        }

        public void SetUpMapComponents ()//sets up map components
        {

            generated_map = GenMap();//assign gen map to generated map
        }
        

        public (int, int) DecideMapSize()//dual int method that generates a random map size
        {

            rand_num = new Random();

            int x = rand_num.Next(min_map_size_x, max_map_size_x);

            int y = rand_num.Next(min_map_size_y, max_map_size_y);



            return (x, y);

        }



        (int,int) RandomEnemySpawn ()//dual int generates random enemy spawn point
        {


            //Console.WriteLine(x_map_size);

            int x = rand_num.Next(2, x_map_size - 1);

            int y = rand_num.Next(2, y_map_size - 1);



            return (x, y);

        }

       
        int RandomItemPicker ()
        {


            return rand_num.Next(0, 5); ;
        }


        Item[] Items ()//items method that adds items to the map
        {
            Item[] items = new Item[item_amt];//create the items array and set its size

            for (int i = 0; i <= item_amt - 1; i++)//loop through every item
            {
               
                switch(RandomItemPicker())
                {
                    case 0:
                        items[i] = new Gold(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2);//add gold to the items array at a random position

                        break;

                    case 1:
                        items[i] = new MeleeWeapon(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2, Weapon.WeaponType.Dagger);//add gold to the items array at a random position

                        break;

                    case 2:
                        items[i] = new MeleeWeapon(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2, Weapon.WeaponType.Longsword);//add gold to the items array at a random position

                        break;

                    case 3:
                        items[i] = new RangedWeapon(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2, Weapon.WeaponType.Longbow);//add gold to the items array at a random position

                        break;

                    case 4:
                        items[i] = new RangedWeapon(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2, Weapon.WeaponType.Rifel);//add gold to the items array at a random position

                        break;


                }

                    

                
            }
                return items;//return the items array
        }

        public Item GetItemAtPosition(int i_x, int i_y)//Item method that gets an item at a given position and then returns the item
        {

            Item added_item;//local variable to store the item

            for (int i = 0; i <= items.Length - 1; i++)//loop through the items array
            {

                if (items[i] != null)/*if the current item is not null*/ {

                    if (items[i].x == i_x && items[i].y == i_y)//check if the items position is = to the position we specified
                    {
                        added_item = items[i];//grab the item and store it in the local variable

                        items[i] = null;//remove that item we just got by settings its value to null

                        return added_item;//return the local item variable

                    }
                }
            }

            return null;
        }

        private int PickEnemy()//int that returns a random number based on the number of enemy types(in this case 2), the int will serve as the id for the enemy type i.e 1 = goblin 2 = mage
        {
            int enemy_id;

            enemy_id = rand_num.Next(0, 3);


            return enemy_id;

        }


        Enemy[] Enemies ()//array of enemy objects
        {
            Enemy[] enemies = new Enemy[enemy_amt];//setting the size of the enemy array to the enemy amount that is recieved in the constructor

            for (int i = 0; i <= enemy_amt - 1;i++)//loop through enemy amt and make enemies
            {

                switch (PickEnemy())//switch statement to check the enemy if chosen
                {

                    case 0://if the pick enemy random int id is zero we add a goblin to the enemies array
                        /*Console.WriteLine("goblin");*/ enemies[i] = new Goblin(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2);//if id is 0 then we add a goblin to the enemies array
                        break;
                    case 1://if the pick enemy random int id is one we add a mage to the enemies array
                        /*(Console.WriteLine("mage");*/ enemies[i] = new Mage(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2);//if id is 1 then we add a mage to the enemies array
                        break;
                    case 2://if the pick enemy random int id is two we add a leader to the enemies array
                        /*Console.WriteLine("goblin");*/
                        enemies[i] = new Leader(RandomEnemySpawn().Item1, RandomEnemySpawn().Item2);//if id is 2 then we add a leader to the enemies array
                        break;

                }

                

                    //Console.WriteLine(enemies.Length);

            }

            return enemies;

        }

        
        
       

        public Tile[,] GenMap ()//2d tile array where we generate our map
        {
            //Console.WriteLine(string.Format ("hero x : {0} , hero y : {1}" , hero.x, hero.y));

            Tile[,] tile_array_size = new Tile[x_map_size, y_map_size];//set the size of the array to actual sizes

            for (int x = 0; x <= x_map_size - 1; x++)//nested for loop that loops through the map sizes and ads tiles to the tile array
            {
                for (int y = 0; y <= y_map_size - 1; y++)
                {

                    if (x == 0 || x == x_map_size - 1 || y == 0 || y == y_map_size - 1)//if yoy are a tile in the border create and assign wall
                    {
                        tile_array_size[x, y] = new Tile(x, y, Tile.TileType.Wall);

                    }
                    else if (x == hero.x && y == hero.y)//if you are equal to the player posittion create and assign player
                    {
                        tile_array_size[x, y] = new Tile(x, y, Tile.TileType.Player);
                    }
                    else { tile_array_size[x, y] = new Tile(x, y, Tile.TileType.Air); }//if you are neither player or wall you are air tile
                }

            }

            for (int i = 0; i <= enemy_amt - 1; i++)//loop through enemy amount and create and assign enemies to the tile array

            {


                if (enemies[i] != null)
                {


                    switch (enemies[i].enemy_id) //we check the string id of the enemy to know what tile type to assign to the tile
                    {

                        case "goblin"://if the ememy id is goblin
                            /*Console.WriteLine("goblin");*/
                            tile_array_size[enemies[i].x, enemies[i].y] = new Tile(enemies[i].x, enemies[i].y, Tile.TileType.Goblin);//we give the tile added the goblin tag
                            num_goblins += 1;
                            break;
                        case "mage"://if the ememy id is mage
                            /*Console.WriteLine("mage");*/
                            tile_array_size[enemies[i].x, enemies[i].y] = new Tile(enemies[i].x, enemies[i].y, Tile.TileType.Mage);//we give the tile added the mage tag
                            num_mages += 1;
                            break;
                        case "leader"://if the ememy id is goblin
                            /*Console.WriteLine("goblin");*/
                            tile_array_size[enemies[i].x, enemies[i].y] = new Tile(enemies[i].x, enemies[i].y, Tile.TileType.Leader);//we give the tile added the goblin tag
                            num_leaders += 1;
                            break;

                    }


                }



             //Console.WriteLine(string.Format ("enemy added/updated @ x : {0} , y : {1}" , enemies[i].x, enemies[i].y));
            }

            for (int i = 0; i <= item_amt - 1; i++)//loop through items array
            {

                if (items[i] != null)//if the current item is not null and its a gold item
                {

                    if (items[i].item_type == "gold")
                    {
                        tile_array_size[items[i].x, items[i].y] = new Tile(items[i].x, items[i].y, Tile.TileType.Gold);//we add the gold to the map
                    }

                    if (items[i].item_type == "Dagger")
                    {
                        tile_array_size[items[i].x, items[i].y] = new Tile(items[i].x, items[i].y, Tile.TileType.Dagger);//we add the gold to the map

                        //Console.WriteLine(string.Format("Dagger spawned at {0} , {1}" , items[i].x, items[i].y));
                    }

                    if (items[i].item_type == "Longsword")
                    {
                        tile_array_size[items[i].x, items[i].y] = new Tile(items[i].x, items[i].y, Tile.TileType.Longsword);//we add the gold to the map

                        //Console.WriteLine("Longsword Spawned");
                    }

                    if (items[i].item_type == "Longbow")
                    {
                        tile_array_size[items[i].x, items[i].y] = new Tile(items[i].x, items[i].y, Tile.TileType.Longbow);//we add the gold to the map

                        //Console.WriteLine("Longbow Spawned");
                    }


                    if (items[i].item_type == "Rifel")
                    {
                        tile_array_size[items[i].x, items[i].y] = new Tile(items[i].x, items[i].y, Tile.TileType.Rifel);//we add the gold to the map

                        //Console.WriteLine("Rifel Spawned");
                    }


                }
                else if (items[i] != null)//else
                {
                    tile_array_size[items[i].x, items[i].y] = new Tile(items[i].x, items[i].y, Tile.TileType.Air);//we add an air tile instead
                }
            }


                generated_map = tile_array_size;

            return tile_array_size;

        }


        public void UpdateEnemies ()//method that updates the enemies 
        {

           

            //Console.WriteLine("update enemies called");

            Mage[] mages = new Mage[10];//array of mages so we can access every instance of Mage on our map
            Goblin[] goblins = new Goblin[10];//array of goblins so we can access every instance of Goblin on our map
            Leader[] leaders = new Leader[10];//array of lerders so we can access every instance of Leader on our map

            for (int i = 0; i <= enemy_amt - 1; i++)//loop through every enemy in the enemies array
            {

                if (enemies[i] != null)
                {

                    enemies[i].map_tiles = generated_map;//assign the tile array gen map to the map_tiles for every enemy instance
                    enemies[i].x_size = x_map_size;
                    enemies[i].y_size = y_map_size;



                    switch (enemies[i].enemy_id)//check the id of the enemy
                    {

                        case "goblin"://if enemy is a goblin
                            goblins[i] = (Goblin)enemies[i];//we take the goblins out of the enemies array and store them in the goblins array to we can access them
                            goblins[i].RollDirection();//we cann rolldirection to update
                            break;
                        case "mage"://if enemy is mage
                            mages[i] = (Mage)enemies[i];//we take the mages out of the enemies array and store them in the mages array to we can access them
                            break;
                        case "leader"://if enemy is a goblin
                            leaders[i] = (Leader)enemies[i];//we take the lerders out of the enemies array and store them in the leaders array to we can access them
                            leaders[i].LeaderMovement();//we cann leadermovement to update
                            break;

                    }


                    if (enemies[i].IsDead(enemies[i]) == true)
                    {

                        Console.WriteLine(string.Format("enemy {0} is sentenced for termination by the program.", enemies[i]));



                        enemies[i] = null;

                        Form1 f1 = new Form1();

                        f1.DeleteEnemy(i);




                    }

                }
                
            }
        }



        public void CheckEnemies()//method that updates the enemies 
        {



            //Console.WriteLine("update enemies called");

            Mage[] mages = new Mage[10];//array of mages so we can access every instance of Mage on our map
            Goblin[] goblins = new Goblin[10];//array of goblins so we can access every instance of Goblin on our map
            Leader[] leaders = new Leader[10];//array of leaders so we can access every instance of Leader on our map

            for (int i = 0; i <= enemy_amt - 1; i++)//loop through every enemy in the enemies array
            {

                if (enemies[i] != null)
                {

                    enemies[i].map_tiles = generated_map;//assign the tile array gen map to the map_tiles for every enemy instance
                    enemies[i].x_size = x_map_size;
                    enemies[i].y_size = y_map_size;



                    switch (enemies[i].enemy_id)//check the id of the enemy
                    {

                        case "goblin"://if enemy is a goblin
                            goblins[i] = (Goblin)enemies[i];//we take the goblins out of the enemies array and store them in the goblins array to we can access them
                           
                            break;
                        case "mage"://if enemy is mage
                            mages[i] = (Mage)enemies[i];//we take the mages out of the enemies array and store them in the mages array to we can access them
                            break;
                        case "leader"://if enemy is a goblin
                            leaders[i] = (Leader)enemies[i];//we take the leaders out of the enemies array and store them in the leaders array to we can access them
                            break;

                    }


                    if (enemies[i].IsDead(enemies[i]) == true)
                    {

                        Console.WriteLine(string.Format("enemy {0} is sentenced for termination by the program.", enemies[i]));



                        enemies[i] = null;

                        Form1 f1 = new Form1();

                        f1.DeleteEnemy(i);




                    }

                }

            }
        }





    }

}//19338445 Ethan Daniel Hunt, my fingers dont hurt as much (¬‿¬)