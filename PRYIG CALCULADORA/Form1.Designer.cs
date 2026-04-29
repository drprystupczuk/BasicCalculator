namespace BasicCalculator
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoFinal = new System.Windows.Forms.Label();
            this.cgrOperaciones = new System.Windows.Forms.GroupBox();
            this.cmdMenos = new System.Windows.Forms.Button();
            this.cmdDividir = new System.Windows.Forms.Button();
            this.cmdMultiplicar = new System.Windows.Forms.Button();
            this.cmdMás = new System.Windows.Forms.Button();
            this.cgrOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(46, 25);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(46, 52);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(40, 13);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(94, 25);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(75, 20);
            this.txtV1.TabIndex = 2;
            this.txtV1.TextChanged += new System.EventHandler(this.txtV1_TextChanged);
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(94, 49);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(75, 20);
            this.txtV2.TabIndex = 3;
            this.txtV2.TextChanged += new System.EventHandler(this.txtV2_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(63, 97);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblResultadoFinal
            // 
            this.lblResultadoFinal.AutoSize = true;
            this.lblResultadoFinal.Location = new System.Drawing.Point(125, 97);
            this.lblResultadoFinal.Name = "lblResultadoFinal";
            this.lblResultadoFinal.Size = new System.Drawing.Size(21, 13);
            this.lblResultadoFinal.TabIndex = 5;
            this.lblResultadoFinal.Text = "XX";
            // 
            // cgrOperaciones
            // 
            this.cgrOperaciones.Controls.Add(this.cmdMenos);
            this.cgrOperaciones.Controls.Add(this.cmdDividir);
            this.cgrOperaciones.Controls.Add(this.cmdMultiplicar);
            this.cgrOperaciones.Controls.Add(this.cmdMás);
            this.cgrOperaciones.Location = new System.Drawing.Point(18, 152);
            this.cgrOperaciones.Name = "cgrOperaciones";
            this.cgrOperaciones.Size = new System.Drawing.Size(185, 155);
            this.cgrOperaciones.TabIndex = 6;
            this.cgrOperaciones.TabStop = false;
            this.cgrOperaciones.Text = "OPERACIONES";
            // 
            // cmdMenos
            // 
            this.cmdMenos.Location = new System.Drawing.Point(117, 30);
            this.cmdMenos.Name = "cmdMenos";
            this.cmdMenos.Size = new System.Drawing.Size(62, 27);
            this.cmdMenos.TabIndex = 3;
            this.cmdMenos.Text = "-";
            this.cmdMenos.UseVisualStyleBackColor = true;
            this.cmdMenos.Click += new System.EventHandler(this.cmdMenos_Click);
            // 
            // cmdDividir
            // 
            this.cmdDividir.Location = new System.Drawing.Point(117, 91);
            this.cmdDividir.Name = "cmdDividir";
            this.cmdDividir.Size = new System.Drawing.Size(62, 27);
            this.cmdDividir.TabIndex = 2;
            this.cmdDividir.Text = "/";
            this.cmdDividir.UseVisualStyleBackColor = true;
            this.cmdDividir.Click += new System.EventHandler(this.cmdDividir_Click);
            // 
            // cmdMultiplicar
            // 
            this.cmdMultiplicar.Location = new System.Drawing.Point(6, 91);
            this.cmdMultiplicar.Name = "cmdMultiplicar";
            this.cmdMultiplicar.Size = new System.Drawing.Size(62, 27);
            this.cmdMultiplicar.TabIndex = 1;
            this.cmdMultiplicar.Text = "*";
            this.cmdMultiplicar.UseVisualStyleBackColor = true;
            this.cmdMultiplicar.Click += new System.EventHandler(this.cmdMultiplicar_Click);
            // 
            // cmdMás
            // 
            this.cmdMás.Location = new System.Drawing.Point(6, 30);
            this.cmdMás.Name = "cmdMás";
            this.cmdMás.Size = new System.Drawing.Size(62, 27);
            this.cmdMás.TabIndex = 0;
            this.cmdMás.Text = "+";
            this.cmdMás.UseVisualStyleBackColor = true;
            this.cmdMás.Click += new System.EventHandler(this.cmdMás_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 337);
            this.Controls.Add(this.cgrOperaciones);
            this.Controls.Add(this.lblResultadoFinal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cgrOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoFinal;
        private System.Windows.Forms.GroupBox cgrOperaciones;
        private System.Windows.Forms.Button cmdMenos;
        private System.Windows.Forms.Button cmdDividir;
        private System.Windows.Forms.Button cmdMultiplicar;
        private System.Windows.Forms.Button cmdMás;
    }
}

