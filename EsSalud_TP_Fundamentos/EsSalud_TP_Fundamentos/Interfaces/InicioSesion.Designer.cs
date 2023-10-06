namespace EsSalud_TP_Fundamentos.Interfaces
{
    partial class InicioSesion
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            TB_DNI = new TextBox();
            TB_Contra = new TextBox();
            button1 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_EsSalud;
            pictureBox1.Location = new Point(-73, 282);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 124);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 2;
            label1.Text = "Iniciar Sesion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(46, 77);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 5;
            label4.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(46, 150);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 8;
            label7.Text = "Contraseña";
            // 
            // TB_DNI
            // 
            TB_DNI.BackColor = SystemColors.HotTrack;
            TB_DNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_DNI.ForeColor = SystemColors.Info;
            TB_DNI.Location = new Point(241, 75);
            TB_DNI.Name = "TB_DNI";
            TB_DNI.Size = new Size(274, 22);
            TB_DNI.TabIndex = 12;
            // 
            // TB_Contra
            // 
            TB_Contra.BackColor = SystemColors.HotTrack;
            TB_Contra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Contra.ForeColor = SystemColors.Info;
            TB_Contra.Location = new Point(241, 150);
            TB_Contra.Name = "TB_Contra";
            TB_Contra.PasswordChar = '•';
            TB_Contra.Size = new Size(274, 22);
            TB_Contra.TabIndex = 15;
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
            button1.Location = new Point(181, 229);
            button1.Name = "button1";
            button1.Size = new Size(205, 45);
            button1.TabIndex = 17;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(223, 370);
            label9.Name = "label9";
            label9.Size = new Size(122, 16);
            label9.TabIndex = 18;
            label9.Text = "2023 Copyright ©";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 395);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(TB_Contra);
            Controls.Add(TB_DNI);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "InicioSesion";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioSesion";
            Load += InicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label7;
        private TextBox TB_DNI;
        private TextBox TB_Contra;
        private Button button1;
        private Label label9;
    }
}