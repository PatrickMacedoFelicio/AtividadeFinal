﻿namespace AppGeradorLoterias.Formularios
{
    partial class FormMega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbImpar = new System.Windows.Forms.Label();
            this.lbPar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NÚMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            this.btGerar15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.Black;
            this.btVoltar.Location = new System.Drawing.Point(12, 416);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(88, 22);
            this.btVoltar.TabIndex = 59;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.Green;
            this.btSalvar.Location = new System.Drawing.Point(35, 348);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(200, 30);
            this.btSalvar.TabIndex = 68;
            this.btSalvar.Text = "Salvar em Excel";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbClass
            // 
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.ForeColor = System.Drawing.Color.Green;
            this.lbClass.Location = new System.Drawing.Point(91, 258);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(162, 24);
            this.lbClass.TabIndex = 67;
            this.lbClass.Text = "CLASSIFICAÇÃO";
            // 
            // lbImpar
            // 
            this.lbImpar.AutoSize = true;
            this.lbImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpar.ForeColor = System.Drawing.Color.Green;
            this.lbImpar.Location = new System.Drawing.Point(91, 200);
            this.lbImpar.Name = "lbImpar";
            this.lbImpar.Size = new System.Drawing.Size(89, 20);
            this.lbImpar.TabIndex = 66;
            this.lbImpar.Text = "ÍMPARES";
            // 
            // lbPar
            // 
            this.lbPar.AutoSize = true;
            this.lbPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPar.ForeColor = System.Drawing.Color.Green;
            this.lbPar.Location = new System.Drawing.Point(91, 158);
            this.lbPar.Name = "lbPar";
            this.lbPar.Size = new System.Drawing.Size(69, 20);
            this.lbPar.TabIndex = 65;
            this.lbPar.Text = "PARES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(164, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "MEGA SENA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "NÚMEROS DA SORTE";
            // 
            // dgvNumeros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            this.dgvNumeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORD,
            this.NÚMERO});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNumeros.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNumeros.Location = new System.Drawing.Point(284, 53);
            this.dgvNumeros.Name = "dgvNumeros";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNumeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNumeros.RowHeadersWidth = 51;
            this.dgvNumeros.Size = new System.Drawing.Size(163, 375);
            this.dgvNumeros.TabIndex = 62;
            // 
            // ORD
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ORD.DefaultCellStyle = dataGridViewCellStyle3;
            this.ORD.HeaderText = "ORD";
            this.ORD.MinimumWidth = 6;
            this.ORD.Name = "ORD";
            this.ORD.Visible = false;
            this.ORD.Width = 125;
            // 
            // NÚMERO
            // 
            this.NÚMERO.DataPropertyName = "Numero";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NÚMERO.DefaultCellStyle = dataGridViewCellStyle4;
            this.NÚMERO.HeaderText = "NÚMERO";
            this.NÚMERO.MinimumWidth = 6;
            this.NÚMERO.Name = "NÚMERO";
            this.NÚMERO.Width = 125;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(35, 107);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(200, 23);
            this.btLimpar.TabIndex = 61;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(35, 49);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(200, 23);
            this.btGerar.TabIndex = 60;
            this.btGerar.Text = "GERAR 6 NÚMEROS ";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // btGerar15
            // 
            this.btGerar15.Location = new System.Drawing.Point(35, 78);
            this.btGerar15.Name = "btGerar15";
            this.btGerar15.Size = new System.Drawing.Size(200, 23);
            this.btGerar15.TabIndex = 69;
            this.btGerar15.Text = "GERAR ATÉ 15 NÚMEROS";
            this.btGerar15.UseVisualStyleBackColor = true;
            this.btGerar15.Click += new System.EventHandler(this.btGerar15_Click);
            // 
            // FormMega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.btGerar15);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbImpar);
            this.Controls.Add(this.lbPar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvNumeros);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.btVoltar);
            this.Name = "FormMega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMega";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbImpar;
        private System.Windows.Forms.Label lbPar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NÚMERO;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Button btGerar15;
    }
}