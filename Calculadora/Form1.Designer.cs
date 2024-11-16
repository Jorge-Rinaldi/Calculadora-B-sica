namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_Numerador = new System.Windows.Forms.TextBox();
            this.lbl_Denominador = new System.Windows.Forms.Label();
            this.txt_Denominador = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.btn_Sumar = new System.Windows.Forms.Button();
            this.btn_Restar = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(105, 84);
            this.lbl_Numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(72, 13);
            this.lbl_Numero.TabIndex = 0;
            this.lbl_Numero.Text = "Numerador:";
            // 
            // txt_Numerador
            // 
            this.txt_Numerador.Location = new System.Drawing.Point(225, 81);
            this.txt_Numerador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Numerador.Name = "txt_Numerador";
            this.txt_Numerador.Size = new System.Drawing.Size(116, 20);
            this.txt_Numerador.TabIndex = 0;
            this.txt_Numerador.Text = "0";
            // 
            // lbl_Denominador
            // 
            this.lbl_Denominador.AutoSize = true;
            this.lbl_Denominador.Location = new System.Drawing.Point(105, 115);
            this.lbl_Denominador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Denominador.Name = "lbl_Denominador";
            this.lbl_Denominador.Size = new System.Drawing.Size(85, 13);
            this.lbl_Denominador.TabIndex = 3;
            this.lbl_Denominador.Text = "Denominador:";
            // 
            // txt_Denominador
            // 
            this.txt_Denominador.Location = new System.Drawing.Point(225, 112);
            this.txt_Denominador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Denominador.Name = "txt_Denominador";
            this.txt_Denominador.Size = new System.Drawing.Size(116, 20);
            this.txt_Denominador.TabIndex = 1;
            this.txt_Denominador.Text = "0";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(105, 171);
            this.lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(68, 13);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "Resultado:";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(225, 168);
            this.txt_Resultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(116, 20);
            this.txt_Resultado.TabIndex = 6;
            // 
            // btn_Sumar
            // 
            this.btn_Sumar.Location = new System.Drawing.Point(386, 79);
            this.btn_Sumar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sumar.Name = "btn_Sumar";
            this.btn_Sumar.Size = new System.Drawing.Size(88, 23);
            this.btn_Sumar.TabIndex = 2;
            this.btn_Sumar.Text = "Sumar";
            this.btn_Sumar.UseVisualStyleBackColor = true;
            this.btn_Sumar.Click += new System.EventHandler(this.btn_Sumar_Click);
            // 
            // btn_Restar
            // 
            this.btn_Restar.Location = new System.Drawing.Point(386, 110);
            this.btn_Restar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Restar.Name = "btn_Restar";
            this.btn_Restar.Size = new System.Drawing.Size(88, 23);
            this.btn_Restar.TabIndex = 3;
            this.btn_Restar.Text = "Restar";
            this.btn_Restar.UseVisualStyleBackColor = true;
            this.btn_Restar.Click += new System.EventHandler(this.btn_Restar_Click);
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.Location = new System.Drawing.Point(386, 139);
            this.btn_Multiplicar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(88, 23);
            this.btn_Multiplicar.TabIndex = 4;
            this.btn_Multiplicar.Text = "Multiplicar";
            this.btn_Multiplicar.UseVisualStyleBackColor = true;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Location = new System.Drawing.Point(386, 168);
            this.btn_Dividir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(88, 23);
            this.btn_Dividir.TabIndex = 5;
            this.btn_Dividir.Text = "Dividir";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 289);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_Restar);
            this.Controls.Add(this.btn_Sumar);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Denominador);
            this.Controls.Add(this.lbl_Denominador);
            this.Controls.Add(this.txt_Numerador);
            this.Controls.Add(this.lbl_Numero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_Numerador;
        private System.Windows.Forms.Label lbl_Denominador;
        private System.Windows.Forms.TextBox txt_Denominador;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn_Sumar;
        private System.Windows.Forms.Button btn_Restar;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.Button btn_Dividir;
    }
}

