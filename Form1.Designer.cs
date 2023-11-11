namespace Suma_los_números_capturados_3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SG Alternative High-Alt", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(118, 21);
            label1.Name = "label1";
            label1.Size = new Size(446, 25);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los números capurados ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(105, 75);
            label2.Name = "label2";
            label2.Size = new Size(198, 22);
            label2.TabIndex = 1;
            label2.Text = "Introduce un número ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(105, 208);
            label3.Name = "label3";
            label3.Size = new Size(201, 22);
            label3.TabIndex = 2;
            label3.Text = "La suma de todos son:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(444, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 124);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(322, 103);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 6;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(309, 236);
            button2.Name = "button2";
            button2.Size = new Size(100, 26);
            button2.TabIndex = 7;
            button2.Text = "Sumatoria";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}