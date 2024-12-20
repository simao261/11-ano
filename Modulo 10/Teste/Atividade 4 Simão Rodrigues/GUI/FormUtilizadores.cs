﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca.GUI
{
    public partial class FormUtilizadores : Form
    {
        public FormUtilizadores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void ListaUtilizadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormUtilizadores_Load(object sender, EventArgs e)
        {
            this.Text = "Utilizadores";
            this.CancelButton = BotaoFechar;

            this.MinimumSize = new Size(816, 384);
            this.SizeGripStyle = SizeGripStyle.Show;
            ListaUtilizadores.View = View.Details;
            ListaUtilizadores.FullRowSelect = true;
            // Acrescentar as colunas à lista de utilizadores
            ListaUtilizadores.Columns.Add("Ativo", 50, HorizontalAlignment.Center);
            ListaUtilizadores.Columns.Add("ID", 240, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Username", 150, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Nome", 160, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Email", -2, HorizontalAlignment.Left);
            

            
           
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            FormUtilizador frmUtilizador = new FormUtilizador();
            frmUtilizador.ShowDialog();
            frmUtilizador.Dispose();
        }

        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            FormUtilizador frmUtilizador = new FormUtilizador();
            frmUtilizador.ShowDialog();
            frmUtilizador.Dispose();
        }
    }
}
