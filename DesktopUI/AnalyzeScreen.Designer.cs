namespace DesktopUI
{
    partial class AnalyzeScreen
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
            this.x = new System.Windows.Forms.CheckedListBox();
            this.GetStocksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.FormattingEnabled = true;
            this.x.Items.AddRange(new object[] {
            "y"});
            this.x.Location = new System.Drawing.Point(12, 12);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(224, 598);
            this.x.TabIndex = 0;
            // 
            // GetStocksButton
            // 
            this.GetStocksButton.Location = new System.Drawing.Point(12, 616);
            this.GetStocksButton.Name = "GetStocksButton";
            this.GetStocksButton.Size = new System.Drawing.Size(75, 23);
            this.GetStocksButton.TabIndex = 1;
            this.GetStocksButton.Text = "Yükle";
            this.GetStocksButton.UseVisualStyleBackColor = true;
            this.GetStocksButton.Click += new System.EventHandler(this.GetStocksButton_Click);
            // 
            // AnalyzeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.GetStocksButton);
            this.Controls.Add(this.x);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnalyzeScreen";
            this.Text = "AnalyzeScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox x;
        private Button GetStocksButton;
    }
}