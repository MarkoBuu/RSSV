namespace lv1
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
            lbl_vrijeme = new Label();
            btn_start_stop = new Button();
            alarm = new TextBox();
            SuspendLayout();
            // 
            // lbl_vrijeme
            // 
            lbl_vrijeme.AutoSize = true;
            lbl_vrijeme.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_vrijeme.Location = new Point(60, 41);
            lbl_vrijeme.Name = "lbl_vrijeme";
            lbl_vrijeme.Size = new Size(162, 59);
            lbl_vrijeme.TabIndex = 0;
            lbl_vrijeme.Text = "vrijeme";
            // 
            // btn_start_stop
            // 
            btn_start_stop.Location = new Point(416, 211);
            btn_start_stop.Name = "btn_start_stop";
            btn_start_stop.Size = new Size(75, 23);
            btn_start_stop.TabIndex = 1;
            btn_start_stop.Text = "Pokreni";
            btn_start_stop.UseVisualStyleBackColor = true;
            btn_start_stop.Click += btn_start_stop_Click;
            // 
            // alarm
            // 
            alarm.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            alarm.Location = new Point(60, 124);
            alarm.Name = "alarm";
            alarm.Size = new Size(150, 64);
            alarm.TabIndex = 2;
            alarm.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 270);
            Controls.Add(alarm);
            Controls.Add(btn_start_stop);
            Controls.Add(lbl_vrijeme);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_vrijeme;
        private Button btn_start_stop;
        private TextBox alarm;
    }
}