namespace GraphTheory_Project
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
            this.panl1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chboxGrid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panl1
            // 
            this.panl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panl1.Location = new System.Drawing.Point(730, 185);
            this.panl1.Name = "panl1";
            this.panl1.Size = new System.Drawing.Size(661, 504);
            this.panl1.TabIndex = 0;
            this.panl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panl1_Paint);
            this.panl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panl1_MouseClick);
            this.panl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 565);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // chboxGrid
            // 
            this.chboxGrid.AutoSize = true;
            this.chboxGrid.Location = new System.Drawing.Point(45, 626);
            this.chboxGrid.Name = "chboxGrid";
            this.chboxGrid.Size = new System.Drawing.Size(75, 17);
            this.chboxGrid.TabIndex = 2;
            this.chboxGrid.Text = "Show Grid";
            this.chboxGrid.UseVisualStyleBackColor = true;
            this.chboxGrid.CheckStateChanged += new System.EventHandler(this.chboxGrid_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 701);
            this.Controls.Add(this.chboxGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panl1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chboxGrid;
    }
}

