namespace Bombones2025TP03.Windows
{
    partial class FrmFiltrar
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
            btnCancelar = new Button();
            btnOk = new Button();
            textBoxAFiltrar = new TextBox();
            labelFiltro = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = Properties.Resources.CANCEL40;
            btnCancelar.Location = new Point(369, 67);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 66);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Image = Properties.Resources.OK40;
            btnOk.Location = new Point(82, 67);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(80, 66);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += this.btnOk_Click;
            // 
            // textBoxAFiltrar
            // 
            textBoxAFiltrar.Location = new Point(207, 23);
            textBoxAFiltrar.Name = "textBoxAFiltrar";
            textBoxAFiltrar.Size = new Size(242, 23);
            textBoxAFiltrar.TabIndex = 5;
            textBoxAFiltrar.TextChanged += this.textBoxTipoDePago_TextChanged;
            // 
            // labelFiltro
            // 
            labelFiltro.AutoSize = true;
            labelFiltro.Location = new Point(82, 26);
            labelFiltro.Name = "labelFiltro";
            labelFiltro.Size = new Size(119, 15);
            labelFiltro.TabIndex = 4;
            labelFiltro.Text = "Ingrese texto a Filtrar:";
            labelFiltro.Click += this.labelTipoDePago_Click;
            // 
            // FrmFiltrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 156);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(textBoxAFiltrar);
            Controls.Add(labelFiltro);
            Name = "FrmFiltrar";
            Text = "FrmFiltrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOk;
        private TextBox textBoxAFiltrar;
        private Label labelFiltro;
    }
}