using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetInterne
{
    public partial class ChoixNombreRouter : Form
    {
        public ChoixNombreRouter()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
            Form1.NombreDeRouter = Convert.ToInt32(NombreRouterBox.Value);
            ChoixDesLiaisons liaisons = new ChoixDesLiaisons();
            liaisons.ShowDialog();
        }

        private void NbRouterClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
