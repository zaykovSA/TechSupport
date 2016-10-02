namespace StatisticsG
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientsP = new System.Windows.Forms.TabPage();
            this.userGroupCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteClientB = new System.Windows.Forms.Button();
            this.clearClientB = new System.Windows.Forms.Button();
            this.clientFilterTB = new System.Windows.Forms.TextBox();
            this.newClientB = new System.Windows.Forms.Button();
            this.editClientB = new System.Windows.Forms.Button();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.FIOTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientsLB = new System.Windows.Forms.ListBox();
            this.usersP = new System.Windows.Forms.TabPage();
            this.deleteB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.filterTB = new System.Windows.Forms.TextBox();
            this.newB = new System.Windows.Forms.Button();
            this.editB = new System.Windows.Forms.Button();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersLB = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.clientsP.SuspendLayout();
            this.usersP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientsP);
            this.tabControl1.Controls.Add(this.usersP);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 259);
            this.tabControl1.TabIndex = 2;
            // 
            // clientsP
            // 
            this.clientsP.Controls.Add(this.userGroupCB);
            this.clientsP.Controls.Add(this.label5);
            this.clientsP.Controls.Add(this.deleteClientB);
            this.clientsP.Controls.Add(this.clearClientB);
            this.clientsP.Controls.Add(this.clientFilterTB);
            this.clientsP.Controls.Add(this.newClientB);
            this.clientsP.Controls.Add(this.editClientB);
            this.clientsP.Controls.Add(this.PhoneTB);
            this.clientsP.Controls.Add(this.FIOTB);
            this.clientsP.Controls.Add(this.label3);
            this.clientsP.Controls.Add(this.label4);
            this.clientsP.Controls.Add(this.clientsLB);
            this.clientsP.Location = new System.Drawing.Point(4, 22);
            this.clientsP.Name = "clientsP";
            this.clientsP.Padding = new System.Windows.Forms.Padding(3);
            this.clientsP.Size = new System.Drawing.Size(402, 233);
            this.clientsP.TabIndex = 0;
            this.clientsP.Text = "Редактирование списка клиентов";
            this.clientsP.UseVisualStyleBackColor = true;
            // 
            // userGroupCB
            // 
            this.userGroupCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userGroupCB.FormattingEnabled = true;
            this.userGroupCB.Items.AddRange(new object[] {
            "Первокурсник",
            "Младшекурсник",
            "Старшекурсник",
            "Выпускник",
            "Гость",
            "Сотрудник"});
            this.userGroupCB.Location = new System.Drawing.Point(147, 97);
            this.userGroupCB.Name = "userGroupCB";
            this.userGroupCB.Size = new System.Drawing.Size(249, 21);
            this.userGroupCB.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Группа пользователя";
            // 
            // deleteClientB
            // 
            this.deleteClientB.Location = new System.Drawing.Point(147, 179);
            this.deleteClientB.Name = "deleteClientB";
            this.deleteClientB.Size = new System.Drawing.Size(249, 20);
            this.deleteClientB.TabIndex = 20;
            this.deleteClientB.Text = "Удалить пользователя";
            this.deleteClientB.UseVisualStyleBackColor = true;
            this.deleteClientB.Click += new System.EventHandler(this.deleteClientB_Click);
            // 
            // clearClientB
            // 
            this.clearClientB.Location = new System.Drawing.Point(147, 205);
            this.clearClientB.Name = "clearClientB";
            this.clearClientB.Size = new System.Drawing.Size(249, 20);
            this.clearClientB.TabIndex = 19;
            this.clearClientB.Text = "Отменить выбор";
            this.clearClientB.UseVisualStyleBackColor = true;
            this.clearClientB.Click += new System.EventHandler(this.clearClientB_Click);
            // 
            // clientFilterTB
            // 
            this.clientFilterTB.Location = new System.Drawing.Point(7, 205);
            this.clientFilterTB.Name = "clientFilterTB";
            this.clientFilterTB.Size = new System.Drawing.Size(120, 20);
            this.clientFilterTB.TabIndex = 18;
            this.clientFilterTB.TextChanged += new System.EventHandler(this.clientFilterTB_TextChanged);
            // 
            // newClientB
            // 
            this.newClientB.Location = new System.Drawing.Point(277, 124);
            this.newClientB.Name = "newClientB";
            this.newClientB.Size = new System.Drawing.Size(119, 49);
            this.newClientB.TabIndex = 17;
            this.newClientB.Text = "Добавить нового";
            this.newClientB.UseVisualStyleBackColor = true;
            this.newClientB.Click += new System.EventHandler(this.newClientB_Click);
            // 
            // editClientB
            // 
            this.editClientB.Location = new System.Drawing.Point(147, 124);
            this.editClientB.Name = "editClientB";
            this.editClientB.Size = new System.Drawing.Size(119, 49);
            this.editClientB.TabIndex = 16;
            this.editClientB.Text = "Изменить";
            this.editClientB.UseVisualStyleBackColor = true;
            this.editClientB.Click += new System.EventHandler(this.editClientB_Click);
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(147, 59);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(249, 20);
            this.PhoneTB.TabIndex = 15;
            // 
            // FIOTB
            // 
            this.FIOTB.Location = new System.Drawing.Point(147, 23);
            this.FIOTB.Name = "FIOTB";
            this.FIOTB.Size = new System.Drawing.Size(249, 20);
            this.FIOTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ФИО";
            // 
            // clientsLB
            // 
            this.clientsLB.FormattingEnabled = true;
            this.clientsLB.Location = new System.Drawing.Point(7, 7);
            this.clientsLB.Name = "clientsLB";
            this.clientsLB.Size = new System.Drawing.Size(120, 199);
            this.clientsLB.TabIndex = 11;
            this.clientsLB.SelectedIndexChanged += new System.EventHandler(this.clientsLB_SelectedIndexChanged);
            // 
            // usersP
            // 
            this.usersP.Controls.Add(this.deleteB);
            this.usersP.Controls.Add(this.clearB);
            this.usersP.Controls.Add(this.filterTB);
            this.usersP.Controls.Add(this.newB);
            this.usersP.Controls.Add(this.editB);
            this.usersP.Controls.Add(this.PassTB);
            this.usersP.Controls.Add(this.loginTB);
            this.usersP.Controls.Add(this.label2);
            this.usersP.Controls.Add(this.label1);
            this.usersP.Controls.Add(this.UsersLB);
            this.usersP.Location = new System.Drawing.Point(4, 22);
            this.usersP.Name = "usersP";
            this.usersP.Padding = new System.Windows.Forms.Padding(3);
            this.usersP.Size = new System.Drawing.Size(402, 233);
            this.usersP.TabIndex = 1;
            this.usersP.Text = "Редактирование списка пользователей";
            this.usersP.UseVisualStyleBackColor = true;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(147, 156);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(249, 29);
            this.deleteB.TabIndex = 10;
            this.deleteB.Text = "Удалить пользователя";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(147, 193);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(249, 29);
            this.clearB.TabIndex = 9;
            this.clearB.Text = "Отменить выбор";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // filterTB
            // 
            this.filterTB.Location = new System.Drawing.Point(7, 202);
            this.filterTB.Name = "filterTB";
            this.filterTB.Size = new System.Drawing.Size(120, 20);
            this.filterTB.TabIndex = 8;
            this.filterTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // newB
            // 
            this.newB.Location = new System.Drawing.Point(277, 103);
            this.newB.Name = "newB";
            this.newB.Size = new System.Drawing.Size(119, 47);
            this.newB.TabIndex = 7;
            this.newB.Text = "Добавить нового";
            this.newB.UseVisualStyleBackColor = true;
            this.newB.Click += new System.EventHandler(this.newB_Click);
            // 
            // editB
            // 
            this.editB.Location = new System.Drawing.Point(147, 103);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(119, 47);
            this.editB.TabIndex = 6;
            this.editB.Text = "Изменить";
            this.editB.UseVisualStyleBackColor = true;
            this.editB.Click += new System.EventHandler(this.editB_Click);
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(147, 70);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(249, 20);
            this.PassTB.TabIndex = 4;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(147, 22);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(249, 20);
            this.loginTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // UsersLB
            // 
            this.UsersLB.FormattingEnabled = true;
            this.UsersLB.Location = new System.Drawing.Point(7, 4);
            this.UsersLB.Name = "UsersLB";
            this.UsersLB.Size = new System.Drawing.Size(120, 199);
            this.UsersLB.TabIndex = 0;
            this.UsersLB.SelectedValueChanged += new System.EventHandler(this.UsersLB_SelectedValueChanged);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 298);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientsForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.clientsP.ResumeLayout(false);
            this.clientsP.PerformLayout();
            this.usersP.ResumeLayout(false);
            this.usersP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientsP;
        private System.Windows.Forms.TabPage usersP;
        private System.Windows.Forms.ListBox UsersLB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editB;
        private System.Windows.Forms.TextBox filterTB;
        private System.Windows.Forms.Button newB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.ComboBox userGroupCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteClientB;
        private System.Windows.Forms.Button clearClientB;
        private System.Windows.Forms.TextBox clientFilterTB;
        private System.Windows.Forms.Button newClientB;
        private System.Windows.Forms.Button editClientB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox FIOTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox clientsLB;
    }
}