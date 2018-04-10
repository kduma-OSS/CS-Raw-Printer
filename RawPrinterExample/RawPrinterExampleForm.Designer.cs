namespace RawPrinterExample
{
    partial class RawPrinterExampleForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BPrintSample = new System.Windows.Forms.Button();
            this.BChoicePrinter = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LSelectedPrinter = new System.Windows.Forms.ToolStripStatusLabel();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.BSayHello = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BPrintSample
            // 
            this.BPrintSample.Location = new System.Drawing.Point(12, 53);
            this.BPrintSample.Name = "BPrintSample";
            this.BPrintSample.Size = new System.Drawing.Size(360, 35);
            this.BPrintSample.TabIndex = 3;
            this.BPrintSample.Text = "Print Sample!";
            this.BPrintSample.UseVisualStyleBackColor = true;
            this.BPrintSample.Click += new System.EventHandler(this.BPrintSample_Click);
            // 
            // BChoicePrinter
            // 
            this.BChoicePrinter.Location = new System.Drawing.Point(12, 12);
            this.BChoicePrinter.Name = "BChoicePrinter";
            this.BChoicePrinter.Size = new System.Drawing.Size(360, 35);
            this.BChoicePrinter.TabIndex = 2;
            this.BChoicePrinter.Text = "Choose printer";
            this.BChoicePrinter.UseVisualStyleBackColor = true;
            this.BChoicePrinter.Click += new System.EventHandler(this.BChoicePrinter_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LSelectedPrinter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 140);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = "Selected printer:";
            // 
            // LSelectedPrinter
            // 
            this.LSelectedPrinter.Name = "LSelectedPrinter";
            this.LSelectedPrinter.Size = new System.Drawing.Size(118, 17);
            this.LSelectedPrinter.Text = "toolStripStatusLabel2";
            // 
            // PrintDialog
            // 
            this.PrintDialog.AllowPrintToFile = false;
            this.PrintDialog.ShowNetwork = false;
            this.PrintDialog.UseEXDialog = true;
            // 
            // BSayHello
            // 
            this.BSayHello.Location = new System.Drawing.Point(12, 94);
            this.BSayHello.Name = "BSayHello";
            this.BSayHello.Size = new System.Drawing.Size(111, 21);
            this.BSayHello.TabIndex = 5;
            this.BSayHello.Text = "Say Hello";
            this.BSayHello.UseVisualStyleBackColor = true;
            this.BSayHello.Click += new System.EventHandler(this.BSayHello_Click);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(130, 95);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(242, 20);
            this.TBName.TabIndex = 6;
            this.TBName.Text = "Smith";
            // 
            // RawPrinterExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.BSayHello);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BPrintSample);
            this.Controls.Add(this.BChoicePrinter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "RawPrinterExampleForm";
            this.Text = "RawPrinter Example";
            this.Load += new System.EventHandler(this.RawPrinterExampleForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrintSample;
        private System.Windows.Forms.Button BChoicePrinter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LSelectedPrinter;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.Button BSayHello;
        private System.Windows.Forms.TextBox TBName;
    }
}

