namespace CajeroAutomatico
{
    partial class frmHistorial
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
            button9 = new Button();
            dataGridView1 = new DataGridView();
            cienMil = new DataGridViewTextBoxColumn();
            cinCuentaMil = new DataGridViewTextBoxColumn();
            veinteMil = new DataGridViewTextBoxColumn();
            diezMil = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblConsignacion = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 38);
            label1.Name = "label1";
            label1.Size = new Size(290, 25);
            label1.TabIndex = 1;
            label1.Text = "HISTORIAL DE CONSIGNACIÓN";
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.Location = new Point(37, 364);
            button9.Name = "button9";
            button9.Size = new Size(123, 34);
            button9.TabIndex = 10;
            button9.Text = "REGRESAR";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cienMil, cinCuentaMil, veinteMil, diezMil });
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(37, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(450, 112);
            dataGridView1.TabIndex = 11;
            // 
            // cienMil
            // 
            cienMil.HeaderText = "$100.000";
            cienMil.Name = "cienMil";
            cienMil.ReadOnly = true;
            // 
            // cinCuentaMil
            // 
            cinCuentaMil.HeaderText = "$50.000";
            cinCuentaMil.Name = "cinCuentaMil";
            cinCuentaMil.ReadOnly = true;
            // 
            // veinteMil
            // 
            veinteMil.HeaderText = "$20.000";
            veinteMil.Name = "veinteMil";
            veinteMil.ReadOnly = true;
            // 
            // diezMil
            // 
            diezMil.HeaderText = "$10.000";
            diezMil.Name = "diezMil";
            diezMil.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 81);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 12;
            label2.Text = "Número de retiro: ";
            // 
            // lblConsignacion
            // 
            lblConsignacion.AutoSize = true;
            lblConsignacion.Location = new Point(156, 81);
            lblConsignacion.Name = "lblConsignacion";
            lblConsignacion.Size = new Size(13, 15);
            lblConsignacion.TabIndex = 13;
            lblConsignacion.Text = "0";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(37, 265);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(450, 73);
            dataGridView2.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "$100.000";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "$50.000";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "$20.000";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "$10.000";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 235);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 15;
            label3.Text = "Total de billetes retirados:";
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 410);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(lblConsignacion);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button9);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorial";
            Text = "frmValorRetiro";
            MouseMove += frmValorRetiro_MouseMove;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button9;
        private DataGridView dataGridView1;
        private Label label2;
        private Label lblConsignacion;
        private DataGridViewTextBoxColumn cienMil;
        private DataGridViewTextBoxColumn cinCuentaMil;
        private DataGridViewTextBoxColumn veinteMil;
        private DataGridViewTextBoxColumn diezMil;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label3;
    }
}