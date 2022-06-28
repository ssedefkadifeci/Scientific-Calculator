namespace WindowsFormsApplication1
{
    partial class frmStatisticsForm
    {
        frmMainWindow objectOfMain;
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
            this.btnFocusToMainWindow = new System.Windows.Forms.Button();
            this.btnShowSelectedEntryInResultBox = new System.Windows.Forms.Button();
            this.btnClearSelectedEntry = new System.Windows.Forms.Button();
            this.btnClearAllEntry = new System.Windows.Forms.Button();
            this.lblStataticsEntryCount = new System.Windows.Forms.Label();
            this.lbxStatisticsEntries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFocusToMainWindow
            // 
            this.btnFocusToMainWindow.Location = new System.Drawing.Point(23, 133);
            this.btnFocusToMainWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFocusToMainWindow.Name = "btnFocusToMainWindow";
            this.btnFocusToMainWindow.Size = new System.Drawing.Size(63, 32);
            this.btnFocusToMainWindow.TabIndex = 1;
            this.btnFocusToMainWindow.Text = "RET";
            this.btnFocusToMainWindow.UseVisualStyleBackColor = true;
            this.btnFocusToMainWindow.Click += new System.EventHandler(this.FocusToMainWindowForm);
            // 
            // btnShowSelectedEntryInResultBox
            // 
            this.btnShowSelectedEntryInResultBox.Location = new System.Drawing.Point(93, 133);
            this.btnShowSelectedEntryInResultBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowSelectedEntryInResultBox.Name = "btnShowSelectedEntryInResultBox";
            this.btnShowSelectedEntryInResultBox.Size = new System.Drawing.Size(63, 32);
            this.btnShowSelectedEntryInResultBox.TabIndex = 1;
            this.btnShowSelectedEntryInResultBox.Text = "LOAD";
            this.btnShowSelectedEntryInResultBox.UseVisualStyleBackColor = true;
            this.btnShowSelectedEntryInResultBox.Click += new System.EventHandler(this.CopySelectedEntryToMainWindowTextBox);
            // 
            // btnClearSelectedEntry
            // 
            this.btnClearSelectedEntry.Location = new System.Drawing.Point(164, 133);
            this.btnClearSelectedEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearSelectedEntry.Name = "btnClearSelectedEntry";
            this.btnClearSelectedEntry.Size = new System.Drawing.Size(63, 32);
            this.btnClearSelectedEntry.TabIndex = 1;
            this.btnClearSelectedEntry.Text = "CD";
            this.btnClearSelectedEntry.UseVisualStyleBackColor = true;
            this.btnClearSelectedEntry.Click += new System.EventHandler(this.DeleteSelectedEntry);
            // 
            // btnClearAllEntry
            // 
            this.btnClearAllEntry.Location = new System.Drawing.Point(235, 133);
            this.btnClearAllEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAllEntry.Name = "btnClearAllEntry";
            this.btnClearAllEntry.Size = new System.Drawing.Size(63, 32);
            this.btnClearAllEntry.TabIndex = 1;
            this.btnClearAllEntry.Text = "CAD";
            this.btnClearAllEntry.UseVisualStyleBackColor = true;
            this.btnClearAllEntry.Click += new System.EventHandler(this.ClearAllStatisticEntries);
            // 
            // lblStataticsEntryCount
            // 
            this.lblStataticsEntryCount.AutoSize = true;
            this.lblStataticsEntryCount.Location = new System.Drawing.Point(140, 174);
            this.lblStataticsEntryCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStataticsEntryCount.Name = "lblStataticsEntryCount";
            this.lblStataticsEntryCount.Size = new System.Drawing.Size(32, 17);
            this.lblStataticsEntryCount.TabIndex = 2;
            this.lblStataticsEntryCount.Text = "n=0";
            // 
            // lbxStatisticsEntries
            // 
            this.lbxStatisticsEntries.FormattingEnabled = true;
            this.lbxStatisticsEntries.ItemHeight = 16;
            this.lbxStatisticsEntries.Location = new System.Drawing.Point(23, 15);
            this.lbxStatisticsEntries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxStatisticsEntries.Name = "lbxStatisticsEntries";
            this.lbxStatisticsEntries.Size = new System.Drawing.Size(273, 100);
            this.lbxStatisticsEntries.TabIndex = 3;
            // 
            // frmStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 201);
            this.Controls.Add(this.lbxStatisticsEntries);
            this.Controls.Add(this.lblStataticsEntryCount);
            this.Controls.Add(this.btnClearAllEntry);
            this.Controls.Add(this.btnClearSelectedEntry);
            this.Controls.Add(this.btnShowSelectedEntryInResultBox);
            this.Controls.Add(this.btnFocusToMainWindow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatisticsForm";
            this.ShowIcon = false;
            this.Text = "Statistics Box";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisableStatisticsButtons);
            this.Load += new System.EventHandler(this.frmStatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFocusToMainWindow;
        private System.Windows.Forms.Button btnShowSelectedEntryInResultBox;
        private System.Windows.Forms.Button btnClearSelectedEntry;
        private System.Windows.Forms.Button btnClearAllEntry;
        public System.Windows.Forms.Label lblStataticsEntryCount;
        public System.Windows.Forms.ListBox lbxStatisticsEntries;
    }
}