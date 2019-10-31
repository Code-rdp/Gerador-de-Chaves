namespace Gerador_de_Chaves
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_chave = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.Grup_mes = new System.Windows.Forms.GroupBox();
            this.rd_4meses = new System.Windows.Forms.RadioButton();
            this.rd_2meses = new System.Windows.Forms.RadioButton();
            this.rd_3meses = new System.Windows.Forms.RadioButton();
            this.rd_1mes = new System.Windows.Forms.RadioButton();
            this.lb_texto_quantidades = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_data = new System.Windows.Forms.RadioButton();
            this.rd_mes = new System.Windows.Forms.RadioButton();
            this.rd_dias = new System.Windows.Forms.RadioButton();
            this.Grup_dias = new System.Windows.Forms.GroupBox();
            this.rd_120 = new System.Windows.Forms.RadioButton();
            this.rd_110 = new System.Windows.Forms.RadioButton();
            this.rd_100 = new System.Windows.Forms.RadioButton();
            this.rd_90 = new System.Windows.Forms.RadioButton();
            this.rd_80 = new System.Windows.Forms.RadioButton();
            this.rd_70 = new System.Windows.Forms.RadioButton();
            this.rd_60 = new System.Windows.Forms.RadioButton();
            this.rd_50 = new System.Windows.Forms.RadioButton();
            this.rd_40 = new System.Windows.Forms.RadioButton();
            this.rd_30 = new System.Windows.Forms.RadioButton();
            this.rd_20 = new System.Windows.Forms.RadioButton();
            this.rd_10 = new System.Windows.Forms.RadioButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Grup_mes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Grup_dias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 31);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gerador de Licença";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_chave);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(501, 434);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(487, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gerar Chave";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(7, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chave de Liberação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_chave
            // 
            this.txt_chave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_chave.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_chave.Location = new System.Drawing.Point(7, 370);
            this.txt_chave.Multiline = true;
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.ReadOnly = true;
            this.txt_chave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_chave.Size = new System.Drawing.Size(487, 57);
            this.txt_chave.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(487, 286);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Data);
            this.panel4.Controls.Add(this.Grup_mes);
            this.panel4.Controls.Add(this.lb_texto_quantidades);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.Grup_dias);
            this.panel4.Controls.Add(this.txt_id);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(483, 282);
            this.panel4.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.Location = new System.Drawing.Point(247, 79);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(228, 25);
            this.Data.TabIndex = 14;
            // 
            // Grup_mes
            // 
            this.Grup_mes.Controls.Add(this.rd_4meses);
            this.Grup_mes.Controls.Add(this.rd_2meses);
            this.Grup_mes.Controls.Add(this.rd_3meses);
            this.Grup_mes.Controls.Add(this.rd_1mes);
            this.Grup_mes.Location = new System.Drawing.Point(247, 110);
            this.Grup_mes.Name = "Grup_mes";
            this.Grup_mes.Size = new System.Drawing.Size(228, 67);
            this.Grup_mes.TabIndex = 13;
            this.Grup_mes.TabStop = false;
            // 
            // rd_4meses
            // 
            this.rd_4meses.AutoSize = true;
            this.rd_4meses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_4meses.Location = new System.Drawing.Point(103, 38);
            this.rd_4meses.Name = "rd_4meses";
            this.rd_4meses.Size = new System.Drawing.Size(72, 19);
            this.rd_4meses.TabIndex = 6;
            this.rd_4meses.TabStop = true;
            this.rd_4meses.Text = "4 Meses";
            this.rd_4meses.UseVisualStyleBackColor = true;
            // 
            // rd_2meses
            // 
            this.rd_2meses.AutoSize = true;
            this.rd_2meses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_2meses.Location = new System.Drawing.Point(103, 13);
            this.rd_2meses.Name = "rd_2meses";
            this.rd_2meses.Size = new System.Drawing.Size(72, 19);
            this.rd_2meses.TabIndex = 5;
            this.rd_2meses.TabStop = true;
            this.rd_2meses.Text = "2 Meses";
            this.rd_2meses.UseVisualStyleBackColor = true;
            // 
            // rd_3meses
            // 
            this.rd_3meses.AutoSize = true;
            this.rd_3meses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_3meses.Location = new System.Drawing.Point(6, 38);
            this.rd_3meses.Name = "rd_3meses";
            this.rd_3meses.Size = new System.Drawing.Size(72, 19);
            this.rd_3meses.TabIndex = 2;
            this.rd_3meses.TabStop = true;
            this.rd_3meses.Text = "3 Meses";
            this.rd_3meses.UseVisualStyleBackColor = true;
            // 
            // rd_1mes
            // 
            this.rd_1mes.AutoSize = true;
            this.rd_1mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_1mes.Location = new System.Drawing.Point(6, 13);
            this.rd_1mes.Name = "rd_1mes";
            this.rd_1mes.Size = new System.Drawing.Size(58, 19);
            this.rd_1mes.TabIndex = 1;
            this.rd_1mes.TabStop = true;
            this.rd_1mes.Text = "1 Mês";
            this.rd_1mes.UseVisualStyleBackColor = true;
            // 
            // lb_texto_quantidades
            // 
            this.lb_texto_quantidades.AutoSize = true;
            this.lb_texto_quantidades.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lb_texto_quantidades.Location = new System.Drawing.Point(30, 140);
            this.lb_texto_quantidades.Name = "lb_texto_quantidades";
            this.lb_texto_quantidades.Size = new System.Drawing.Size(0, 17);
            this.lb_texto_quantidades.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_data);
            this.groupBox2.Controls.Add(this.rd_mes);
            this.groupBox2.Controls.Add(this.rd_dias);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Ativação";
            // 
            // rd_data
            // 
            this.rd_data.AutoSize = true;
            this.rd_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_data.Location = new System.Drawing.Point(135, 29);
            this.rd_data.Name = "rd_data";
            this.rd_data.Size = new System.Drawing.Size(57, 21);
            this.rd_data.TabIndex = 2;
            this.rd_data.TabStop = true;
            this.rd_data.Text = "Data";
            this.rd_data.UseVisualStyleBackColor = true;
            this.rd_data.CheckedChanged += new System.EventHandler(this.rd_data_CheckedChanged);
            // 
            // rd_mes
            // 
            this.rd_mes.AutoSize = true;
            this.rd_mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_mes.Location = new System.Drawing.Point(66, 29);
            this.rd_mes.Name = "rd_mes";
            this.rd_mes.Size = new System.Drawing.Size(53, 21);
            this.rd_mes.TabIndex = 1;
            this.rd_mes.TabStop = true;
            this.rd_mes.Text = "Mês";
            this.rd_mes.UseVisualStyleBackColor = true;
            this.rd_mes.CheckedChanged += new System.EventHandler(this.rd_mes_CheckedChanged);
            // 
            // rd_dias
            // 
            this.rd_dias.AutoSize = true;
            this.rd_dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_dias.Location = new System.Drawing.Point(6, 29);
            this.rd_dias.Name = "rd_dias";
            this.rd_dias.Size = new System.Drawing.Size(48, 21);
            this.rd_dias.TabIndex = 0;
            this.rd_dias.TabStop = true;
            this.rd_dias.Text = "Dia";
            this.rd_dias.UseVisualStyleBackColor = true;
            this.rd_dias.CheckedChanged += new System.EventHandler(this.rd_dias_CheckedChanged);
            // 
            // Grup_dias
            // 
            this.Grup_dias.Controls.Add(this.rd_120);
            this.Grup_dias.Controls.Add(this.rd_110);
            this.Grup_dias.Controls.Add(this.rd_100);
            this.Grup_dias.Controls.Add(this.rd_90);
            this.Grup_dias.Controls.Add(this.rd_80);
            this.Grup_dias.Controls.Add(this.rd_70);
            this.Grup_dias.Controls.Add(this.rd_60);
            this.Grup_dias.Controls.Add(this.rd_50);
            this.Grup_dias.Controls.Add(this.rd_40);
            this.Grup_dias.Controls.Add(this.rd_30);
            this.Grup_dias.Controls.Add(this.rd_20);
            this.Grup_dias.Controls.Add(this.rd_10);
            this.Grup_dias.Location = new System.Drawing.Point(13, 157);
            this.Grup_dias.Name = "Grup_dias";
            this.Grup_dias.Size = new System.Drawing.Size(228, 117);
            this.Grup_dias.TabIndex = 8;
            this.Grup_dias.TabStop = false;
            // 
            // rd_120
            // 
            this.rd_120.AutoSize = true;
            this.rd_120.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_120.Location = new System.Drawing.Point(149, 88);
            this.rd_120.Name = "rd_120";
            this.rd_120.Size = new System.Drawing.Size(75, 19);
            this.rd_120.TabIndex = 12;
            this.rd_120.TabStop = true;
            this.rd_120.Text = "120 Dias";
            this.rd_120.UseVisualStyleBackColor = true;
            // 
            // rd_110
            // 
            this.rd_110.AutoSize = true;
            this.rd_110.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_110.Location = new System.Drawing.Point(149, 63);
            this.rd_110.Name = "rd_110";
            this.rd_110.Size = new System.Drawing.Size(74, 19);
            this.rd_110.TabIndex = 11;
            this.rd_110.TabStop = true;
            this.rd_110.Text = "110 Dias";
            this.rd_110.UseVisualStyleBackColor = true;
            // 
            // rd_100
            // 
            this.rd_100.AutoSize = true;
            this.rd_100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_100.Location = new System.Drawing.Point(149, 38);
            this.rd_100.Name = "rd_100";
            this.rd_100.Size = new System.Drawing.Size(75, 19);
            this.rd_100.TabIndex = 10;
            this.rd_100.TabStop = true;
            this.rd_100.Text = "100 Dias";
            this.rd_100.UseVisualStyleBackColor = true;
            // 
            // rd_90
            // 
            this.rd_90.AutoSize = true;
            this.rd_90.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_90.Location = new System.Drawing.Point(149, 13);
            this.rd_90.Name = "rd_90";
            this.rd_90.Size = new System.Drawing.Size(68, 19);
            this.rd_90.TabIndex = 9;
            this.rd_90.TabStop = true;
            this.rd_90.Text = "90 Dias";
            this.rd_90.UseVisualStyleBackColor = true;
            // 
            // rd_80
            // 
            this.rd_80.AutoSize = true;
            this.rd_80.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_80.Location = new System.Drawing.Point(80, 88);
            this.rd_80.Name = "rd_80";
            this.rd_80.Size = new System.Drawing.Size(68, 19);
            this.rd_80.TabIndex = 8;
            this.rd_80.TabStop = true;
            this.rd_80.Text = "80 Dias";
            this.rd_80.UseVisualStyleBackColor = true;
            // 
            // rd_70
            // 
            this.rd_70.AutoSize = true;
            this.rd_70.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_70.Location = new System.Drawing.Point(80, 63);
            this.rd_70.Name = "rd_70";
            this.rd_70.Size = new System.Drawing.Size(68, 19);
            this.rd_70.TabIndex = 7;
            this.rd_70.TabStop = true;
            this.rd_70.Text = "70 Dias";
            this.rd_70.UseVisualStyleBackColor = true;
            // 
            // rd_60
            // 
            this.rd_60.AutoSize = true;
            this.rd_60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_60.Location = new System.Drawing.Point(80, 38);
            this.rd_60.Name = "rd_60";
            this.rd_60.Size = new System.Drawing.Size(68, 19);
            this.rd_60.TabIndex = 6;
            this.rd_60.TabStop = true;
            this.rd_60.Text = "60 Dias";
            this.rd_60.UseVisualStyleBackColor = true;
            // 
            // rd_50
            // 
            this.rd_50.AutoSize = true;
            this.rd_50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_50.Location = new System.Drawing.Point(80, 13);
            this.rd_50.Name = "rd_50";
            this.rd_50.Size = new System.Drawing.Size(68, 19);
            this.rd_50.TabIndex = 5;
            this.rd_50.TabStop = true;
            this.rd_50.Text = "50 Dias";
            this.rd_50.UseVisualStyleBackColor = true;
            // 
            // rd_40
            // 
            this.rd_40.AutoSize = true;
            this.rd_40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_40.Location = new System.Drawing.Point(6, 88);
            this.rd_40.Name = "rd_40";
            this.rd_40.Size = new System.Drawing.Size(68, 19);
            this.rd_40.TabIndex = 4;
            this.rd_40.TabStop = true;
            this.rd_40.Text = "40 Dias";
            this.rd_40.UseVisualStyleBackColor = true;
            // 
            // rd_30
            // 
            this.rd_30.AutoSize = true;
            this.rd_30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_30.Location = new System.Drawing.Point(6, 63);
            this.rd_30.Name = "rd_30";
            this.rd_30.Size = new System.Drawing.Size(68, 19);
            this.rd_30.TabIndex = 3;
            this.rd_30.TabStop = true;
            this.rd_30.Text = "30 Dias";
            this.rd_30.UseVisualStyleBackColor = true;
            // 
            // rd_20
            // 
            this.rd_20.AutoSize = true;
            this.rd_20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_20.Location = new System.Drawing.Point(6, 38);
            this.rd_20.Name = "rd_20";
            this.rd_20.Size = new System.Drawing.Size(68, 19);
            this.rd_20.TabIndex = 2;
            this.rd_20.TabStop = true;
            this.rd_20.Text = "20 Dias";
            this.rd_20.UseVisualStyleBackColor = true;
            // 
            // rd_10
            // 
            this.rd_10.AutoSize = true;
            this.rd_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_10.Location = new System.Drawing.Point(6, 13);
            this.rd_10.Name = "rd_10";
            this.rd_10.Size = new System.Drawing.Size(68, 19);
            this.rd_10.TabIndex = 1;
            this.rd_10.TabStop = true;
            this.rd_10.Text = "10 Dias";
            this.rd_10.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_id.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(5, 36);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(473, 25);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID da Instalação";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Licença";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Atalhos);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Grup_mes.ResumeLayout(false);
            this.Grup_mes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Grup_dias.ResumeLayout(false);
            this.Grup_dias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_chave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox Grup_dias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_dias;
        private System.Windows.Forms.RadioButton rd_mes;
        private System.Windows.Forms.RadioButton rd_data;
        private System.Windows.Forms.RadioButton rd_10;
        private System.Windows.Forms.RadioButton rd_20;
        private System.Windows.Forms.RadioButton rd_30;
        private System.Windows.Forms.RadioButton rd_40;
        private System.Windows.Forms.RadioButton rd_120;
        private System.Windows.Forms.RadioButton rd_110;
        private System.Windows.Forms.RadioButton rd_100;
        private System.Windows.Forms.RadioButton rd_90;
        private System.Windows.Forms.RadioButton rd_80;
        private System.Windows.Forms.RadioButton rd_70;
        private System.Windows.Forms.RadioButton rd_60;
        private System.Windows.Forms.RadioButton rd_50;
        private System.Windows.Forms.Label lb_texto_quantidades;
        private System.Windows.Forms.GroupBox Grup_mes;
        private System.Windows.Forms.RadioButton rd_4meses;
        private System.Windows.Forms.RadioButton rd_2meses;
        private System.Windows.Forms.RadioButton rd_3meses;
        private System.Windows.Forms.RadioButton rd_1mes;
        private System.Windows.Forms.DateTimePicker Data;
    }
}

