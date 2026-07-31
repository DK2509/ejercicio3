namespace ejercicio3
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            txtCantidad = new TextBox();
            cboProductosPrecios = new ComboBox();
            txtResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(277, 223);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Fectivo";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(443, 227);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(228, 127);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(143, 23);
            txtCantidad.TabIndex = 2;
            // 
            // cboProductosPrecios
            // 
            cboProductosPrecios.FormattingEnabled = true;
            cboProductosPrecios.Location = new Point(443, 127);
            cboProductosPrecios.Name = "cboProductosPrecios";
            cboProductosPrecios.Size = new Size(221, 23);
            cboProductosPrecios.TabIndex = 3;
            cboProductosPrecios.SelectedIndexChanged += cboProductosPrecios_SelectedIndexChanged;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Location = new Point(358, 290);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(59, 15);
            txtResultado.TabIndex = 4;
            txtResultado.Text = "Resultado";
            txtResultado.Click += txtResultado_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(108, 194);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(cboProductosPrecios);
            Controls.Add(txtCantidad);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txtCantidad;
        private ComboBox cboProductosPrecios;
        private Label txtResultado;
        private Button btnCalcular;
    }
}
