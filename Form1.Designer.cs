namespace Assignment_6
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
            btnRock = new Button();
            btnScissors = new Button();
            btnPaper = new Button();
            panel1 = new Panel();
            lblResult = new Label();
            lblComputerChoice = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(131, 36);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(114, 44);
            btnRock.TabIndex = 0;
            btnRock.Tag = "";
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(131, 86);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(114, 44);
            btnScissors.TabIndex = 1;
            btnScissors.Tag = "";
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(131, 136);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(114, 44);
            btnPaper.TabIndex = 2;
            btnPaper.Tag = "";
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(lblComputerChoice);
            panel1.Location = new Point(12, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 153);
            panel1.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(18, 58);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result";
            lblResult.Visible = false;
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.AutoSize = true;
            lblComputerChoice.Location = new Point(18, 16);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(122, 20);
            lblComputerChoice.TabIndex = 0;
            lblComputerChoice.Text = "Computer choice";
            lblComputerChoice.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 351);
            Controls.Add(panel1);
            Controls.Add(btnPaper);
            Controls.Add(btnScissors);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Rock scissors paper";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRock;
        private Button btnScissors;
        private Button btnPaper;
        private Panel panel1;
        private Label lblComputerChoice;
        private Label lblResult;
    }
}