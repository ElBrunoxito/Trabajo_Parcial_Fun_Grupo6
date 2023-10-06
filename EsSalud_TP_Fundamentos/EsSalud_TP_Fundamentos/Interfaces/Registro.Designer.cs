namespace EsSalud_TP_Fundamentos.Interfaces
{
    partial class Registro
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
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            TB_Telefono = new TextBox();
            TB_Direccion = new TextBox();
            TB_DNI = new TextBox();
            TB_Apellidos = new TextBox();
            TB_Nombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            DT_Fecha = new DateTimePicker();
            TB_CContra = new TextBox();
            TB_Contra = new TextBox();
            TB_Correo = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            TB_Genero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(362, 668);
            button2.Name = "button2";
            button2.Size = new Size(145, 23);
            button2.TabIndex = 42;
            button2.Text = "Seleccionar imagen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(224, 599);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 92);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(31, 599);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 40;
            label10.Text = "Foto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(269, 833);
            label9.Name = "label9";
            label9.Size = new Size(122, 16);
            label9.TabIndex = 39;
            label9.Text = "2023 Copyright ©";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 164, 222);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(224, 734);
            button1.Name = "button1";
            button1.Size = new Size(205, 45);
            button1.TabIndex = 38;
            button1.Text = "Guardar datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TB_Telefono
            // 
            TB_Telefono.BackColor = SystemColors.HotTrack;
            TB_Telefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Telefono.ForeColor = SystemColors.Info;
            TB_Telefono.Location = new Point(224, 376);
            TB_Telefono.Name = "TB_Telefono";
            TB_Telefono.Size = new Size(274, 22);
            TB_Telefono.TabIndex = 37;
            // 
            // TB_Direccion
            // 
            TB_Direccion.BackColor = SystemColors.HotTrack;
            TB_Direccion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Direccion.ForeColor = SystemColors.Info;
            TB_Direccion.Location = new Point(224, 326);
            TB_Direccion.Name = "TB_Direccion";
            TB_Direccion.Size = new Size(274, 22);
            TB_Direccion.TabIndex = 36;
            // 
            // TB_DNI
            // 
            TB_DNI.BackColor = SystemColors.HotTrack;
            TB_DNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_DNI.ForeColor = SystemColors.Info;
            TB_DNI.Location = new Point(224, 174);
            TB_DNI.Name = "TB_DNI";
            TB_DNI.Size = new Size(274, 22);
            TB_DNI.TabIndex = 33;
            TB_DNI.TextChanged += TB_DNI_TextChanged;
            // 
            // TB_Apellidos
            // 
            TB_Apellidos.BackColor = SystemColors.HotTrack;
            TB_Apellidos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Apellidos.ForeColor = SystemColors.Info;
            TB_Apellidos.Location = new Point(224, 127);
            TB_Apellidos.Name = "TB_Apellidos";
            TB_Apellidos.Size = new Size(274, 22);
            TB_Apellidos.TabIndex = 32;
            // 
            // TB_Nombre
            // 
            TB_Nombre.BackColor = SystemColors.HotTrack;
            TB_Nombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Nombre.ForeColor = SystemColors.Info;
            TB_Nombre.Location = new Point(224, 83);
            TB_Nombre.Name = "TB_Nombre";
            TB_Nombre.Size = new Size(274, 22);
            TB_Nombre.TabIndex = 31;
            TB_Nombre.TextChanged += TB_Nombre_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(29, 376);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 30;
            label8.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(29, 326);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 29;
            label7.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 275);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 28;
            label6.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(29, 223);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 27;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(29, 176);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 26;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 129);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 25;
            label3.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 24;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(304, 8);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 23;
            label1.Text = "Registro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_EsSalud;
            pictureBox1.Location = new Point(469, 748);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 124);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // DT_Fecha
            // 
            DT_Fecha.Format = DateTimePickerFormat.Short;
            DT_Fecha.Location = new Point(224, 220);
            DT_Fecha.Name = "DT_Fecha";
            DT_Fecha.Size = new Size(274, 23);
            DT_Fecha.TabIndex = 43;
            // 
            // TB_CContra
            // 
            TB_CContra.BackColor = SystemColors.HotTrack;
            TB_CContra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_CContra.ForeColor = SystemColors.Info;
            TB_CContra.Location = new Point(224, 523);
            TB_CContra.Name = "TB_CContra";
            TB_CContra.PasswordChar = '•';
            TB_CContra.Size = new Size(274, 22);
            TB_CContra.TabIndex = 49;
            // 
            // TB_Contra
            // 
            TB_Contra.BackColor = SystemColors.HotTrack;
            TB_Contra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Contra.ForeColor = SystemColors.Info;
            TB_Contra.Location = new Point(224, 473);
            TB_Contra.Name = "TB_Contra";
            TB_Contra.PasswordChar = '•';
            TB_Contra.Size = new Size(274, 22);
            TB_Contra.TabIndex = 48;
            // 
            // TB_Correo
            // 
            TB_Correo.BackColor = SystemColors.HotTrack;
            TB_Correo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Correo.ForeColor = SystemColors.Info;
            TB_Correo.Location = new Point(224, 420);
            TB_Correo.Name = "TB_Correo";
            TB_Correo.Size = new Size(274, 22);
            TB_Correo.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(29, 523);
            label11.Name = "label11";
            label11.Size = new Size(157, 20);
            label11.TabIndex = 46;
            label11.Text = "Confirme contraseña";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(29, 473);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 45;
            label12.Text = "Contraseña";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(29, 422);
            label13.Name = "label13";
            label13.Size = new Size(138, 20);
            label13.TabIndex = 44;
            label13.Text = "Correo electronico";
            label13.Click += label13_Click;
            // 
            // TB_Genero
            // 
            TB_Genero.BackColor = SystemColors.HotTrack;
            TB_Genero.ForeColor = SystemColors.Info;
            TB_Genero.FormattingEnabled = true;
            TB_Genero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            TB_Genero.Location = new Point(224, 272);
            TB_Genero.Name = "TB_Genero";
            TB_Genero.Size = new Size(274, 23);
            TB_Genero.TabIndex = 50;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 858);
            Controls.Add(TB_Genero);
            Controls.Add(TB_CContra);
            Controls.Add(TB_Contra);
            Controls.Add(TB_Correo);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(DT_Fecha);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(TB_Telefono);
            Controls.Add(TB_Direccion);
            Controls.Add(TB_DNI);
            Controls.Add(TB_Apellidos);
            Controls.Add(TB_Nombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Registro";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox2;
        private Label label10;
        private Label label9;
        private Button button1;
        private TextBox TB_Telefono;
        private TextBox TB_Direccion;
        private TextBox TB_DNI;
        private TextBox TB_Apellidos;
        private TextBox TB_Nombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker DT_Fecha;
        private TextBox TB_CContra;
        private TextBox TB_Contra;
        private TextBox TB_Correo;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox TB_Genero;
    }
}