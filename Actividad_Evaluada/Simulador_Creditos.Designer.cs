
namespace Actividad_Evaluada
{
    partial class Simulador_Creditos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMontoS = new System.Windows.Forms.TextBox();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            this.txtVCuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Créditos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto a solicitar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de cuotas:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(174, 186);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(223, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // txtMontoS
            // 
            this.txtMontoS.Location = new System.Drawing.Point(236, 226);
            this.txtMontoS.Name = "txtMontoS";
            this.txtMontoS.Size = new System.Drawing.Size(161, 22);
            this.txtMontoS.TabIndex = 7;
            this.txtMontoS.TextChanged += new System.EventHandler(this.txtMontoS_TextChanged);
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(254, 277);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(143, 22);
            this.txtCuotas.TabIndex = 8;
            this.txtCuotas.TextChanged += new System.EventHandler(this.txtCuotas_TextChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(174, 377);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(140, 27);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar Simulación";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor cuota:";
            // 
            // txtMontoT
            // 
            this.txtMontoT.Location = new System.Drawing.Point(200, 441);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.Size = new System.Drawing.Size(166, 22);
            this.txtMontoT.TabIndex = 12;
            this.txtMontoT.TextChanged += new System.EventHandler(this.txtMontoT_TextChanged);
            // 
            // txtVCuota
            // 
            this.txtVCuota.Location = new System.Drawing.Point(199, 490);
            this.txtVCuota.Name = "txtVCuota";
            this.txtVCuota.Size = new System.Drawing.Size(167, 22);
            this.txtVCuota.TabIndex = 13;
            this.txtVCuota.TextChanged += new System.EventHandler(this.txtVCuota_TextChanged);
            // 
            // Simulador_Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 615);
            this.Controls.Add(this.txtVCuota);
            this.Controls.Add(this.txtMontoT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.txtMontoS);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Simulador_Creditos";
            this.Text = "Simulador de Creditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMontoS;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontoT;
        private System.Windows.Forms.TextBox txtVCuota;
    }
}

