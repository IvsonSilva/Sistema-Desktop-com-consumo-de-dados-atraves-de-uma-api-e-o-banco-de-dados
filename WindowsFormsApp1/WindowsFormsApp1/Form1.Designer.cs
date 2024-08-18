namespace WindowsFormsApp1
{
    partial class formularioclientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioclientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtdoc = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.RadioButton();
            this.cnpj = new System.Windows.Forms.RadioButton();
            this.opm = new System.Windows.Forms.RadioButton();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.cbestadocivil = new System.Windows.Forms.ComboBox();
            this.txtnascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.cksituacao = new System.Windows.Forms.CheckBox();
            this.opf = new System.Windows.Forms.RadioButton();
            this.outros = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.cbendereco = new System.Windows.Forms.ComboBox();
            this.cbbairro = new System.Windows.Forms.ComboBox();
            this.cbcidade = new System.Windows.Forms.ComboBox();
            this.imgcliente = new System.Windows.Forms.PictureBox();
            this.btaddfoto = new System.Windows.Forms.Button();
            this.btremovefoto = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.btnovo = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "RG:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado Civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(634, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "N°:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bairro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(378, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 14);
            this.label12.TabIndex = 11;
            this.label12.Text = "Estados:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(225, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 12;
            this.label13.Text = "Celular:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(451, 419);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 14);
            this.label14.TabIndex = 13;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 487);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 14);
            this.label15.TabIndex = 14;
            this.label15.Text = "Observações:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, 589);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 14);
            this.label16.TabIndex = 15;
            this.label16.Text = "Situação Cadastral:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(228, 86);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(94, 22);
            this.txtid.TabIndex = 16;
            this.txtid.TabStop = false;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(346, 86);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(368, 22);
            this.txtnome.TabIndex = 0;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(255, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 14);
            this.label17.TabIndex = 18;
            this.label17.Text = "Documento:";
            // 
            // txtdoc
            // 
            this.txtdoc.BeepOnError = true;
            this.txtdoc.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoc.HidePromptOnLeave = true;
            this.txtdoc.Location = new System.Drawing.Point(8, 25);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(143, 22);
            this.txtdoc.TabIndex = 2;
            this.txtdoc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtdoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtdoc_Validating);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.BackColor = System.Drawing.Color.Transparent;
            this.cpf.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(12, 10);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(46, 18);
            this.cpf.TabIndex = 1;
            this.cpf.TabStop = true;
            this.cpf.Text = "CPF";
            this.cpf.UseVisualStyleBackColor = false;
            this.cpf.CheckedChanged += new System.EventHandler(this.cpf_CheckedChanged);
            // 
            // cnpj
            // 
            this.cnpj.AutoSize = true;
            this.cnpj.BackColor = System.Drawing.Color.Transparent;
            this.cnpj.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj.Location = new System.Drawing.Point(76, 10);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(53, 18);
            this.cnpj.TabIndex = 2;
            this.cnpj.Text = "CNPJ";
            this.cnpj.UseVisualStyleBackColor = false;
            this.cnpj.CheckedChanged += new System.EventHandler(this.cnpj_CheckedChanged);
            // 
            // opm
            // 
            this.opm.AutoSize = true;
            this.opm.BackColor = System.Drawing.Color.Transparent;
            this.opm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opm.Location = new System.Drawing.Point(3, 21);
            this.opm.Name = "opm";
            this.opm.Size = new System.Drawing.Size(88, 18);
            this.opm.TabIndex = 0;
            this.opm.Text = "Masculino";
            this.opm.UseVisualStyleBackColor = false;
            this.opm.CheckedChanged += new System.EventHandler(this.opm_CheckedChanged);
            // 
            // txtrg
            // 
            this.txtrg.BeepOnError = true;
            this.txtrg.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(228, 218);
            this.txtrg.Mask = "00,000,000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(142, 22);
            this.txtrg.TabIndex = 3;
            // 
            // cbestadocivil
            // 
            this.cbestadocivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbestadocivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbestadocivil.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestadocivil.FormattingEnabled = true;
            this.cbestadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.cbestadocivil.Location = new System.Drawing.Point(381, 218);
            this.cbestadocivil.Name = "cbestadocivil";
            this.cbestadocivil.Size = new System.Drawing.Size(216, 22);
            this.cbestadocivil.TabIndex = 4;
            this.cbestadocivil.Validating += new System.ComponentModel.CancelEventHandler(this.cbestadocivil_Validating);
            // 
            // txtnascimento
            // 
            this.txtnascimento.BeepOnError = true;
            this.txtnascimento.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnascimento.HidePromptOnLeave = true;
            this.txtnascimento.Location = new System.Drawing.Point(603, 218);
            this.txtnascimento.Mask = "00/00/0000";
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(111, 22);
            this.txtnascimento.TabIndex = 5;
            this.txtnascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtnascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            this.txtnascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtnascimento_Validating);
            // 
            // txtcep
            // 
            this.txtcep.BeepOnError = true;
            this.txtcep.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.HidePromptOnLeave = true;
            this.txtcep.Location = new System.Drawing.Point(33, 304);
            this.txtcep.Mask = "00,000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(120, 22);
            this.txtcep.TabIndex = 6;
            this.txtcep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtcep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            this.txtcep.Validating += new System.ComponentModel.CancelEventHandler(this.txtcep_Validating);
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(637, 304);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(77, 22);
            this.txtnumero.TabIndex = 8;
            // 
            // txtcelular
            // 
            this.txtcelular.BeepOnError = true;
            this.txtcelular.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.HidePromptOnLeave = true;
            this.txtcelular.Location = new System.Drawing.Point(228, 437);
            this.txtcelular.Mask = "(00) 0 0000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(206, 22);
            this.txtcelular.TabIndex = 12;
            this.txtcelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(454, 436);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(260, 22);
            this.txtemail.TabIndex = 13;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(33, 504);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(681, 72);
            this.txtobs.TabIndex = 14;
            // 
            // cksituacao
            // 
            this.cksituacao.AutoSize = true;
            this.cksituacao.BackColor = System.Drawing.Color.Transparent;
            this.cksituacao.Checked = true;
            this.cksituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cksituacao.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cksituacao.Location = new System.Drawing.Point(176, 588);
            this.cksituacao.Name = "cksituacao";
            this.cksituacao.Size = new System.Drawing.Size(61, 18);
            this.cksituacao.TabIndex = 35;
            this.cksituacao.TabStop = false;
            this.cksituacao.Text = "Ativo";
            this.cksituacao.UseVisualStyleBackColor = false;
            // 
            // opf
            // 
            this.opf.AutoSize = true;
            this.opf.BackColor = System.Drawing.Color.Transparent;
            this.opf.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opf.Location = new System.Drawing.Point(97, 21);
            this.opf.Name = "opf";
            this.opf.Size = new System.Drawing.Size(81, 18);
            this.opf.TabIndex = 5;
            this.opf.Text = "Feminino";
            this.opf.UseVisualStyleBackColor = false;
            this.opf.CheckedChanged += new System.EventHandler(this.opf_CheckedChanged);
            // 
            // outros
            // 
            this.outros.AutoSize = true;
            this.outros.BackColor = System.Drawing.Color.Transparent;
            this.outros.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outros.Location = new System.Drawing.Point(184, 21);
            this.outros.Name = "outros";
            this.outros.Size = new System.Drawing.Size(67, 18);
            this.outros.TabIndex = 6;
            this.outros.Text = "Outros";
            this.outros.UseVisualStyleBackColor = false;
            this.outros.CheckedChanged += new System.EventHandler(this.outros_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.outros);
            this.panel1.Controls.Add(this.opm);
            this.panel1.Controls.Add(this.opf);
            this.panel1.Location = new System.Drawing.Point(399, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 47);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtdoc);
            this.panel2.Controls.Add(this.cpf);
            this.panel2.Controls.Add(this.cnpj);
            this.panel2.Location = new System.Drawing.Point(220, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 53);
            this.panel2.TabIndex = 1;
            // 
            // cbestado
            // 
            this.cbestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbestado.DropDownHeight = 200;
            this.cbestado.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestado.FormattingEnabled = true;
            this.cbestado.IntegralHeight = false;
            this.cbestado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espirito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso do Sul",
            "Mato Grosso",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbestado.Location = new System.Drawing.Point(33, 437);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(172, 22);
            this.cbestado.TabIndex = 11;
            this.cbestado.Validating += new System.ComponentModel.CancelEventHandler(this.cbestado_Validating);
            // 
            // cbendereco
            // 
            this.cbendereco.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbendereco.FormattingEnabled = true;
            this.cbendereco.Location = new System.Drawing.Point(175, 304);
            this.cbendereco.Name = "cbendereco";
            this.cbendereco.Size = new System.Drawing.Size(445, 22);
            this.cbendereco.TabIndex = 7;
            this.cbendereco.TextChanged += new System.EventHandler(this.cbendereco_TextChanged);
            // 
            // cbbairro
            // 
            this.cbbairro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbairro.FormattingEnabled = true;
            this.cbbairro.Location = new System.Drawing.Point(33, 372);
            this.cbbairro.Name = "cbbairro";
            this.cbbairro.Size = new System.Drawing.Size(338, 22);
            this.cbbairro.TabIndex = 9;
            this.cbbairro.SelectedIndexChanged += new System.EventHandler(this.cbbairro_SelectedIndexChanged);
            this.cbbairro.TextChanged += new System.EventHandler(this.cbbairro_TextChanged);
            // 
            // cbcidade
            // 
            this.cbcidade.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcidade.FormattingEnabled = true;
            this.cbcidade.Location = new System.Drawing.Point(381, 372);
            this.cbcidade.Name = "cbcidade";
            this.cbcidade.Size = new System.Drawing.Size(333, 22);
            this.cbcidade.TabIndex = 10;
            this.cbcidade.TextChanged += new System.EventHandler(this.cbcidade_TextChanged);
            // 
            // imgcliente
            // 
            this.imgcliente.BackColor = System.Drawing.Color.Transparent;
            this.imgcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgcliente.Image = global::WindowsFormsApp1.Properties.Resources.avatar_2092113_6401;
            this.imgcliente.Location = new System.Drawing.Point(33, 49);
            this.imgcliente.Name = "imgcliente";
            this.imgcliente.Size = new System.Drawing.Size(154, 191);
            this.imgcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgcliente.TabIndex = 44;
            this.imgcliente.TabStop = false;
            // 
            // btaddfoto
            // 
            this.btaddfoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btaddfoto.FlatAppearance.BorderSize = 0;
            this.btaddfoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btaddfoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaddfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddfoto.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddfoto.Image = global::WindowsFormsApp1.Properties.Resources.icons8_fotografia_16;
            this.btaddfoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaddfoto.Location = new System.Drawing.Point(33, 246);
            this.btaddfoto.Name = "btaddfoto";
            this.btaddfoto.Size = new System.Drawing.Size(88, 23);
            this.btaddfoto.TabIndex = 18;
            this.btaddfoto.TabStop = false;
            this.btaddfoto.Text = "Imagem";
            this.btaddfoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btaddfoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btaddfoto.UseVisualStyleBackColor = false;
            this.btaddfoto.Click += new System.EventHandler(this.btaddfoto_Click);
            // 
            // btremovefoto
            // 
            this.btremovefoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btremovefoto.FlatAppearance.BorderSize = 0;
            this.btremovefoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btremovefoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btremovefoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btremovefoto.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btremovefoto.Image = global::WindowsFormsApp1.Properties.Resources.icons8_fotografia_161;
            this.btremovefoto.Location = new System.Drawing.Point(130, 246);
            this.btremovefoto.Name = "btremovefoto";
            this.btremovefoto.Size = new System.Drawing.Size(57, 23);
            this.btremovefoto.TabIndex = 46;
            this.btremovefoto.TabStop = false;
            this.btremovefoto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btremovefoto.UseVisualStyleBackColor = false;
            this.btremovefoto.Click += new System.EventHandler(this.btremovefoto_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsair.FlatAppearance.BorderSize = 0;
            this.btsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.Location = new System.Drawing.Point(33, 624);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(75, 23);
            this.btsair.TabIndex = 47;
            this.btsair.TabStop = false;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnovo
            // 
            this.btnovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnovo.FlatAppearance.BorderSize = 0;
            this.btnovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnovo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnovo.Location = new System.Drawing.Point(130, 624);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(75, 23);
            this.btnovo.TabIndex = 48;
            this.btnovo.TabStop = false;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = false;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btsalvar.FlatAppearance.BorderSize = 0;
            this.btsalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btsalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.Location = new System.Drawing.Point(637, 624);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(75, 23);
            this.btsalvar.TabIndex = 15;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // formularioclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.azul_com_branco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 662);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btnovo);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btremovefoto);
            this.Controls.Add(this.btaddfoto);
            this.Controls.Add(this.imgcliente);
            this.Controls.Add(this.cbcidade);
            this.Controls.Add(this.cbbairro);
            this.Controls.Add(this.cbendereco);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cksituacao);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.cbestadocivil);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formularioclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.formularioclientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formularioclientes_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtdoc;
        private System.Windows.Forms.RadioButton cpf;
        private System.Windows.Forms.RadioButton cnpj;
        private System.Windows.Forms.RadioButton opm;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.ComboBox cbestadocivil;
        private System.Windows.Forms.MaskedTextBox txtnascimento;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.CheckBox cksituacao;
        private System.Windows.Forms.RadioButton opf;
        private System.Windows.Forms.RadioButton outros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.ComboBox cbendereco;
        private System.Windows.Forms.ComboBox cbbairro;
        private System.Windows.Forms.ComboBox cbcidade;
        private System.Windows.Forms.PictureBox imgcliente;
        private System.Windows.Forms.Button btaddfoto;
        private System.Windows.Forms.Button btremovefoto;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btnovo;
        private System.Windows.Forms.Button btsalvar;
    }
}

