using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe2
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(10, 47);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(166, 47);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(322, 47);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(10, 203);
            button4.Name = "button4";
            button4.Size = new Size(150, 150);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(166, 203);
            button5.Name = "button5";
            button5.Size = new Size(150, 150);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(322, 203);
            button6.Name = "button6";
            button6.Size = new Size(150, 150);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(10, 359);
            button7.Name = "button7";
            button7.Size = new Size(150, 150);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(166, 359);
            button8.Name = "button8";
            button8.Size = new Size(150, 150);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(322, 359);
            button9.Name = "button9";
            button9.Size = new Size(150, 150);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 24);
            label1.TabIndex = 9;
            label1.Text = "Ход: Игрок 1 (LoL)\r\n";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 573);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            ShowIcon = false;
            Text = "LoL vs Dota 2 (based on Tic-Tac-Toe)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
    }
}
