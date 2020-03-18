namespace course
{
    partial class BDhandler
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElementsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BDstatusInfoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BdInfo = new System.Windows.Forms.Label();
            this.BackBut = new System.Windows.Forms.PictureBox();
            this.TabInfoPanel = new System.Windows.Forms.Panel();
            this.TabBut1 = new System.Windows.Forms.Button();
            this.TabBut2 = new System.Windows.Forms.Button();
            this.TabBut3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearBut = new System.Windows.Forms.Button();
            this.BdName = new System.Windows.Forms.ComboBox();
            this.BDstatusInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBut)).BeginInit();
            this.SuspendLayout();
            // 
            // ElementsPanel
            // 
            this.ElementsPanel.AllowDrop = true;
            this.ElementsPanel.AutoScroll = true;
            this.ElementsPanel.BackColor = System.Drawing.Color.White;
            this.ElementsPanel.Location = new System.Drawing.Point(323, 67);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.Size = new System.Drawing.Size(286, 354);
            this.ElementsPanel.TabIndex = 17;
            this.ElementsPanel.Visible = false;
            this.ElementsPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.ElementsPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // BDstatusInfoPanel
            // 
            this.BDstatusInfoPanel.AllowDrop = true;
            this.BDstatusInfoPanel.BackColor = System.Drawing.Color.White;
            this.BDstatusInfoPanel.Controls.Add(this.label3);
            this.BDstatusInfoPanel.Controls.Add(this.DirectoryPath);
            this.BDstatusInfoPanel.Controls.Add(this.label1);
            this.BDstatusInfoPanel.Controls.Add(this.pictureBox1);
            this.BDstatusInfoPanel.Controls.Add(this.BdInfo);
            this.BDstatusInfoPanel.Location = new System.Drawing.Point(6, 67);
            this.BDstatusInfoPanel.Name = "BDstatusInfoPanel";
            this.BDstatusInfoPanel.Size = new System.Drawing.Size(286, 354);
            this.BDstatusInfoPanel.TabIndex = 23;
            this.BDstatusInfoPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.BDstatusInfoPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(3, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Путь к каталогу с базами данных:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.BackColor = System.Drawing.Color.White;
            this.DirectoryPath.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.DirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DirectoryPath.Location = new System.Drawing.Point(3, 320);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(280, 25);
            this.DirectoryPath.TabIndex = 16;
            this.DirectoryPath.TabStop = false;
            this.DirectoryPath.Text = "Hello world";
            this.DirectoryPath.TextChanged += new System.EventHandler(this.DirectoryPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(3, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите имя базы данных\r\nили перетащите файл в эту панель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::course.Properties.Resources.Nothing;
            this.pictureBox1.Location = new System.Drawing.Point(106, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BdInfo
            // 
            this.BdInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BdInfo.AutoSize = true;
            this.BdInfo.BackColor = System.Drawing.Color.Transparent;
            this.BdInfo.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.BdInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BdInfo.Location = new System.Drawing.Point(26, 23);
            this.BdInfo.Name = "BdInfo";
            this.BdInfo.Size = new System.Drawing.Size(223, 21);
            this.BdInfo.TabIndex = 10;
            this.BdInfo.Text = "Выбранная база данных пуста";
            this.BdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BdInfo.Visible = false;
            // 
            // BackBut
            // 
            this.BackBut.Image = global::course.Properties.Resources.Back_Default;
            this.BackBut.Location = new System.Drawing.Point(654, 5);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(30, 30);
            this.BackBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBut.TabIndex = 22;
            this.BackBut.TabStop = false;
            this.BackBut.MouseEnter += new System.EventHandler(this.BackBut_Animation_Enter);
            this.BackBut.MouseLeave += new System.EventHandler(this.BackBut_Animation_Leave);
            // 
            // TabInfoPanel
            // 
            this.TabInfoPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TabInfoPanel.Location = new System.Drawing.Point(324, 67);
            this.TabInfoPanel.Name = "TabInfoPanel";
            this.TabInfoPanel.Size = new System.Drawing.Size(367, 3);
            this.TabInfoPanel.TabIndex = 18;
            // 
            // TabBut1
            // 
            this.TabBut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.TabBut1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut1.FlatAppearance.BorderSize = 0;
            this.TabBut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabBut1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabBut1.Location = new System.Drawing.Point(329, 37);
            this.TabBut1.Name = "TabBut1";
            this.TabBut1.Size = new System.Drawing.Size(60, 30);
            this.TabBut1.TabIndex = 19;
            this.TabBut1.TabStop = false;
            this.TabBut1.Text = "Edit BD";
            this.TabBut1.UseVisualStyleBackColor = false;
            this.TabBut1.Click += new System.EventHandler(this.TabBut1_Click);
            // 
            // TabBut2
            // 
            this.TabBut2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut2.Enabled = false;
            this.TabBut2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut2.FlatAppearance.BorderSize = 0;
            this.TabBut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabBut2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabBut2.Location = new System.Drawing.Point(389, 37);
            this.TabBut2.Name = "TabBut2";
            this.TabBut2.Size = new System.Drawing.Size(60, 30);
            this.TabBut2.TabIndex = 20;
            this.TabBut2.TabStop = false;
            this.TabBut2.Text = "Tasks";
            this.TabBut2.UseVisualStyleBackColor = false;
            this.TabBut2.Click += new System.EventHandler(this.TabBut2_Click);
            // 
            // TabBut3
            // 
            this.TabBut3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut3.Enabled = false;
            this.TabBut3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut3.FlatAppearance.BorderSize = 0;
            this.TabBut3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabBut3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabBut3.Location = new System.Drawing.Point(449, 37);
            this.TabBut3.Name = "TabBut3";
            this.TabBut3.Size = new System.Drawing.Size(60, 30);
            this.TabBut3.TabIndex = 21;
            this.TabBut3.TabStop = false;
            this.TabBut3.Text = "Graphs";
            this.TabBut3.UseVisualStyleBackColor = false;
            this.TabBut3.Click += new System.EventHandler(this.TabBut3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Имя базы данных:";
            // 
            // ClearBut
            // 
            this.ClearBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClearBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBut.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBut.Location = new System.Drawing.Point(231, 33);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(61, 29);
            this.ClearBut.TabIndex = 24;
            this.ClearBut.TabStop = false;
            this.ClearBut.Text = "Clear";
            this.ClearBut.UseVisualStyleBackColor = false;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // BdName
            // 
            this.BdName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.BdName.FormattingEnabled = true;
            this.BdName.Location = new System.Drawing.Point(6, 33);
            this.BdName.Name = "BdName";
            this.BdName.Size = new System.Drawing.Size(226, 29);
            this.BdName.TabIndex = 0;
            this.BdName.TabStop = false;
            this.BdName.SelectedIndexChanged += new System.EventHandler(this.BdName_TextChanged);
            this.BdName.TextUpdate += new System.EventHandler(this.BdName_TextChanged);
            // 
            // BDhandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::course.Properties.Resources.d51ea6e460ff3245;
            this.Controls.Add(this.BdName);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.BDstatusInfoPanel);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.TabInfoPanel);
            this.Controls.Add(this.TabBut1);
            this.Controls.Add(this.TabBut2);
            this.Controls.Add(this.TabBut3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "BDhandler";
            this.Size = new System.Drawing.Size(694, 426);
            this.BDstatusInfoPanel.ResumeLayout(false);
            this.BDstatusInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TabInfoPanel;
        public System.Windows.Forms.Button TabBut3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox BackBut;
        public System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearBut;
        public System.Windows.Forms.Label BdInfo;
        public System.Windows.Forms.FlowLayoutPanel ElementsPanel;
        public System.Windows.Forms.ComboBox BdName;
        public System.Windows.Forms.Button TabBut1;
        public System.Windows.Forms.Button TabBut2;
        public System.Windows.Forms.Panel BDstatusInfoPanel;
    }
}
