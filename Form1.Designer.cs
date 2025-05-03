namespace Nomina
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            txtsalario = new TextBox();
            label3 = new Label();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            richTextBox2 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtsalario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdentificacion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 859);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleado";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 502);
            button1.Name = "button1";
            button1.Size = new Size(458, 82);
            button1.TabIndex = 8;
            button1.Text = "Crear Empleado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nivel I (Riesgo mínimo)", "Nivel II (Riesgo bajo)", "Nivel III (Riesgo medio)", "Nivel IV (Riesgo alto)", "Nivel V (Riesgo máximo)" });
            comboBox1.Location = new Point(24, 327);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(439, 40);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label4.Location = new Point(28, 383);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 6;
            label4.Text = "Salario";
            // 
            // txtsalario
            // 
            txtsalario.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtsalario.Location = new Point(34, 427);
            txtsalario.Name = "txtsalario";
            txtsalario.Size = new Size(438, 39);
            txtsalario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label3.Location = new Point(24, 279);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 4;
            label3.Text = "Riesgo ARL";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtIdentificacion.Location = new Point(21, 215);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(442, 39);
            txtIdentificacion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(21, 180);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 2;
            label2.Text = "Identificación";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtNombre.Location = new Point(21, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(451, 39);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label1.Location = new Point(21, 62);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveBorder;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(536, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(732, 398);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Empleado";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(8, 302);
            button2.Name = "button2";
            button2.Size = new Size(707, 84);
            button2.TabIndex = 1;
            button2.Text = "Ver Empleado";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(8, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(707, 254);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.InactiveBorder;
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(richTextBox2);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(536, 424);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(732, 456);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cálculo de Nomina";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(8, 365);
            button3.Name = "button3";
            button3.Size = new Size(707, 83);
            button3.TabIndex = 1;
            button3.Text = "Mostrar Nómina";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 36);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(709, 323);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 883);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdentificacion;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox txtsalario;
        private Label label3;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button button3;
        private RichTextBox richTextBox2;
    }
}
