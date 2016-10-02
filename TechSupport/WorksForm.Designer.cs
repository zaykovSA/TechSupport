namespace StatisticsG
{
    partial class WorksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workDD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedWorkL = new System.Windows.Forms.Label();
            this.dateOfWork = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.saveWorkB = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // clientDD
            // 
            this.clientDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientDD.FormattingEnabled = true;
            this.clientDD.Items.AddRange(new object[] {
            "Первокурсник",
            "Младшекурсник",
            "Старшекурсник",
            "Выпускник",
            "Гость",
            "Сотрудник"});
            this.clientDD.Location = new System.Drawing.Point(13, 39);
            this.clientDD.Name = "clientDD";
            this.clientDD.Size = new System.Drawing.Size(249, 21);
            this.clientDD.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Выберите клиента из списка";
            // 
            // workDD
            // 
            this.workDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workDD.FormattingEnabled = true;
            this.workDD.Items.AddRange(new object[] {
            "K1",
            "K2",
            "K3",
            "K4",
            "K5",
            "K6",
            "K7",
            "O1",
            "O2",
            "O3",
            "H1",
            "H2",
            "H3",
            "H4",
            "H5",
            "H6",
            "H7",
            "A11",
            "A12",
            "A13",
            "A2",
            "A3",
            "A4",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5"});
            this.workDD.Location = new System.Drawing.Point(13, 114);
            this.workDD.Name = "workDD";
            this.workDD.Size = new System.Drawing.Size(49, 21);
            this.workDD.TabIndex = 26;
            this.workDD.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выберите услугу из списка";
            // 
            // selectedWorkL
            // 
            this.selectedWorkL.Location = new System.Drawing.Point(68, 114);
            this.selectedWorkL.Name = "selectedWorkL";
            this.selectedWorkL.Size = new System.Drawing.Size(311, 43);
            this.selectedWorkL.TabIndex = 27;
            // 
            // dateOfWork
            // 
            this.dateOfWork.Location = new System.Drawing.Point(13, 77);
            this.dateOfWork.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfWork.Name = "dateOfWork";
            this.dateOfWork.Size = new System.Drawing.Size(200, 20);
            this.dateOfWork.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Введите дату проведения работы";
            // 
            // saveWorkB
            // 
            this.saveWorkB.Location = new System.Drawing.Point(13, 164);
            this.saveWorkB.Name = "saveWorkB";
            this.saveWorkB.Size = new System.Drawing.Size(366, 36);
            this.saveWorkB.TabIndex = 30;
            this.saveWorkB.Text = "Сохранить";
            this.saveWorkB.UseVisualStyleBackColor = true;
            this.saveWorkB.Click += new System.EventHandler(this.saveWorkB_Click);
            // 
            // WorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 207);
            this.Controls.Add(this.saveWorkB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOfWork);
            this.Controls.Add(this.selectedWorkL);
            this.Controls.Add(this.workDD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientDD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorksForm";
            this.Text = "Работы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorksForm_FormClosed);
            this.Load += new System.EventHandler(this.WorksForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ComboBox clientDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox workDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedWorkL;
        private System.Windows.Forms.DateTimePicker dateOfWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveWorkB;
    }
}