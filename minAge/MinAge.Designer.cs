
namespace minAge
{
    partial class MinAge
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.BirthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.FullNameTb = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.peopleTable = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(292, 26);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(292, 85);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // BirthdayDTP
            // 
            this.BirthdayDTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDTP.Location = new System.Drawing.Point(15, 84);
            this.BirthdayDTP.Name = "BirthdayDTP";
            this.BirthdayDTP.Size = new System.Drawing.Size(253, 22);
            this.BirthdayDTP.TabIndex = 2;
            // 
            // FullNameTb
            // 
            this.FullNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTb.Location = new System.Drawing.Point(15, 29);
            this.FullNameTb.Name = "FullNameTb";
            this.FullNameTb.Size = new System.Drawing.Size(253, 22);
            this.FullNameTb.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(12, 6);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(47, 20);
            this.FullNameLabel.TabIndex = 4;
            this.FullNameLabel.Text = "ФИО";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.Location = new System.Drawing.Point(11, 61);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(128, 20);
            this.BirthdayLabel.TabIndex = 5;
            this.BirthdayLabel.Text = "Дата рождения";
            // 
            // peopleTable
            // 
            this.peopleTable.AllowUserToAddRows = false;
            this.peopleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.peopleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Birthday});
            this.peopleTable.Location = new System.Drawing.Point(15, 128);
            this.peopleTable.Name = "peopleTable";
            this.peopleTable.Size = new System.Drawing.Size(361, 237);
            this.peopleTable.TabIndex = 6;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            // 
            // Birthday
            // 
            this.Birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            // 
            // findMin
            // 
            this.findMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findMin.Location = new System.Drawing.Point(104, 371);
            this.findMin.Name = "findMin";
            this.findMin.Size = new System.Drawing.Size(176, 23);
            this.findMin.TabIndex = 7;
            this.findMin.Text = "Найти  самого младшего";
            this.findMin.UseVisualStyleBackColor = true;
            this.findMin.Click += new System.EventHandler(this.findMin_Click);
            // 
            // MinAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 424);
            this.Controls.Add(this.findMin);
            this.Controls.Add(this.peopleTable);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.FullNameTb);
            this.Controls.Add(this.BirthdayDTP);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Add);
            this.MinimumSize = new System.Drawing.Size(449, 463);
            this.Name = "MinAge";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.peopleTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DateTimePicker BirthdayDTP;
        private System.Windows.Forms.TextBox FullNameTb;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.DataGridView peopleTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.Button findMin;
    }
}

