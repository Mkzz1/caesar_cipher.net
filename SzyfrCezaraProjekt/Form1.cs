using System.IO;

namespace SzyfrCezaraProjekt
{
    public partial class Form1 : Form
    {
        private SzyfrujZaszyfruj mojSzyfr;
        public Form1()
        {
            mojSzyfr = new SzyfrCezara();

            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrzyciskCzyszczeniaTXTrozszyfrowane_Click(object sender, EventArgs e)
        {
            RozszyfrowanyTXT.Text = String.Empty;
        }

        private void PrzyciskCzyszczeniaTXTzaszyfrowane_Click(object sender, EventArgs e)
        {
            ZaszyfrowanyTXT.Text = String.Empty; 
        }

        private void Zaszyfruj_Click(object sender, EventArgs e)
        {
            string txtDoZaszyfrowania = RozszyfrowanyTXT.Text;
            string txtZaszyfrowany = mojSzyfr.Szyfruj(txtDoZaszyfrowania, int.Parse(Klucz.Text) +1);
            ZaszyfrowanyTXT.Text = txtZaszyfrowany;
        }

        private void Rozszyfruj_Click(object sender, EventArgs e)
        {
            string txtDoRozszyfrowania = ZaszyfrowanyTXT.Text;
            string txtRozszyfrowany = mojSzyfr.Zaszyfruj(txtDoRozszyfrowania, int.Parse(Klucz.Text) +1);
            RozszyfrowanyTXT.Text = txtRozszyfrowany;
        }

        private void ImportujTXTbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                RozszyfrowanyTXT.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void WyeksportujTXTbtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(saveFileDialog1.FileName);

                writer.Write(ZaszyfrowanyTXT.Text);

                writer.Close();
            }
        }
    }
}