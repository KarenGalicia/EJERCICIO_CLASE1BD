namespace EJERCICIO_CLASE1BD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxraza = new System.Windows.Forms.TextBox();
            this.numericUpDownNivel_De_Poder = new System.Windows.Forms.NumericUpDown();
            this.Buscar = new System.Windows.Forms.Label();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel_De_Poder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de poder";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(51, 9);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(207, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(62, 33);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(196, 20);
            this.textBoxnombre.TabIndex = 5;
            // 
            // textBoxraza
            // 
            this.textBoxraza.Location = new System.Drawing.Point(62, 61);
            this.textBoxraza.Name = "textBoxraza";
            this.textBoxraza.Size = new System.Drawing.Size(196, 20);
            this.textBoxraza.TabIndex = 6;
            // 
            // numericUpDownNivel_De_Poder
            // 
            this.numericUpDownNivel_De_Poder.Location = new System.Drawing.Point(94, 87);
            this.numericUpDownNivel_De_Poder.Name = "numericUpDownNivel_De_Poder";
            this.numericUpDownNivel_De_Poder.Size = new System.Drawing.Size(182, 20);
            this.numericUpDownNivel_De_Poder.TabIndex = 7;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(558, 28);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(40, 13);
            this.Buscar.TabIndex = 14;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(449, 63);
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(148, 20);
            this.textBoxHistoria.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(252, 173);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(341, 84);
            this.dataGridViewPersonajes.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.numericUpDownNivel_De_Poder);
            this.Controls.Add(this.textBoxraza);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel_De_Poder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxraza;
        private System.Windows.Forms.NumericUpDown numericUpDownNivel_De_Poder;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
    }
}

