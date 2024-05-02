namespace AdressBook
{
    partial class FormRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonRegister = new Button();
            textBoxRepeatPassword = new TextBox();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            textBoxSurename = new TextBox();
            textBoxName = new TextBox();
            comboBox = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            labelLogin = new Label();
            labelPassword = new Label();
            panelLogin = new Panel();
            panelPassword = new Panel();
            buttonGoLogin = new Button();
            panelRepeatPassword = new Panel();
            labelRepeatPassword = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(97, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 34);
            label1.TabIndex = 0;
            label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 84);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 333);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 2;
            label2.Text = "Повторите пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 285);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 4;
            label4.Text = "Логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 192);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 5;
            label5.Text = "Организация";
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.None;
            label6.AutoSize = true;
            label6.Location = new Point(18, 147);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 6;
            label6.Text = "Фамилия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 108);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 7;
            label7.Text = "Имя";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.SandyBrown;
            buttonRegister.Dock = DockStyle.Bottom;
            buttonRegister.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegister.Location = new Point(0, 428);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(439, 62);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Location = new Point(213, 325);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.Size = new Size(204, 28);
            textBoxRepeatPassword.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(213, 277);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(204, 28);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(213, 227);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(204, 28);
            textBoxLogin.TabIndex = 11;
            textBoxLogin.KeyPress += textBoxLogin_KeyPress;
            // 
            // textBoxSurename
            // 
            textBoxSurename.Location = new Point(213, 139);
            textBoxSurename.Name = "textBoxSurename";
            textBoxSurename.Size = new Size(204, 28);
            textBoxSurename.TabIndex = 13;
            textBoxSurename.KeyPress += textBoxSurename_KeyPress;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(213, 100);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(204, 28);
            textBoxName.TabIndex = 14;
            textBoxName.KeyPress += textBoxName_KeyPress_1;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(213, 184);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(204, 28);
            comboBox.TabIndex = 15;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 10;
            timer3.Tick += timer3_Tick;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(213, 258);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(51, 16);
            labelLogin.TabIndex = 16;
            labelLogin.Text = "label8";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(213, 308);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(51, 16);
            labelPassword.TabIndex = 17;
            labelPassword.Text = "label8";
            // 
            // panelLogin
            // 
            panelLogin.Location = new Point(213, 250);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(204, 5);
            panelLogin.TabIndex = 19;
            // 
            // panelPassword
            // 
            panelPassword.Location = new Point(213, 300);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(204, 5);
            panelPassword.TabIndex = 20;
            // 
            // buttonGoLogin
            // 
            buttonGoLogin.Location = new Point(116, 383);
            buttonGoLogin.Name = "buttonGoLogin";
            buttonGoLogin.Size = new Size(211, 29);
            buttonGoLogin.TabIndex = 22;
            buttonGoLogin.Text = "Уже есть аккаунт";
            buttonGoLogin.UseVisualStyleBackColor = true;
            buttonGoLogin.Click += buttonGoLogin_Click;
            // 
            // panelRepeatPassword
            // 
            panelRepeatPassword.Location = new Point(213, 348);
            panelRepeatPassword.Name = "panelRepeatPassword";
            panelRepeatPassword.Size = new Size(204, 5);
            panelRepeatPassword.TabIndex = 23;
            // 
            // labelRepeatPassword
            // 
            labelRepeatPassword.AutoSize = true;
            labelRepeatPassword.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRepeatPassword.Location = new Point(213, 360);
            labelRepeatPassword.Name = "labelRepeatPassword";
            labelRepeatPassword.Size = new Size(51, 16);
            labelRepeatPassword.TabIndex = 0;
            labelRepeatPassword.Text = "label8";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(439, 490);
            Controls.Add(labelRepeatPassword);
            Controls.Add(panelRepeatPassword);
            Controls.Add(buttonGoLogin);
            Controls.Add(panelPassword);
            Controls.Add(panelLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(comboBox);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurename);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(buttonRegister);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRegister";
            Load += FormRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonRegister;
        private TextBox textBoxRepeatPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxSurename;
        private TextBox textBoxName;
        private ComboBox comboBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label labelLogin;
        private Label labelPassword;
        private Panel panelLogin;
        private Panel panelPassword;
        private Button buttonGoLogin;
        private Panel panelRepeatPassword;
        private Label labelRepeatPassword;
    }
}
