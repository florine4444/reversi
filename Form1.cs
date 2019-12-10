using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi
{
    public partial class Form1 : Form
    {
        float groottevakje, startcirkel1, startcirkel2, startcirkel3, startcirkel4;
        int t;
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(715, 900);
            this.panel1.Paint += this.panel1_Paint;
            panel1.ClientSize = new Size(400, 400);
        }
        private void panel1_Paint(object sender, PaintEventArgs pea)
        {
            Graphics gr = pea.Graphics;
            for (t = 0; t <= 7; t++)
            {
                groottevakje = panel1.Width / 6;
                //verticale lijnen
                gr.DrawLine(Pens.Black, (groottevakje * t), 0, (groottevakje * t), (panel1.Height - 4));
                //horizontale lijnen
                //-4 omdat de lijn anders net te lang is om een of andere reden
                gr.DrawLine(Pens.Black, 0, (groottevakje * t), (panel1.Width - 4), (groottevakje * t));
            }
            gr.FillEllipse(Brushes.Blue, groottevakje * 2, groottevakje * 2, groottevakje, groottevakje);
            gr.FillEllipse(Brushes.Red, groottevakje * 3, groottevakje * 2, groottevakje, groottevakje);
            gr.FillEllipse(Brushes.Red, groottevakje * 2, groottevakje * 3, groottevakje, groottevakje);
            gr.FillEllipse(Brushes.Blue, groottevakje * 3, groottevakje * 3, groottevakje, groottevakje);
            startcirkel1 = gr.FillEllipse(Brushes.Blue, groottevakje * 2, groottevakje * 2, groottevakje, groottevakje);
        }
        }
}
