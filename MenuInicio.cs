using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topicosProyecto
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            FormViajes forma = new FormViajes();
            forma.Show();
        }

        private void btnViajeros_Click(object sender, EventArgs e)
        {
            FormViajeros formViajeros = new FormViajeros();
            formViajeros.Show();
        }
    }
}
