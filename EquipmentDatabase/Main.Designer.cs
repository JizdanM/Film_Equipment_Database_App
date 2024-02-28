namespace EquipmentDatabase
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.echipamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loguriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddEquipmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddLog = new System.Windows.Forms.ToolStripMenuItem();
            this.cautăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaElevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaEchipamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataOutput
            // 
            this.dataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOutput.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Location = new System.Drawing.Point(12, 37);
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.Size = new System.Drawing.Size(1063, 531);
            this.dataOutput.TabIndex = 0;
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.topMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.addToolStripMenuItem,
            this.cautăToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 6);
            this.topMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.topMenu.Size = new System.Drawing.Size(1087, 30);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.optionsToolStripMenuItem.Text = "Opțiuni";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingsToolStripMenuItem.Text = "Setări";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Ieșire";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.echipamenteToolStripMenuItem,
            this.categoriiToolStripMenuItem,
            this.eleviToolStripMenuItem,
            this.loguriToolStripMenuItem});
            this.selectToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.selectToolStripMenuItem.Text = "Afisare";
            // 
            // echipamenteToolStripMenuItem
            // 
            this.echipamenteToolStripMenuItem.Name = "echipamenteToolStripMenuItem";
            this.echipamenteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.echipamenteToolStripMenuItem.Text = "Echipamente";
            this.echipamenteToolStripMenuItem.Click += new System.EventHandler(this.echipamenteToolStripMenuItem_Click);
            // 
            // categoriiToolStripMenuItem
            // 
            this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
            this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.categoriiToolStripMenuItem.Text = "Categorii";
            this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
            // 
            // eleviToolStripMenuItem
            // 
            this.eleviToolStripMenuItem.Name = "eleviToolStripMenuItem";
            this.eleviToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eleviToolStripMenuItem.Text = "Elevi";
            this.eleviToolStripMenuItem.Click += new System.EventHandler(this.eleviToolStripMenuItem_Click);
            // 
            // loguriToolStripMenuItem
            // 
            this.loguriToolStripMenuItem.Name = "loguriToolStripMenuItem";
            this.loguriToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loguriToolStripMenuItem.Text = "Loguri";
            this.loguriToolStripMenuItem.Click += new System.EventHandler(this.loguriToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripAddEquipmentMenu,
            this.stripAddStudent,
            this.stripAddLog});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.addToolStripMenuItem.Text = "Adaugă";
            // 
            // stripAddEquipmentMenu
            // 
            this.stripAddEquipmentMenu.BackColor = System.Drawing.Color.Indigo;
            this.stripAddEquipmentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripAddCategory,
            this.stripAddEquipment});
            this.stripAddEquipmentMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stripAddEquipmentMenu.Name = "stripAddEquipmentMenu";
            this.stripAddEquipmentMenu.Size = new System.Drawing.Size(164, 22);
            this.stripAddEquipmentMenu.Text = "Echipament";
            // 
            // stripAddCategory
            // 
            this.stripAddCategory.BackColor = System.Drawing.Color.Indigo;
            this.stripAddCategory.Name = "stripAddCategory";
            this.stripAddCategory.Size = new System.Drawing.Size(164, 22);
            this.stripAddCategory.Text = "Categorie";
            this.stripAddCategory.Click += new System.EventHandler(this.stripAddCategory_Click);
            // 
            // stripAddEquipment
            // 
            this.stripAddEquipment.Name = "stripAddEquipment";
            this.stripAddEquipment.Size = new System.Drawing.Size(164, 22);
            this.stripAddEquipment.Text = "Echipament";
            this.stripAddEquipment.Click += new System.EventHandler(this.stripAddEquipment_Click);
            // 
            // stripAddStudent
            // 
            this.stripAddStudent.BackColor = System.Drawing.Color.Indigo;
            this.stripAddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stripAddStudent.Name = "stripAddStudent";
            this.stripAddStudent.Size = new System.Drawing.Size(164, 22);
            this.stripAddStudent.Text = "Elev";
            this.stripAddStudent.Click += new System.EventHandler(this.stripAddStudent_Click);
            // 
            // stripAddLog
            // 
            this.stripAddLog.Name = "stripAddLog";
            this.stripAddLog.Size = new System.Drawing.Size(164, 22);
            this.stripAddLog.Text = "Log";
            this.stripAddLog.Click += new System.EventHandler(this.stripAddLog_Click);
            // 
            // cautăToolStripMenuItem
            // 
            this.cautăToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.cautăToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cautăToolStripMenuItem.Name = "cautăToolStripMenuItem";
            this.cautăToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.cautăToolStripMenuItem.Text = "Caută";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(972, 574);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dupaElevToolStripMenuItem,
            this.dupaEchipamentToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // dupaElevToolStripMenuItem
            // 
            this.dupaElevToolStripMenuItem.Name = "dupaElevToolStripMenuItem";
            this.dupaElevToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dupaElevToolStripMenuItem.Text = "Dupa elev";
            // 
            // dupaEchipamentToolStripMenuItem
            // 
            this.dupaEchipamentToolStripMenuItem.Name = "dupaEchipamentToolStripMenuItem";
            this.dupaEchipamentToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dupaEchipamentToolStripMenuItem.Text = "Dupa echipament";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1087, 618);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataOutput);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bază de date echipament";
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOutput;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripAddEquipmentMenu;
        private System.Windows.Forms.ToolStripMenuItem stripAddCategory;
        private System.Windows.Forms.ToolStripMenuItem stripAddEquipment;
        private System.Windows.Forms.ToolStripMenuItem stripAddStudent;
        private System.Windows.Forms.ToolStripMenuItem stripAddLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem echipamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loguriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaElevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaEchipamentToolStripMenuItem;
    }
}

