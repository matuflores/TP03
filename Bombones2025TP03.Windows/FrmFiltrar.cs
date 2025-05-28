using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025TP03.Windows
{
    public partial class FrmFiltrar : Form
    {
        private string? textoFiltro;
        public FrmFiltrar()
        {
            InitializeComponent();
        }

        public string? GetTexto()
        {
            return textoFiltro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                textoFiltro=textBoxAFiltrar.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProviderFiltro.Clear();
            if (string.IsNullOrEmpty(textBoxAFiltrar.Text.Trim()))
            {
                valido = false;
                errorProviderFiltro.SetError(textBoxAFiltrar, "Debe ingresar un texto a filtrar");
            }
            return valido;
        }
    }
}
