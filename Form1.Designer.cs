
namespace Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textOutput = new TextBox();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.Location = new Point(46, 368);
            button1.Name = "button1";
            button1.Size = new Size(94, 84);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new Point(136, 368);
            button2.Name = "button2";
            button2.Size = new Size(94, 84);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.Location = new Point(46, 458);
            button3.Name = "button3";
            button3.Size = new Size(184, 84);
            button3.TabIndex = 2;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.Location = new Point(228, 458);
            button4.Name = "button4";
            button4.Size = new Size(94, 84);
            button4.TabIndex = 3;
            button4.Text = ".";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_click;
            // 
            // textOutput
            // 
            textOutput.Location = new Point(12, 39);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(433, 86);
            textOutput.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Font = new Font("Segoe UI", 13.8F);
            button5.Location = new Point(318, 458);
            button5.Name = "button5";
            button5.Size = new Size(94, 84);
            button5.TabIndex = 8;
            button5.Text = "=";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Equals_click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 0);
            button7.Font = new Font("Segoe UI", 13.8F);
            button7.Location = new Point(318, 368);
            button7.Name = "button7";
            button7.Size = new Size(94, 84);
            button7.TabIndex = 6;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F);
            button8.Location = new Point(228, 368);
            button8.Name = "button8";
            button8.Size = new Size(94, 84);
            button8.TabIndex = 5;
            button8.Text = "3";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.Font = new Font("Segoe UI", 13.8F);
            button9.Location = new Point(318, 290);
            button9.Name = "button9";
            button9.Size = new Size(94, 84);
            button9.TabIndex = 16;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 13.8F);
            button10.Location = new Point(228, 290);
            button10.Name = "button10";
            button10.Size = new Size(94, 84);
            button10.TabIndex = 15;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 128, 0);
            button11.Font = new Font("Segoe UI", 13.8F);
            button11.Location = new Point(318, 216);
            button11.Name = "button11";
            button11.Size = new Size(94, 84);
            button11.TabIndex = 14;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button_click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 13.8F);
            button12.Location = new Point(228, 216);
            button12.Name = "button12";
            button12.Size = new Size(94, 84);
            button12.TabIndex = 13;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 13.8F);
            button13.Location = new Point(136, 290);
            button13.Name = "button13";
            button13.Size = new Size(94, 84);
            button13.TabIndex = 12;
            button13.Text = "5";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 13.8F);
            button14.Location = new Point(46, 290);
            button14.Name = "button14";
            button14.Size = new Size(94, 84);
            button14.TabIndex = 11;
            button14.Text = "4";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 13.8F);
            button15.Location = new Point(136, 216);
            button15.Name = "button15";
            button15.Size = new Size(94, 84);
            button15.TabIndex = 10;
            button15.Text = "8";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 13.8F);
            button16.Location = new Point(46, 216);
            button16.Name = "button16";
            button16.Size = new Size(94, 84);
            button16.TabIndex = 9;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button_click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(255, 128, 0);
            button17.Font = new Font("Segoe UI", 13.8F);
            button17.Location = new Point(318, 137);
            button17.Name = "button17";
            button17.Size = new Size(94, 84);
            button17.TabIndex = 20;
            button17.Text = "/";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button_click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 13.8F);
            button18.Location = new Point(228, 137);
            button18.Name = "button18";
            button18.Size = new Size(94, 84);
            button18.TabIndex = 19;
            button18.Text = "%";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 13.8F);
            button19.Location = new Point(136, 137);
            button19.Name = "button19";
            button19.Size = new Size(94, 84);
            button19.TabIndex = 18;
            button19.Text = "CE";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button_clearEntry_click;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 13.8F);
            button20.Location = new Point(46, 137);
            button20.Name = "button20";
            button20.Size = new Size(94, 84);
            button20.TabIndex = 17;
            button20.Text = "C";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Clear_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(462, 556);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(textOutput);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textOutput;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}
