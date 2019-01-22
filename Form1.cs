using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AE1
{
    public partial class Form1 : Form
    {
        public double pk, pm, a, b, c, d;
        public int liczebnosc, iteracja, iteracje, iloscBitow, poczatek, koniec;
        public double[,] przystosowanie;
        public int[,] osobniki, osobnikiBitowo;
        public double[] pMin, pMax, pSr;

        public Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            cmbKrzyzowanie.SelectedIndex = 0;
            cmbSelekcja.SelectedIndex = 0;
            cmbPoszukiwanie.SelectedIndex = 0;
            btnOblicz_Click(null, null);
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            //pobieranie parametrow
            try
            {
                pk = Double.Parse(txtBoxPk.Text);
                pm = Double.Parse(txtBoxPm.Text);
                liczebnosc = Int32.Parse(txtBoxLosobnikow.Text);
                iteracje = Int32.Parse(txtBoxLiteracji.Text) + 1;
                poczatek = Int32.Parse(txtBoxPocz.Text);
                koniec = Int32.Parse(txtBoxKoniec.Text);
                a = Double.Parse(txtBoxA.Text);
                b = Double.Parse(txtBoxB.Text);
                c = Double.Parse(txtBoxC.Text);
                d = Double.Parse(txtBoxD.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy pobieraniu wpisanych parametrów: \n\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            rysujWykresFunkcji();
            obliczenia();
        }
        
        public void obliczenia()
        {
            try
            {
                pMin = new double[iteracje]; //przystosowanie min
                pMax = new double[iteracje]; //przystosowanie max
                pSr = new double[iteracje]; //przystosowanie srednie
                przystosowanie = new double[iteracje, liczebnosc]; //wszystkie przystosowania
                osobniki = new int[iteracje, liczebnosc];
                iteracja = 0;

                for (int i = 0; i < liczebnosc; i++) //gen. populacji pocz.
                    osobniki[0, i] = losujInt(poczatek, koniec);
                
                liczPrzystosowanie(); //przystosowanie populacji poczatkowej

                //ewolucja
                for (iteracja = 1; iteracja < iteracje; iteracja++)
                {
                    zmianaPrzedzialu(true);
                    selekcjaRuletka();
                    generujBitoweOdpowiedniki();
                    krzyzowanie();
                    mutacja();
                    zamienBitoweNaDziesietne();
                    funkcjaKary();
                    zmianaPrzedzialu(false);
                    liczPrzystosowanie();
                }

                rysujWykresPrzystosowania();
            }
            catch (Exception e)
            {
                MessageBox.Show("Nastąpił nieoczekiwany błąd:\n" + e.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void zmianaPrzedzialu(Boolean wGore)
        {
            if (poczatek >= 0)
                return;

            if (wGore)
            {
                for (int i = 0; i < liczebnosc; i++)
                {
                    osobniki[iteracja - 1, i] += Math.Abs(poczatek);
                }
            }
            else
            {
                for (int i = 0; i < liczebnosc; i++)
                {
                    osobniki[iteracja, i] -= Math.Abs(poczatek);
                }
            }
        }

        private void cmbPoszukiwanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoszukiwanie.SelectedIndex == 0) //maksimum
            {
                chart2.Series[0].Color = System.Drawing.Color.Red;
                chart2.Series[2].Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                chart2.Series[2].Name = "";
                chart2.Series[0].Name = "Najgorsze";
                chart2.Series[2].Name = "Najlepsze";
            }
            else //minimum
            {
                chart2.Series[0].Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                chart2.Series[2].Color = System.Drawing.Color.Red;
                chart2.Series[2].Name = "";
                chart2.Series[0].Name = "Najlepsze";
                chart2.Series[2].Name = "Najgorsze";
            }

            btnOblicz_Click(null, null);
        }

        public void rysujWykresFunkcji()
        {
            rtxtFunkcja.Text = "Wykres funkcji f(x) = " + a + "x2 " + (b < 0 ? b.ToString() : "+" + b.ToString()) + "x " + (c < 0 ? c.ToString() : "+" + c.ToString());
            rtxtFunkcja.SelectionStart = rtxtFunkcja.Text.IndexOf("x2") + 1;
            rtxtFunkcja.SelectionLength = 1;
            rtxtFunkcja.SelectionCharOffset = 4;
            rtxtFunkcja.SelectAll();
            rtxtFunkcja.SelectionAlignment = HorizontalAlignment.Center;

            chart1.Series[0].Points.Clear();

            for (int i = poczatek; i <= koniec; i++)
                chart1.Series[0].Points.AddXY(i, wartoscFunkcji(i));

            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
        }

        public void rysujWykresPrzystosowania()
        {
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();

            for (int i=0; i<iteracje; i++)
            {
                chart2.Series[0].Points.AddXY(i, pMin[i]);
                chart2.Series[1].Points.AddXY(i, pSr[i]);
                chart2.Series[2].Points.AddXY(i, pMax[i]);
            }

            chart2.ChartAreas[0].AxisX.IsMarginVisible = false;
        }

        public void selekcjaRuletka()
        {
            double tmp = 0;
            for (int i = 0; i < liczebnosc; i++)
                tmp += osobniki[iteracja - 1, i];
            
            double[] skala = new double[liczebnosc];

            if (cmbSelekcja.SelectedIndex == 0) //kolo ruletki
            {
                //inicjalizacja kola ruletki
                if (cmbPoszukiwanie.SelectedIndex == 0) //poszukiwanie maksimum
                {
                    skala[0] = ((przystosowanie[iteracja - 1, 0] - pMin[iteracja - 1]) / (pMax[iteracja - 1] - pMin[iteracja - 1] + 1));
                    for (int i = 1; i < liczebnosc; i++)
                        skala[i] = skala[i - 1] + ((przystosowanie[iteracja - 1, i] - pMin[iteracja - 1]) / (pMax[iteracja - 1] - pMin[iteracja - 1] + 1)) + (1.0 / liczebnosc);
                }
                else //poszukiwanie minimum
                {
                    skala[0] = -((przystosowanie[iteracja - 1, 0] - pMin[iteracja - 1]) / (pMax[iteracja - 1] - pMin[iteracja - 1] + 1)) + 1;
                    for (int i = 1; i < liczebnosc; i++)
                        skala[i] = skala[i - 1] - ((przystosowanie[iteracja - 1, i] - pMin[iteracja - 1]) / (pMax[iteracja - 1] - pMin[iteracja - 1] + 1)) + (1.0 / liczebnosc) + 1;
                }
            }
            else //metoda rankingowa
            {
                double sumaPrzystosowan = 0;
                for (int i = 0; i < liczebnosc; i++)
                    sumaPrzystosowan += przystosowanie[iteracja-1, i] - pMin[iteracja-1];

                if (pMin[iteracja - 1] == pMax[iteracja - 1])
                    Console.Write("");

                if (cmbPoszukiwanie.SelectedIndex == 0) //poszukiwanie maksimum
                {
                    skala[0] = ((przystosowanie[iteracja-1, 0]-pMin[iteracja-1])/(sumaPrzystosowan+1));
                    for (int i = 1; i < liczebnosc; i++)
                        skala[i] = skala[i - 1] + ((przystosowanie[iteracja-1, i]-pMin[iteracja-1])/ (sumaPrzystosowan+1)) + 1.0/liczebnosc;
                }
                else //poszukiwanie minimum
                {
                    skala[0] = -10*((przystosowanie[iteracja-1, 0]-pMin[iteracja-1])/ (sumaPrzystosowan+1)) + 1;
                    for (int i = 1; i < liczebnosc; i++)
                        skala[i] = skala[i - 1] - 10*((przystosowanie[iteracja-1, i]-pMin[iteracja-1]) / (sumaPrzystosowan+1)) + 1 + 1.0/liczebnosc;
                }
            }
            
            //selekcja
            for (int i=0; i<liczebnosc; i++)
            {
                double los = losujDouble(0, skala[liczebnosc-1]);
                for (int j=0; j<liczebnosc; j++)
                {
                    if (los < skala[j])
                    {
                        osobniki[iteracja, i] = osobniki[iteracja-1, j];
                        break;
                    }
                }
            }
        }

        public void generujBitoweOdpowiedniki()
        {
            //znajdz najwiekszego osobnika
            int max = -1;
            for (int i = 0; i < liczebnosc; i++)
                max = osobniki[iteracja, i] > max ? osobniki[iteracja, i] : max;

            iloscBitow = 0;
            while (max>=1)
            {
                max = max / 2;
                iloscBitow++;
            }

            if (iloscBitow == 0)
                iloscBitow = 3;

            osobnikiBitowo = new int[liczebnosc, iloscBitow];
            for (int i=0; i<liczebnosc; i++) //zamien kazdego osobnika
            {
                String osobnik = Convert.ToString(osobniki[iteracja, i], 2);
                while (osobnik.Length < iloscBitow)
                    osobnik = "0" + osobnik;
                for (int j = 0; j < iloscBitow; j++)
                    osobnikiBitowo[i, j] = Int32.Parse(osobnik.ToCharArray()[j].ToString());
            }
        }

        public void zamienBitoweNaDziesietne()
        {
            for (int i=0; i<liczebnosc; i++)
            {
                int osobnikTmp = 0;
                int k = 0;
                for (int j = iloscBitow - 1; j >= 0; j--)
                    osobnikTmp += osobnikiBitowo[i,j]*(int)Math.Pow(2, k++);
                osobniki[iteracja, i] = osobnikTmp;
            }
        }

        public void funkcjaKary()
        {
            int knc = koniec;
            int pc = poczatek;

            if (poczatek < 0)
            {
                knc = koniec + Math.Abs(poczatek);
                pc = 0;
            }

            for (int i = 0; i < liczebnosc; i++)
            {
                osobniki[iteracja, i] = osobniki[iteracja, i] < poczatek ? poczatek : osobniki[iteracja, i];
                osobniki[iteracja, i] = osobniki[iteracja, i] > knc ? knc : osobniki[iteracja, i];
            }
        }

        public void krzyzowanie()
        {
            if (cmbKrzyzowanie.SelectedIndex == 0)
            {
                krzyzowanieProste();
            }
            else
            {
                krzyzowanieOX();
            }
        }

        public void krzyzowanieProste()
        {
            int[,] osobnikiBitowoNowe = new int[liczebnosc, iloscBitow];
            List<int> indeksy = new List<int>();
            for (int i = 0; i < liczebnosc; i++)
                indeksy.Add(i);
            int j = 0;
            while (indeksy.Count > 1) //dopoki sa przynajmniej 2 wolne osobniki (moze zajsc krzyzowanie)
            {
                if (losujDouble(0,1) < pk)
                {
                    //losuj osobnika i skrzyzuj go z pierwszym, przepisz dzieci i usun oba z listy
                    int indeks2Osobnika = losujInt(1, indeksy.Count - 1);
                    int locus = losujInt(0, iloscBitow - 1); //punkt przeciecia
                    for (int i = 0; i < locus; i++) {
                        osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[0],i];
                        osobnikiBitowoNowe[j+1, i] = osobnikiBitowo[indeksy[indeks2Osobnika],i];
                    }
                    for (int i = locus; i < iloscBitow; i++)
                    {
                        osobnikiBitowoNowe[j+1, i] = osobnikiBitowo[indeksy[0], i];
                        osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[indeks2Osobnika], i];
                    }
                    j += 2;
                    indeksy.RemoveAt(indeks2Osobnika);
                    indeksy.RemoveAt(0);
                } else
                {
                    //wyciagnij z listy pierwszego osobnika i go przepisz
                    for (int i=0; i<iloscBitow; i++)
                        osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[0], i];
                    indeksy.RemoveAt(0);
                    j++;
                }
                
            }
            if (indeksy.Count > 0)
            {
                for (int i = 0; i < iloscBitow; i++)
                    osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[0], i];
            }
            //jesli zostal jakis osobnik - przepisz
            for (int i = 0; i < liczebnosc; i++)
            {
                for (int k = 0; k < iloscBitow; k++)
                {
                    osobnikiBitowo[i, k] = osobnikiBitowoNowe[i, k];
                }
            }
        }

        public void krzyzowanieOX()
        {
            int[,] osobnikiBitowoNowe = new int[liczebnosc, iloscBitow];
            List<int> indeksy = new List<int>();
            for (int i = 0; i < liczebnosc; i++)
                indeksy.Add(i);
            int j = 0;
            while (indeksy.Count > 1) //dopoki sa przynajmniej 2 wolne osobniki (moze zajsc krzyzowanie)
            {
                if (losujDouble(0, 1) < pk)
                {
                    //losuj osobnika i skrzyzuj go z pierwszym, przepisz dzieci i usun oba z listy
                    int indeks2Osobnika = losujInt(1, indeksy.Count - 1);
                    int locus = losujInt(1, iloscBitow - 1); //punkt przeciecia
                    int pocz = losujInt(0, iloscBitow - 2); //pierwszy punkt przeciecia
                    int kon = losujInt(pocz, iloscBitow - 1); //drugi punkt przeciecia

                    for (int i = 0; i < iloscBitow; i++)
                    {
                        if (i < pocz || i > kon) {
                            osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[0], i];
                            osobnikiBitowoNowe[j + 1, i] = osobnikiBitowo[indeksy[indeks2Osobnika], i];
                        }
                        else
                        {
                            osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[indeks2Osobnika], i];
                            osobnikiBitowoNowe[j + 1, i] = osobnikiBitowo[indeksy[0], i];
                        }
                    }

                    for (int i = 0; i < locus; i++)
                    {
                        osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[0], i];
                        osobnikiBitowoNowe[j + 1, i] = osobnikiBitowo[indeksy[indeks2Osobnika], i];
                    }
                    for (int i = locus; i < iloscBitow; i++)
                    {
                        osobnikiBitowoNowe[j + 1, i] = osobnikiBitowo[indeksy[0], i];
                        osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[indeks2Osobnika], i];
                    }
                    j += 2;
                    indeksy.RemoveAt(indeks2Osobnika);
                    indeksy.RemoveAt(0);
                }
                else
                {
                    //wyciagnij z listy pierwszego osobnika i go przepisz
                    for (int i = 0; i < iloscBitow; i++)
                        osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[0], i];
                    indeksy.RemoveAt(0);
                    j++;
                }

            }
            if (indeksy.Count > 0)
            {
                for (int i = 0; i < iloscBitow; i++)
                    osobnikiBitowoNowe[j, i] = osobnikiBitowo[indeksy[0], i];
            }
            //jesli zostal jakis osobnik - przepisz
            for (int i = 0; i < liczebnosc; i++)
            {
                for (int k = 0; k < iloscBitow; k++)
                {
                    osobnikiBitowo[i, k] = osobnikiBitowoNowe[i, k];
                }
            }
        }

        public void mutacja()
        {
            for (int i=0; i<liczebnosc; i++)
            {
                if (losujDouble(0,1) < pm)
                {
                    int bit = losujInt(0, iloscBitow - 1);
                    osobnikiBitowo[i, bit] = Math.Abs(osobnikiBitowo[i, bit] - 1);
                }
            }
        }

        public void liczPrzystosowanie()
        {
            double min = Double.MaxValue, max = Double.MinValue, sr=0;
            for (int i=0; i<liczebnosc; i++)
            {
                przystosowanie[iteracja, i] = wartoscFunkcji(osobniki[iteracja, i]);
                min = przystosowanie[iteracja, i] < min ? przystosowanie[iteracja, i] : min;
                max = przystosowanie[iteracja, i] > max ? przystosowanie[iteracja, i] : max;
                sr += przystosowanie[iteracja, i];
            }
            pMin[iteracja] = min;
            pMax[iteracja] = max;
            pSr[iteracja] = sr / liczebnosc;
        }

        //zwraca wartosc funkcji dla danego x
        public double wartoscFunkcji(double x)
        {
            return a * x * x * x + b * x * x + c * x + d;
        }

        //losowy integer z przedzialu domknietego
        public int losujInt(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        //losowy double z przedzialu domknietego
        public double losujDouble(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }
    }
}
