namespace Lab_JsonProjectWinforms
{
    partial class YesNoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesNoForm));
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelErrorMessage.Location = new System.Drawing.Point(85, 30);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(401, 146);
            this.labelErrorMessage.TabIndex = 27;
            this.labelErrorMessage.Text = "Error";
            this.labelErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.noButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.noButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.noButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.noButton.Location = new System.Drawing.Point(154, 214);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(67, 36);
            this.noButton.TabIndex = 28;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.yesButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.yesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yesButton.Location = new System.Drawing.Point(338, 214);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(67, 36);
            this.yesButton.TabIndex = 29;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // YesNoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(565, 307);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.labelErrorMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YesNoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YesNoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelErrorMessage;
        private Button noButton;
        private Button yesButton;
    }
}