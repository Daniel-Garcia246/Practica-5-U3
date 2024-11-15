namespace Practica_5_U3
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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            label7=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            textBox4=new TextBox();
            textBox5=new TextBox();
            textBox6=new TextBox();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            pictureBox1=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(254, 22);
            label1.Name="label1";
            label1.Size=new Size(218, 15);
            label1.TabIndex=0;
            label1.Text="Introduce las dimensiones del cilindrdro";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(156, 58);
            label2.Name="label2";
            label2.Size=new Size(37, 15);
            label2.TabIndex=1;
            label2.Text="Radio";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(156, 102);
            label3.Name="label3";
            label3.Size=new Size(39, 15);
            label3.TabIndex=2;
            label3.Text="Altura";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(156, 211);
            label4.Name="label4";
            label4.Size=new Size(56, 15);
            label4.TabIndex=3;
            label4.Text="Base área";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(156, 249);
            label5.Name="label5";
            label5.Size=new Size(67, 15);
            label5.TabIndex=4;
            label5.Text="Lateral área";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(156, 282);
            label6.Name="label6";
            label6.Size=new Size(58, 15);
            label6.TabIndex=5;
            label6.Text="Total área";
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(156, 320);
            label7.Name="label7";
            label7.Size=new Size(54, 15);
            label7.TabIndex=6;
            label7.Text="Volumen";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(323, 55);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=7;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(323, 99);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(100, 23);
            textBox2.TabIndex=8;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(323, 208);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(100, 23);
            textBox3.TabIndex=9;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(323, 246);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(100, 23);
            textBox4.TabIndex=10;
            // 
            // textBox5
            // 
            textBox5.Location=new Point(323, 279);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(100, 23);
            textBox5.TabIndex=11;
            // 
            // textBox6
            // 
            textBox6.Location=new Point(323, 317);
            textBox6.Name="textBox6";
            textBox6.Size=new Size(100, 23);
            textBox6.TabIndex=12;
            // 
            // button1
            // 
            button1.Location=new Point(151, 152);
            button1.Name="button1";
            button1.Size=new Size(75, 23);
            button1.TabIndex=13;
            button1.Text="Calcular";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(335, 152);
            button2.Name="button2";
            button2.Size=new Size(75, 23);
            button2.TabIndex=14;
            button2.Text="Borrar";
            button2.UseVisualStyleBackColor=true;
            // 
            // button3
            // 
            button3.Location=new Point(489, 152);
            button3.Name="button3";
            button3.Size=new Size(75, 23);
            button3.TabIndex=15;
            button3.Text="Salir";
            button3.UseVisualStyleBackColor=true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.cilindro;
            pictureBox1.Location=new Point(472, 208);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(169, 158);
            pictureBox1.TabIndex=16;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}