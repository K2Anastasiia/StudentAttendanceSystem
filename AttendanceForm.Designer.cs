namespace StudentAttendanceSystem
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pctrGroup = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bttnAttendance = new System.Windows.Forms.Button();
            this.bttnRecord = new System.Windows.Forms.Button();
            this.bttnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bttnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(9, 15);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(51, 20);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Name";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscipline.Location = new System.Drawing.Point(9, 35);
            this.lblDiscipline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(76, 20);
            this.lblDiscipline.TabIndex = 7;
            this.lblDiscipline.Text = "Discipline";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 335);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(895, 67);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(89, 335);
            this.dataGridView2.TabIndex = 9;
            // 
            // pctrGroup
            // 
            this.pctrGroup.Image = ((System.Drawing.Image)(resources.GetObject("pctrGroup.Image")));
            this.pctrGroup.Location = new System.Drawing.Point(13, 418);
            this.pctrGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctrGroup.Name = "pctrGroup";
            this.pctrGroup.Size = new System.Drawing.Size(73, 71);
            this.pctrGroup.TabIndex = 10;
            this.pctrGroup.TabStop = false;
            this.pctrGroup.Click += new System.EventHandler(this.pctrGroup_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(895, 37);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // bttnAttendance
            // 
            this.bttnAttendance.BackColor = System.Drawing.Color.GreenYellow;
            this.bttnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnAttendance.Location = new System.Drawing.Point(895, 422);
            this.bttnAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnAttendance.Name = "bttnAttendance";
            this.bttnAttendance.Size = new System.Drawing.Size(89, 58);
            this.bttnAttendance.TabIndex = 12;
            this.bttnAttendance.Text = "Виставити";
            this.bttnAttendance.UseVisualStyleBackColor = false;
            this.bttnAttendance.Click += new System.EventHandler(this.bttnAttendance_Click);
            // 
            // bttnRecord
            // 
            this.bttnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnRecord.Location = new System.Drawing.Point(756, 422);
            this.bttnRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnRecord.Name = "bttnRecord";
            this.bttnRecord.Size = new System.Drawing.Size(113, 58);
            this.bttnRecord.TabIndex = 13;
            this.bttnRecord.Text = "Підрахунок пропусків";
            this.bttnRecord.UseVisualStyleBackColor = true;
            this.bttnRecord.Click += new System.EventHandler(this.bttnRecord_Click);
            // 
            // bttnExport
            // 
            this.bttnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnExport.Location = new System.Drawing.Point(106, 422);
            this.bttnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnExport.Name = "bttnExport";
            this.bttnExport.Size = new System.Drawing.Size(89, 58);
            this.bttnExport.TabIndex = 14;
            this.bttnExport.Text = "Зберегти групу";
            this.bttnExport.UseVisualStyleBackColor = true;
            this.bttnExport.Click += new System.EventHandler(this.bttnExport_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Зберегти";
            // 
            // bttnImport
            // 
            this.bttnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnImport.Location = new System.Drawing.Point(218, 422);
            this.bttnImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnImport.Name = "bttnImport";
            this.bttnImport.Size = new System.Drawing.Size(89, 58);
            this.bttnImport.TabIndex = 15;
            this.bttnImport.Text = "Відкрити групу";
            this.bttnImport.UseVisualStyleBackColor = true;
            this.bttnImport.Click += new System.EventHandler(this.bttnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(762, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Заняття номер:";
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnImport);
            this.Controls.Add(this.bttnExport);
            this.Controls.Add(this.bttnRecord);
            this.Controls.Add(this.bttnAttendance);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pctrGroup);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.lblFullName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AttendanceForm";
            this.Text = "Контроль відвідівань";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pctrGroup;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bttnAttendance;
        private System.Windows.Forms.Button bttnRecord;
        private System.Windows.Forms.Button bttnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bttnImport;
        private System.Windows.Forms.Label label1;
    }
}