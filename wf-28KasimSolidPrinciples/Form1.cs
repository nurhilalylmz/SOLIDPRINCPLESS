using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_28KasimSolidPrinciples.SRP;

namespace wf_28KasimSolidPrinciples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var spp = new Sepet();
            spp.Sepettekiler = new List<SiparisItem>();
            Siparis s = new Siparis();
            s.SiparisVer(spp, new Musteri());
        }
    }
}
