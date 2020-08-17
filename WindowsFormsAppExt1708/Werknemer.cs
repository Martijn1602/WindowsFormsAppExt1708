using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppExt1708
{
    public partial class Werknemer : Form
    {

        Werknemer werknemer = new Werknemer();
        public List<Werknemer> werknemerlijst { get; set; } = new List<Werknemer>();
        public Werknemer()
        {
            InitializeComponent();
        }

        private void btnCreateEmpl_Click(object sender, EventArgs e)
        {
            string geslacht = gbGeslacht.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault().Text;
           
            Werknemer werknemer = new Werknemer(txtNaam.Text, dtGeboortedatum.Value, geslacht);
            werknemer.werknemerlijst.Add(werknemer);


        }
    }
}
