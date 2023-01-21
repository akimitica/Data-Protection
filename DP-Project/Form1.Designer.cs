namespace DP_Project
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OutputDirOTP = new System.Windows.Forms.TextBox();
            this.InputDirOTP = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FSCOutputDir = new System.Windows.Forms.TextBox();
            this.FSCInputDir = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FSCOutputBox = new System.Windows.Forms.TextBox();
            this.FSCKeyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FSCInputBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.XXTEAOutputDir = new System.Windows.Forms.TextBox();
            this.XXTEAInputDir = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XXTEAOutput = new System.Windows.Forms.TextBox();
            this.XXTEAKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.XXTEAInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OutputDirOTP);
            this.tabPage1.Controls.Add(this.InputDirOTP);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "One Time Pad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OutputDirOTP
            // 
            this.OutputDirOTP.Location = new System.Drawing.Point(497, 124);
            this.OutputDirOTP.Name = "OutputDirOTP";
            this.OutputDirOTP.Size = new System.Drawing.Size(274, 23);
            this.OutputDirOTP.TabIndex = 14;
            // 
            // InputDirOTP
            // 
            this.InputDirOTP.Location = new System.Drawing.Point(497, 43);
            this.InputDirOTP.Name = "InputDirOTP";
            this.InputDirOTP.Size = new System.Drawing.Size(274, 23);
            this.InputDirOTP.TabIndex = 13;
            this.InputDirOTP.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(647, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 39);
            this.button7.TabIndex = 12;
            this.button7.Text = "Decrypt File";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(497, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 39);
            this.button6.TabIndex = 11;
            this.button6.Text = "Encrypt File";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "Output file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "Input file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Decrypt input";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Encrypt input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 166);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 125);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 125);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FSCOutputDir);
            this.tabPage2.Controls.Add(this.FSCInputDir);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.FSCOutputBox);
            this.tabPage2.Controls.Add(this.FSCKeyBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.FSCInputBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Four Square Cypher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FSCOutputDir
            // 
            this.FSCOutputDir.Location = new System.Drawing.Point(497, 124);
            this.FSCOutputDir.Name = "FSCOutputDir";
            this.FSCOutputDir.Size = new System.Drawing.Size(274, 23);
            this.FSCOutputDir.TabIndex = 30;
            // 
            // FSCInputDir
            // 
            this.FSCInputDir.Location = new System.Drawing.Point(497, 43);
            this.FSCInputDir.Name = "FSCInputDir";
            this.FSCInputDir.Size = new System.Drawing.Size(274, 23);
            this.FSCInputDir.TabIndex = 29;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(647, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 39);
            this.button8.TabIndex = 28;
            this.button8.Text = "Decrypt File";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(497, 195);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 39);
            this.button9.TabIndex = 27;
            this.button9.Text = "Encrypt File";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(366, 108);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(103, 52);
            this.button11.TabIndex = 25;
            this.button11.Text = "Output file";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(366, 27);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(103, 52);
            this.button12.TabIndex = 24;
            this.button12.Text = "Input file";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(8, 355);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(188, 52);
            this.button13.TabIndex = 23;
            this.button13.Text = "Decrypt input";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(8, 297);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(188, 52);
            this.button14.TabIndex = 22;
            this.button14.Text = "Encrypt input";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Key";
            // 
            // FSCOutputBox
            // 
            this.FSCOutputBox.Location = new System.Drawing.Point(8, 166);
            this.FSCOutputBox.Multiline = true;
            this.FSCOutputBox.Name = "FSCOutputBox";
            this.FSCOutputBox.Size = new System.Drawing.Size(274, 125);
            this.FSCOutputBox.TabIndex = 19;
            this.FSCOutputBox.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // FSCKeyBox
            // 
            this.FSCKeyBox.Location = new System.Drawing.Point(8, 137);
            this.FSCKeyBox.Name = "FSCKeyBox";
            this.FSCKeyBox.Size = new System.Drawing.Size(274, 23);
            this.FSCKeyBox.TabIndex = 18;
            this.FSCKeyBox.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Input";
            // 
            // FSCInputBox
            // 
            this.FSCInputBox.Location = new System.Drawing.Point(8, 6);
            this.FSCInputBox.Multiline = true;
            this.FSCInputBox.Name = "FSCInputBox";
            this.FSCInputBox.Size = new System.Drawing.Size(274, 125);
            this.FSCInputBox.TabIndex = 16;
            this.FSCInputBox.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.XXTEAOutputDir);
            this.tabPage3.Controls.Add(this.XXTEAInputDir);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Controls.Add(this.button18);
            this.tabPage3.Controls.Add(this.button19);
            this.tabPage3.Controls.Add(this.button20);
            this.tabPage3.Controls.Add(this.button21);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.XXTEAOutput);
            this.tabPage3.Controls.Add(this.XXTEAKey);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.XXTEAInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "XXTEA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // XXTEAOutputDir
            // 
            this.XXTEAOutputDir.Location = new System.Drawing.Point(497, 124);
            this.XXTEAOutputDir.Name = "XXTEAOutputDir";
            this.XXTEAOutputDir.Size = new System.Drawing.Size(274, 23);
            this.XXTEAOutputDir.TabIndex = 30;
            // 
            // XXTEAInputDir
            // 
            this.XXTEAInputDir.Location = new System.Drawing.Point(497, 43);
            this.XXTEAInputDir.Name = "XXTEAInputDir";
            this.XXTEAInputDir.Size = new System.Drawing.Size(274, 23);
            this.XXTEAInputDir.TabIndex = 29;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(647, 195);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(124, 39);
            this.button15.TabIndex = 28;
            this.button15.Text = "Decrypt File";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(497, 195);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(124, 39);
            this.button16.TabIndex = 27;
            this.button16.Text = "Encrypt File";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(366, 108);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(103, 52);
            this.button18.TabIndex = 25;
            this.button18.Text = "Output file";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(366, 27);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(103, 52);
            this.button19.TabIndex = 24;
            this.button19.Text = "Input file";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(8, 355);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(188, 52);
            this.button20.TabIndex = 23;
            this.button20.Text = "Decrypt input";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(8, 297);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(188, 52);
            this.button21.TabIndex = 22;
            this.button21.Text = "Encrypt input";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Key";
            // 
            // XXTEAOutput
            // 
            this.XXTEAOutput.Location = new System.Drawing.Point(8, 166);
            this.XXTEAOutput.Multiline = true;
            this.XXTEAOutput.Name = "XXTEAOutput";
            this.XXTEAOutput.Size = new System.Drawing.Size(274, 125);
            this.XXTEAOutput.TabIndex = 19;
            // 
            // XXTEAKey
            // 
            this.XXTEAKey.Location = new System.Drawing.Point(8, 137);
            this.XXTEAKey.Name = "XXTEAKey";
            this.XXTEAKey.Size = new System.Drawing.Size(274, 23);
            this.XXTEAKey.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Input";
            // 
            // XXTEAInput
            // 
            this.XXTEAInput.Location = new System.Drawing.Point(8, 6);
            this.XXTEAInput.Multiline = true;
            this.XXTEAInput.Name = "XXTEAInput";
            this.XXTEAInput.Size = new System.Drawing.Size(274, 125);
            this.XXTEAInput.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Crypto Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox OutputDirOTP;
        private TextBox InputDirOTP;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox FSCOutputDir;
        private TextBox FSCInputDir;
        private Button button8;
        private Button button9;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label label4;
        private Label label5;
        private TextBox FSCOutputBox;
        private TextBox FSCKeyBox;
        private Label label6;
        private TextBox FSCInputBox;
        private TextBox XXTEAOutputDir;
        private TextBox XXTEAInputDir;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Label label7;
        private Label label8;
        private TextBox XXTEAOutput;
        private TextBox XXTEAKey;
        private Label label9;
        private TextBox XXTEAInput;
    }
}