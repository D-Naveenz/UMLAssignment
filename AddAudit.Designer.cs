namespace _20UMLQuestion
{
    partial class AddAudit
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
            this.description = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.addAuditBtn = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.storeid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.auditIDBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.storeIDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(197, 291);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(106, 22);
            this.description.TabIndex = 14;
            this.description.Text = "Description";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(197, 235);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(50, 22);
            this.date.TabIndex = 13;
            this.date.Text = "Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Audit Details";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(266, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(285, 61);
            this.title.TabIndex = 11;
            this.title.Text = "Lock Hood";
            // 
            // addAuditBtn
            // 
            this.addAuditBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAuditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addAuditBtn.Location = new System.Drawing.Point(319, 403);
            this.addAuditBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addAuditBtn.Name = "addAuditBtn";
            this.addAuditBtn.Size = new System.Drawing.Size(192, 66);
            this.addAuditBtn.TabIndex = 10;
            this.addAuditBtn.Text = "Add Audit";
            this.addAuditBtn.UseVisualStyleBackColor = true;
            this.addAuditBtn.Click += new System.EventHandler(this.addAuditBtn_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(366, 290);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(223, 26);
            this.descriptionBox.TabIndex = 8;
            // 
            // storeid
            // 
            this.storeid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.storeid.AutoSize = true;
            this.storeid.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeid.Location = new System.Drawing.Point(197, 344);
            this.storeid.Name = "storeid";
            this.storeid.Size = new System.Drawing.Size(81, 22);
            this.storeid.TabIndex = 16;
            this.storeid.Text = "Store ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Audit ID";
            // 
            // auditIDBox
            // 
            this.auditIDBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.auditIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditIDBox.Location = new System.Drawing.Point(366, 181);
            this.auditIDBox.Name = "auditIDBox";
            this.auditIDBox.Size = new System.Drawing.Size(223, 26);
            this.auditIDBox.TabIndex = 17;
            // 
            // dateBox
            // 
            this.dateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBox.Location = new System.Drawing.Point(366, 236);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(223, 20);
            this.dateBox.TabIndex = 19;
            // 
            // storeIDBox
            // 
            this.storeIDBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.storeIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeIDBox.Location = new System.Drawing.Point(366, 340);
            this.storeIDBox.Name = "storeIDBox";
            this.storeIDBox.Size = new System.Drawing.Size(223, 26);
            this.storeIDBox.TabIndex = 20;
            // 
            // AddAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.storeIDBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.auditIDBox);
            this.Controls.Add(this.storeid);
            this.Controls.Add(this.description);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addAuditBtn);
            this.Controls.Add(this.descriptionBox);
            this.Name = "AddAudit";
            this.Text = "AddAudit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addAuditBtn;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label storeid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox auditIDBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.TextBox storeIDBox;
    }
}