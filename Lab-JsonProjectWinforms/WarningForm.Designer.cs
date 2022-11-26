namespace Lab_JsonProjectWinforms
{
    partial class WarningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningForm));
            this.okButton = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.okButton.Location = new System.Drawing.Point(240, 224);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(67, 36);
            this.okButton.TabIndex = 17;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelErrorMessage.Location = new System.Drawing.Point(70, 31);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(401, 146);
            this.labelErrorMessage.TabIndex = 26;
            this.labelErrorMessage.Text = "Error";
            this.labelErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErrorMessage.Click += new System.EventHandler(this.labelErrorMessage_Click);
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(542, 301);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarningForm";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.WarningForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button okButton;
        private Label labelErrorMessage;
    }
}