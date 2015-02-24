namespace _101
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtParity = new System.Windows.Forms.TextBox();
            this.Paritylbl = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblPreliminary = new System.Windows.Forms.Label();
            this.CheckPreliminarieslbl = new System.Windows.Forms.Label();
            this.txtPreliminary = new System.Windows.Forms.TextBox();
            this.lblParenthesisCheck = new System.Windows.Forms.Label();
            this.ParenthesisChecklbl = new System.Windows.Forms.Label();
            this.txtlblParenthesis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtParity
            // 
            this.txtParity.Location = new System.Drawing.Point(29, 50);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(288, 20);
            this.txtParity.TabIndex = 0;
            this.txtParity.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            // 
            // Paritylbl
            // 
            this.Paritylbl.AutoSize = true;
            this.Paritylbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paritylbl.Location = new System.Drawing.Point(25, 28);
            this.Paritylbl.Name = "Paritylbl";
            this.Paritylbl.Size = new System.Drawing.Size(124, 19);
            this.Paritylbl.TabIndex = 1;
            this.Paritylbl.Text = "Parity Counting:";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParity.Location = new System.Drawing.Point(149, 28);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(0, 19);
            this.lblParity.TabIndex = 3;
            // 
            // lblPreliminary
            // 
            this.lblPreliminary.AutoSize = true;
            this.lblPreliminary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreliminary.Location = new System.Drawing.Point(120, 118);
            this.lblPreliminary.Name = "lblPreliminary";
            this.lblPreliminary.Size = new System.Drawing.Size(0, 19);
            this.lblPreliminary.TabIndex = 6;
            // 
            // CheckPreliminarieslbl
            // 
            this.CheckPreliminarieslbl.AutoSize = true;
            this.CheckPreliminarieslbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPreliminarieslbl.Location = new System.Drawing.Point(25, 118);
            this.CheckPreliminarieslbl.Name = "CheckPreliminarieslbl";
            this.CheckPreliminarieslbl.Size = new System.Drawing.Size(104, 19);
            this.CheckPreliminarieslbl.TabIndex = 5;
            this.CheckPreliminarieslbl.Text = "Preliminarity:";
            // 
            // txtPreliminary
            // 
            this.txtPreliminary.Location = new System.Drawing.Point(29, 140);
            this.txtPreliminary.Name = "txtPreliminary";
            this.txtPreliminary.Size = new System.Drawing.Size(288, 20);
            this.txtPreliminary.TabIndex = 4;
            this.txtPreliminary.TextChanged += new System.EventHandler(this.txtPreliminary_TextChanged);
            // 
            // lblParenthesisCheck
            // 
            this.lblParenthesisCheck.AutoSize = true;
            this.lblParenthesisCheck.Enabled = false;
            this.lblParenthesisCheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParenthesisCheck.Location = new System.Drawing.Point(167, 73);
            this.lblParenthesisCheck.Name = "lblParenthesisCheck";
            this.lblParenthesisCheck.Size = new System.Drawing.Size(0, 19);
            this.lblParenthesisCheck.TabIndex = 9;
            // 
            // ParenthesisChecklbl
            // 
            this.ParenthesisChecklbl.AutoSize = true;
            this.ParenthesisChecklbl.Enabled = false;
            this.ParenthesisChecklbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParenthesisChecklbl.Location = new System.Drawing.Point(25, 73);
            this.ParenthesisChecklbl.Name = "ParenthesisChecklbl";
            this.ParenthesisChecklbl.Size = new System.Drawing.Size(142, 19);
            this.ParenthesisChecklbl.TabIndex = 8;
            this.ParenthesisChecklbl.Text = "Parenthesis Check:";
            // 
            // txtlblParenthesis
            // 
            this.txtlblParenthesis.Enabled = false;
            this.txtlblParenthesis.Location = new System.Drawing.Point(29, 95);
            this.txtlblParenthesis.Name = "txtlblParenthesis";
            this.txtlblParenthesis.Size = new System.Drawing.Size(288, 20);
            this.txtlblParenthesis.TabIndex = 7;
            this.txtlblParenthesis.TextChanged += new System.EventHandler(this.txtlblParenthesis_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(343, 189);
            this.Controls.Add(this.lblParenthesisCheck);
            this.Controls.Add(this.ParenthesisChecklbl);
            this.Controls.Add(this.txtlblParenthesis);
            this.Controls.Add(this.lblPreliminary);
            this.Controls.Add(this.CheckPreliminarieslbl);
            this.Controls.Add(this.txtPreliminary);
            this.Controls.Add(this.lblParity);
            this.Controls.Add(this.Paritylbl);
            this.Controls.Add(this.txtParity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "101";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParity;
        private System.Windows.Forms.Label Paritylbl;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblPreliminary;
        private System.Windows.Forms.Label CheckPreliminarieslbl;
        private System.Windows.Forms.TextBox txtPreliminary;
        private System.Windows.Forms.Label lblParenthesisCheck;
        private System.Windows.Forms.Label ParenthesisChecklbl;
        private System.Windows.Forms.TextBox txtlblParenthesis;
    }
}

