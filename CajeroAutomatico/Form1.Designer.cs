namespace CajeroAutomatico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptrClosed = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptrClosed).BeginInit();
            SuspendLayout();
            // 
            // ptrClosed
            // 
            ptrClosed.Cursor = Cursors.Hand;
            ptrClosed.Image = (Image)resources.GetObject("ptrClosed.Image");
            ptrClosed.Location = new Point(792, 12);
            ptrClosed.Name = "ptrClosed";
            ptrClosed.Size = new Size(37, 35);
            ptrClosed.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrClosed.TabIndex = 0;
            ptrClosed.TabStop = false;
            ptrClosed.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(213, 120);
            button1.Name = "button1";
            button1.Size = new Size(157, 54);
            button1.TabIndex = 3;
            button1.Text = "RETIRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(213, 232);
            button2.Name = "button2";
            button2.Size = new Size(157, 54);
            button2.TabIndex = 4;
            button2.Text = "SALDO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(450, 120);
            button3.Name = "button3";
            button3.Size = new Size(157, 54);
            button3.TabIndex = 5;
            button3.Text = "CONSIGNAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(450, 232);
            button4.Name = "button4";
            button4.Size = new Size(157, 54);
            button4.TabIndex = 6;
            button4.Text = "SALIR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(841, 479);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ptrClosed);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)ptrClosed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptrClosed;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}