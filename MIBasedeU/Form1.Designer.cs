namespace MIBasedeU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSaludar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textcarnet = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.buttoncrear = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.btnseccion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaludar
            // 
            this.buttonSaludar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSaludar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaludar.Location = new System.Drawing.Point(2, 367);
            this.buttonSaludar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaludar.Name = "buttonSaludar";
            this.buttonSaludar.Size = new System.Drawing.Size(106, 41);
            this.buttonSaludar.TabIndex = 0;
            this.buttonSaludar.Text = "Tareas";
            this.buttonSaludar.UseVisualStyleBackColor = false;
            this.buttonSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "seccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "correo";
            // 
            // textcarnet
            // 
            this.textcarnet.Location = new System.Drawing.Point(155, 46);
            this.textcarnet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textcarnet.Name = "textcarnet";
            this.textcarnet.Size = new System.Drawing.Size(102, 20);
            this.textcarnet.TabIndex = 6;
            this.textcarnet.TextChanged += new System.EventHandler(this.textcarnet_TextChanged);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(155, 75);
            this.textnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(269, 20);
            this.textnombre.TabIndex = 7;
            // 
            // textcorreo
            // 
            this.textcorreo.Location = new System.Drawing.Point(155, 133);
            this.textcorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(129, 20);
            this.textcorreo.TabIndex = 8;
            // 
            // buttoncrear
            // 
            this.buttoncrear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttoncrear.Location = new System.Drawing.Point(184, 367);
            this.buttoncrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoncrear.Name = "buttoncrear";
            this.buttoncrear.Size = new System.Drawing.Size(142, 41);
            this.buttoncrear.TabIndex = 10;
            this.buttoncrear.Text = "Registrar";
            this.buttoncrear.UseVisualStyleBackColor = false;
            this.buttoncrear.Click += new System.EventHandler(this.buttoncrear_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBuscar.Location = new System.Drawing.Point(260, 46);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(52, 21);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonactualizar.Location = new System.Drawing.Point(437, 75);
            this.buttonactualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(56, 19);
            this.buttonactualizar.TabIndex = 12;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = false;
            this.buttonactualizar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnseccion
            // 
            this.btnseccion.FormattingEnabled = true;
            this.btnseccion.Location = new System.Drawing.Point(155, 100);
            this.btnseccion.Name = "btnseccion";
            this.btnseccion.Size = new System.Drawing.Size(39, 21);
            this.btnseccion.TabIndex = 13;
            this.btnseccion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(520, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnseccion);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttoncrear);
            this.Controls.Add(this.textcorreo);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textcarnet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaludar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Menu de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textcarnet;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.Button buttoncrear;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.ComboBox btnseccion;
        private System.Windows.Forms.Button button1;
    }
}

