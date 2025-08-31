namespace FortuneTeller
{
    partial class FormHistory
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
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Items.AddRange(new object[] {
            "2025-08-24 13:00:01 - 20071202 03 - 올해 귀인이 찾아와서..",
            "2025-08-24 13:02:01 - 20070208 05 - 올해 ..",
            "2025-08-24 13:03:01 - 20070922 03 - 올해 ..",
            "2025-08-24 13:05:01 - 20070302 12 - 올해 ..",
            "2025-08-24 13:07:01 - 20071004 13 - 올해 .."});
            this.lbHistory.Location = new System.Drawing.Point(12, 57);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(320, 381);
            this.lbHistory.TabIndex = 0;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(31, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(279, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "내역 다시 불러오기";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbHistory);
            this.Name = "FormHistory";
            this.Text = "내역 보기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnRefresh;
    }
}