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

namespace aplikacijaZaBiblioteku
{
    public partial class Pregled : Form
    {
        public Pregled()
        {
            InitializeComponent();
        }

        private void btnProvjera_Click(object sender, EventArgs e)
        {
            string putX = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileX = "Korisnici.xml";
            string fileXX = "Knjige.xml";

            if (cmbOdabir.Text == "Knjiga")
            {

            }

            else
            {

            }
        }
    }
}
