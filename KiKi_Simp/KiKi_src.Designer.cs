namespace KiKi_Simp
{
    partial class KiKi_src
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
            btn_copyTpClipboard = new Button();
            checkBox_LowerCase = new CheckBox();
            checkBox_UpperCase = new CheckBox();
            checkBox_Numbers = new CheckBox();
            checkBox_Symbols = new CheckBox();
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
            // btn_copyTpClipboard
            // 
            btn_copyTpClipboard.Location = new Point(78, 181);
            btn_copyTpClipboard.Margin = new Padding(2);
            btn_copyTpClipboard.Name = "btn_copyTpClipboard";
            btn_copyTpClipboard.Size = new Size(140, 20);
            btn_copyTpClipboard.TabIndex = 9;
            btn_copyTpClipboard.Text = "Copy To Clipboard";
            btn_copyTpClipboard.UseVisualStyleBackColor = true;
            btn_copyTpClipboard.Click += button2_Click;
            // 
            // checkBox_LowerCase
            // 
            checkBox_LowerCase.AutoSize = true;
            checkBox_LowerCase.Location = new Point(78, 67);
            checkBox_LowerCase.Margin = new Padding(2);
            checkBox_LowerCase.Name = "checkBox_LowerCase";
            checkBox_LowerCase.Size = new Size(108, 19);
            checkBox_LowerCase.TabIndex = 10;
            checkBox_LowerCase.Text = "Use Lower Case";
            checkBox_LowerCase.UseVisualStyleBackColor = true;
            checkBox_LowerCase.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox_UpperCase
            // 
            checkBox_UpperCase.AutoSize = true;
            checkBox_UpperCase.Location = new Point(78, 88);
            checkBox_UpperCase.Margin = new Padding(2);
            checkBox_UpperCase.Name = "checkBox_UpperCase";
            checkBox_UpperCase.Size = new Size(108, 19);
            checkBox_UpperCase.TabIndex = 11;
            checkBox_UpperCase.Text = "Use Upper Case";
            checkBox_UpperCase.UseVisualStyleBackColor = true;
            checkBox_UpperCase.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox_Numbers
            // 
            checkBox_Numbers.AutoSize = true;
            checkBox_Numbers.Location = new Point(78, 109);
            checkBox_Numbers.Margin = new Padding(2);
            checkBox_Numbers.Name = "checkBox_Numbers";
            checkBox_Numbers.Size = new Size(97, 19);
            checkBox_Numbers.TabIndex = 12;
            checkBox_Numbers.Text = "Use Numbers";
            checkBox_Numbers.UseVisualStyleBackColor = true;
            checkBox_Numbers.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox_Symbols
            // 
            checkBox_Symbols.AutoSize = true;
            checkBox_Symbols.Location = new Point(78, 130);
            checkBox_Symbols.Margin = new Padding(2);
            checkBox_Symbols.Name = "checkBox_Symbols";
            checkBox_Symbols.Size = new Size(93, 19);
            checkBox_Symbols.TabIndex = 13;
            checkBox_Symbols.Text = "Use Symbols";
            checkBox_Symbols.UseVisualStyleBackColor = true;
            checkBox_Symbols.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // createPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(checkBox_Symbols);
            Controls.Add(checkBox_Numbers);
            Controls.Add(checkBox_UpperCase);
            Controls.Add(checkBox_LowerCase);
            Controls.Add(btn_copyTpClipboard);
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
        private Button btn_copyTpClipboard;
        private CheckBox checkBox_LowerCase;
        private CheckBox checkBox_UpperCase;
        private CheckBox checkBox_Numbers;
        private CheckBox checkBox_Symbols;
    }
}