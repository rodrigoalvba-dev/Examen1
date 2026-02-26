namespace Examen1
{
    partial class FormSueldo
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
            textBox1 = new TextBox();
            buttCAp = new Button();
            label1 = new Label();
            labelISR = new Label();
            label3 = new Label();
            label2 = new Label();
            labelSueNet = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // buttCAp
            // 
            buttCAp.Location = new Point(38, 157);
            buttCAp.Name = "buttCAp";
            buttCAp.Size = new Size(94, 29);
            buttCAp.TabIndex = 1;
            buttCAp.Text = "Capturar";
            buttCAp.UseVisualStyleBackColor = true;
            buttCAp.Click += buttCAp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 2;
            label1.Text = "Sueldo del trabajador:";
            // 
            // labelISR
            // 
            labelISR.AutoSize = true;
            labelISR.Location = new Point(236, 99);
            labelISR.Name = "labelISR";
            labelISR.Size = new Size(37, 20);
            labelISR.TabIndex = 3;
            labelISR.Text = " ISR:";
            labelISR.Click += this.labelISR_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 90);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            label2.Click += this.label2_Click;
            // 
            // labelSueNet
            // 
            labelSueNet.AutoSize = true;
            labelSueNet.Location = new Point(236, 166);
            labelSueNet.Name = "labelSueNet";
            labelSueNet.Size = new Size(92, 20);
            labelSueNet.TabIndex = 6;
            labelSueNet.Text = "Sueldo neto:";
            // 
            // FormSueldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 236);
            Controls.Add(labelSueNet);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(labelISR);
            Controls.Add(label1);
            Controls.Add(buttCAp);
            Controls.Add(textBox1);
            Name = "FormSueldo";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttCAp;
        private Label label1;
        private Label labelISR;
        private Label label3;
        private Label label2;
        private Label labelSueNet;
    }
}
