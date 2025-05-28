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
            components = new System.ComponentModel.Container();
            btnOk = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            textBoxAFiltrar = new TextBox();
            errorProviderFiltro = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderFiltro).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.OK40;
            btnOk.Location = new Point(104, 69);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 65);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.OK40;
            btnCancelar.Location = new Point(355, 69);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 65);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese texto a filtrar:";
            // 
            // textBoxAFiltrar
            // 
            textBoxAFiltrar.Location = new Point(193, 24);
            textBoxAFiltrar.Name = "textBoxAFiltrar";
            textBoxAFiltrar.Size = new Size(237, 23);
            textBoxAFiltrar.TabIndex = 3;
            // 
            // errorProviderFiltro
            // 
            errorProviderFiltro.ContainerControl = this;
            // 
            // FrmFiltrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 156);
            Controls.Add(textBoxAFiltrar);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Name = "FrmFiltrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFiltrar";
            ((System.ComponentModel.ISupportInitialize)errorProviderFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancelar;
        private Label label1;
        private TextBox textBoxAFiltrar;
        private ErrorProvider errorProviderFiltro;
    }
}