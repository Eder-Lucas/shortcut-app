namespace quickRun
{
    partial class frmPrincipal
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
            chkAuto = new CheckBox();
            lblSaida = new Label();
            btnTeste = new Label();
            btnIniciar = new Label();
            btnFechar = new Label();
            lbl_processo = new Label();
            lbl_fechar = new Label();
            SuspendLayout();
            // 
            // chkAuto
            // 
            chkAuto.AutoSize = true;
            chkAuto.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAuto.ForeColor = Color.White;
            chkAuto.Location = new Point(308, 143);
            chkAuto.Name = "chkAuto";
            chkAuto.Size = new Size(205, 23);
            chkAuto.TabIndex = 19;
            chkAuto.Text = "Iniciar automaticamente";
            chkAuto.UseVisualStyleBackColor = true;
            chkAuto.CheckedChanged += chkAuto_CheckedChanged;
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaida.ForeColor = Color.White;
            lblSaida.Location = new Point(14, 14);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(48, 19);
            lblSaida.TabIndex = 16;
            lblSaida.Text = "saida";
            // 
            // btnTeste
            // 
            btnTeste.AutoSize = true;
            btnTeste.BackColor = Color.FromArgb(36, 36, 36);
            btnTeste.BorderStyle = BorderStyle.FixedSingle;
            btnTeste.Cursor = Cursors.Hand;
            btnTeste.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeste.ForeColor = Color.WhiteSmoke;
            btnTeste.Location = new Point(201, 139);
            btnTeste.Name = "btnTeste";
            btnTeste.Padding = new Padding(21, 3, 21, 3);
            btnTeste.Size = new Size(96, 27);
            btnTeste.TabIndex = 20;
            btnTeste.Text = "Testar";
            btnTeste.Click += btnTeste_Click;
            btnTeste.MouseEnter += HoverBotoesEntrada;
            btnTeste.MouseLeave += HoverBotoesSaida;
            // 
            // btnIniciar
            // 
            btnIniciar.AutoSize = true;
            btnIniciar.BackColor = Color.FromArgb(36, 36, 36);
            btnIniciar.BorderStyle = BorderStyle.FixedSingle;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.WhiteSmoke;
            btnIniciar.Location = new Point(201, 180);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Padding = new Padding(20, 3, 20, 3);
            btnIniciar.Size = new Size(97, 27);
            btnIniciar.TabIndex = 20;
            btnIniciar.Text = "Iniciar";
            btnIniciar.Click += btnIniciar_Click;
            btnIniciar.MouseEnter += HoverBotoesEntrada;
            btnIniciar.MouseLeave += HoverBotoesSaida;
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = true;
            btnFechar.BackColor = Color.FromArgb(36, 36, 36);
            btnFechar.BorderStyle = BorderStyle.FixedSingle;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.WhiteSmoke;
            btnFechar.Location = new Point(201, 221);
            btnFechar.Name = "btnFechar";
            btnFechar.Padding = new Padding(17, 3, 17, 3);
            btnFechar.Size = new Size(97, 27);
            btnFechar.TabIndex = 20;
            btnFechar.Text = "Fechar";
            btnFechar.Click += btnFechar_Click;
            btnFechar.MouseEnter += HoverBotoesEntrada;
            btnFechar.MouseLeave += HoverBotoesSaida;
            // 
            // lbl_processo
            // 
            lbl_processo.AutoSize = true;
            lbl_processo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_processo.ForeColor = Color.White;
            lbl_processo.Location = new Point(12, 55);
            lbl_processo.Name = "lbl_processo";
            lbl_processo.Size = new Size(0, 19);
            lbl_processo.TabIndex = 16;
            // 
            // lbl_fechar
            // 
            lbl_fechar.AutoSize = true;
            lbl_fechar.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fechar.ForeColor = Color.White;
            lbl_fechar.Location = new Point(12, 103);
            lbl_fechar.Name = "lbl_fechar";
            lbl_fechar.Size = new Size(0, 19);
            lbl_fechar.TabIndex = 16;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(514, 257);
            Controls.Add(btnFechar);
            Controls.Add(btnIniciar);
            Controls.Add(btnTeste);
            Controls.Add(chkAuto);
            Controls.Add(lbl_fechar);
            Controls.Add(lbl_processo);
            Controls.Add(lblSaida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shot Cut - Control Center";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAuto;
        private Label lblSaida;
        private Label btnTeste;
        private Label btnIniciar;
        private Label btnFechar;
        private Label lbl_processo;
        private Label lbl_fechar;
    }
}