using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathTextBox.Text = openFileDialog1.FileName;
        }

        private void integersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] liczby_int = textBox.Text.Split(' ', '\n');
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            foreach (var liczba in liczby_int)
            {
                int zm = Convert.ToInt32(liczba);
                bw.Write(zm);
            }
            bw.Close();
            fs.Close();
            textBox.Text = "";
        }

        private void doublesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] liczby_double = textBox.Text.Split(' ', '\n');
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            foreach (var liczba in liczby_double)
            {
                double zm = Convert.ToDouble(liczba);
                bw.Write(zm);
            }
            bw.Close();
            fs.Close();
            textBox.Text = "";
        }

        private void int1Double1StringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] liczby = textBox.Text.Split(' ', '\n');
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int zm_i = Convert.ToInt32(liczby[0]);
            bw.Write(zm_i);
            double zm_d = Convert.ToDouble(liczby[1]);
            bw.Write(zm_d);
            bw.Write(liczby[2]);
            bw.Close();
            fs.Close();
            textBox.Text = "";
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] liczby = textBox.Text.Split(' ', '\n');
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(liczby[0]);
            bw.Write(liczby[1]);
            int data_rodz = Convert.ToInt32(liczby[2]);
            bw.Write(data_rodz);
            double wzroszt = Convert.ToDouble(liczby[3]);
            bw.Write(wzroszt);
            double waga = Convert.ToDouble(liczby[4]);
            bw.Write(waga);
            bw.Close();
            fs.Close();
            textBox.Text = "";
        }

        private void integersAndDoublesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] liczby = textBox.Text.Split('\n');
            string[] cal = liczby[0].Split(' ');
            int ilosc = cal.Length;
            string[] rz = liczby[1].Split(' ');
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(ilosc);
            foreach (var liczba in cal)
            {
                int zm = Convert.ToInt32(liczba);
                bw.Write(zm);
            }
            
            foreach (var liczba in rz)
            {
                double zm = Convert.ToDouble(liczba);
                bw.Write(zm);
            }
            bw.Close();
            fs.Close();
            textBox.Text = "";
        }

        private void osobyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] osoby = textBox.Text.Split('\n');
            string[][] osoba = new string[osoby.Length][];
            for (int i = 0; i < osoby.Length; i++)
            {
                osoba[i] = new string[osoby[i].Split(' ').Length];
                osoba[i] = osoby[i].Split(' ');
            }
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            foreach (var person in osoba)
            {
                bw.Write(person[0]);
                bw.Write(person[1]);
                bw.Write(Convert.ToInt32(person[2]));
                bw.Write(Convert.ToDouble(person[3]));
                bw.Write(Convert.ToDouble(person[4]));
            }
            bw.Close();
            fs.Close();
            textBox.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////////
        private void integersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            try
            {
                while (br.PeekChar() > -1)
                {
                    int zm = br.ReadInt32();
                    textBox.Text += Convert.ToString(zm);
                    textBox.Text += ' ';
                }
            }
            catch( Exception)
            {
            }
            br.Close();
            fs.Close();
        }

        private void doublesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            try
            {
                while (br.PeekChar() > -1)
                {
                    double zm = br.ReadDouble();
                    textBox.Text += Convert.ToString(zm);
                    textBox.Text += ' ';
                }
            }
            catch (Exception)
            {
            }
            br.Close();
            fs.Close();
        }

        private void int1Double1StringToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int zm_i = br.ReadInt32();
            textBox.Text += Convert.ToString(zm_i);
            textBox.Text += ' ';
            double zm_d = br.ReadDouble();
            textBox.Text += Convert.ToString(zm_d);
            textBox.Text += ' ';
            string zm_s = br.ReadString();
            textBox.Text += zm_s;
            textBox.Text += ' ';
            br.Close();
            fs.Close();
        }

        private void osobaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            string imia = br.ReadString();
            textBox.Text += imia;
            textBox.Text += ' ';
            string nazwisko = br.ReadString();
            textBox.Text += nazwisko;
            textBox.Text += ' ';
            int data = br.ReadInt32();
            textBox.Text += Convert.ToString(data);
            textBox.Text += ' ';
            double wzrost = br.ReadDouble();
            textBox.Text += Convert.ToString(wzrost);
            textBox.Text += ' ';
            double waga = br.ReadDouble();
            textBox.Text += Convert.ToString(waga);
            textBox.Text += ' ';
            br.Close();
            fs.Close();
        }

        private void integersAndDoublesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int ilosc = br.ReadInt32();
            try
            {
                for (int i = 0; i < ilosc; i++)
                {
                    string zm = (br.ReadInt32()).ToString();
                    textBox.Text += zm;
                    textBox.Text += ' ';
                }
                textBox.Text += "    ";
                while (br.PeekChar() > -1)
                {
                    string zm = (br.ReadDouble()).ToString();
                    textBox.Text += zm;
                    textBox.Text += ' ';
                }
            }
            catch (Exception)
            {
            }
            br.Close();
            fs.Close();
        }

        private void osobyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            try
            {
                while (br.PeekChar() > -1)
                {
                    textBox.Text += br.ReadString();
                    textBox.Text += ' ';
                    textBox.Text += br.ReadString();
                    textBox.Text += ' ';
                    textBox.Text += br.ReadInt32();
                    textBox.Text += ' ';
                    textBox.Text += br.ReadDouble();
                    textBox.Text += ' ';
                    textBox.Text += br.ReadDouble();
                    textBox.Text += "    ";
                }
            }
            catch (Exception)
            {
            }
            br.Close();
            fs.Close();
        }
    }
}
