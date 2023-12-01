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
            int contador = 0, qtdPar = 0, qtdImpar = 0, temporario = 0;
            Random randomico = new Random(); //gerar numeros aleatorios

            while (contador < 6)
            {
                temporario = randomico.Next(1, 61);

                if (numGerados.Where(n => n.Numero == temporario).Count() == 0)
                {
                    NumerosDaSorte numeroSorteado = new NumerosDaSorte();
                    numeroSorteado.Numero = temporario;
                    numGerados.Add(numeroSorteado);
                    if (temporario % 2 == 0) qtdPar++;
                    if (temporario % 2 == 1) qtdImpar++;
                    contador++;
                }
                dgvNumeros.DataSource = numGerados.OrderBy(ns => ns.Numero).ToList();
                btGerar.Enabled = false;
                lbPar.Text = "Números Pares: " + qtdPar;
                lbImpar.Text = "Números Ímpares: " + qtdImpar;
                AnalisarJogo(qtdPar, qtdImpar);
            }

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

            var planilha = pasta.Worksheet(5);

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

        /*private void btSalvar_Click(object sender, EventArgs e)
        {
            btGerar.Click += Veri;
            btGerar15.Click += Veri;
        }

        public void Veri(object sender, EventArgs e)
        {
            if (sender == btGerar)
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
            else if (sender == btGerar15)
            {
                var pasta = new XLWorkbook(@"C:\Users\Public\Excel\loteria.xlsx");

                var planilha = pasta.Worksheet(5);

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
        }*/

        private void btGerar15_Click(object sender, EventArgs e)
        {
            int contador = 0, qtdPar = 0, qtdImpar = 0, temporario = 0;
            Random randomico = new Random(); //gerar numeros aleatorios

            while (contador < 15)
            {
                temporario = randomico.Next(1, 61);

                if (numGerados.Where(n => n.Numero == temporario).Count() == 0)
                {
                    NumerosDaSorte numeroSorteado = new NumerosDaSorte();
                    numeroSorteado.Numero = temporario;
                    numGerados.Add(numeroSorteado);
                    if (temporario % 2 == 0) qtdPar++;
                    if (temporario % 2 == 1) qtdImpar++;
                    contador++;
                }
                dgvNumeros.DataSource = numGerados.OrderBy(ns => ns.Numero).ToList();
                btGerar.Enabled = false;
                lbPar.Text = "Números Pares: " + qtdPar;
                lbImpar.Text = "Números Ímpares: " + qtdImpar;
                AnalisarJogo(qtdPar, qtdImpar);
            }
        }
    }
}
