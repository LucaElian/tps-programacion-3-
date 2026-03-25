namespace TP1_GRUPO_6
{
    partial class Ejercicio1
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
            this.lsbPersonas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnPasarValor = new System.Windows.Forms.Button();
            this.lsbResultado = new System.Windows.Forms.ListBox();
            this.btnPasarTodo = new System.Windows.Forms.Button();
            this.tbnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbPersonas
            // 
            this.lsbPersonas.FormattingEnabled = true;
            this.lsbPersonas.Location = new System.Drawing.Point(79, 101);
            this.lsbPersonas.Name = "lsbPersonas";
            this.lsbPersonas.Size = new System.Drawing.Size(271, 277);
            this.lsbPersonas.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(649, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(235, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(382, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(76, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(153, 18);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // btnPasarValor
            // 
            this.btnPasarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarValor.Location = new System.Drawing.Point(371, 173);
            this.btnPasarValor.Name = "btnPasarValor";
            this.btnPasarValor.Size = new System.Drawing.Size(62, 45);
            this.btnPasarValor.TabIndex = 14;
            this.btnPasarValor.Text = ">";
            this.btnPasarValor.UseVisualStyleBackColor = true;
            this.btnPasarValor.Click += new System.EventHandler(this.btnPasarValor_Click);
            // 
            // lsbResultado
            // 
            this.lsbResultado.FormattingEnabled = true;
            this.lsbResultado.Location = new System.Drawing.Point(453, 101);
            this.lsbResultado.Name = "lsbResultado";
            this.lsbResultado.Size = new System.Drawing.Size(271, 277);
            this.lsbResultado.TabIndex = 15;
            // 
            // btnPasarTodo
            // 
            this.btnPasarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodo.Location = new System.Drawing.Point(371, 245);
            this.btnPasarTodo.Name = "btnPasarTodo";
            this.btnPasarTodo.Size = new System.Drawing.Size(62, 46);
            this.btnPasarTodo.TabIndex = 16;
            this.btnPasarTodo.Text = ">>";
            this.btnPasarTodo.UseVisualStyleBackColor = true;
            this.btnPasarTodo.Click += new System.EventHandler(this.btnPasarTodo_Click);
            // 
            // tbnVolver
            // 
            this.tbnVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbnVolver.Location = new System.Drawing.Point(361, 394);
            this.tbnVolver.Name = "tbnVolver";
            this.tbnVolver.Size = new System.Drawing.Size(81, 23);
            this.tbnVolver.TabIndex = 17;
            this.tbnVolver.Text = "Volver";
            this.tbnVolver.UseVisualStyleBackColor = true;
            this.tbnVolver.Click += new System.EventHandler(this.tbnVolver_Click);
            // 
            // Ejercicio1
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 433);
            this.Controls.Add(this.tbnVolver);
            this.Controls.Add(this.btnPasarTodo);
            this.Controls.Add(this.lsbResultado);
            this.Controls.Add(this.btnPasarValor);
            this.Controls.Add(this.lsbPersonas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbPersonas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnPasarValor;
        private System.Windows.Forms.ListBox lsbResultado;
        private System.Windows.Forms.Button btnPasarTodo;
        private System.Windows.Forms.Button tbnVolver;
    }
}