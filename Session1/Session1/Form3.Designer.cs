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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 40);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Poetry Quote";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(255, 192, 255);
            richTextBox1.ForeColor = Color.Fuchsia;
            richTextBox1.Location = new Point(32, 83);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(191, 83);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "It was somewhere up the country\nIn a land of bush and scrub\nThey formed an institution called\nThe Geebung Polo Club";
            // 
            // Grant_JoyceQuestion3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(250, 201);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Grant_JoyceQuestion3";
            Text = "Grant_JoyceQuestion3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
    }
}