namespace Bombones2025TP03.Windows
{
    partial class FrmTiposDePagoAE
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
            labelTipoDePago = new Label();
            textBoxTipoDePago = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // labelTipoDePago
            // 
            labelTipoDePago.AutoSize = true;
            labelTipoDePago.Location = new Point(82, 37);
            labelTipoDePago.Name = "labelTipoDePago";
            labelTipoDePago.Size = new Size(80, 15);
            labelTipoDePago.TabIndex = 0;
            labelTipoDePago.Text = "Tipo de Pago:";
            // 
            // textBoxTipoDePago
            // 
            textBoxTipoDePago.Location = new Point(193, 34);
            textBoxTipoDePago.Name = "textBoxTipoDePago";
            textBoxTipoDePago.Size = new Size(256, 23);
            textBoxTipoDePago.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Image = Properties.Resources.OK40;
            btnOk.Location = new Point(82, 78);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(80, 66);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = Properties.Resources.CANCEL40;
            btnCancelar.Location = new Point(369, 78);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 66);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmTiposDePagoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 156);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(textBoxTipoDePago);
            Controls.Add(labelTipoDePago);
            Name = "FrmTiposDePagoAE";
            Text = "FrmTiposDePagoAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTipoDePago;
        private TextBox textBoxTipoDePago;
        private Button btnOk;
        private Button btnCancelar;
    }
}