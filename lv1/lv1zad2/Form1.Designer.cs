namespace lv1zad2
{
    partial class Form1
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
            richTextBox = new RichTextBox();
            btn_start_stop = new Button();
            endValue = new TextBox();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(51, 32);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(182, 384);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // btn_start_stop
            // 
            btn_start_stop.Location = new Point(576, 356);
            btn_start_stop.Name = "btn_start_stop";
            btn_start_stop.Size = new Size(114, 37);
            btn_start_stop.TabIndex = 1;
            btn_start_stop.Text = "Pokreni";
            btn_start_stop.UseVisualStyleBackColor = true;
            btn_start_stop.Click += btn_start_stop_Click;
            // 
            // endValue
            // 
            endValue.Location = new Point(576, 103);
            endValue.Name = "endValue";
            endValue.Size = new Size(100, 23);
            endValue.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(endValue);
            Controls.Add(btn_start_stop);
            Controls.Add(richTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox;
        private Button btn_start_stop;
        private TextBox endValue;
    }
}