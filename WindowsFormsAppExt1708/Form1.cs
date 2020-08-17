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
    public partial class Form1 : Form
    {
        Pretpark pretpark = new Pretpark();
        Werknemer werknemer = new Werknemer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Attractie attractie = new Attractie("5e middelbaar", "Informatica");
            pretpark.attractielijst.Add(attractie);
            attractie = new Attractie("6e middelbaar", "Boekhouden");
            pretpark.attractielijst.Add(attractie);

           
        }

        private void buttonWNAdd_Click(object sender, EventArgs e)
        {
            Werknemer werknemer = new Werknemer();
            werknemer.Show();
        }
    }
}
