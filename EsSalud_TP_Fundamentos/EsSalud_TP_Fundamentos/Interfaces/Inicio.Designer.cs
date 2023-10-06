namespace EsSalud_TP_Fundamentos.Interfaces
{
    partial class Inicio
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_EsSalud;
            pictureBox1.Location = new Point(98, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 193);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(124, 239);
            label1.Name = "label1";
            label1.Size = new Size(270, 24);
            label1.TabIndex = 1;
            label1.Text = "Sistema de registro en linea";
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
            button1.Location = new Point(151, 306);
            button1.Name = "button1";
            button1.Size = new Size(205, 45);
            button1.TabIndex = 2;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(151, 377);
            button2.Name = "button2";
            button2.Size = new Size(205, 45);
            button2.TabIndex = 3;
            button2.Text = "Registro";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(193, 476);
            label2.Name = "label2";
            label2.Size = new Size(122, 16);
            label2.TabIndex = 4;
            label2.Text = "2023 Copyright ©";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 501);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}