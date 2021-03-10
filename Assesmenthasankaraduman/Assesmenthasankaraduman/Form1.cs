using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assesmenthasankaraduman
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        public string dosya_yeri=Application.StartupPath;
        public string dosya_ismi;
        
        
        public string metin;
        public string degistirilecek_metin;
        public string Re;

        public string sorgulanacak_kelime;
        int sayici=0;
        

        public String  Regular_tanimla(string deger)
        {
            string re = "";
            if (deger[0] != '-' && deger[0] != '*')
            {
                re += '^';
            }
            else if (deger[0] == '-')
            {
                re += '^';
            }
            else if (deger[0] == '*')
            {
                re += '^';
            }

            for (int i = 0; i < deger.Length; i++)
            {

                if (deger[i] == '-')
                {
                    re += "[a-zA-Z]";
                }
                //çğıöşüÇĞİÖŞÜ
                else if (deger[i] == '*')
                {
                    re += "[a-zA-Z]*";
                }

                else
                {
                    re += deger[i];
                }



            }

            if (deger[deger.Length - 1] != '-' && deger[deger.Length - 1] != '*')
            {
                re += "$";
            }
            else if (deger[deger.Length - 1] == '-')
            {
                re += "$";
            }
            else if (deger[deger.Length - 1] == '*')
            {
                re += "$";
            }

            return re;
        }


        public void regular_Click(object sender, EventArgs e)
        {
            Re = Regular_tanimla(textBox1.Text);

            regular.Text = Re;
        }

         public void Metni_getir(string dosya)
        {
            dosya_ismi = dosya;
            StreamReader streamReader = File.OpenText(Application.StartupPath + "\\\\"+dosya+".txt");
            string okunan;
                        
            while ((okunan = streamReader.ReadLine()) != null)
            {
                metin +=okunan;
            }
            richTextBox1.Text = metin;
            streamReader.Close();
        }

        public void ara_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            Re = Regular_tanimla(textBox1.Text);
            sorgulanacak_kelime = "";
            regular.Text = Re;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            sayici = 0;
            ArrayList kelimeler = new ArrayList();
            int metin_uzunluk = metin.Length;
            for(int i=0;i<metin_uzunluk;i++)
            {

                //if(metin[i]!=' ' && metin[i]!=',' && metin[i]!='.' && metin[i] != ';' && metin[i] != ':' && metin[i] != '/')
                if (char.IsLetter(metin[i]) == true)
                {
                    sorgulanacak_kelime += metin[i];
                }
                else
                    
                {
                    kelimeler.Add(sorgulanacak_kelime);
                    Ara(sorgulanacak_kelime);
                    sorgulanacak_kelime = "";
                }
            }
            
        }

        public void Ara(string sorgulanacak_kelime)
        {

            Regex reg = new Regex(Re);

            bool sonuc = reg.IsMatch(sorgulanacak_kelime);

            
            if (sonuc == true)
            {
                sayici += 1;

                int start = 0;
                int end = richTextBox1.Text.LastIndexOf(sorgulanacak_kelime);//sorgulanacak_kelimenin en son bulundugu yerin başlangıç indexi


                while (start <= end)
                {

                    richTextBox1.Find(sorgulanacak_kelime, start, richTextBox1.TextLength, RichTextBoxFinds.WholeWord);


                    richTextBox1.SelectionBackColor = Color.Yellow;

                    start = richTextBox1.Text.IndexOf(sorgulanacak_kelime, start) + 1;

                }
                textBox2.Text = sayici.ToString();
            }

        }

        public void degistir_Click(object sender, EventArgs e)
        {
            Re = Regular_tanimla(textBox1.Text);

            regular.Text = Re;
            string degistirilecek_kelime = textBox3.Text;
            degistirilecek_metin = metin;
            sorgulanacak_kelime = "";

            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            
            
            int metin_uzunluk = metin.Length;
            for (int i = 0; i < metin_uzunluk; i++)
            {
                if (metin[i] != ' ' && metin[i] != ',' && metin[i] != '.' && metin[i] != ';' && metin[i] != ':')
                {
                    sorgulanacak_kelime += metin[i];
                }
                else

                {
                    Degistir(sorgulanacak_kelime,degistirilecek_kelime);
                    sorgulanacak_kelime = "";
                }
                
                
            }
            richTextBox1.Clear();
            richTextBox1.SelectAll();
            metin = degistirilecek_metin;
            richTextBox1.Text = metin;
            

        }

        public void Degistir(string sorgulanacak_kelime,string degistirilecek_kelime)
        {
            Regex reg = new Regex(Re);
            

            bool sonuc = reg.IsMatch(sorgulanacak_kelime);

            //label1.Text = sonuc.ToString();
            if (sonuc == true)
            {
                degistirilecek_metin=degistirilecek_metin.Replace(sorgulanacak_kelime, degistirilecek_kelime);
            }
            
        }

        public void ara_Click_1(object sender, EventArgs e)
        {
            Re = Regular_tanimla(textBox1.Text);

            regular.Text = Re;

            degistirilecek_metin = metin;
            sorgulanacak_kelime = "";
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;


            int metin_uzunluk = metin.Length;
            for (int i = 0; i < metin_uzunluk; i++)
            {
                if (metin[i] != ' ' && metin[i] != ',' && metin[i] != '.' && metin[i] != ';' && metin[i] != ':')
                {
                    sorgulanacak_kelime += metin[i];
                }
                else

                {
                    Degistir(sorgulanacak_kelime, "");
                    sorgulanacak_kelime = "";
                }


            }
            richTextBox1.Clear();
            richTextBox1.SelectAll();
            metin = degistirilecek_metin;
            richTextBox1.Text = metin;


        }



        private void dosya_text_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                string dosya = dosya_text.Text;
                Metni_getir(dosya);
                dosya_text.Visible = false;
                label1.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                regular.Visible = true;
                ara.Visible = true;
                degistir.Visible = true;
                sil.Visible = true;
                esc.Visible = true;
            }
            
        }

        private void esc_Click(object sender, EventArgs e)
        {
            StreamWriter streamwriter = new StreamWriter(Application.StartupPath + "\\\\" + dosya_ismi + ".txt");
            streamwriter.Write(metin);
            streamwriter.Close();
            richTextBox1.Clear();
            Application.Exit();
        }

        public void sil_Click_1(object sender, EventArgs e)
        {
            Re = Regular_tanimla(textBox1.Text);

            regular.Text = Re;

            degistirilecek_metin = metin;
            sorgulanacak_kelime = "";
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;


            int metin_uzunluk = metin.Length;
            for (int i = 0; i < metin_uzunluk; i++)
            {
                if (metin[i] != ' ' && metin[i] != ',' && metin[i] != '.' && metin[i] != ';' && metin[i] != ':')
                {
                    sorgulanacak_kelime += metin[i];
                }
                else

                {
                    Degistir(sorgulanacak_kelime, "");
                    sorgulanacak_kelime = "";
                }


            }
            richTextBox1.Clear();
            richTextBox1.SelectAll();
            metin = degistirilecek_metin;
            richTextBox1.Text = metin;
        }
    }
}
