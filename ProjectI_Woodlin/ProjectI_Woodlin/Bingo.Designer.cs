namespace ProjectI_Woodlin
{
    partial class frmBingo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.txtCalledNumber = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.pnlBingoCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(241, 4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(355, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to The Game of BINGO! ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(145, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(460, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 26);
            this.txtName.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPlay.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnPlay.Location = new System.Drawing.Point(148, 64);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(149, 37);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Let\'s Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(513, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtRules
            // 
            this.txtRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRules.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRules.Location = new System.Drawing.Point(32, 121);
            this.txtRules.Multiline = true;
            this.txtRules.Name = "txtRules";
            this.txtRules.ReadOnly = true;
            this.txtRules.Size = new System.Drawing.Size(324, 65);
            this.txtRules.TabIndex = 5;
            this.txtRules.TabStop = false;
            this.txtRules.Text = "We will call one number at a time.  Check your card for that number if found clic" +
    "k on that cell.\r\nThe number called will appear on the right, if not found on car" +
    "d click the \"Don\'t Have\" Button.";
            this.txtRules.Visible = false;
            // 
            // txtCalledNumber
            // 
            this.txtCalledNumber.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalledNumber.Location = new System.Drawing.Point(460, 121);
            this.txtCalledNumber.Name = "txtCalledNumber";
            this.txtCalledNumber.ReadOnly = true;
            this.txtCalledNumber.Size = new System.Drawing.Size(146, 26);
            this.txtCalledNumber.TabIndex = 6;
            this.txtCalledNumber.TabStop = false;
            this.txtCalledNumber.Visible = false;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDontHave.Location = new System.Drawing.Point(460, 153);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(146, 33);
            this.btnDontHave.TabIndex = 7;
            this.btnDontHave.Text = "Don\'t Have.";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Visible = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // pnlBingoCard
            // 
            this.pnlBingoCard.Location = new System.Drawing.Point(148, 192);
            this.pnlBingoCard.Name = "pnlBingoCard";
            this.pnlBingoCard.Size = new System.Drawing.Size(666, 514);
            this.pnlBingoCard.TabIndex = 9;
            this.pnlBingoCard.Visible = false;
            // 
            // frmBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 718);
            this.Controls.Add(this.pnlBingoCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtCalledNumber);
            this.Controls.Add(this.txtRules);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBingo";
            this.Text = "BINGO!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtRules;
        private System.Windows.Forms.TextBox txtCalledNumber;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Panel pnlBingoCard;
    }
}

