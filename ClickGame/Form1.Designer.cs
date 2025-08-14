namespace ClickGame
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(0, 176);
            button1.Name = "button1";
            button1.Size = new Size(800, 274);
            button1.TabIndex = 0;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.Location = new Point(29, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(190, 54);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "0";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "30", "60" });
            comboBox1.Location = new Point(299, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(29, 125);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 3;
            label1.Text = "Remaining time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(196, 125);
            label2.Name = "label2";
            label2.Size = new Size(23, 28);
            label2.TabIndex = 4;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(568, 60);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(191, 93);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(602, 18);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 6;
            label3.Text = "Your Scores:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(328, 18);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 7;
            label4.Text = "Select Time:";
            // 
            // button2
            // 
            button2.Location = new Point(328, 119);
            button2.Name = "button2";
            button2.Size = new Size(126, 46);
            button2.TabIndex = 8;
            button2.Text = "Start Again";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(88, 18);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 9;
            label5.Text = "Score:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Click Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
    }
}
