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
    public partial class FormViajes : Form
    {
        public FormViajes()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaOrigen forma = new FormaOrigen();
            forma.Show();
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            FormaDestino forma = new FormaDestino();
            forma.Show();
        }
    }
}
