namespace _19338445_Ethan_Daniel_Hunt_GADE5111_Take_Home_Exam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_width_text_box = new System.Windows.Forms.TextBox();
            this.num_mines_text_box = new System.Windows.Forms.TextBox();
            this.grid_height_text_box = new System.Windows.Forms.TextBox();
            this.player_guidence_text = new System.Windows.Forms.Label();
            this.grid_x_size_lable = new System.Windows.Forms.Label();
            this.grid_y_size_lable = new System.Windows.Forms.Label();
            this.num_mines_lable = new System.Windows.Forms.Label();
            this.start_game_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grid_width_text_box
            // 
            this.grid_width_text_box.Location = new System.Drawing.Point(164, 60);
            this.grid_width_text_box.Name = "grid_width_text_box";
            this.grid_width_text_box.Size = new System.Drawing.Size(100, 20);
            this.grid_width_text_box.TabIndex = 0;
            this.grid_width_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grid_width_text_box_KeyPress);
            // 
            // num_mines_text_box
            // 
            this.num_mines_text_box.Location = new System.Drawing.Point(164, 112);
            this.num_mines_text_box.Name = "num_mines_text_box";
            this.num_mines_text_box.Size = new System.Drawing.Size(100, 20);
            this.num_mines_text_box.TabIndex = 1;
            this.num_mines_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_mines_text_box_KeyPress);
            // 
            // grid_height_text_box
            // 
            this.grid_height_text_box.Location = new System.Drawing.Point(164, 86);
            this.grid_height_text_box.Name = "grid_height_text_box";
            this.grid_height_text_box.Size = new System.Drawing.Size(100, 20);
            this.grid_height_text_box.TabIndex = 2;
            this.grid_height_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grid_height_text_box_KeyPress);
            // 
            // player_guidence_text
            // 
            this.player_guidence_text.AutoSize = true;
            this.player_guidence_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.player_guidence_text.Location = new System.Drawing.Point(21, 24);
            this.player_guidence_text.Name = "player_guidence_text";
            this.player_guidence_text.Size = new System.Drawing.Size(321, 24);
            this.player_guidence_text.TabIndex = 3;
            this.player_guidence_text.Text = "Enter your desired game paramaters!";
            // 
            // grid_x_size_lable
            // 
            this.grid_x_size_lable.AutoSize = true;
            this.grid_x_size_lable.Location = new System.Drawing.Point(98, 63);
            this.grid_x_size_lable.Name = "grid_x_size_lable";
            this.grid_x_size_lable.Size = new System.Drawing.Size(57, 13);
            this.grid_x_size_lable.TabIndex = 4;
            this.grid_x_size_lable.Text = "Grid Width";
            // 
            // grid_y_size_lable
            // 
            this.grid_y_size_lable.AutoSize = true;
            this.grid_y_size_lable.Location = new System.Drawing.Point(98, 89);
            this.grid_y_size_lable.Name = "grid_y_size_lable";
            this.grid_y_size_lable.Size = new System.Drawing.Size(60, 13);
            this.grid_y_size_lable.TabIndex = 5;
            this.grid_y_size_lable.Text = "Grid Height";
            // 
            // num_mines_lable
            // 
            this.num_mines_lable.AutoSize = true;
            this.num_mines_lable.Location = new System.Drawing.Point(72, 119);
            this.num_mines_lable.Name = "num_mines_lable";
            this.num_mines_lable.Size = new System.Drawing.Size(86, 13);
            this.num_mines_lable.TabIndex = 6;
            this.num_mines_lable.Text = "Number of mines";
            // 
            // start_game_button
            // 
            this.start_game_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.start_game_button.Location = new System.Drawing.Point(0, 138);
            this.start_game_button.Name = "start_game_button";
            this.start_game_button.Size = new System.Drawing.Size(375, 71);
            this.start_game_button.TabIndex = 7;
            this.start_game_button.Text = "START GAME";
            this.start_game_button.UseVisualStyleBackColor = true;
            this.start_game_button.Click += new System.EventHandler(this.start_game_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 212);
            this.Controls.Add(this.start_game_button);
            this.Controls.Add(this.num_mines_lable);
            this.Controls.Add(this.grid_y_size_lable);
            this.Controls.Add(this.grid_x_size_lable);
            this.Controls.Add(this.player_guidence_text);
            this.Controls.Add(this.grid_height_text_box);
            this.Controls.Add(this.num_mines_text_box);
            this.Controls.Add(this.grid_width_text_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox grid_width_text_box;
        private System.Windows.Forms.TextBox num_mines_text_box;
        private System.Windows.Forms.TextBox grid_height_text_box;
        private System.Windows.Forms.Label player_guidence_text;
        private System.Windows.Forms.Label grid_x_size_lable;
        private System.Windows.Forms.Label grid_y_size_lable;
        private System.Windows.Forms.Label num_mines_lable;
        private System.Windows.Forms.Button start_game_button;
    }
}

