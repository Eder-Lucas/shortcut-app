namespace quickRun
{
    partial class frmPrincipal
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
            btnTeste = new Button();
            lblSaida = new Label();
            button1 = new Button();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(441, 216);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(94, 29);
            btnTeste.TabIndex = 0;
            btnTeste.Text = "Testar";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Location = new Point(12, 9);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(44, 20);
            lblSaida.TabIndex = 1;
            lblSaida.Text = "saida";
            // 
            // button1
            // 
            button1.Location = new Point(299, 216);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(446, 110);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Controls.Add(button1);
            Controls.Add(lblSaida);
            Controls.Add(btnTeste);
            Name = "frmPrincipal";
            Text = "Form principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTeste;
        private Label lblSaida;
        private Button button1;
        private Button btnIniciar;
    }
}
