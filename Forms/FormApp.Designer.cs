namespace AdressBook
{
    partial class FormApp
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            label1 = new Label();
            buttonExit = new Button();
            labelId = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            panel4 = new Panel();
            textBoxNumber = new TextBox();
            label2 = new Label();
            textBoxPhone = new TextBox();
            textBoxFIO = new TextBox();
            label4 = new Label();
            label = new Label();
            panel2 = new Panel();
            listBoxReport = new ListBox();
            panel3 = new Panel();
            textBoxSearch = new TextBox();
            label3 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(18, 41);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 389);
            panel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(26, 15);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(423, 356);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 1;
            label1.Text = "АДРЕСНАЯ КНИГА";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(992, 9);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "ВЫЙТИ";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(209, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(67, 20);
            labelId.TabIndex = 6;
            labelId.Text = "label3";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(251, 108);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(198, 29);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "РЕДАКТИРОВАТЬ";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(251, 64);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(198, 29);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "УДАЛИТЬ";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(251, 19);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(198, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "ДОБАВИТЬ";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Controls.Add(textBoxNumber);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(buttonEdit);
            panel4.Controls.Add(textBoxPhone);
            panel4.Controls.Add(buttonDelete);
            panel4.Controls.Add(textBoxFIO);
            panel4.Controls.Add(buttonAdd);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label);
            panel4.Location = new Point(18, 436);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 157);
            panel4.TabIndex = 4;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Enabled = false;
            textBoxNumber.Location = new Point(109, 24);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 28);
            textBoxNumber.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 27);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 11;
            label2.Text = "Номер";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(109, 102);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 28);
            textBoxPhone.TabIndex = 9;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new Point(109, 64);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new Size(125, 28);
            textBoxFIO.TabIndex = 7;
            textBoxFIO.KeyPress += textBoxFIO_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 105);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 7;
            label4.Text = "Телефон";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(8, 64);
            label.Name = "label";
            label.Size = new Size(53, 20);
            label.TabIndex = 8;
            label.Text = "ФИО";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(listBoxReport);
            panel2.Location = new Point(490, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 389);
            panel2.TabIndex = 7;
            // 
            // listBoxReport
            // 
            listBoxReport.FormattingEnabled = true;
            listBoxReport.Location = new Point(18, 15);
            listBoxReport.Name = "listBoxReport";
            listBoxReport.Size = new Size(565, 364);
            listBoxReport.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(490, 437);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 47);
            panel3.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(77, 6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(223, 28);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 0;
            label3.Text = "Поиск";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 608);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(buttonExit);
            Controls.Add(labelId);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormApp";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView;
        private Label label1;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonExit;
        private TextBox textBoxFIO;
        private Label labelId;
        private Panel panel4;
        private Label label4;
        private Label label;
        private TextBox textBoxPhone;
        private TextBox textBoxNumber;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBoxSearch;
        private Label label3;
        private System.Windows.Forms.Timer timer;
        private ListBox listBoxReport;
    }
}