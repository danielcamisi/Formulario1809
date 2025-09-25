namespace Formulario1809
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
            Txt_User = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            Externo = new RadioButton();
            Interno = new RadioButton();
            TxtName = new TextBox();
            TxtPhone = new TextBox();
            groupBox2 = new GroupBox();
            TresMeses = new CheckBox();
            SeisMeses = new CheckBox();
            UmAno = new CheckBox();
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            Sair = new Button();
            Excluir = new Button();
            Consultar = new Button();
            Editar = new Button();
            Incluir = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Txt_User
            // 
            Txt_User.CharacterCasing = CharacterCasing.Upper;
            Txt_User.Location = new Point(12, 32);
            Txt_User.MaxLength = 10;
            Txt_User.Name = "Txt_User";
            Txt_User.ReadOnly = true;
            Txt_User.Size = new Size(106, 21);
            Txt_User.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "Código do Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome do Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefone do Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(Externo);
            groupBox1.Controls.Add(Interno);
            groupBox1.Location = new Point(237, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 116);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.usericon;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.usericon;
            pictureBox1.Location = new Point(122, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Externo
            // 
            Externo.AutoSize = true;
            Externo.Location = new Point(10, 62);
            Externo.Name = "Externo";
            Externo.Size = new Size(66, 19);
            Externo.TabIndex = 1;
            Externo.Text = "Externo";
            Externo.UseVisualStyleBackColor = true;
            // 
            // Interno
            // 
            Interno.AutoSize = true;
            Interno.Checked = true;
            Interno.Location = new Point(10, 37);
            Interno.Name = "Interno";
            Interno.Size = new Size(63, 19);
            Interno.TabIndex = 0;
            Interno.TabStop = true;
            Interno.Text = "Interno";
            Interno.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            TxtName.CharacterCasing = CharacterCasing.Upper;
            TxtName.Location = new Point(12, 136);
            TxtName.MaxLength = 255;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(474, 21);
            TxtName.TabIndex = 5;
            // 
            // TxtPhone
            // 
            TxtPhone.CharacterCasing = CharacterCasing.Upper;
            TxtPhone.Location = new Point(12, 197);
            TxtPhone.MaxLength = 11;
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(134, 21);
            TxtPhone.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TresMeses);
            groupBox2.Controls.Add(SeisMeses);
            groupBox2.Controls.Add(UmAno);
            groupBox2.Location = new Point(256, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 46);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente Vip";
            // 
            // TresMeses
            // 
            TresMeses.AutoSize = true;
            TresMeses.Location = new Point(150, 18);
            TresMeses.Name = "TresMeses";
            TresMeses.Size = new Size(73, 19);
            TresMeses.TabIndex = 2;
            TresMeses.Text = "3 Meses";
            TresMeses.UseVisualStyleBackColor = true;
            TresMeses.CheckedChanged += TresMeses_CheckedChanged;
            // 
            // SeisMeses
            // 
            SeisMeses.AutoSize = true;
            SeisMeses.Location = new Point(70, 18);
            SeisMeses.Name = "SeisMeses";
            SeisMeses.Size = new Size(73, 19);
            SeisMeses.TabIndex = 1;
            SeisMeses.Text = "6 Meses";
            SeisMeses.UseVisualStyleBackColor = true;
            SeisMeses.CheckedChanged += SeisMeses_CheckedChanged;
            // 
            // UmAno
            // 
            UmAno.AutoSize = true;
            UmAno.Location = new Point(7, 18);
            UmAno.Name = "UmAno";
            UmAno.Size = new Size(56, 19);
            UmAno.TabIndex = 0;
            UmAno.Text = "1 Ano";
            UmAno.UseVisualStyleBackColor = true;
            UmAno.CheckedChanged += UmAno_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Location = new Point(256, 217);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 54);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data do Cadastro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 21);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Location = new Point(257, 276);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(229, 55);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Prospect";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sim", "Não" });
            comboBox1.Location = new Point(51, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // Sair
            // 
            Sair.BackColor = Color.DarkOrange;
            Sair.FlatStyle = FlatStyle.Flat;
            Sair.Location = new Point(406, 362);
            Sair.Name = "Sair";
            Sair.Size = new Size(80, 23);
            Sair.TabIndex = 10;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = false;
            Sair.Click += Sair_Click;
            // 
            // Excluir
            // 
            Excluir.BackColor = Color.Red;
            Excluir.FlatStyle = FlatStyle.Flat;
            Excluir.Location = new Point(306, 362);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(80, 23);
            Excluir.TabIndex = 11;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = false;
            Excluir.Click += Excluir_Click;
            // 
            // Consultar
            // 
            Consultar.BackColor = Color.SkyBlue;
            Consultar.FlatStyle = FlatStyle.Flat;
            Consultar.Location = new Point(206, 362);
            Consultar.Name = "Consultar";
            Consultar.Size = new Size(80, 23);
            Consultar.TabIndex = 12;
            Consultar.Text = "Consultar";
            Consultar.UseVisualStyleBackColor = false;
            Consultar.Click += Consultar_Click;
            // 
            // Editar
            // 
            Editar.BackColor = Color.FromArgb(255, 255, 128);
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.Location = new Point(106, 362);
            Editar.Name = "Editar";
            Editar.Size = new Size(80, 23);
            Editar.TabIndex = 13;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // Incluir
            // 
            Incluir.BackColor = Color.LightGreen;
            Incluir.FlatStyle = FlatStyle.Flat;
            Incluir.Location = new Point(12, 362);
            Incluir.Name = "Incluir";
            Incluir.Size = new Size(80, 23);
            Incluir.TabIndex = 14;
            Incluir.Text = "Incluir";
            Incluir.UseVisualStyleBackColor = false;
            Incluir.Click += Incluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(474, 200);
            dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 616);
            Controls.Add(dataGridView1);
            Controls.Add(Incluir);
            Controls.Add(Editar);
            Controls.Add(Consultar);
            Controls.Add(Excluir);
            Controls.Add(Sair);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(TxtPhone);
            Controls.Add(TxtName);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_User);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contato";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_User;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton Externo;
        private RadioButton Interno;
        private TextBox TxtName;
        private TextBox TxtPhone;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private CheckBox TresMeses;
        private CheckBox SeisMeses;
        private CheckBox UmAno;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private Button Sair;
        private Button Excluir;
        private Button Consultar;
        private Button Editar;
        private Button Incluir;
        private DataGridView dataGridView1;
    }
}
