namespace CalificadorNotas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_examen = new System.Windows.Forms.TextBox();
            this.txtbox_plataforma = new System.Windows.Forms.TextBox();
            this.txtbox_actVal = new System.Windows.Forms.TextBox();
            this.txtbox_trabFinal = new System.Windows.Forms.TextBox();
            this.btn_nota = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.output_nota = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.output_estado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.output_literal = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plataforma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actitudes y Valores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trabajo Final";
            // 
            // txtbox_examen
            // 
            this.txtbox_examen.Location = new System.Drawing.Point(178, 44);
            this.txtbox_examen.Name = "txtbox_examen";
            this.txtbox_examen.Size = new System.Drawing.Size(104, 20);
            this.txtbox_examen.TabIndex = 4;
            // 
            // txtbox_plataforma
            // 
            this.txtbox_plataforma.Location = new System.Drawing.Point(178, 95);
            this.txtbox_plataforma.Name = "txtbox_plataforma";
            this.txtbox_plataforma.Size = new System.Drawing.Size(104, 20);
            this.txtbox_plataforma.TabIndex = 5;
            // 
            // txtbox_actVal
            // 
            this.txtbox_actVal.Location = new System.Drawing.Point(178, 145);
            this.txtbox_actVal.Name = "txtbox_actVal";
            this.txtbox_actVal.Size = new System.Drawing.Size(104, 20);
            this.txtbox_actVal.TabIndex = 6;
            // 
            // txtbox_trabFinal
            // 
            this.txtbox_trabFinal.Location = new System.Drawing.Point(178, 196);
            this.txtbox_trabFinal.Name = "txtbox_trabFinal";
            this.txtbox_trabFinal.Size = new System.Drawing.Size(104, 20);
            this.txtbox_trabFinal.TabIndex = 7;
            // 
            // btn_nota
            // 
            this.btn_nota.Location = new System.Drawing.Point(168, 244);
            this.btn_nota.Name = "btn_nota";
            this.btn_nota.Size = new System.Drawing.Size(114, 23);
            this.btn_nota.TabIndex = 8;
            this.btn_nota.Text = "Calcular Nota";
            this.btn_nota.UseVisualStyleBackColor = true;
            this.btn_nota.Click += new System.EventHandler(this.btn_nota_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.output_nota);
            this.panel1.Location = new System.Drawing.Point(300, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 71);
            this.panel1.TabIndex = 9;
            // 
            // output_nota
            // 
            this.output_nota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_nota.Location = new System.Drawing.Point(0, 0);
            this.output_nota.Name = "output_nota";
            this.output_nota.Size = new System.Drawing.Size(200, 71);
            this.output_nota.TabIndex = 0;
            this.output_nota.Text = "NOTA";
            this.output_nota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.output_estado);
            this.panel2.Location = new System.Drawing.Point(300, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 71);
            this.panel2.TabIndex = 10;
            // 
            // output_estado
            // 
            this.output_estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_estado.Location = new System.Drawing.Point(0, 0);
            this.output_estado.Name = "output_estado";
            this.output_estado.Size = new System.Drawing.Size(200, 71);
            this.output_estado.TabIndex = 1;
            this.output_estado.Text = "ESTADO";
            this.output_estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.output_literal);
            this.panel3.Location = new System.Drawing.Point(300, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 71);
            this.panel3.TabIndex = 11;
            // 
            // output_literal
            // 
            this.output_literal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_literal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_literal.Location = new System.Drawing.Point(0, 0);
            this.output_literal.Name = "output_literal";
            this.output_literal.Size = new System.Drawing.Size(200, 71);
            this.output_literal.TabIndex = 2;
            this.output_literal.Text = "LITERAL";
            this.output_literal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(52, 244);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(114, 23);
            this.btn_Limpiar.TabIndex = 12;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 330);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_nota);
            this.Controls.Add(this.txtbox_trabFinal);
            this.Controls.Add(this.txtbox_actVal);
            this.Controls.Add(this.txtbox_plataforma);
            this.Controls.Add(this.txtbox_examen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calcular Nota";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_examen;
        private System.Windows.Forms.TextBox txtbox_plataforma;
        private System.Windows.Forms.TextBox txtbox_actVal;
        private System.Windows.Forms.TextBox txtbox_trabFinal;
        private System.Windows.Forms.Button btn_nota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label output_nota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label output_estado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label output_literal;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}

