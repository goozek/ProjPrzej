namespace AE1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxLosobnikow = new System.Windows.Forms.TextBox();
            this.txtBoxLiteracji = new System.Windows.Forms.TextBox();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.txtBoxPocz = new System.Windows.Forms.TextBox();
            this.txtBoxKoniec = new System.Windows.Forms.TextBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbKrzyzowanie = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSelekcja = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbPoszukiwanie = new System.Windows.Forms.ComboBox();
            this.rtxtFunkcja = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoxD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parametry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "P. krzyżowania";
            // 
            // txtBoxPk
            // 
            this.txtBoxPk.Location = new System.Drawing.Point(439, 38);
            this.txtBoxPk.Name = "txtBoxPk";
            this.txtBoxPk.Size = new System.Drawing.Size(60, 20);
            this.txtBoxPk.TabIndex = 3;
            this.txtBoxPk.Text = "0,7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P. mutacji";
            // 
            // txtBoxPm
            // 
            this.txtBoxPm.Location = new System.Drawing.Point(439, 64);
            this.txtBoxPm.Name = "txtBoxPm";
            this.txtBoxPm.Size = new System.Drawing.Size(60, 20);
            this.txtBoxPm.TabIndex = 5;
            this.txtBoxPm.Text = "0,005";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Liczba osobników";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Liczba iteracji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Współczynniki wielomianu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Przedział: <";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = ">";
            // 
            // txtBoxLosobnikow
            // 
            this.txtBoxLosobnikow.Location = new System.Drawing.Point(439, 88);
            this.txtBoxLosobnikow.Name = "txtBoxLosobnikow";
            this.txtBoxLosobnikow.Size = new System.Drawing.Size(60, 20);
            this.txtBoxLosobnikow.TabIndex = 11;
            this.txtBoxLosobnikow.Text = "20";
            // 
            // txtBoxLiteracji
            // 
            this.txtBoxLiteracji.Location = new System.Drawing.Point(439, 114);
            this.txtBoxLiteracji.Name = "txtBoxLiteracji";
            this.txtBoxLiteracji.Size = new System.Drawing.Size(60, 20);
            this.txtBoxLiteracji.TabIndex = 12;
            this.txtBoxLiteracji.Text = "25";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(34, 183);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(41, 20);
            this.txtBoxA.TabIndex = 13;
            this.txtBoxA.Text = "1";
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(107, 183);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(41, 20);
            this.txtBoxB.TabIndex = 15;
            this.txtBoxB.Text = "1";
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(180, 183);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(41, 20);
            this.txtBoxC.TabIndex = 17;
            this.txtBoxC.Text = "-50";
            // 
            // txtBoxPocz
            // 
            this.txtBoxPocz.Location = new System.Drawing.Point(81, 37);
            this.txtBoxPocz.Name = "txtBoxPocz";
            this.txtBoxPocz.Size = new System.Drawing.Size(60, 20);
            this.txtBoxPocz.TabIndex = 18;
            this.txtBoxPocz.Text = "-8";
            // 
            // txtBoxKoniec
            // 
            this.txtBoxKoniec.Location = new System.Drawing.Point(163, 37);
            this.txtBoxKoniec.Name = "txtBoxKoniec";
            this.txtBoxKoniec.Size = new System.Drawing.Size(60, 20);
            this.txtBoxKoniec.TabIndex = 19;
            this.txtBoxKoniec.Text = "7";
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(323, 150);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(176, 53);
            this.btnOblicz.TabIndex = 20;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(15, 247);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.IsVisibleInLegend = false;
            series17.Legend = "Legend1";
            series17.Name = "f(x)";
            series17.Points.Add(dataPoint5);
            this.chart1.Series.Add(series17);
            this.chart1.Size = new System.Drawing.Size(484, 368);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "a:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "b:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "c:";
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(513, 30);
            this.chart2.Name = "chart2";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.Red;
            series18.Legend = "Legend1";
            series18.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series18.Name = "Najgorsze";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.RoyalBlue;
            series19.Legend = "Legend1";
            series19.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series19.Name = "Średnie";
            series19.YValuesPerPoint = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series20.Legend = "Legend1";
            series20.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series20.Name = "Najlepsze";
            this.chart2.Series.Add(series18);
            this.chart2.Series.Add(series19);
            this.chart2.Series.Add(series20);
            this.chart2.Size = new System.Drawing.Size(776, 585);
            this.chart2.TabIndex = 26;
            this.chart2.Text = "chart2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(706, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(271, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Przystosowanie w zależności od iteracji";
            // 
            // cmbKrzyzowanie
            // 
            this.cmbKrzyzowanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKrzyzowanie.FormattingEnabled = true;
            this.cmbKrzyzowanie.Items.AddRange(new object[] {
            "Proste",
            "OX"});
            this.cmbKrzyzowanie.Location = new System.Drawing.Point(94, 124);
            this.cmbKrzyzowanie.Name = "cmbKrzyzowanie";
            this.cmbKrzyzowanie.Size = new System.Drawing.Size(200, 21);
            this.cmbKrzyzowanie.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Krzyżowanie:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Selekcja:";
            // 
            // cmbSelekcja
            // 
            this.cmbSelekcja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelekcja.FormattingEnabled = true;
            this.cmbSelekcja.Items.AddRange(new object[] {
            "Metoda ruletki",
            "Metoda rankingowa"});
            this.cmbSelekcja.Location = new System.Drawing.Point(94, 97);
            this.cmbSelekcja.Name = "cmbSelekcja";
            this.cmbSelekcja.Size = new System.Drawing.Size(200, 21);
            this.cmbSelekcja.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(147, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = ";";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Poszukiwanie:";
            // 
            // cmbPoszukiwanie
            // 
            this.cmbPoszukiwanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoszukiwanie.FormattingEnabled = true;
            this.cmbPoszukiwanie.Items.AddRange(new object[] {
            "Maksimum funkcji",
            "Minimum funkcji"});
            this.cmbPoszukiwanie.Location = new System.Drawing.Point(94, 70);
            this.cmbPoszukiwanie.Name = "cmbPoszukiwanie";
            this.cmbPoszukiwanie.Size = new System.Drawing.Size(200, 21);
            this.cmbPoszukiwanie.TabIndex = 34;
            this.cmbPoszukiwanie.SelectedIndexChanged += new System.EventHandler(this.cmbPoszukiwanie_SelectedIndexChanged);
            // 
            // rtxtFunkcja
            // 
            this.rtxtFunkcja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtFunkcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.05F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxtFunkcja.Location = new System.Drawing.Point(12, 217);
            this.rtxtFunkcja.Multiline = false;
            this.rtxtFunkcja.Name = "rtxtFunkcja";
            this.rtxtFunkcja.ReadOnly = true;
            this.rtxtFunkcja.Size = new System.Drawing.Size(484, 28);
            this.rtxtFunkcja.TabIndex = 35;
            this.rtxtFunkcja.Text = "Wykres funkcji: ...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(229, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "d:";
            // 
            // txtBoxD
            // 
            this.txtBoxD.Location = new System.Drawing.Point(251, 183);
            this.txtBoxD.Name = "txtBoxD";
            this.txtBoxD.Size = new System.Drawing.Size(43, 20);
            this.txtBoxD.TabIndex = 37;
            this.txtBoxD.Text = "25";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 627);
            this.Controls.Add(this.txtBoxD);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.rtxtFunkcja);
            this.Controls.Add(this.cmbPoszukiwanie);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbSelekcja);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbKrzyzowanie);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.txtBoxKoniec);
            this.Controls.Add(this.txtBoxPocz);
            this.Controls.Add(this.txtBoxC);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.txtBoxLiteracji);
            this.Controls.Add(this.txtBoxLosobnikow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Name = "Form1";
            this.Text = "Projekt przejściowy - algorytmy genetyczne - Kamil Guzek";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxLosobnikow;
        private System.Windows.Forms.TextBox txtBoxLiteracji;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.TextBox txtBoxPocz;
        private System.Windows.Forms.TextBox txtBoxKoniec;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbKrzyzowanie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSelekcja;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbPoszukiwanie;
        private System.Windows.Forms.RichTextBox rtxtFunkcja;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBoxD;
    }
}

