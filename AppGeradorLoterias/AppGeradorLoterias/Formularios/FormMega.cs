using AppGeradorLoterias.RegrasNegocios;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormMega : Form
    {
        List<NumerosDaSorte> numGerados = new List<NumerosDaSorte>();
        public FormMega()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AnalisarJogo(int par, int impar)
        {
            if (impar == 3)
            {
                lbClass.Text = "Excelente Jogo!";
                lbClass.ForeColor = Color.Green;
            }
            if (impar == 2) { lbClass.Text = "Ótimo Jogo!"; lbClass.ForeColor = Color.Green; }
            if (impar == 4) { lbClass.Text = "Bom Jogo!"; lbClass.ForeColor = Color.Orange; }
            if (impar == 1) { lbClass.Text = "Jogo Regular!"; lbClass.ForeColor = Color.OrangeRed; }
            if (impar == 5) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
            if (impar == 0) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
        }

        private void btGerar_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            numGerados.Clear();
            dgvNumeros.DataSource = numGerados.ToList();
            btGerar.Enabled = true;
            lbPar.Text = "PARES";
            lbImpar.Text = "IMPARES";
            lbClass.Text = "CLASSIFIÇÃO";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook(@"C:\Users\Public\Excel\loteria.xlsx");

            var planilha = pasta.Worksheet(6);

            int qtdColunas = planilha.ColumnsUsed().Count();

            int qtdLinhas = planilha.RowsUsed().Count();

            int colunregistro = qtdColunas + 1;

            int linhas = qtdLinhas + 1;

            colunregistro = 1;

            foreach (var i in numGerados.OrderBy(ns => ns.Numero).ToList())
            {
                planilha.Cell(linhas, colunregistro).Value = i.Numero;
                colunregistro++;
            }
            planilha.Cell(linhas, colunregistro).Value = lbPar.Text.Substring(15);
            colunregistro++;
            planilha.Cell(linhas, colunregistro).Value = lbImpar.Text.Substring(17);
            colunregistro++;
            planilha.Cell(linhas, colunregistro).Value = lbClass.Text;

            pasta.Save();

            MessageBox.Show("Os dados foram salvos no Excel", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
