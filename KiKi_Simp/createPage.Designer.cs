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
            btnCopy = new Button();
            btnGenerate = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btnHide_Show = new Button();
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
            // btnCopy
            // 
            btnCopy.Location = new Point(112, 157);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(200, 34);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "Copy To Clipboard";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(112, 107);
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
            btnHide_Show.Location = new Point(565, 51);
            btnHide_Show.Name = "btnHide_Show";
            btnHide_Show.Size = new Size(155, 34);
            btnHide_Show.TabIndex = 7;
            btnHide_Show.Text = "Hide password";
            btnHide_Show.UseVisualStyleBackColor = true;
            btnHide_Show.Click += btnHide_Show_Click;
            // 
            // createPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHide_Show);
            Controls.Add(btnGenerate);
            Controls.Add(btnCopy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Name = "createPage";
            Text = "KiKi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPass;
        private Label label2;
        private Label label3;
        private Button btnCopy;
        private Button btnGenerate;
        private SaveFileDialog saveFileDialog1;
        private Button btnHide_Show;
    }
}