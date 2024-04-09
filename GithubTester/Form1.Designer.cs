namespace GithubTester
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblDragonName = new System.Windows.Forms.Label();
            this.txtDragonName = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(776, 67);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(13, 52);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(775, 50);
            this.txtPlayerName.TabIndex = 1;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Location = new System.Drawing.Point(12, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(776, 36);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblDragonName
            // 
            this.lblDragonName.Location = new System.Drawing.Point(11, 118);
            this.lblDragonName.Name = "lblDragonName";
            this.lblDragonName.Size = new System.Drawing.Size(776, 36);
            this.lblDragonName.TabIndex = 5;
            this.lblDragonName.Text = "Dragon Name";
            // 
            // txtDragonName
            // 
            this.txtDragonName.Location = new System.Drawing.Point(12, 157);
            this.txtDragonName.Multiline = true;
            this.txtDragonName.Name = "txtDragonName";
            this.txtDragonName.Size = new System.Drawing.Size(775, 50);
            this.txtDragonName.TabIndex = 4;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 308);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(776, 114);
            this.rtbLog.TabIndex = 6;
            this.rtbLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblDragonName);
            this.Controls.Add(this.txtDragonName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblDragonName;
        private System.Windows.Forms.TextBox txtDragonName;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

