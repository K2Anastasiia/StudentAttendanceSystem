namespace StudentAttendanceSystem
{
    partial class GroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNameS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.nmrcNumberClasses = new System.Windows.Forms.NumericUpDown();
            this.pctrBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcNumberClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(269, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtNameS
            // 
            this.txtNameS.Location = new System.Drawing.Point(14, 37);
            this.txtNameS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameS.Name = "txtNameS";
            this.txtNameS.Size = new System.Drawing.Size(191, 23);
            this.txtNameS.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNameS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(313, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(224, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати студента в групу";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(88, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscipline.Location = new System.Drawing.Point(71, 349);
            this.lblDiscipline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(82, 17);
            this.lblDiscipline.TabIndex = 4;
            this.lblDiscipline.Text = "lblDiscipline";
            // 
            // nmrcNumberClasses
            // 
            this.nmrcNumberClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrcNumberClasses.Location = new System.Drawing.Point(26, 343);
            this.nmrcNumberClasses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrcNumberClasses.Name = "nmrcNumberClasses";
            this.nmrcNumberClasses.Size = new System.Drawing.Size(41, 23);
            this.nmrcNumberClasses.TabIndex = 6;
            this.nmrcNumberClasses.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // pctrBack
            // 
            this.pctrBack.Image = ((System.Drawing.Image)(resources.GetObject("pctrBack.Image")));
            this.pctrBack.Location = new System.Drawing.Point(466, 306);
            this.pctrBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctrBack.Name = "pctrBack";
            this.pctrBack.Size = new System.Drawing.Size(71, 60);
            this.pctrBack.TabIndex = 7;
            this.pctrBack.TabStop = false;
            this.pctrBack.Click += new System.EventHandler(this.pctrBack_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 401);
            this.Controls.Add(this.pctrBack);
            this.Controls.Add(this.nmrcNumberClasses);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcNumberClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNameS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.NumericUpDown nmrcNumberClasses;
        private System.Windows.Forms.PictureBox pctrBack;
    }
}