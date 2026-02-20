namespace WindowsFormsApp1
{
    partial class StudentFrm
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.studentIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateBrn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
<<<<<<< HEAD
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(121, 404);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(133, 33);
=======
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(850, 550);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(120, 40);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // studentIDBox
            // 
<<<<<<< HEAD
            this.studentIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDBox.Location = new System.Drawing.Point(407, 104);
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(383, 31);
=======
            this.studentIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIDBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.studentIDBox.Location = new System.Drawing.Point(850, 120);
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(350, 27);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.studentIDBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
=======
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(850, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "STUDENT MGT FORM";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameBox.Location = new System.Drawing.Point(409, 189);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(383, 31);
=======
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(850, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Management";
            // 
            // fullNameBox
            // 
            this.fullNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fullNameBox.Location = new System.Drawing.Point(850, 200);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(350, 27);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.fullNameBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
=======
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(850, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.label3.TabIndex = 14;
            this.label3.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
<<<<<<< HEAD
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
=======
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(850, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.label5.TabIndex = 18;
            this.label5.Text = "Date of Birth";
            // 
            // addressBox
            // 
<<<<<<< HEAD
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(405, 267);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(383, 31);
=======
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.addressBox.Location = new System.Drawing.Point(850, 280);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(350, 27);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.addressBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
<<<<<<< HEAD
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
=======
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(850, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.label7.TabIndex = 16;
            this.label7.Text = "Address";
            // 
            // UpdateBrn
            // 
<<<<<<< HEAD
            this.UpdateBrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UpdateBrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBrn.Location = new System.Drawing.Point(336, 404);
            this.UpdateBrn.Name = "UpdateBrn";
            this.UpdateBrn.Size = new System.Drawing.Size(133, 33);
            this.UpdateBrn.TabIndex = 20;
            this.UpdateBrn.Text = "Update";
            this.UpdateBrn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(550, 404);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(133, 33);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // dobPicker
            // 
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Location = new System.Drawing.Point(407, 350);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(381, 31);
=======
            this.UpdateBrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.UpdateBrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBrn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.UpdateBrn.ForeColor = System.Drawing.Color.White;
            this.UpdateBrn.Location = new System.Drawing.Point(990, 550);
            this.UpdateBrn.Name = "UpdateBrn";
            this.UpdateBrn.Size = new System.Drawing.Size(120, 40);
            this.UpdateBrn.TabIndex = 20;
            this.UpdateBrn.Text = "Update";
            this.UpdateBrn.UseVisualStyleBackColor = false;
            this.UpdateBrn.Click += new System.EventHandler(this.UpdateBrn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(850, 610);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(260, 40);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dobPicker
            // 
            this.dobPicker.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dobPicker.Location = new System.Drawing.Point(850, 360);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(350, 27);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.dobPicker.TabIndex = 22;
            // 
            // dataGridView1
            // 
<<<<<<< HEAD
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 372);
=======
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 620);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.dataGridView1.TabIndex = 23;
            // 
            // StudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
=======
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1250, 700);
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBrn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.studentIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
<<<<<<< HEAD
            this.Name = "StudentFrm";
            this.Text = "StudentFrm";
=======
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
>>>>>>> 33904f415612412c4471df37e51828a52e42d1c8
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox studentIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UpdateBrn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}