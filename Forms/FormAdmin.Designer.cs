namespace AdressBook
{
    partial class FormAdmin
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
            dataGridView = new DataGridView();
            panel1 = new Panel();
            buttonExit = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxId = new TextBox();
            label1 = new Label();
            buttonDelete = new Button();
            buttonSave = new Button();
            comboBoxRole = new ComboBox();
            label = new Label();
            comboBoxOrg = new ComboBox();
            textBoxName = new TextBox();
            textBoxSurename = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(18, 12);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(521, 388);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(comboBoxRole);
            panel1.Controls.Add(label);
            panel1.Controls.Add(comboBoxOrg);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxSurename);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(547, 12);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 388);
            panel1.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(204, 336);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(136, 29);
            buttonExit.TabIndex = 47;
            buttonExit.Text = "ВЫЙТИ";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Enabled = false;
            textBoxLogin.Location = new Point(182, 119);
            textBoxLogin.Margin = new Padding(4, 3, 4, 3);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(158, 28);
            textBoxLogin.TabIndex = 46;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Location = new Point(182, 158);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(158, 28);
            textBoxPassword.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 126);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 44;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.AutoSize = true;
            label3.Location = new Point(20, 165);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 43;
            label3.Text = "Пароль";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(182, 11);
            textBoxId.Margin = new Padding(4, 3, 4, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(158, 28);
            textBoxId.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 41;
            label1.Text = "Id";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(20, 336);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(136, 29);
            buttonDelete.TabIndex = 40;
            buttonDelete.Text = "УДАЛИТЬ";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(20, 294);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(136, 29);
            buttonSave.TabIndex = 39;
            buttonSave.Text = "СОХРАНИТЬ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(182, 233);
            comboBoxRole.Margin = new Padding(4, 3, 4, 3);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(158, 28);
            comboBoxRole.TabIndex = 38;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(20, 239);
            label.Margin = new Padding(6, 0, 6, 0);
            label.Name = "label";
            label.Size = new Size(56, 20);
            label.TabIndex = 37;
            label.Text = "Роль";
            // 
            // comboBoxOrg
            // 
            comboBoxOrg.FormattingEnabled = true;
            comboBoxOrg.Location = new Point(182, 190);
            comboBoxOrg.Margin = new Padding(4, 3, 4, 3);
            comboBoxOrg.Name = "comboBoxOrg";
            comboBoxOrg.Size = new Size(158, 28);
            comboBoxOrg.TabIndex = 36;
            // 
            // textBoxName
            // 
            textBoxName.Enabled = false;
            textBoxName.Location = new Point(182, 45);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(158, 28);
            textBoxName.TabIndex = 35;
            // 
            // textBoxSurename
            // 
            textBoxSurename.Enabled = false;
            textBoxSurename.Location = new Point(182, 84);
            textBoxSurename.Margin = new Padding(4, 3, 4, 3);
            textBoxSurename.Name = "textBoxSurename";
            textBoxSurename.Size = new Size(158, 28);
            textBoxSurename.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 52);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 30;
            label7.Text = "Имя";
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.None;
            label6.AutoSize = true;
            label6.Location = new Point(20, 91);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 29;
            label6.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 197);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 28;
            label5.Text = "Организация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-82, 184);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 27;
            label4.Text = "Логин";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 412);
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Panel panel1;
        private ComboBox comboBoxOrg;
        private TextBox textBoxName;
        private TextBox textBoxSurename;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxRole;
        private Label label;
        private Button buttonDelete;
        private Button buttonSave;
        private TextBox textBoxId;
        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label2;
        private Label label3;
        private Button buttonExit;
    }
}