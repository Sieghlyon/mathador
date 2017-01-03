namespace Mathador
{
    partial class Score_windows
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
            this.Score_Grid = new System.Windows.Forms.DataGridView();
            this.to_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Score_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Score_Grid
            // 
            this.Score_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Score_Grid.Location = new System.Drawing.Point(3, 3);
            this.Score_Grid.Name = "Score_Grid";
            this.Score_Grid.Size = new System.Drawing.Size(969, 397);
            this.Score_Grid.TabIndex = 0;
            // 
            // to_menu
            // 
            this.to_menu.Location = new System.Drawing.Point(1123, 490);
            this.to_menu.Name = "to_menu";
            this.to_menu.Size = new System.Drawing.Size(260, 97);
            this.to_menu.TabIndex = 1;
            this.to_menu.Text = "menu";
            this.to_menu.UseVisualStyleBackColor = true;
            this.to_menu.Click += new System.EventHandler(this.to_menu_Click);
            // 
            // Score_windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.to_menu);
            this.Controls.Add(this.Score_Grid);
            this.Name = "Score_windows";
            this.Size = new System.Drawing.Size(1413, 624);
            ((System.ComponentModel.ISupportInitialize)(this.Score_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Score_Grid;
        private System.Windows.Forms.Button to_menu;
    }
}
