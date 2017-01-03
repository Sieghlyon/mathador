namespace Mathador
{
    partial class Menu_windows
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
            this.to_score = new System.Windows.Forms.Button();
            this.to_game = new System.Windows.Forms.Button();
            this.pseudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // to_score
            // 
            this.to_score.Location = new System.Drawing.Point(380, 303);
            this.to_score.Name = "to_score";
            this.to_score.Size = new System.Drawing.Size(250, 153);
            this.to_score.TabIndex = 0;
            this.to_score.Text = "score";
            this.to_score.UseVisualStyleBackColor = true;
            this.to_score.Click += new System.EventHandler(this.to_score_Click);
            // 
            // to_game
            // 
            this.to_game.Location = new System.Drawing.Point(828, 303);
            this.to_game.Name = "to_game";
            this.to_game.Size = new System.Drawing.Size(272, 135);
            this.to_game.TabIndex = 1;
            this.to_game.Text = "game";
            this.to_game.UseVisualStyleBackColor = true;
            this.to_game.Click += new System.EventHandler(this.to_game_Click);
            // 
            // pseudo
            // 
            this.pseudo.Location = new System.Drawing.Point(462, 149);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(462, 20);
            this.pseudo.TabIndex = 2;
            // 
            // Menu_windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pseudo);
            this.Controls.Add(this.to_game);
            this.Controls.Add(this.to_score);
            this.Name = "Menu_windows";
            this.Size = new System.Drawing.Size(1446, 644);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button to_score;
        private System.Windows.Forms.Button to_game;
        private System.Windows.Forms.TextBox pseudo;
    }
}
