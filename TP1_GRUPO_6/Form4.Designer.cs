namespace TP1_GRUPO_6
{
    partial class Ejercicio3
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
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.gpbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.cListBoxOficios = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            this.gpbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Controls.Add(this.rdbFemenino);
            this.gpbSexo.Location = new System.Drawing.Point(52, 42);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(135, 100);
            this.gpbSexo.TabIndex = 0;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(17, 67);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(86, 20);
            this.rdbMasculino.TabIndex = 1;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Checked = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.Location = new System.Drawing.Point(17, 31);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(85, 20);
            this.rdbFemenino.TabIndex = 0;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // gpbEstadoCivil
            // 
            this.gpbEstadoCivil.Controls.Add(this.rdbSoltero);
            this.gpbEstadoCivil.Controls.Add(this.rdbCasado);
            this.gpbEstadoCivil.Location = new System.Drawing.Point(308, 42);
            this.gpbEstadoCivil.Name = "gpbEstadoCivil";
            this.gpbEstadoCivil.Size = new System.Drawing.Size(139, 100);
            this.gpbEstadoCivil.TabIndex = 1;
            this.gpbEstadoCivil.TabStop = false;
            this.gpbEstadoCivil.Text = "Estado Civil";
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSoltero.Location = new System.Drawing.Point(15, 67);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(68, 20);
            this.rdbSoltero.TabIndex = 1;
            this.rdbSoltero.Text = "Soltero";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Checked = true;
            this.rdbCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCasado.Location = new System.Drawing.Point(15, 31);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(73, 20);
            this.rdbCasado.TabIndex = 0;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // cListBoxOficios
            // 
            this.cListBoxOficios.FormattingEnabled = true;
            this.cListBoxOficios.Items.AddRange(new object[] {
            "Data Enty",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.cListBoxOficios.Location = new System.Drawing.Point(165, 161);
            this.cListBoxOficios.Name = "cListBoxOficios";
            this.cListBoxOficios.Size = new System.Drawing.Size(169, 94);
            this.cListBoxOficios.TabIndex = 3;
            this.cListBoxOficios.UseCompatibleTextRendering = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(174, 272);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(150, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 442);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cListBoxOficios);
            this.Controls.Add(this.gpbEstadoCivil);
            this.Controls.Add(this.gpbSexo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbEstadoCivil.ResumeLayout(false);
            this.gpbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.GroupBox gpbEstadoCivil;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.CheckedListBox cListBoxOficios;
        private System.Windows.Forms.Button btnMostrar;
    }
}