namespace _19338445_GADE_6112_Task_1
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
            this.user_controlls_lable = new System.Windows.Forms.Label();
            this.w_lable = new System.Windows.Forms.Label();
            this.s_lable = new System.Windows.Forms.Label();
            this.d_lable = new System.Windows.Forms.Label();
            this.a_lable = new System.Windows.Forms.Label();
            this.enemy_list = new System.Windows.Forms.ComboBox();
            this.attack_enemy_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hero_gold_label = new System.Windows.Forms.Label();
            this.hero_health_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enemy_health_label = new System.Windows.Forms.Label();
            this.hero_damage_label = new System.Windows.Forms.Label();
            this.enemy_damage_label = new System.Windows.Forms.Label();
            this.enemy_type_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hero_position_label = new System.Windows.Forms.Label();
            this.hero_weapon_label = new System.Windows.Forms.Label();
            this.enemy_weapon_label = new System.Windows.Forms.Label();
            this.hero_weapon_durability = new System.Windows.Forms.Label();
            this.enemy_weapon_durability = new System.Windows.Forms.Label();
            this.hero_weapon_range = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_controlls_lable
            // 
            this.user_controlls_lable.AutoSize = true;
            this.user_controlls_lable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.user_controlls_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.user_controlls_lable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_controlls_lable.Location = new System.Drawing.Point(593, 20);
            this.user_controlls_lable.Name = "user_controlls_lable";
            this.user_controlls_lable.Size = new System.Drawing.Size(195, 31);
            this.user_controlls_lable.TabIndex = 0;
            this.user_controlls_lable.Text = "User Controlls:";
            // 
            // w_lable
            // 
            this.w_lable.AutoSize = true;
            this.w_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.w_lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.w_lable.Location = new System.Drawing.Point(593, 51);
            this.w_lable.Name = "w_lable";
            this.w_lable.Size = new System.Drawing.Size(162, 31);
            this.w_lable.TabIndex = 1;
            this.w_lable.Text = "Move Up: W";
            // 
            // s_lable
            // 
            this.s_lable.AutoSize = true;
            this.s_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.s_lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.s_lable.Location = new System.Drawing.Point(593, 82);
            this.s_lable.Name = "s_lable";
            this.s_lable.Size = new System.Drawing.Size(190, 31);
            this.s_lable.TabIndex = 2;
            this.s_lable.Text = "Move Down: S";
            // 
            // d_lable
            // 
            this.d_lable.AutoSize = true;
            this.d_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.d_lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.d_lable.Location = new System.Drawing.Point(593, 113);
            this.d_lable.Name = "d_lable";
            this.d_lable.Size = new System.Drawing.Size(186, 31);
            this.d_lable.TabIndex = 3;
            this.d_lable.Text = "Move Right: D";
            // 
            // a_lable
            // 
            this.a_lable.AutoSize = true;
            this.a_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.a_lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a_lable.Location = new System.Drawing.Point(593, 144);
            this.a_lable.Name = "a_lable";
            this.a_lable.Size = new System.Drawing.Size(166, 31);
            this.a_lable.TabIndex = 4;
            this.a_lable.Text = "Move Left: A";
            // 
            // enemy_list
            // 
            this.enemy_list.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.enemy_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemy_list.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enemy_list.FormattingEnabled = true;
            this.enemy_list.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.enemy_list.Location = new System.Drawing.Point(575, 237);
            this.enemy_list.Name = "enemy_list";
            this.enemy_list.Size = new System.Drawing.Size(213, 21);
            this.enemy_list.TabIndex = 5;
            this.enemy_list.SelectedIndexChanged += new System.EventHandler(this.enemy_list_SelectedIndexChanged);
            // 
            // attack_enemy_button
            // 
            this.attack_enemy_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attack_enemy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.attack_enemy_button.ForeColor = System.Drawing.Color.Red;
            this.attack_enemy_button.Location = new System.Drawing.Point(473, 21);
            this.attack_enemy_button.Name = "attack_enemy_button";
            this.attack_enemy_button.Size = new System.Drawing.Size(114, 40);
            this.attack_enemy_button.TabIndex = 6;
            this.attack_enemy_button.Text = "Attack";
            this.attack_enemy_button.UseVisualStyleBackColor = false;
            this.attack_enemy_button.Click += new System.EventHandler(this.attack_enemy_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(794, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hero Stats";
            // 
            // hero_gold_label
            // 
            this.hero_gold_label.AutoSize = true;
            this.hero_gold_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hero_gold_label.ForeColor = System.Drawing.Color.Yellow;
            this.hero_gold_label.Location = new System.Drawing.Point(794, 51);
            this.hero_gold_label.Name = "hero_gold_label";
            this.hero_gold_label.Size = new System.Drawing.Size(101, 31);
            this.hero_gold_label.TabIndex = 9;
            this.hero_gold_label.Text = "Gold: _";
            // 
            // hero_health_label
            // 
            this.hero_health_label.AutoSize = true;
            this.hero_health_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hero_health_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hero_health_label.Location = new System.Drawing.Point(794, 82);
            this.hero_health_label.Name = "hero_health_label";
            this.hero_health_label.Size = new System.Drawing.Size(123, 31);
            this.hero_health_label.TabIndex = 10;
            this.hero_health_label.Text = "Health: _";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(794, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enemy Stats";
            // 
            // enemy_health_label
            // 
            this.enemy_health_label.AutoSize = true;
            this.enemy_health_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enemy_health_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enemy_health_label.Location = new System.Drawing.Point(794, 313);
            this.enemy_health_label.Name = "enemy_health_label";
            this.enemy_health_label.Size = new System.Drawing.Size(123, 31);
            this.enemy_health_label.TabIndex = 12;
            this.enemy_health_label.Text = "Health: _";
            // 
            // hero_damage_label
            // 
            this.hero_damage_label.AutoSize = true;
            this.hero_damage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hero_damage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.hero_damage_label.Location = new System.Drawing.Point(794, 113);
            this.hero_damage_label.Name = "hero_damage_label";
            this.hero_damage_label.Size = new System.Drawing.Size(146, 31);
            this.hero_damage_label.TabIndex = 13;
            this.hero_damage_label.Text = "Damage: _";
            // 
            // enemy_damage_label
            // 
            this.enemy_damage_label.AutoSize = true;
            this.enemy_damage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enemy_damage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.enemy_damage_label.Location = new System.Drawing.Point(794, 344);
            this.enemy_damage_label.Name = "enemy_damage_label";
            this.enemy_damage_label.Size = new System.Drawing.Size(146, 31);
            this.enemy_damage_label.TabIndex = 14;
            this.enemy_damage_label.Text = "Damage: _";
            // 
            // enemy_type_label
            // 
            this.enemy_type_label.AutoSize = true;
            this.enemy_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enemy_type_label.ForeColor = System.Drawing.Color.Lime;
            this.enemy_type_label.Location = new System.Drawing.Point(794, 375);
            this.enemy_type_label.Name = "enemy_type_label";
            this.enemy_type_label.Size = new System.Drawing.Size(105, 31);
            this.enemy_type_label.TabIndex = 15;
            this.enemy_type_label.Text = "Type: _";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label3.Location = new System.Drawing.Point(576, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enemy Selection:";
            // 
            // hero_position_label
            // 
            this.hero_position_label.AutoSize = true;
            this.hero_position_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hero_position_label.ForeColor = System.Drawing.Color.White;
            this.hero_position_label.Location = new System.Drawing.Point(794, 144);
            this.hero_position_label.Name = "hero_position_label";
            this.hero_position_label.Size = new System.Drawing.Size(170, 31);
            this.hero_position_label.TabIndex = 17;
            this.hero_position_label.Text = "Location: _:_";
            // 
            // hero_weapon_label
            // 
            this.hero_weapon_label.AutoSize = true;
            this.hero_weapon_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hero_weapon_label.ForeColor = System.Drawing.Color.Fuchsia;
            this.hero_weapon_label.Location = new System.Drawing.Point(794, 175);
            this.hero_weapon_label.Name = "hero_weapon_label";
            this.hero_weapon_label.Size = new System.Drawing.Size(144, 31);
            this.hero_weapon_label.TabIndex = 18;
            this.hero_weapon_label.Text = "Weapon: _";
            // 
            // enemy_weapon_label
            // 
            this.enemy_weapon_label.AutoSize = true;
            this.enemy_weapon_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enemy_weapon_label.ForeColor = System.Drawing.Color.Fuchsia;
            this.enemy_weapon_label.Location = new System.Drawing.Point(796, 406);
            this.enemy_weapon_label.Name = "enemy_weapon_label";
            this.enemy_weapon_label.Size = new System.Drawing.Size(144, 31);
            this.enemy_weapon_label.TabIndex = 19;
            this.enemy_weapon_label.Text = "Weapon: _";
            // 
            // hero_weapon_durability
            // 
            this.hero_weapon_durability.AutoSize = true;
            this.hero_weapon_durability.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hero_weapon_durability.ForeColor = System.Drawing.Color.Aqua;
            this.hero_weapon_durability.Location = new System.Drawing.Point(796, 206);
            this.hero_weapon_durability.Name = "hero_weapon_durability";
            this.hero_weapon_durability.Size = new System.Drawing.Size(151, 31);
            this.hero_weapon_durability.TabIndex = 20;
            this.hero_weapon_durability.Text = "Durability:_";
            // 
            // enemy_weapon_durability
            // 
            this.enemy_weapon_durability.AutoSize = true;
            this.enemy_weapon_durability.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enemy_weapon_durability.ForeColor = System.Drawing.Color.Aqua;
            this.enemy_weapon_durability.Location = new System.Drawing.Point(796, 437);
            this.enemy_weapon_durability.Name = "enemy_weapon_durability";
            this.enemy_weapon_durability.Size = new System.Drawing.Size(151, 31);
            this.enemy_weapon_durability.TabIndex = 21;
            this.enemy_weapon_durability.Text = "Durability:_";
            // 
            // hero_weapon_range
            // 
            this.hero_weapon_range.AutoSize = true;
            this.hero_weapon_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hero_weapon_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hero_weapon_range.Location = new System.Drawing.Point(796, 237);
            this.hero_weapon_range.Name = "hero_weapon_range";
            this.hero_weapon_range.Size = new System.Drawing.Size(117, 31);
            this.hero_weapon_range.TabIndex = 22;
            this.hero_weapon_range.Text = "Range:_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1124, 508);
            this.Controls.Add(this.hero_weapon_range);
            this.Controls.Add(this.enemy_weapon_durability);
            this.Controls.Add(this.hero_weapon_durability);
            this.Controls.Add(this.enemy_weapon_label);
            this.Controls.Add(this.hero_weapon_label);
            this.Controls.Add(this.hero_position_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enemy_type_label);
            this.Controls.Add(this.enemy_damage_label);
            this.Controls.Add(this.hero_damage_label);
            this.Controls.Add(this.enemy_health_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hero_health_label);
            this.Controls.Add(this.hero_gold_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attack_enemy_button);
            this.Controls.Add(this.enemy_list);
            this.Controls.Add(this.a_lable);
            this.Controls.Add(this.d_lable);
            this.Controls.Add(this.s_lable);
            this.Controls.Add(this.w_lable);
            this.Controls.Add(this.user_controlls_lable);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_controlls_lable;
        private System.Windows.Forms.Label w_lable;
        private System.Windows.Forms.Label s_lable;
        private System.Windows.Forms.Label d_lable;
        private System.Windows.Forms.Label a_lable;
        private System.Windows.Forms.ComboBox enemy_list;
        private System.Windows.Forms.Button attack_enemy_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hero_gold_label;
        private System.Windows.Forms.Label hero_health_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label enemy_health_label;
        private System.Windows.Forms.Label hero_damage_label;
        private System.Windows.Forms.Label enemy_damage_label;
        private System.Windows.Forms.Label enemy_type_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hero_position_label;
        private System.Windows.Forms.Label hero_weapon_label;
        private System.Windows.Forms.Label enemy_weapon_label;
        private System.Windows.Forms.Label hero_weapon_durability;
        private System.Windows.Forms.Label enemy_weapon_durability;
        private System.Windows.Forms.Label hero_weapon_range;
    }
}

