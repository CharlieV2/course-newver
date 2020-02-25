using System.Windows.Forms;

namespace course
{
    partial class MainForm
    {
        // включение двойной буферизации
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

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
            this.components = new System.ComponentModel.Container();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.RewriteWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextStepBut = new System.Windows.Forms.Button();
            this.DeleteBDBut = new System.Windows.Forms.Button();
            this.NewBDBut = new System.Windows.Forms.Button();
            this.BdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.AllowDrop = true;
            this.StartPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StartPanel.Controls.Add(this.label3);
            this.StartPanel.Controls.Add(this.DirectoryPath);
            this.StartPanel.Controls.Add(this.RewriteWarning);
            this.StartPanel.Controls.Add(this.label2);
            this.StartPanel.Controls.Add(this.NextStepBut);
            this.StartPanel.Controls.Add(this.DeleteBDBut);
            this.StartPanel.Controls.Add(this.NewBDBut);
            this.StartPanel.Controls.Add(this.BdName);
            this.StartPanel.Controls.Add(this.label1);
            this.StartPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartPanel.Location = new System.Drawing.Point(12, 12);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(295, 402);
            this.StartPanel.TabIndex = 2;
            this.StartPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.StartPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Путь к каталогу с базами данных:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.BackColor = System.Drawing.Color.White;
            this.DirectoryPath.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.DirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.DirectoryPath.Location = new System.Drawing.Point(5, 370);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(280, 25);
            this.DirectoryPath.TabIndex = 18;
            this.DirectoryPath.TabStop = false;
            this.DirectoryPath.Text = "Hello world";
            this.DirectoryPath.TextChanged += new System.EventHandler(this.DirectoryPath_TextChanged);
            // 
            // RewriteWarning
            // 
            this.RewriteWarning.AutoSize = true;
            this.RewriteWarning.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RewriteWarning.ForeColor = System.Drawing.Color.White;
            this.RewriteWarning.Location = new System.Drawing.Point(26, 193);
            this.RewriteWarning.Name = "RewriteWarning";
            this.RewriteWarning.Size = new System.Drawing.Size(248, 60);
            this.RewriteWarning.TabIndex = 7;
            this.RewriteWarning.Text = "БД с таким именем уже существует!\r\nПри создании новой БД , старая\r\nбудет перезапи" +
    "сана!";
            this.RewriteWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RewriteWarning.Visible = false;
            this.RewriteWarning.Click += new System.EventHandler(this.RewriteWarning_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя базы данных:";
            // 
            // NextStepBut
            // 
            this.NextStepBut.BackColor = System.Drawing.Color.RoyalBlue;
            this.NextStepBut.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.NextStepBut.FlatAppearance.BorderSize = 0;
            this.NextStepBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(242)))));
            this.NextStepBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextStepBut.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.NextStepBut.ForeColor = System.Drawing.Color.White;
            this.NextStepBut.Location = new System.Drawing.Point(175, 105);
            this.NextStepBut.Name = "NextStepBut";
            this.NextStepBut.Size = new System.Drawing.Size(110, 31);
            this.NextStepBut.TabIndex = 4;
            this.NextStepBut.TabStop = false;
            this.NextStepBut.Text = "Next step";
            this.NextStepBut.UseVisualStyleBackColor = false;
            this.NextStepBut.Click += new System.EventHandler(this.NextStepBut_Click);
            // 
            // DeleteBDBut
            // 
            this.DeleteBDBut.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteBDBut.Enabled = false;
            this.DeleteBDBut.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DeleteBDBut.FlatAppearance.BorderSize = 0;
            this.DeleteBDBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.DeleteBDBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.DeleteBDBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBDBut.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.DeleteBDBut.ForeColor = System.Drawing.Color.White;
            this.DeleteBDBut.Location = new System.Drawing.Point(9, 142);
            this.DeleteBDBut.Name = "DeleteBDBut";
            this.DeleteBDBut.Size = new System.Drawing.Size(83, 31);
            this.DeleteBDBut.TabIndex = 3;
            this.DeleteBDBut.TabStop = false;
            this.DeleteBDBut.Text = "Delete";
            this.DeleteBDBut.UseVisualStyleBackColor = false;
            this.DeleteBDBut.Click += new System.EventHandler(this.DeleteBDBut_Click);
            // 
            // NewBDBut
            // 
            this.NewBDBut.BackColor = System.Drawing.Color.RoyalBlue;
            this.NewBDBut.Enabled = false;
            this.NewBDBut.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.NewBDBut.FlatAppearance.BorderSize = 0;
            this.NewBDBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(242)))));
            this.NewBDBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBDBut.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.NewBDBut.ForeColor = System.Drawing.Color.White;
            this.NewBDBut.Location = new System.Drawing.Point(9, 105);
            this.NewBDBut.Name = "NewBDBut";
            this.NewBDBut.Size = new System.Drawing.Size(83, 31);
            this.NewBDBut.TabIndex = 2;
            this.NewBDBut.TabStop = false;
            this.NewBDBut.Text = "New";
            this.NewBDBut.UseVisualStyleBackColor = false;
            this.NewBDBut.Click += new System.EventHandler(this.NewBDBut_Click);
            // 
            // BdName
            // 
            this.BdName.BackColor = System.Drawing.Color.White;
            this.BdName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BdName.Location = new System.Drawing.Point(9, 70);
            this.BdName.Name = "BdName";
            this.BdName.Size = new System.Drawing.Size(276, 29);
            this.BdName.TabIndex = 1;
            this.BdName.TabStop = false;
            this.BdName.TextChanged += new System.EventHandler(this.BdName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание/удаление баз данных";
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Location = new System.Drawing.Point(313, 12);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(160, 402);
            this.ActionsPanel.TabIndex = 6;
            this.ActionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ActionsPanel_Paint);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Enabled = true;
            this.AnimationTimer.Interval = 25;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::course.Properties.Resources.d51ea6e460ff3245;
            this.ClientSize = new System.Drawing.Size(694, 426);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.ActionsPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 465);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program name";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextStepBut;
        private System.Windows.Forms.Button DeleteBDBut;
        private System.Windows.Forms.Button NewBDBut;
        private System.Windows.Forms.TextBox BdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ActionsPanel;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Label RewriteWarning;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox DirectoryPath;
    }
}

