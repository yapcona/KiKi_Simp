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
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "KiKi (SIMP)";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(112, 52);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(447, 31);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 55);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 116);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 4;
            label3.Click += label3_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(112, 262);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(200, 34);
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
            btnHide_Show.Location = new Point(565, 51);
            btnHide_Show.Name = "btnHide_Show";
            btnHide_Show.Size = new Size(200, 34);
            btnHide_Show.TabIndex = 7;
            btnHide_Show.Text = "Hide password";
            btnHide_Show.UseVisualStyleBackColor = false;
            btnHide_Show.Click += btnHide_Show_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 302);
            button2.Name = "button2";
            button2.Size = new Size(200, 34);
            button2.TabIndex = 9;
            button2.Text = "Copy To Clipboard";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(112, 112);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(161, 29);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Use Lower Case";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(112, 147);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(163, 29);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Use Upper Case";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(112, 182);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(145, 29);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "Use Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(112, 217);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(140, 29);
            checkBox4.TabIndex = 13;
            checkBox4.Text = "Use Symbols";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // createPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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