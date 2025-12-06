namespace BMI_Calculator
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
            lblTitle = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            lblOutput = new Label();
            lblStatus = new Label();
            btnReset = new Button();
            lblGithub = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(108, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(356, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Body Mass Index Calculator";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHeight.Location = new Point(147, 90);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(118, 26);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Height (m):";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblWeight.Location = new Point(147, 138);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(127, 26);
            lblWeight.TabIndex = 2;
            lblWeight.Text = "Weight (kg):";
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.Silver;
            txtHeight.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtHeight.ForeColor = SystemColors.HotTrack;
            txtHeight.Location = new Point(323, 91);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 30);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.Silver;
            txtWeight.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtWeight.ForeColor = SystemColors.HotTrack;
            txtWeight.Location = new Point(323, 139);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 30);
            txtWeight.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Black;
            btnCalculate.ForeColor = Color.Red;
            btnCalculate.Location = new Point(147, 191);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(127, 43);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblResult.Location = new Point(147, 275);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(83, 25);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOutput.Location = new Point(255, 275);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(85, 25);
            lblOutput.TabIndex = 7;
            lblOutput.Text = "Output";
            lblOutput.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStatus.Location = new Point(373, 275);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 25);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            lblStatus.Visible = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Black;
            btnReset.ForeColor = Color.Fuchsia;
            btnReset.Location = new Point(147, 328);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 42);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblGithub
            // 
            lblGithub.ActiveLinkColor = Color.Plum;
            lblGithub.AutoSize = true;
            lblGithub.DisabledLinkColor = Color.White;
            lblGithub.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblGithub.ForeColor = SystemColors.ActiveBorder;
            lblGithub.Location = new Point(630, 414);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(132, 22);
            lblGithub.TabIndex = 10;
            lblGithub.TabStop = true;
            lblGithub.Text = "Umut Albayrak";
            lblGithub.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(774, 445);
            Controls.Add(lblGithub);
            Controls.Add(btnReset);
            Controls.Add(lblStatus);
            Controls.Add(lblOutput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Body Mass Index Calculator v1.0";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblHeight;
        private Label lblWeight;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnCalculate;
        private Label lblResult;
        private Label lblOutput;
        private Label lblStatus;
        private Button btnReset;
        private LinkLabel lblGithub;
    }
}
