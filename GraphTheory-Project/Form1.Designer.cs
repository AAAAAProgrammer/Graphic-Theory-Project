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
            this.chxDrwaLine = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chboxGrid = new System.Windows.Forms.CheckBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panl1
            // 
            this.panl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panl1.Controls.Add(this.dataGridView1);
            this.panl1.Location = new System.Drawing.Point(731, 34);
            this.panl1.Name = "panl1";
            this.panl1.Size = new System.Drawing.Size(661, 565);
            this.panl1.TabIndex = 0;
            this.panl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panl1_Paint);
            this.panl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panl1_MouseClick);
            this.panl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // chxDrwaLine
            // 
            this.chxDrwaLine.AutoSize = true;
            this.chxDrwaLine.Location = new System.Drawing.Point(45, 649);
            this.chxDrwaLine.Name = "chxDrwaLine";
            this.chxDrwaLine.Size = new System.Drawing.Size(74, 17);
            this.chxDrwaLine.TabIndex = 3;
            this.chxDrwaLine.Text = "Drwa Line";
            this.chxDrwaLine.UseVisualStyleBackColor = true;
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
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouse.Location = new System.Drawing.Point(456, 649);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(64, 25);
            this.lblMouse.TabIndex = 3;
            this.lblMouse.Text = "TTTT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(3, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 208);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 701);
            this.Controls.Add(this.chxDrwaLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.chboxGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panl1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chboxGrid;
        private System.Windows.Forms.CheckBox chxDrwaLine;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

