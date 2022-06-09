namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciatsolauzaklık, ikinciatsolauzaklık, üçüncüatsolauzaklık;
        Random rastgele = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            üçüncüatsolauzaklık = pictureBox3.Left;


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenişliği = pictureBox1.Width;
            int ikinciatıngenişliği = pictureBox2.Width;
            int üçüncüatıngenişliği = pictureBox3.Width;

            int bitişuzaklığı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(10, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (birinciatıngenişliği + pictureBox1.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;
                MessageBox.Show("Seni Seviyorum Çiğdem!");
            }

            if (ikinciatıngenişliği + pictureBox2.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;

                MessageBox.Show("Seni Seviyorum Çiğdem");
            }

            if (üçüncüatıngenişliği + pictureBox3.Left >= bitişuzaklığı)
            {
                timer1.Enabled = false;

                MessageBox.Show("Seni Seviyorum Çiğdem");


            }




        }


    }
        
}