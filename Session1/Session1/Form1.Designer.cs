namespace Session1
{
    partial class Grant_JoyceQuestion1
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
            btn1 = new Button();
            lbl2 = new Label();
            lbl1 = new Label();
            txt2 = new TextBox();
            txt1 = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(327, 135);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 0;
            btn1.Text = "Click";
            btn1.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(97, 138);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(83, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "FAMILY NAME";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(139, 97);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(41, 30);
            lbl1.TabIndex = 2;
            lbl1.Text = "GIVEN\r\nNAME";
            // 
            // txt2
            // 
            txt2.BackColor = Color.FromArgb(192, 192, 255);
            txt2.ForeColor = Color.Yellow;
            txt2.Location = new Point(202, 135);
            txt2.Name = "txt2";
            txt2.PlaceholderText = "XXXXXXXXXX";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 3;
            txt2.TextAlign = HorizontalAlignment.Center;
            // 
            // txt1
            // 
            txt1.BackColor = Color.FromArgb(192, 192, 255);
            txt1.ForeColor = Color.Yellow;
            txt1.Location = new Point(202, 97);
            txt1.Name = "txt1";
            txt1.PlaceholderText = "XXXXXXXXXX";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 4;
            txt1.TextAlign = HorizontalAlignment.Center;
            // 
            // Grant_JoyceQuestion1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(505, 279);
            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(lbl1);
            Controls.Add(lbl2);
            Controls.Add(btn1);
            Name = "Grant_JoyceQuestion1";
            Text = "Grant_JoyceQuestion1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label lbl2;
        private Label lbl1;
        private TextBox txt2;
        private TextBox txt1;
    }
}
