namespace KiKi_Simp
{
    partial class createPage
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
            label1 = new Label();
            txtPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGenerate = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btnHide_Show = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "KiKi (SIMP)";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(78, 31);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(314, 23);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 70);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            label3.Click += label3_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(78, 157);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(140, 20);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // btnHide_Show
            // 
            btnHide_Show.BackColor = SystemColors.HighlightText;
            btnHide_Show.Location = new Point(396, 31);
            btnHide_Show.Margin = new Padding(2);
            btnHide_Show.Name = "btnHide_Show";
            btnHide_Show.Size = new Size(140, 20);
            btnHide_Show.TabIndex = 7;
            btnHide_Show.Text = "Hide password";
            btnHide_Show.UseVisualStyleBackColor = false;
            btnHide_Show.Click += btnHide_Show_Click;
            // 
            // button2
            // 
            button2.Location = new Point(78, 181);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(140, 20);
            button2.TabIndex = 9;
            button2.Text = "Copy To Clipboard";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(78, 67);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Use Lower Case";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(78, 88);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Use Upper Case";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(78, 109);
            checkBox3.Margin = new Padding(2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(97, 19);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "Use Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(78, 130);
            checkBox4.Margin = new Padding(2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(93, 19);
            checkBox4.TabIndex = 13;
            checkBox4.Text = "Use Symbols";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // createPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(btnHide_Show);
            Controls.Add(btnGenerate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "createPage";
            Text = "KiKi";
            Load += createPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPass;
        private Label label2;
        private Label label3;
        private Button btnGenerate;
        private SaveFileDialog saveFileDialog1;
        private Button btnHide_Show;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}