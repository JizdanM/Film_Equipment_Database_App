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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddEquipmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAddLog = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataOutput
            // 
            this.dataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOutput.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Location = new System.Drawing.Point(12, 37);
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.Size = new System.Drawing.Size(1063, 531);
            this.dataOutput.TabIndex = 0;
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.topMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.addToolStripMenuItem});
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Setări";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Ieșire";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.selectToolStripMenuItem.Text = "Afisare";
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
            this.stripAddEquipmentMenu.Size = new System.Drawing.Size(180, 22);
            this.stripAddEquipmentMenu.Text = "Echipament";
            // 
            // stripAddCategory
            // 
            this.stripAddCategory.BackColor = System.Drawing.Color.Indigo;
            this.stripAddCategory.Name = "stripAddCategory";
            this.stripAddCategory.Size = new System.Drawing.Size(180, 22);
            this.stripAddCategory.Text = "Categorie";
            // 
            // stripAddEquipment
            // 
            this.stripAddEquipment.Name = "stripAddEquipment";
            this.stripAddEquipment.Size = new System.Drawing.Size(180, 22);
            this.stripAddEquipment.Text = "Echipament";
            // 
            // stripAddStudent
            // 
            this.stripAddStudent.BackColor = System.Drawing.Color.Indigo;
            this.stripAddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stripAddStudent.Name = "stripAddStudent";
            this.stripAddStudent.Size = new System.Drawing.Size(180, 22);
            this.stripAddStudent.Text = "Elev";
            // 
            // stripAddLog
            // 
            this.stripAddLog.Name = "stripAddLog";
            this.stripAddLog.Size = new System.Drawing.Size(180, 22);
            this.stripAddLog.Text = "Înregistrare";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(972, 574);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(103, 32);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Refresh";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1087, 618);
            this.Controls.Add(this.btnSelect);
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
        private System.Windows.Forms.Button btnSelect;
    }
}

