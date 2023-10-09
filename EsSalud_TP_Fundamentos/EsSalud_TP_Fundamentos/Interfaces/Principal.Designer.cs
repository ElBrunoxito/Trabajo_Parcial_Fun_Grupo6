namespace EsSalud_TP_Fundamentos.Interfaces
{
    partial class Principal
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
            menuStrip1 = new MenuStrip();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            programacionDeCitasToolStripMenuItem = new ToolStripMenuItem();
            informacionAdministrativaYSegurosToolStripMenuItem = new ToolStripMenuItem();
            educacionYPromocionToolStripMenuItem = new ToolStripMenuItem();
            consultasYQuejasToolStripMenuItem = new ToolStripMenuItem();
            Panel_Programacion_Citas = new Panel();
            uno_cb_tipo = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            button1 = new Button();
            uno_cb_medicos = new ComboBox();
            uno_cb_hospital = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            uno_dt_hora = new DateTimePicker();
            uno_dt_fecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            Panel_Info_Adms = new Panel();
            panel_Consultas = new Panel();
            label10 = new Label();
            cuatro_ingresar_bt = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            cuatro_hospital = new ComboBox();
            label9 = new Label();
            cuatro_Queja_tb = new TextBox();
            label8 = new Label();
            dos_btn_beneficios = new Button();
            label6 = new Label();
            dos_btn_tramites = new Button();
            menuStrip1.SuspendLayout();
            Panel_Programacion_Citas.SuspendLayout();
            Panel_Info_Adms.SuspendLayout();
            panel_Consultas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, programacionDeCitasToolStripMenuItem, informacionAdministrativaYSegurosToolStripMenuItem, educacionYPromocionToolStripMenuItem, consultasYQuejasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(890, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(73, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // programacionDeCitasToolStripMenuItem
            // 
            programacionDeCitasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            programacionDeCitasToolStripMenuItem.Name = "programacionDeCitasToolStripMenuItem";
            programacionDeCitasToolStripMenuItem.Size = new Size(175, 20);
            programacionDeCitasToolStripMenuItem.Text = "Programacion de citas";
            programacionDeCitasToolStripMenuItem.Click += programacionDeCitasToolStripMenuItem_Click;
            // 
            // informacionAdministrativaYSegurosToolStripMenuItem
            // 
            informacionAdministrativaYSegurosToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            informacionAdministrativaYSegurosToolStripMenuItem.Name = "informacionAdministrativaYSegurosToolStripMenuItem";
            informacionAdministrativaYSegurosToolStripMenuItem.Size = new Size(201, 20);
            informacionAdministrativaYSegurosToolStripMenuItem.Text = "Informacion Administrativa";
            informacionAdministrativaYSegurosToolStripMenuItem.Click += informacionAdministrativaYSegurosToolStripMenuItem_Click;
            // 
            // educacionYPromocionToolStripMenuItem
            // 
            educacionYPromocionToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            educacionYPromocionToolStripMenuItem.Name = "educacionYPromocionToolStripMenuItem";
            educacionYPromocionToolStripMenuItem.Size = new Size(181, 20);
            educacionYPromocionToolStripMenuItem.Text = "Educacion y promocion";
            // 
            // consultasYQuejasToolStripMenuItem
            // 
            consultasYQuejasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            consultasYQuejasToolStripMenuItem.Name = "consultasYQuejasToolStripMenuItem";
            consultasYQuejasToolStripMenuItem.Size = new Size(150, 20);
            consultasYQuejasToolStripMenuItem.Text = "Consultas y quejas";
            consultasYQuejasToolStripMenuItem.Click += consultasYQuejasToolStripMenuItem_Click;
            // 
            // Panel_Programacion_Citas
            // 
            Panel_Programacion_Citas.BackColor = SystemColors.Control;
            Panel_Programacion_Citas.Controls.Add(uno_cb_tipo);
            Panel_Programacion_Citas.Controls.Add(label7);
            Panel_Programacion_Citas.Controls.Add(label5);
            Panel_Programacion_Citas.Controls.Add(button1);
            Panel_Programacion_Citas.Controls.Add(uno_cb_medicos);
            Panel_Programacion_Citas.Controls.Add(uno_cb_hospital);
            Panel_Programacion_Citas.Controls.Add(label3);
            Panel_Programacion_Citas.Controls.Add(label4);
            Panel_Programacion_Citas.Controls.Add(uno_dt_hora);
            Panel_Programacion_Citas.Controls.Add(uno_dt_fecha);
            Panel_Programacion_Citas.Controls.Add(label1);
            Panel_Programacion_Citas.Controls.Add(label2);
            Panel_Programacion_Citas.Location = new Point(0, 218);
            Panel_Programacion_Citas.Name = "Panel_Programacion_Citas";
            Panel_Programacion_Citas.Size = new Size(890, 537);
            Panel_Programacion_Citas.TabIndex = 1;
            Panel_Programacion_Citas.Visible = false;
            Panel_Programacion_Citas.Paint += Programacion_Citas_Paint;
            // 
            // uno_cb_tipo
            // 
            uno_cb_tipo.BackColor = SystemColors.HotTrack;
            uno_cb_tipo.ForeColor = SystemColors.Info;
            uno_cb_tipo.FormattingEnabled = true;
            uno_cb_tipo.Location = new Point(248, 86);
            uno_cb_tipo.Name = "uno_cb_tipo";
            uno_cb_tipo.Size = new Size(200, 23);
            uno_cb_tipo.TabIndex = 66;
            uno_cb_tipo.SelectedIndexChanged += uno_cb_tipo_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(100, 85);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 65;
            label7.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(213, 45);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 63;
            label5.Text = "Programa una cita";
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
            button1.Location = new Point(248, 413);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 62;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // uno_cb_medicos
            // 
            uno_cb_medicos.BackColor = SystemColors.HotTrack;
            uno_cb_medicos.ForeColor = SystemColors.Info;
            uno_cb_medicos.FormattingEnabled = true;
            uno_cb_medicos.Location = new Point(248, 357);
            uno_cb_medicos.Name = "uno_cb_medicos";
            uno_cb_medicos.Size = new Size(200, 23);
            uno_cb_medicos.TabIndex = 61;
            // 
            // uno_cb_hospital
            // 
            uno_cb_hospital.BackColor = SystemColors.HotTrack;
            uno_cb_hospital.ForeColor = SystemColors.Info;
            uno_cb_hospital.FormattingEnabled = true;
            uno_cb_hospital.Location = new Point(248, 289);
            uno_cb_hospital.Name = "uno_cb_hospital";
            uno_cb_hospital.Size = new Size(200, 23);
            uno_cb_hospital.TabIndex = 60;
            uno_cb_hospital.SelectedIndexChanged += uno_cb_hospital_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(100, 360);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 59;
            label3.Text = "Medico disponible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(100, 289);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 58;
            label4.Text = "Hospital";
            // 
            // uno_dt_hora
            // 
            uno_dt_hora.Format = DateTimePickerFormat.Time;
            uno_dt_hora.Location = new Point(248, 222);
            uno_dt_hora.Name = "uno_dt_hora";
            uno_dt_hora.Size = new Size(200, 23);
            uno_dt_hora.TabIndex = 57;
            // 
            // uno_dt_fecha
            // 
            uno_dt_fecha.Format = DateTimePickerFormat.Short;
            uno_dt_fecha.Location = new Point(248, 152);
            uno_dt_fecha.Name = "uno_dt_fecha";
            uno_dt_fecha.Size = new Size(200, 23);
            uno_dt_fecha.TabIndex = 56;
            uno_dt_fecha.ValueChanged += uno_dt_fecha_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(100, 225);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 55;
            label1.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(100, 155);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 54;
            label2.Text = "Fecha";
            // 
            // Panel_Info_Adms
            // 
            Panel_Info_Adms.BackColor = SystemColors.Control;
            Panel_Info_Adms.Controls.Add(dos_btn_beneficios);
            Panel_Info_Adms.Controls.Add(label6);
            Panel_Info_Adms.Controls.Add(dos_btn_tramites);
            Panel_Info_Adms.Location = new Point(25, 188);
            Panel_Info_Adms.Name = "Panel_Info_Adms";
            Panel_Info_Adms.Size = new Size(890, 537);
            Panel_Info_Adms.TabIndex = 67;
            Panel_Info_Adms.Visible = false;
            // 
            // panel_Consultas
            // 
            panel_Consultas.BackColor = SystemColors.Control;
            panel_Consultas.Controls.Add(label10);
            panel_Consultas.Controls.Add(cuatro_ingresar_bt);
            panel_Consultas.Controls.Add(groupBox1);
            panel_Consultas.Controls.Add(cuatro_hospital);
            panel_Consultas.Controls.Add(label9);
            panel_Consultas.Controls.Add(cuatro_Queja_tb);
            panel_Consultas.Controls.Add(label8);
            panel_Consultas.Location = new Point(145, 172);
            panel_Consultas.Name = "panel_Consultas";
            panel_Consultas.Size = new Size(890, 537);
            panel_Consultas.TabIndex = 68;
            panel_Consultas.Visible = false;
            panel_Consultas.Paint += panel_Consultas_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(169, 200);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 69;
            label10.Text = "Comentario";
            // 
            // cuatro_ingresar_bt
            // 
            cuatro_ingresar_bt.BackColor = SystemColors.HotTrack;
            cuatro_ingresar_bt.FlatAppearance.BorderColor = SystemColors.HotTrack;
            cuatro_ingresar_bt.FlatAppearance.BorderSize = 2;
            cuatro_ingresar_bt.FlatAppearance.MouseOverBackColor = Color.White;
            cuatro_ingresar_bt.FlatStyle = FlatStyle.Flat;
            cuatro_ingresar_bt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cuatro_ingresar_bt.ForeColor = Color.White;
            cuatro_ingresar_bt.Location = new Point(257, 436);
            cuatro_ingresar_bt.Name = "cuatro_ingresar_bt";
            cuatro_ingresar_bt.Size = new Size(205, 45);
            cuatro_ingresar_bt.TabIndex = 68;
            cuatro_ingresar_bt.Text = "Ingresar";
            cuatro_ingresar_bt.UseVisualStyleBackColor = false;
            cuatro_ingresar_bt.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(169, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 46);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(88, 14);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 69;
            radioButton2.TabStop = true;
            radioButton2.Text = "Queja";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 68;
            radioButton1.TabStop = true;
            radioButton1.Text = "Consulta";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // cuatro_hospital
            // 
            cuatro_hospital.BackColor = SystemColors.HotTrack;
            cuatro_hospital.ForeColor = SystemColors.Info;
            cuatro_hospital.FormattingEnabled = true;
            cuatro_hospital.Location = new Point(315, 86);
            cuatro_hospital.Name = "cuatro_hospital";
            cuatro_hospital.Size = new Size(200, 23);
            cuatro_hospital.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(167, 86);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 65;
            label9.Text = "Hospital";
            // 
            // cuatro_Queja_tb
            // 
            cuatro_Queja_tb.Location = new Point(169, 223);
            cuatro_Queja_tb.Multiline = true;
            cuatro_Queja_tb.Name = "cuatro_Queja_tb";
            cuatro_Queja_tb.Size = new Size(346, 183);
            cuatro_Queja_tb.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(257, 45);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 63;
            label8.Text = "Consultas y quejas";
            // 
            // dos_btn_beneficios
            // 
            dos_btn_beneficios.BackColor = SystemColors.ButtonHighlight;
            dos_btn_beneficios.FlatAppearance.BorderColor = SystemColors.HotTrack;
            dos_btn_beneficios.FlatAppearance.BorderSize = 2;
            dos_btn_beneficios.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 164, 222);
            dos_btn_beneficios.FlatStyle = FlatStyle.Flat;
            dos_btn_beneficios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dos_btn_beneficios.ForeColor = Color.Black;
            dos_btn_beneficios.Location = new Point(198, 200);
            dos_btn_beneficios.Name = "dos_btn_beneficios";
            dos_btn_beneficios.Size = new Size(262, 45);
            dos_btn_beneficios.TabIndex = 64;
            dos_btn_beneficios.Text = "Beneficios de seguros";
            dos_btn_beneficios.UseVisualStyleBackColor = false;
            dos_btn_beneficios.Click += dos_btn_beneficios_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(213, 45);
            label6.Name = "label6";
            label6.Size = new Size(222, 20);
            label6.TabIndex = 63;
            label6.Text = "Informacion Administrativa";
            // 
            // dos_btn_tramites
            // 
            dos_btn_tramites.BackColor = SystemColors.ButtonHighlight;
            dos_btn_tramites.FlatAppearance.BorderColor = SystemColors.HotTrack;
            dos_btn_tramites.FlatAppearance.BorderSize = 2;
            dos_btn_tramites.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 164, 222);
            dos_btn_tramites.FlatStyle = FlatStyle.Flat;
            dos_btn_tramites.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dos_btn_tramites.ForeColor = Color.Black;
            dos_btn_tramites.Location = new Point(198, 132);
            dos_btn_tramites.Name = "dos_btn_tramites";
            dos_btn_tramites.Size = new Size(262, 45);
            dos_btn_tramites.TabIndex = 62;
            dos_btn_tramites.Text = "Tramites administrativos";
            dos_btn_tramites.UseVisualStyleBackColor = false;
            dos_btn_tramites.Click += dos_btn_tramites_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 564);
            Controls.Add(panel_Consultas);
            Controls.Add(Panel_Info_Adms);
            Controls.Add(Panel_Programacion_Citas);
            Controls.Add(menuStrip1);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Panel_Programacion_Citas.ResumeLayout(false);
            Panel_Programacion_Citas.PerformLayout();
            Panel_Info_Adms.ResumeLayout(false);
            Panel_Info_Adms.PerformLayout();
            panel_Consultas.ResumeLayout(false);
            panel_Consultas.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem programacionDeCitasToolStripMenuItem;
        private ToolStripMenuItem informacionAdministrativaYSegurosToolStripMenuItem;
        private ToolStripMenuItem educacionYPromocionToolStripMenuItem;
        private ToolStripMenuItem consultasYQuejasToolStripMenuItem;
        private Panel Panel_Programacion_Citas;
        private Label label5;
        private Button button1;
        private ComboBox uno_cb_medicos;
        private ComboBox uno_cb_hospital;
        private Label label3;
        private Label label4;
        private DateTimePicker uno_dt_hora;
        private DateTimePicker uno_dt_fecha;
        private Label label1;
        private Label label2;
        private ComboBox uno_cb_tipo;
        private Label label7;
        private Panel Panel_Info_Adms;
        private Button dos_btn_beneficios;
        private Label label6;
        private Button dos_btn_tramites;
        private Panel panel_Consultas;
        private Label label8;
        private TextBox cuatro_Queja_tb;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox cuatro_hospital;
        private Label label9;
        private Button cuatro_ingresar_bt;
        private Label label10;
    }
}