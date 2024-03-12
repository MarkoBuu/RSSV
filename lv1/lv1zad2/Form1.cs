namespace lv1zad2
{

    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        private StreamReader reader;
        private int criticalValue;
        private string line;

        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
            reader = new StreamReader("text.txt");
        }

        private void vrijeme(object s, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                criticalValue = Int32.Parse(endValue.Text);
                line = reader.ReadLine();
                if (line == null)
                {
                    t.Stop();
                    reader.Close();
                    return;
                }
                richTextBox.AppendText(line);
                if (line != null)
                {
                    if (Int32.Parse(line) > criticalValue)
                    {
                    t.Stop();
                    MessageBox.Show("poruke");
                    t.Start();
                    }
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // r.Close();
        }
    }
}