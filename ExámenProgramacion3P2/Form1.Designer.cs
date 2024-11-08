namespace ExámenProgramacion3P2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblRawValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLedOn = new System.Windows.Forms.Button();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnServoOn = new System.Windows.Forms.Button();
            this.btnServoOff = new System.Windows.Forms.Button();
            this.btnReadTemperature = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos del usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha del registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sensor de Temperatura";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(160, 296);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(40, 13);
            this.lblCelsius.TabIndex = 9;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(151, 326);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 10;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblRawValue
            // 
            this.lblRawValue.AutoSize = true;
            this.lblRawValue.Location = new System.Drawing.Point(160, 356);
            this.lblRawValue.Name = "lblRawValue";
            this.lblRawValue.Size = new System.Drawing.Size(33, 13);
            this.lblRawValue.TabIndex = 11;
            this.lblRawValue.Text = "RAW";
            this.lblRawValue.Click += new System.EventHandler(this.lblRawValue_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Led";
            // 
            // btnLedOn
            // 
            this.btnLedOn.Location = new System.Drawing.Point(443, 77);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(75, 62);
            this.btnLedOn.TabIndex = 13;
            this.btnLedOn.Text = "Encender";
            this.btnLedOn.UseVisualStyleBackColor = true;
            this.btnLedOn.Click += new System.EventHandler(this.btnLedOn_Click);
            // 
            // btnLedOff
            // 
            this.btnLedOff.Location = new System.Drawing.Point(578, 77);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(75, 62);
            this.btnLedOff.TabIndex = 14;
            this.btnLedOff.Text = "Apagar";
            this.btnLedOff.UseVisualStyleBackColor = true;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Servomotor";
            // 
            // btnServoOn
            // 
            this.btnServoOn.Location = new System.Drawing.Point(430, 256);
            this.btnServoOn.Name = "btnServoOn";
            this.btnServoOn.Size = new System.Drawing.Size(88, 70);
            this.btnServoOn.TabIndex = 16;
            this.btnServoOn.Text = "Encender";
            this.btnServoOn.UseVisualStyleBackColor = true;
            this.btnServoOn.Click += new System.EventHandler(this.btnServoOn_Click);
            // 
            // btnServoOff
            // 
            this.btnServoOff.Location = new System.Drawing.Point(578, 256);
            this.btnServoOff.Name = "btnServoOff";
            this.btnServoOff.Size = new System.Drawing.Size(88, 70);
            this.btnServoOff.TabIndex = 17;
            this.btnServoOff.Text = "Apagar";
            this.btnServoOff.UseVisualStyleBackColor = true;
            this.btnServoOff.Click += new System.EventHandler(this.btnServoOff_Click);
            // 
            // btnReadTemperature
            // 
            this.btnReadTemperature.Location = new System.Drawing.Point(122, 243);
            this.btnReadTemperature.Name = "btnReadTemperature";
            this.btnReadTemperature.Size = new System.Drawing.Size(110, 40);
            this.btnReadTemperature.TabIndex = 18;
            this.btnReadTemperature.Text = "Leer Temperatura";
            this.btnReadTemperature.UseVisualStyleBackColor = true;
            this.btnReadTemperature.Click += new System.EventHandler(this.btnReadTemperature_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(163, 133);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 19;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // btnGuardarUsuario_Click
            // 
            this.btnGuardarUsuario_Click.Location = new System.Drawing.Point(119, 172);
            this.btnGuardarUsuario_Click.Name = "btnGuardarUsuario_Click";
            this.btnGuardarUsuario_Click.Size = new System.Drawing.Size(101, 23);
            this.btnGuardarUsuario_Click.TabIndex = 20;
            this.btnGuardarUsuario_Click.Text = "Guardar datos";
            this.btnGuardarUsuario_Click.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario_Click.Click += new System.EventHandler(this.btnGuardarUsuario_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.btnGuardarUsuario_Click);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnReadTemperature);
            this.Controls.Add(this.btnServoOff);
            this.Controls.Add(this.btnServoOn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLedOff);
            this.Controls.Add(this.btnLedOn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRawValue);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblRawValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLedOn;
        private System.Windows.Forms.Button btnLedOff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnServoOn;
        private System.Windows.Forms.Button btnServoOff;
        private System.Windows.Forms.Button btnReadTemperature;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnGuardarUsuario_Click;
    }
}

