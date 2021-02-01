
namespace Trinity.PoolManager
{
    partial class PoolManagerForm
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
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tvOverview = new System.Windows.Forms.TreeView();
            this.tpPoolConversion = new System.Windows.Forms.TabPage();
            this.tpPoolDesigner = new System.Windows.Forms.TabPage();
            this.ssStatus.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tpOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusText,
            this.pgStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 428);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(800, 22);
            this.ssStatus.TabIndex = 3;
            this.ssStatus.Resize += new System.EventHandler(this.statusStrip1_Resize);
            // 
            // tsStatusText
            // 
            this.tsStatusText.AutoSize = false;
            this.tsStatusText.Name = "tsStatusText";
            this.tsStatusText.Size = new System.Drawing.Size(200, 17);
            this.tsStatusText.Text = "Status Text";
            this.tsStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgStatus
            // 
            this.pgStatus.AutoSize = false;
            this.pgStatus.Name = "pgStatus";
            this.pgStatus.Size = new System.Drawing.Size(580, 16);
            this.pgStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpOverview);
            this.tbMain.Controls.Add(this.tpPoolConversion);
            this.tbMain.Controls.Add(this.tpPoolDesigner);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(800, 428);
            this.tbMain.TabIndex = 4;
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.splitContainer1);
            this.tpOverview.Location = new System.Drawing.Point(4, 24);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverview.Size = new System.Drawing.Size(792, 400);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Overview";
            this.tpOverview.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            this.splitContainer1.Panel1.Controls.Add(this.tvOverview);
            this.splitContainer1.Size = new System.Drawing.Size(786, 394);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(3, 363);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(196, 28);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tvOverview
            // 
            this.tvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvOverview.Location = new System.Drawing.Point(3, 3);
            this.tvOverview.Name = "tvOverview";
            this.tvOverview.Size = new System.Drawing.Size(196, 354);
            this.tvOverview.TabIndex = 10;
            // 
            // tpPoolConversion
            // 
            this.tpPoolConversion.Location = new System.Drawing.Point(4, 24);
            this.tpPoolConversion.Name = "tpPoolConversion";
            this.tpPoolConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tpPoolConversion.Size = new System.Drawing.Size(792, 400);
            this.tpPoolConversion.TabIndex = 1;
            this.tpPoolConversion.Text = "Legacy Pool Conversion";
            this.tpPoolConversion.UseVisualStyleBackColor = true;
            // 
            // tpPoolDesigner
            // 
            this.tpPoolDesigner.Location = new System.Drawing.Point(4, 24);
            this.tpPoolDesigner.Name = "tpPoolDesigner";
            this.tpPoolDesigner.Size = new System.Drawing.Size(792, 400);
            this.tpPoolDesigner.TabIndex = 2;
            this.tpPoolDesigner.Text = "Pool Designer";
            this.tpPoolDesigner.UseVisualStyleBackColor = true;
            // 
            // PoolManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.ssStatus);
            this.Name = "PoolManagerForm";
            this.Text = "Trinity Pool Manager";
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tpOverview.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusText;
        private System.Windows.Forms.ToolStripProgressBar pgStatus;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.TabPage tpPoolConversion;
        private System.Windows.Forms.TabPage tpPoolDesigner;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView tvOverview;
    }
}

