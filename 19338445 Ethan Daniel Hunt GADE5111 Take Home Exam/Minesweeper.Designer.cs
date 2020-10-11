namespace _19338445_Ethan_Daniel_Hunt_GADE5111_Take_Home_Exam
{
    partial class Minesweeper
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
            this.mine_field_lable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.user_entered_y_pos_lable = new System.Windows.Forms.Label();
            this.user_entered_x_pos_lable = new System.Windows.Forms.Label();
            this.reveal_tile_button = new System.Windows.Forms.Button();
            this.flag_mine_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mine_field_lable
            // 
            this.mine_field_lable.AutoSize = true;
            this.mine_field_lable.Font = new System.Drawing.Font("Courier New", 10F);
            this.mine_field_lable.Location = new System.Drawing.Point(47, 52);
            this.mine_field_lable.Name = "mine_field_lable";
            this.mine_field_lable.Size = new System.Drawing.Size(56, 17);
            this.mine_field_lable.TabIndex = 0;
            this.mine_field_lable.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(564, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // user_entered_y_pos_lable
            // 
            this.user_entered_y_pos_lable.AutoSize = true;
            this.user_entered_y_pos_lable.Location = new System.Drawing.Point(680, 187);
            this.user_entered_y_pos_lable.Name = "user_entered_y_pos_lable";
            this.user_entered_y_pos_lable.Size = new System.Drawing.Size(54, 13);
            this.user_entered_y_pos_lable.TabIndex = 3;
            this.user_entered_y_pos_lable.Text = "Y Position";
            // 
            // user_entered_x_pos_lable
            // 
            this.user_entered_x_pos_lable.AutoSize = true;
            this.user_entered_x_pos_lable.Location = new System.Drawing.Point(680, 115);
            this.user_entered_x_pos_lable.Name = "user_entered_x_pos_lable";
            this.user_entered_x_pos_lable.Size = new System.Drawing.Size(54, 13);
            this.user_entered_x_pos_lable.TabIndex = 4;
            this.user_entered_x_pos_lable.Text = "X Position";
            // 
            // reveal_tile_button
            // 
            this.reveal_tile_button.Location = new System.Drawing.Point(576, 277);
            this.reveal_tile_button.Name = "reveal_tile_button";
            this.reveal_tile_button.Size = new System.Drawing.Size(75, 23);
            this.reveal_tile_button.TabIndex = 5;
            this.reveal_tile_button.Text = "Reveal Tile";
            this.reveal_tile_button.UseVisualStyleBackColor = true;
            // 
            // flag_mine_button
            // 
            this.flag_mine_button.Location = new System.Drawing.Point(576, 317);
            this.flag_mine_button.Name = "flag_mine_button";
            this.flag_mine_button.Size = new System.Drawing.Size(75, 23);
            this.flag_mine_button.TabIndex = 6;
            this.flag_mine_button.Text = "Flag Mine";
            this.flag_mine_button.UseVisualStyleBackColor = true;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flag_mine_button);
            this.Controls.Add(this.reveal_tile_button);
            this.Controls.Add(this.user_entered_x_pos_lable);
            this.Controls.Add(this.user_entered_y_pos_lable);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mine_field_lable);
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Minesweeper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mine_field_lable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label user_entered_y_pos_lable;
        private System.Windows.Forms.Label user_entered_x_pos_lable;
        private System.Windows.Forms.Button reveal_tile_button;
        private System.Windows.Forms.Button flag_mine_button;
    }
}