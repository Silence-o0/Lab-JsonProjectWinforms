namespace Lab_JsonProjectWinforms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.textBoxDataSearch = new System.Windows.Forms.TextBox();
            this.ComboBoxTypeSearch = new System.Windows.Forms.ComboBox();
            this.SearchText = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.okSearchButton = new System.Windows.Forms.Button();
            this.returnSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.GridColor = System.Drawing.Color.Lavender;
            this.DataGridView.Location = new System.Drawing.Point(538, 93);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.RowTemplate.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(462, 364);
            this.DataGridView.TabIndex = 1;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.EditButton.FlatAppearance.BorderSize = 2;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.Blue;
            this.EditButton.Location = new System.Drawing.Point(177, 298);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(171, 47);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // textBoxDataSearch
            // 
            this.textBoxDataSearch.Location = new System.Drawing.Point(291, 183);
            this.textBoxDataSearch.Name = "textBoxDataSearch";
            this.textBoxDataSearch.Size = new System.Drawing.Size(152, 31);
            this.textBoxDataSearch.TabIndex = 5;
            // 
            // ComboBoxTypeSearch
            // 
            this.ComboBoxTypeSearch.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxTypeSearch.FormattingEnabled = true;
            this.ComboBoxTypeSearch.Items.AddRange(new object[] {
            "ПІБ:",
            "Дисципліна:",
            "Група:"});
            this.ComboBoxTypeSearch.Location = new System.Drawing.Point(71, 181);
            this.ComboBoxTypeSearch.Name = "ComboBoxTypeSearch";
            this.ComboBoxTypeSearch.Size = new System.Drawing.Size(182, 32);
            this.ComboBoxTypeSearch.TabIndex = 7;
            // 
            // SearchText
            // 
            this.SearchText.AutoSize = true;
            this.SearchText.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchText.ForeColor = System.Drawing.Color.Blue;
            this.SearchText.Location = new System.Drawing.Point(80, 139);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(91, 30);
            this.SearchText.TabIndex = 11;
            this.SearchText.Text = "Search:";
            this.SearchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightCyan;
            this.AddButton.BackgroundImage = global::Lab_JsonProjectWinforms.Properties.Resources.add_button_icon1;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(125, 372);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 85);
            this.AddButton.TabIndex = 16;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightCyan;
            this.DeleteButton.BackgroundImage = global::Lab_JsonProjectWinforms.Properties.Resources.delete_button_icon;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(293, 372);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 85);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 75);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.AutoSize = false;
            this.MenuItem.BackColor = System.Drawing.Color.Lavender;
            this.MenuItem.BackgroundImage = global::Lab_JsonProjectWinforms.Properties.Resources.menu_icon2;
            this.MenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsButton,
            this.openAsButton,
            this.infoButton});
            this.MenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(58, 55);
            this.MenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // saveAsButton
            // 
            this.saveAsButton.BackColor = System.Drawing.Color.Lavender;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(176, 34);
            this.saveAsButton.Text = "Save as";
            this.saveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // openAsButton
            // 
            this.openAsButton.BackColor = System.Drawing.Color.Lavender;
            this.openAsButton.Name = "openAsButton";
            this.openAsButton.Size = new System.Drawing.Size(176, 34);
            this.openAsButton.Text = "Open as";
            this.openAsButton.Click += new System.EventHandler(this.OpenAsButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.AutoSize = false;
            this.infoButton.BackColor = System.Drawing.Color.Lavender;
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(270, 34);
            this.infoButton.Text = "Info";
            this.infoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // okSearchButton
            // 
            this.okSearchButton.BackColor = System.Drawing.Color.LightCyan;
            this.okSearchButton.BackgroundImage = global::Lab_JsonProjectWinforms.Properties.Resources.ok_icon;
            this.okSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okSearchButton.FlatAppearance.BorderSize = 0;
            this.okSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okSearchButton.Location = new System.Drawing.Point(458, 160);
            this.okSearchButton.Name = "okSearchButton";
            this.okSearchButton.Size = new System.Drawing.Size(37, 37);
            this.okSearchButton.TabIndex = 19;
            this.okSearchButton.UseVisualStyleBackColor = false;
            this.okSearchButton.Click += new System.EventHandler(this.OkSearchButton_Click);
            // 
            // returnSearchButton
            // 
            this.returnSearchButton.BackColor = System.Drawing.Color.LightCyan;
            this.returnSearchButton.BackgroundImage = global::Lab_JsonProjectWinforms.Properties.Resources.return2_icon2;
            this.returnSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnSearchButton.FlatAppearance.BorderSize = 0;
            this.returnSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnSearchButton.Location = new System.Drawing.Point(458, 203);
            this.returnSearchButton.Name = "returnSearchButton";
            this.returnSearchButton.Size = new System.Drawing.Size(37, 35);
            this.returnSearchButton.TabIndex = 20;
            this.returnSearchButton.UseVisualStyleBackColor = false;
            this.returnSearchButton.Click += new System.EventHandler(this.ReturnSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1036, 536);
            this.Controls.Add(this.returnSearchButton);
            this.Controls.Add(this.okSearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.ComboBoxTypeSearch);
            this.Controls.Add(this.textBoxDataSearch);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGridView;
        private Button EditButton;
        private TextBox textBoxDataSearch;
        private ComboBox ComboBoxTypeSearch;
        private Label SearchText;
        private Button AddButton;
        private Button DeleteButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem;
        private ToolStripMenuItem saveAsButton;
        private ToolStripMenuItem openAsButton;
        private ToolStripMenuItem infoButton;
        private BindingSource bindingSource1;
        private Button okSearchButton;
        private Button returnSearchButton;
    }
}