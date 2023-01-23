using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace aplikacijaZaBiblioteku
{
    public partial class UnosKnjiga : Form
    {
        public UnosKnjiga()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            var s = XDocument.Load(Environment.SpecialFolder.MyDocuments + "Biblioteka.xml");
            s.Element("Korisnik").Add(new XElement("Knjiga"));
            this.Close();
        }
    }
}
