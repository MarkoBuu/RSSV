namespace lv1

{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
        }
        private void vrijeme(object s, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                lbl_vrijeme.Text = DateTime.Now.ToLongTimeString();
                if (lbl_vrijeme.Text == alarm.Text)
                {
                    Console.Beep();
                }
            });
        }
        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            if (t.Enabled == false)
            {
                t.Start();
                btn_start_stop.Text = "Zaustavi";
            }
            else
            {
                t.Stop();
                btn_start_stop.Text = "Pokreni";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}