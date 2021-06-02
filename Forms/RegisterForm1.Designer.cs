namespace Version_1._1
{
    partial class RegisterForm1
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
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.tnameBox = new System.Windows.Forms.TextBox();
            this.registerButton1 = new System.Windows.Forms.Button();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorizationLabel.Font = new System.Drawing.Font("Georgia", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationLabel.ForeColor = System.Drawing.Color.Silver;
            this.authorizationLabel.Location = new System.Drawing.Point(0, 0);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(758, 86);
            this.authorizationLabel.TabIndex = 0;
            this.authorizationLabel.Text = "Реєстрація";
            this.authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorizationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authorizationLabel_MouseDown);
            this.authorizationLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authorizationLabel_MouseMove);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.mainPanel.Controls.Add(this.emailBox);
            this.mainPanel.Controls.Add(this.phoneBox);
            this.mainPanel.Controls.Add(this.tnameBox);
            this.mainPanel.Controls.Add(this.registerButton1);
            this.mainPanel.Controls.Add(this.snameBox);
            this.mainPanel.Controls.Add(this.fnameBox);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(758, 442);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseClick);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(411, 263);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(323, 37);
            this.emailBox.TabIndex = 5;
            this.emailBox.Text = "Пошта";
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
            this.emailBox.Leave += new System.EventHandler(this.emailBox_Leave);
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneBox.Location = new System.Drawing.Point(411, 200);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(323, 37);
            this.phoneBox.TabIndex = 4;
            this.phoneBox.Text = "Телефон";
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneBox.Enter += new System.EventHandler(this.phoneBox_Enter);
            this.phoneBox.Leave += new System.EventHandler(this.phoneBox_Leave);
            // 
            // tnameBox
            // 
            this.tnameBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tnameBox.Location = new System.Drawing.Point(33, 332);
            this.tnameBox.Name = "tnameBox";
            this.tnameBox.Size = new System.Drawing.Size(323, 37);
            this.tnameBox.TabIndex = 3;
            this.tnameBox.Text = "По-батькові";
            this.tnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tnameBox.Enter += new System.EventHandler(this.tnameBox_Enter);
            this.tnameBox.Leave += new System.EventHandler(this.tnameBox_Leave);
            // 
            // registerButton1
            // 
            this.registerButton1.BackColor = System.Drawing.Color.Brown;
            this.registerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.registerButton1.FlatAppearance.BorderSize = 2;
            this.registerButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.registerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton1.ForeColor = System.Drawing.Color.White;
            this.registerButton1.Location = new System.Drawing.Point(411, 361);
            this.registerButton1.Name = "registerButton1";
            this.registerButton1.Size = new System.Drawing.Size(323, 58);
            this.registerButton1.TabIndex = 6;
            this.registerButton1.Text = "Далі";
            this.registerButton1.UseVisualStyleBackColor = false;
            this.registerButton1.Click += new System.EventHandler(this.registerButton1_Click);
            // 
            // snameBox
            // 
            this.snameBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snameBox.Location = new System.Drawing.Point(33, 263);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(323, 37);
            this.snameBox.TabIndex = 2;
            this.snameBox.Text = "Прізвище";
            this.snameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.snameBox.Enter += new System.EventHandler(this.snameBox_Enter);
            this.snameBox.Leave += new System.EventHandler(this.snameBox_Leave);
            // 
            // fnameBox
            // 
            this.fnameBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fnameBox.Location = new System.Drawing.Point(33, 200);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(323, 37);
            this.fnameBox.TabIndex = 1;
            this.fnameBox.Text = "Ім\'я";
            this.fnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fnameBox.Enter += new System.EventHandler(this.fnameBox_Enter);
            this.fnameBox.Leave += new System.EventHandler(this.fnameBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Version_1._1.Properties.Resources.registerIcon;
            this.pictureBox1.Location = new System.Drawing.Point(331, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.closeLabel);
            this.panel2.Controls.Add(this.authorizationLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 86);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(731, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.Silver;
            this.closeLabel.Location = new System.Drawing.Point(773, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(27, 26);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            // 
            // RegisterForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 442);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm1";
            this.Text = "RegisterForm";
            this.Shown += new System.EventHandler(this.RegisterForm1_Shown);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button registerButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeLabel;
        public System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox snameBox;
        public System.Windows.Forms.TextBox emailBox;
        public System.Windows.Forms.TextBox phoneBox;
        public System.Windows.Forms.TextBox tnameBox;
    }
}