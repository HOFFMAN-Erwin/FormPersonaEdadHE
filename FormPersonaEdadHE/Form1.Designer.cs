namespace FormPersonaEdadHE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbDni = new System.Windows.Forms.TextBox();
            this.txtbFechaNac = new System.Windows.Forms.TextBox();
            this.btn_Persona = new System.Windows.Forms.Button();
            this.btn_Edad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(62, 75);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 15);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(62, 108);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(122, 15);
            this.lblFechaNac.TabIndex = 0;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(62, 138);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(202, 37);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 23);
            this.txtbNombre.TabIndex = 1;
            // 
            // txtbDni
            // 
            this.txtbDni.Location = new System.Drawing.Point(202, 67);
            this.txtbDni.Name = "txtbDni";
            this.txtbDni.Size = new System.Drawing.Size(100, 23);
            this.txtbDni.TabIndex = 2;
            // 
            // txtbFechaNac
            // 
            this.txtbFechaNac.Location = new System.Drawing.Point(202, 100);
            this.txtbFechaNac.Name = "txtbFechaNac";
            this.txtbFechaNac.Size = new System.Drawing.Size(100, 23);
            this.txtbFechaNac.TabIndex = 3;
            // 
            // btn_Persona
            // 
            this.btn_Persona.Location = new System.Drawing.Point(420, 57);
            this.btn_Persona.Name = "btn_Persona";
            this.btn_Persona.Size = new System.Drawing.Size(75, 44);
            this.btn_Persona.TabIndex = 4;
            this.btn_Persona.Text = "Persona";
            this.btn_Persona.UseVisualStyleBackColor = true;
            this.btn_Persona.Click += new System.EventHandler(this.btn_Persona_Click);
            // 
            // btn_Edad
            // 
            this.btn_Edad.Location = new System.Drawing.Point(420, 109);
            this.btn_Edad.Name = "btn_Edad";
            this.btn_Edad.Size = new System.Drawing.Size(75, 44);
            this.btn_Edad.TabIndex = 4;
            this.btn_Edad.Text = "Edad";
            this.btn_Edad.UseVisualStyleBackColor = true;
            this.btn_Edad.Click += new System.EventHandler(this.btn_Edad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 268);
            this.Controls.Add(this.btn_Edad);
            this.Controls.Add(this.btn_Persona);
            this.Controls.Add(this.txtbFechaNac);
            this.Controls.Add(this.txtbDni);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDni;
        private Label lblFechaNac;
        private Label lblEdad;
        private TextBox txtbNombre;
        private TextBox txtbDni;
        private TextBox txtbFechaNac;
        private Button btn_Persona;
        private Button btn_Edad;
    }
}