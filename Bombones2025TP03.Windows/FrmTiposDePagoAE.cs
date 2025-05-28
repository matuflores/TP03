using Bombones2025TP03.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025TP03.Windows
{
    public partial class FrmTiposDePagoAE : Form
    {
        private TipoDePago? tipoDePago;
        public FrmTiposDePagoAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDePago is not null)
            {
                textBoxTipoDePago.Text = tipoDePago.Descripcion;
            }
        }

        public TipoDePago? GetTipoDePago()
        {
            return tipoDePago;
        }

        public void SetTipoDePago(TipoDePago tipoPago)
        {
            this.tipoDePago = tipoPago;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDePago == null)
                {
                    tipoDePago = new TipoDePago();
                }
                tipoDePago.Descripcion = textBoxTipoDePago.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProviderTipoPagoAE.Clear();
            if (string.IsNullOrEmpty(textBoxTipoDePago.Text))
            {
                valido = false;
                errorProviderTipoPagoAE.SetError(textBoxTipoDePago, "Tipo de Pago requerido");
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
