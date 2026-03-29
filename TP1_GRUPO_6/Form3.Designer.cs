namespace TP1_GRUPO_6
{
    partial class Ejercicio2
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
            this.gpbNyA = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbElementos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lsbElementos = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpbNyA.SuspendLayout();
            this.gpbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNyA
            // 
            this.gpbNyA.Controls.Add(this.btnAgregar);
            this.gpbNyA.Controls.Add(this.txtApellido);
            this.gpbNyA.Controls.Add(this.txtNombre);
            this.gpbNyA.Controls.Add(this.lblApellido);
            this.gpbNyA.Controls.Add(this.lblNombre);
            this.gpbNyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNyA.Location = new System.Drawing.Point(37, 26);
            this.gpbNyA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNyA.Name = "gpbNyA";
            this.gpbNyA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNyA.Size = new System.Drawing.Size(389, 588);
            this.gpbNyA.TabIndex = 0;
            this.gpbNyA.TabStop = false;
            this.gpbNyA.Text = "Ingreso de datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(104, 315);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 59);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(147, 231);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 26);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 185);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(8, 231);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(120, 29);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(8, 180);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gpbElementos
            // 
            this.gpbElementos.Controls.Add(this.btnBorrar);
            this.gpbElementos.Controls.Add(this.lsbElementos);
            this.gpbElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbElementos.Location = new System.Drawing.Point(435, 26);
            this.gpbElementos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbElementos.Name = "gpbElementos";
            this.gpbElementos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbElementos.Size = new System.Drawing.Size(389, 588);
            this.gpbElementos.TabIndex = 1;
            this.gpbElementos.TabStop = false;
            this.gpbElementos.Text = "Elementos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(152, 532);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lsbElementos
            // 
            this.lsbElementos.FormattingEnabled = true;
            this.lsbElementos.ItemHeight = 20;
            this.lsbElementos.Location = new System.Drawing.Point(27, 23);
            this.lsbElementos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbElementos.Name = "lsbElementos";
            this.lsbElementos.Size = new System.Drawing.Size(336, 444);
            this.lsbElementos.Sorted = true;
            this.lsbElementos.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(369, 638);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(123, 28);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Ejercicio2
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 681);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpbElementos);
            this.Controls.Add(this.gpbNyA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio2_FormClosed);
            this.gpbNyA.ResumeLayout(false);
            this.gpbNyA.PerformLayout();
            this.gpbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNyA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gpbElementos;
        private System.Windows.Forms.ListBox lsbElementos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVolver;
    }
}