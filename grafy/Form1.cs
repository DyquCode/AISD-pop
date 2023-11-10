using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_wezel_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(5);
            var w2 = new Wezel(3);
            var w3 = new Wezel(4);
            var w4 = new Wezel(1);
            var w5 = new Wezel(2);
            var w6 = new Wezel(7);

            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);

            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);

            A(w1);
        }

        void A(Wezel w)
        {
            MessageBox.Show(w.wartosc.ToString());
            A(w.dzieci.wartosc);
        }
    }
}
