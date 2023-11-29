using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGeradorLoterias.Formularios; 

namespace AppGeradorLoterias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLotoFacil_Click(object sender, EventArgs e)
        {
            FormLotoFacil form = new FormLotoFacil();
            form.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLotoMania form = new FormLotoMania();
            form.ShowDialog();
        }

        private void btMega_Click(object sender, EventArgs e)
        {
            FormMega form = new FormMega();
            form.ShowDialog();
        }

        private void btQuina_Click(object sender, EventArgs e)
        {
            FormQuina form = new FormQuina();
            form.ShowDialog();
        }

        private void btDiaSorte_Click(object sender, EventArgs e)
        {
            FormDiadeSorte form = new FormDiadeSorte();
            form.ShowDialog();
        }

        private void btSuperSete_Click(object sender, EventArgs e)
        {
            FormSuperSete form = new FormSuperSete();
            form.ShowDialog();
        }
    }
}
