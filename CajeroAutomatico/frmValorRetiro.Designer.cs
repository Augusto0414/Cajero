namespace CajeroAutomatico
{
    partial class frmValorRetiro
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
            txtSaldo = new TextBox();
            button1 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 58);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 1;
            label1.Text = "DIGITE VALOR A RETIRAR";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(260, 139);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(238, 23);
            txtSaldo.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(260, 206);
            button1.Name = "button1";
            button1.Size = new Size(238, 40);
            button1.TabIndex = 3;
            button1.Text = "RETIRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(24, 331);
            button9.Name = "button9";
            button9.Size = new Size(123, 34);
            button9.TabIndex = 10;
            button9.Text = "INICIO";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // frmValorRetiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 389);
            Controls.Add(button9);
            Controls.Add(button1);
            Controls.Add(txtSaldo);
            Controls.Add(label1);
            Cursor = Cursors.IBeam;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmValorRetiro";
            Text = "frmValorRetiro";
            MouseMove += frmValorRetiro_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSaldo;
        private Button button1;
        private Button button9;
    }
}