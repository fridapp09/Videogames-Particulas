namespace Clase6_Particles
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
            components = new System.ComponentModel.Container();
            PCT_CANVAS = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            TXT_BALLS_AMOUNT = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PCT_CANVAS).BeginInit();
            SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            PCT_CANVAS.BackColor = Color.Black;
            PCT_CANVAS.Dock = DockStyle.Fill;
            PCT_CANVAS.Location = new Point(0, 0);
            PCT_CANVAS.Name = "PCT_CANVAS";
            PCT_CANVAS.Size = new Size(800, 450);
            PCT_CANVAS.TabIndex = 0;
            PCT_CANVAS.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // TXT_BALLS_AMOUNT
            // 
            TXT_BALLS_AMOUNT.Location = new Point(130, 12);
            TXT_BALLS_AMOUNT.Name = "TXT_BALLS_AMOUNT";
            TXT_BALLS_AMOUNT.ReadOnly = true;
            TXT_BALLS_AMOUNT.Size = new Size(34, 23);
            TXT_BALLS_AMOUNT.TabIndex = 1;
            TXT_BALLS_AMOUNT.Text = "15";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Número de pelotas:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TXT_BALLS_AMOUNT);
            Controls.Add(PCT_CANVAS);
            Name = "Form1";
            Text = "Partículas";
            ((System.ComponentModel.ISupportInitialize)PCT_CANVAS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PCT_CANVAS;
        private System.Windows.Forms.Timer timer1;
        private TextBox TXT_BALLS_AMOUNT;
        private Label label1;
    }
}
