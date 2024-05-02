namespace AdressBook
{
    partial class FormLogin
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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            buttonGoRegister = new Button();
            labelPassword = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(160, 103);
            textBoxLogin.Margin = new Padding(4, 3, 4, 3);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(243, 28);
            textBoxLogin.TabIndex = 32;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(160, 152);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(243, 28);
            textBoxPassword.TabIndex = 31;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.SandyBrown;
            buttonLogin.Dock = DockStyle.Bottom;
            buttonLogin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogin.Location = new Point(0, 242);
            buttonLogin.Margin = new Padding(4, 3, 4, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(428, 62);
            buttonLogin.TabIndex = 29;
            buttonLogin.Text = "ВОЙТИ";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 106);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 25;
            label4.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 155);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 24;
            label3.Text = "Пароль";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 3, 6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 84);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(92, 25);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 34);
            label1.TabIndex = 0;
            label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // buttonGoRegister
            // 
            buttonGoRegister.Location = new Point(137, 202);
            buttonGoRegister.Name = "buttonGoRegister";
            buttonGoRegister.Size = new Size(165, 29);
            buttonGoRegister.TabIndex = 33;
            buttonGoRegister.Text = "Нет аккаунта";
            buttonGoRegister.UseVisualStyleBackColor = true;
            buttonGoRegister.Click += buttonGoRegister_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(189, 183);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(0, 16);
            labelPassword.TabIndex = 37;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 304);
            Controls.Add(labelPassword);
            Controls.Add(buttonGoRegister);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Button buttonGoRegister;
        private Label labelPassword;
    }
}