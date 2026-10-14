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
            btnIniciar = new Button();
            btnFechar = new Button();
            lblSaida = new Label();
            btnTeste = new Button();
            SuspendLayout();
            // 
            // chkAuto
            // 
            chkAuto.AutoSize = true;
            chkAuto.Location = new Point(308, 143);
            chkAuto.Name = "chkAuto";
            chkAuto.Size = new Size(192, 24);
            chkAuto.TabIndex = 19;
            chkAuto.Text = "Iniciar automaticamente";
            chkAuto.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(197, 178);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 18;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(197, 213);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 17;
            btnFechar.Text = "fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Location = new Point(14, 14);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(44, 20);
            lblSaida.TabIndex = 16;
            lblSaida.Text = "saida";
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(197, 143);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(94, 29);
            btnTeste.TabIndex = 15;
            btnTeste.Text = "Testar";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 257);
            Controls.Add(chkAuto);
            Controls.Add(btnIniciar);
            Controls.Add(btnFechar);
            Controls.Add(lblSaida);
            Controls.Add(btnTeste);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAuto;
        private Button btnIniciar;
        private Button btnFechar;
        private Label lblSaida;
        private Button btnTeste;
    }
}