namespace WindowsFormsApp16
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtgr = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoyadlarCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IxtisasCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgr
            // 
            this.dtgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AdCol,
            this.SoyadlarCol,
            this.IxtisasCol});
            this.dtgr.Location = new System.Drawing.Point(12, 12);
            this.dtgr.Name = "dtgr";
            this.dtgr.Size = new System.Drawing.Size(445, 150);
            this.dtgr.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Idler";
            this.Id.Name = "Id";
            // 
            // AdCol
            // 
            this.AdCol.HeaderText = "Adlar";
            this.AdCol.Name = "AdCol";
            // 
            // SoyadlarCol
            // 
            this.SoyadlarCol.HeaderText = "Soyadlar";
            this.SoyadlarCol.Name = "SoyadlarCol";
            // 
            // IxtisasCol
            // 
            this.IxtisasCol.HeaderText = "Ixtisaslar";
            this.IxtisasCol.Name = "IxtisasCol";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(211, 193);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(363, 193);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 357);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dtgr);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoyadlarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IxtisasCol;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}

