namespace Mathador
{
    partial class Game_windows
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number_3 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.soustraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.cible = new System.Windows.Forms.Label();
            this.watcher = new System.Windows.Forms.Label();
            this.suivant = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.score_player = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number_3
            // 
            this.number_3.Location = new System.Drawing.Point(617, 193);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(75, 23);
            this.number_3.TabIndex = 0;
            this.number_3.UseVisualStyleBackColor = true;
            this.number_3.Click += new System.EventHandler(this.number_3_Click);
            // 
            // number_2
            // 
            this.number_2.Location = new System.Drawing.Point(379, 193);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(75, 23);
            this.number_2.TabIndex = 1;
            this.number_2.UseVisualStyleBackColor = true;
            this.number_2.Click += new System.EventHandler(this.number_2_Click);
            // 
            // number_4
            // 
            this.number_4.Location = new System.Drawing.Point(845, 193);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(75, 23);
            this.number_4.TabIndex = 2;
            this.number_4.UseVisualStyleBackColor = true;
            this.number_4.Click += new System.EventHandler(this.number_4_Click);
            // 
            // number_5
            // 
            this.number_5.Location = new System.Drawing.Point(1106, 193);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(75, 23);
            this.number_5.TabIndex = 3;
            this.number_5.UseVisualStyleBackColor = true;
            this.number_5.Click += new System.EventHandler(this.number_5_Click);
            // 
            // number_1
            // 
            this.number_1.Location = new System.Drawing.Point(154, 193);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(75, 23);
            this.number_1.TabIndex = 4;
            this.number_1.UseVisualStyleBackColor = true;
            this.number_1.Click += new System.EventHandler(this.number_1_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(240, 364);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 5;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // soustraction
            // 
            this.soustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soustraction.Location = new System.Drawing.Point(484, 364);
            this.soustraction.Name = "soustraction";
            this.soustraction.Size = new System.Drawing.Size(90, 23);
            this.soustraction.TabIndex = 6;
            this.soustraction.Text = "-";
            this.soustraction.UseVisualStyleBackColor = true;
            this.soustraction.Click += new System.EventHandler(this.soustraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(730, 364);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 7;
            this.multiplication.Text = "X";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(1000, 364);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 8;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // cible
            // 
            this.cible.AutoSize = true;
            this.cible.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cible.Location = new System.Drawing.Point(644, 61);
            this.cible.Name = "cible";
            this.cible.Size = new System.Drawing.Size(29, 31);
            this.cible.TabIndex = 9;
            this.cible.Text = "0";
            // 
            // watcher
            // 
            this.watcher.AutoSize = true;
            this.watcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watcher.Location = new System.Drawing.Point(56, 37);
            this.watcher.Name = "watcher";
            this.watcher.Size = new System.Drawing.Size(185, 55);
            this.watcher.TabIndex = 10;
            this.watcher.Text = "3:00:00";
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(828, 469);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(75, 23);
            this.suivant.TabIndex = 11;
            this.suivant.Text = "passer";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(441, 469);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 12;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // score_player
            // 
            this.score_player.AutoSize = true;
            this.score_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_player.Location = new System.Drawing.Point(1121, 55);
            this.score_player.Name = "score_player";
            this.score_player.Size = new System.Drawing.Size(36, 39);
            this.score_player.TabIndex = 13;
            this.score_player.Text = "0";
            // 
            // Game_windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.score_player);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.watcher);
            this.Controls.Add(this.cible);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.soustraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_3);
            this.Name = "Game_windows";
            this.Size = new System.Drawing.Size(1335, 619);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button soustraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label cible;
        private System.Windows.Forms.Label watcher;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label score_player;
    }
}
