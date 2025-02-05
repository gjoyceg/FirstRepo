namespace Session1
{
    partial class Grant_JoyceQuestion3
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
            lbl1 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            lbl2 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(66, 33);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(33, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Hero";
            // 
            // txt1
            // 
            txt1.BorderStyle = BorderStyle.FixedSingle;
            txt1.Cursor = Cursors.IBeam;
            txt1.Location = new Point(167, 33);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 2;
            txt1.Text = "Batman";
            txt1.TextChanged += textBox1_TextChanged;
            // 
            // txt2
            // 
            txt2.BorderStyle = BorderStyle.FixedSingle;
            txt2.Cursor = Cursors.IBeam;
            txt2.Location = new Point(167, 72);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 3;
            txt2.Text = "Joker";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(66, 74);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(39, 15);
            lbl2.TabIndex = 4;
            lbl2.Text = "Villain";
            // 
            // Grant_JoyceQuestion3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(355, 133);
            Controls.Add(lbl2);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Grant_JoyceQuestion3";
            Text = "Grant_JoyceQuestion2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txt1;
        private TextBox txt2;
        private Label lbl2;
    }
}