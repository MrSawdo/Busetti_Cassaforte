namespace Busetti_cassaforte
{
    public partial class Form1 : Form
    {
        private const string codiceSegreto = "abcdef123456";
        private const string codiceUtente = "abcde";

        private Cassaforte cassaforte;

        public Form1()
        {
            InitializeComponent();
            cassaforte = new Cassaforte("abcde", "cassaforte", 5, "Busetti",false, "abcdef123456");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cassaforte.apriCassa(codiceUtente);
            textBox3.Text = "la cassaforte è aperta";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cassaforte.chiudiCassa();
            textBox3.Text = "la cassaforte è chiusa";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = cassaforte.CodiceUtente;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = cassaforte.CodiceSegreto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cassaforte.sbloccaCassa();
            textBox3.Text = "la cassaforte è stata sbloccata";
        }
    }
}
