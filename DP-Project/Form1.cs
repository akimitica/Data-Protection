using DP_Project.Encr_Decr.CryptoHash;
using DP_Project.Encr_Decr.CypherLib;
using DP_Project.Encr_Decr.Mode;

namespace DP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OFB ofb = new OFB();
            textBox3.Text = ofb.Decrypt(textBox2.Text, MODE.OneTimePad, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin|Image Files(*.bmp)|*.bmp";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string directive = d.FileName;
                InputDirOTP.Text = directive;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OFB ofb = new OFB();
            textBox3.Text = ofb.Crypt(textBox2.Text, MODE.OneTimePad, textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin|Image Files(*.bmp)|*.bmp";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string putanja = d.FileName;
                OutputDirOTP.Text = putanja;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (InputDirOTP.Text != "" && OutputDirOTP.Text != "")
            {
                SHA1 sha1 = new SHA1();
                byte[] hash;
                OFB ofb = new OFB();
                byte[] readInput = File.ReadAllBytes(InputDirOTP.Text);
                hash = sha1.GetHash(readInput);
                //povratna vrednost enkripcije
                byte[] res = ofb.Crypt(readInput, MODE.OneTimePad, readInput); //TODO - add keying system
                Array.Copy(hash, res, 20);
                //upis
                File.WriteAllBytes(OutputDirOTP.Text, res);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            OFB ofb = new OFB();
            FSCOutputBox.Text = ofb.Crypt(FSCKeyBox.Text, MODE.FourSquare, FSCInputBox.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {

            OFB ofb = new OFB();
            FSCOutputBox.Text = ofb.Decrypt(FSCKeyBox.Text, MODE.FourSquare, FSCInputBox.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Text files (*.txt)|*.txt";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string putanja = d.FileName;
                FSCInputDir.Text = putanja;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Text files (*.txt)|*.txt";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string putanja = d.FileName;
                FSCOutputDir.Text = putanja;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (FSCInputDir.Text != "" && FSCOutputDir.Text != "")
            {
                SHA1 sha1 = new SHA1();
                byte[] hash;
                OFB ofb = new OFB();
                byte[] readInput = File.ReadAllBytes(InputDirOTP.Text);
                hash = sha1.GetHash(readInput);
                //povratna vrednost enkripcije
                byte[] res = ofb.Crypt(readInput, MODE.FourSquare, readInput); //TODO - add keying system
                Array.Copy(hash, res, 20);
                //upis
                File.WriteAllBytes(FSCOutputDir.Text, res);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (InputDirOTP.Text != "" && OutputDirOTP.Text != "")
            {
                SHA1 sha1 = new SHA1();
                byte[] hash;
                byte[] oldHash;
                byte[] res;
                OFB ofb = new OFB();
                byte[] readInput = File.ReadAllBytes(InputDirOTP.Text);
                oldHash = readInput.Take(20).ToArray();
                readInput = readInput.Skip(20).ToArray();
                hash = sha1.GetHash(readInput);
                //povratna vrednost enkripcije
                if (oldHash.SequenceEqual(hash)) 
                { 
                    res = ofb.Decrypt(readInput, MODE.OneTimePad, readInput);   //TODO - add keying system
                    File.WriteAllBytes(OutputDirOTP.Text, res);   
                }
                else
                {
                    MessageBox.Show("Different hash.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //upis
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (FSCInputDir.Text != "" && FSCOutputDir.Text != "")
            {
                SHA1 sha1 = new SHA1();
                byte[] hash;
                byte[] oldHash;
                byte[] res;
                OFB ofb = new OFB();
                byte[] readInput = File.ReadAllBytes(InputDirOTP.Text);
                oldHash = readInput.Take(20).ToArray();
                readInput = readInput.Skip(20).ToArray();
                hash = sha1.GetHash(readInput);
                //povratna vrednost enkripcije
                if (oldHash.SequenceEqual(hash))
                {
                    res = ofb.Decrypt(readInput, MODE.FourSquare, readInput);   //TODO - add keying system
                    File.WriteAllBytes(OutputDirOTP.Text, res);
                }
                else
                {
                    MessageBox.Show("Different hash.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button21_Click(object sender, EventArgs e)
        {
            OFB ofb = new OFB();
            XXTEAOutput.Text = ofb.Crypt(XXTEAKey.Text, MODE.XXTEA, XXTEAInput.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OFB ofb = new OFB();
            XXTEAOutput.Text = ofb.Decrypt(XXTEAKey.Text, MODE.XXTEA, XXTEAInput.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin|Image Files(*.bmp)|*.bmp";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string putanja = d.FileName;
                XXTEAInputDir.Text = putanja;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin|Image Files(*.bmp)|*.bmp";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string putanja = d.FileName;
                XXTEAOutputDir.Text = putanja;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (XXTEAInputDir.Text != "" && XXTEAOutputDir.Text != "")
            {
                SHA1 sha1 = new SHA1();
                byte[] hash;
                OFB ofb = new OFB();
                byte[] readInput = File.ReadAllBytes(InputDirOTP.Text);
                hash = sha1.GetHash(readInput);
                //povratna vrednost enkripcije
                byte[] res = ofb.Crypt(readInput, MODE.XXTEA, readInput); //TODO - add keying system
                Array.Copy(hash, res, 20);
                //upis
                File.WriteAllBytes(FSCOutputDir.Text, res);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (XXTEAInputDir.Text != "" && XXTEAOutputDir.Text != "")
            {
                SHA1 sha1 = new SHA1();
                byte[] hash;
                byte[] oldHash;
                byte[] res;
                OFB ofb = new OFB();
                byte[] readInput = File.ReadAllBytes(InputDirOTP.Text);
                oldHash = readInput.Take(20).ToArray();
                readInput = readInput.Skip(20).ToArray();
                hash = sha1.GetHash(readInput);
                //povratna vrednost enkripcije
                if (oldHash.SequenceEqual(hash))
                {
                    res = ofb.Decrypt(readInput, MODE.XXTEA, readInput);   //TODO - add keying system
                    File.WriteAllBytes(OutputDirOTP.Text, res);
                }
                else
                {
                    MessageBox.Show("Different hash.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}