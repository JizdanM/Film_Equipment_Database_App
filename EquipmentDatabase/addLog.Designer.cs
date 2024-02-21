namespace EquipmentDatabase
{
    partial class addLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addLog));
            this.btnAddLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogCategory = new System.Windows.Forms.ComboBox();
            this.txtLogEquipment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAddLog
            // 
            this.btnAddLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddLog.Location = new System.Drawing.Point(508, 371);
            this.btnAddLog.Name = "btnAddLog";
            this.btnAddLog.Size = new System.Drawing.Size(93, 33);
            this.btnAddLog.TabIndex = 0;
            this.btnAddLog.Text = "Adaugă";
            this.btnAddLog.UseVisualStyleBackColor = true;
            this.btnAddLog.Click += new System.EventHandler(this.btnAddLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria echipamentului";
            // 
            // txtLogCategory
            // 
            this.txtLogCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLogCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtLogCategory.FormattingEnabled = true;
            this.txtLogCategory.Location = new System.Drawing.Point(34, 63);
            this.txtLogCategory.Name = "txtLogCategory";
            this.txtLogCategory.Size = new System.Drawing.Size(567, 28);
            this.txtLogCategory.TabIndex = 2;
            this.txtLogCategory.SelectedIndexChanged += new System.EventHandler(this.txtLogCategory_SelectedIndexChanged);
            // 
            // txtLogEquipment
            // 
            this.txtLogEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLogEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtLogEquipment.FormattingEnabled = true;
            this.txtLogEquipment.Location = new System.Drawing.Point(34, 151);
            this.txtLogEquipment.Name = "txtLogEquipment";
            this.txtLogEquipment.Size = new System.Drawing.Size(567, 28);
            this.txtLogEquipment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Echipamentul";
            // 
            // txtLogStudent
            // 
            this.txtLogStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLogStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtLogStudent.FormattingEnabled = true;
            this.txtLogStudent.Location = new System.Drawing.Point(34, 240);
            this.txtLogStudent.Name = "txtLogStudent";
            this.txtLogStudent.Size = new System.Drawing.Size(567, 28);
            this.txtLogStudent.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elevul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Elevul";
            // 
            // txtLogDate
            // 
            this.txtLogDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtLogDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtLogDate.Location = new System.Drawing.Point(34, 332);
            this.txtLogDate.Name = "txtLogDate";
            this.txtLogDate.Size = new System.Drawing.Size(164, 26);
            this.txtLogDate.TabIndex = 8;
            this.txtLogDate.Value = new System.DateTime(2024, 2, 21, 0, 0, 0, 0);
            // 
            // addLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 416);
            this.Controls.Add(this.txtLogDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addLog";
            this.Text = "Adaugă un log nou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtLogCategory;
        private System.Windows.Forms.ComboBox txtLogEquipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtLogStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtLogDate;
    }
}