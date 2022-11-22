namespace Lab_JsonProjectWinforms
{
    partial class AddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.acceptButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.labelCathedra = new System.Windows.Forms.Label();
            this.labelAuditory = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.textBoxCathedra = new System.Windows.Forms.TextBox();
            this.textBoxAuditory = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Lavender;
            this.acceptButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.acceptButton.FlatAppearance.BorderSize = 2;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.acceptButton.Location = new System.Drawing.Point(260, 425);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(171, 47);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.Blue;
            this.labelName.Location = new System.Drawing.Point(163, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 30);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "ПІБ:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCyan;
            this.ExitButton.BackgroundImage = global::Lab_JsonProjectWinforms.Properties.Resources.return1;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(12, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 45);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(274, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(300, 31);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFaculty.ForeColor = System.Drawing.Color.Blue;
            this.labelFaculty.Location = new System.Drawing.Point(117, 120);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(124, 30);
            this.labelFaculty.TabIndex = 15;
            this.labelFaculty.Text = "Факультет:";
            this.labelFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFaculty.Click += new System.EventHandler(this.LabelFaculty_Click);
            // 
            // labelCathedra
            // 
            this.labelCathedra.AutoSize = true;
            this.labelCathedra.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCathedra.ForeColor = System.Drawing.Color.Blue;
            this.labelCathedra.Location = new System.Drawing.Point(130, 173);
            this.labelCathedra.Name = "labelCathedra";
            this.labelCathedra.Size = new System.Drawing.Size(111, 30);
            this.labelCathedra.TabIndex = 16;
            this.labelCathedra.Text = "Кафедра:";
            this.labelCathedra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuditory
            // 
            this.labelAuditory.AutoSize = true;
            this.labelAuditory.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuditory.ForeColor = System.Drawing.Color.Blue;
            this.labelAuditory.Location = new System.Drawing.Point(117, 223);
            this.labelAuditory.Name = "labelAuditory";
            this.labelAuditory.Size = new System.Drawing.Size(126, 30);
            this.labelAuditory.TabIndex = 17;
            this.labelAuditory.Text = "Аудиторія:";
            this.labelAuditory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubject.ForeColor = System.Drawing.Color.Blue;
            this.labelSubject.Location = new System.Drawing.Point(96, 275);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(147, 30);
            this.labelSubject.TabIndex = 18;
            this.labelSubject.Text = "Дисципліна:";
            this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.ForeColor = System.Drawing.Color.Blue;
            this.labelGroup.Location = new System.Drawing.Point(159, 330);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(82, 30);
            this.labelGroup.TabIndex = 19;
            this.labelGroup.Text = "Група:";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(274, 119);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(300, 31);
            this.textBoxFaculty.TabIndex = 20;
            this.textBoxFaculty.TextChanged += new System.EventHandler(this.TextBoxFaculty_TextChanged);
            // 
            // textBoxCathedra
            // 
            this.textBoxCathedra.Location = new System.Drawing.Point(274, 174);
            this.textBoxCathedra.Name = "textBoxCathedra";
            this.textBoxCathedra.Size = new System.Drawing.Size(300, 31);
            this.textBoxCathedra.TabIndex = 21;
            // 
            // textBoxAuditory
            // 
            this.textBoxAuditory.Location = new System.Drawing.Point(274, 224);
            this.textBoxAuditory.Name = "textBoxAuditory";
            this.textBoxAuditory.Size = new System.Drawing.Size(300, 31);
            this.textBoxAuditory.TabIndex = 22;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(274, 276);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(300, 31);
            this.textBoxSubject.TabIndex = 23;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(274, 331);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(300, 31);
            this.textBoxGroup.TabIndex = 24;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(688, 535);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxAuditory);
            this.Controls.Add(this.textBoxCathedra);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelAuditory);
            this.Controls.Add(this.labelCathedra);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.acceptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditForm";
            this.Text = "AddEdit";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button acceptButton;
        private Label labelName;
        private Button ExitButton;
        private TextBox textBoxName;
        private Label labelFaculty;
        private Label labelCathedra;
        private Label labelAuditory;
        private Label labelSubject;
        private Label labelGroup;
        private TextBox textBoxFaculty;
        private TextBox textBoxCathedra;
        private TextBox textBoxAuditory;
        private TextBox textBoxSubject;
        private TextBox textBoxGroup;
    }
}