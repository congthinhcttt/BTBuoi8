namespace BTBuoi8
{
    partial class Form1
    {
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxMajor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelMajor;

        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxMajor = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(492, 108);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 62;
            this.dataGridViewStudents.Size = new System.Drawing.Size(695, 385);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(127, 56);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(298, 26);
            this.textBoxFullName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(127, 117);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(298, 26);
            this.textBoxAge.TabIndex = 2;
            // 
            // comboBoxMajor
            // 
            this.comboBoxMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMajor.FormattingEnabled = true;
            this.comboBoxMajor.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kinh tế",
            "Kỹ thuật phần mềm",
            "Quản trị kinh doanh",
            "Công nghệ sinh học"});
            this.comboBoxMajor.Location = new System.Drawing.Point(127, 170);
            this.comboBoxMajor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(298, 28);
            this.comboBoxMajor.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(0, 230);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 35);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(162, 230);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(313, 230);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 35);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(0, 295);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 35);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(162, 295);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(112, 35);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(7, 59);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(77, 20);
            this.labelFullName.TabIndex = 9;
            this.labelFullName.Text = "Họ và tên";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(7, 123);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(39, 20);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Tuổi";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Location = new System.Drawing.Point(7, 178);
            this.labelMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(86, 20);
            this.labelMajor.TabIndex = 11;
            this.labelMajor.Text = "Ngành học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản Lý Danh Sách Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelFullName);
            this.groupBox1.Controls.Add(this.textBoxFullName);
            this.groupBox1.Controls.Add(this.buttonPrevious);
            this.groupBox1.Controls.Add(this.labelMajor);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.comboBoxMajor);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 330);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
