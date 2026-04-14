namespace ejercicio_2
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
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(163, 191);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Agragar nafta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(24, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(117, 409);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(264, 66);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(117, 409);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(264, 491);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(578, 65);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Vender";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(455, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(726, 69);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 6;
            label1.Text = "Total vendido: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 556);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Vendido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 597);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 8;
            label3.Text = "Surtidor que mas recaudo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 639);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 9;
            label4.Text = "Surtidor que menos recaudo: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 678);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 10;
            label5.Text = "Surtidor con mas clientes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 556);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 11;
            label6.Text = "label";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 597);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 12;
            label7.Text = "label";
            // 
            // button4
            // 
            button4.Location = new Point(455, 173);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Recargar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(455, 246);
            label8.Name = "label8";
            label8.Size = new Size(161, 15);
            label8.TabIndex = 14;
            label8.Text = "El surtidor con mas recargas: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(455, 359);
            label9.Name = "label9";
            label9.Size = new Size(146, 15);
            label9.TabIndex = 15;
            label9.Text = "Promedio de recaudacion:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(455, 310);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 16;
            label10.Text = "Promedio de ventas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 984);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button4;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
