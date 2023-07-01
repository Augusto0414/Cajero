namespace CajeroAutomatico
{
    partial class frmConsultarSaldo
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
            label1 = new Label();
            lblSaldo = new Label();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(291, 70);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 1;
            label1.Text = "SALDO ACTUAL";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.Location = new Point(210, 120);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(32, 25);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "$0";
            // 
            // button9
            // 
            button9.Location = new Point(45, 348);
            button9.Name = "button9";
            button9.Size = new Size(116, 34);
            button9.TabIndex = 10;
            button9.Text = "Regresar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // frmConsultarSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultarSaldo";
            Text = "frmConsultarSaldo";
            Load += frmConsultarSaldo_Load;
            MouseMove += frmConsultarSaldo_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSaldo;
        private Button button9;
    }
}