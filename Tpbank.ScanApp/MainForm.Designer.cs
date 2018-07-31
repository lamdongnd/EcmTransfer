namespace Tpbank.ScanApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kRCTool = new ComponentFactory.Krypton.Ribbon.KryptonRibbonContext();
            this.krtTools = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.krg1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.krgt1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krg2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonContexts.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonContext[] {
            this.kRCTool});
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.krtTools,
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.krtTools;
            this.kryptonRibbon1.Size = new System.Drawing.Size(951, 115);
            this.kryptonRibbon1.TabIndex = 4;
            // 
            // kRCTool
            // 
            this.kRCTool.ContextTitle = "Context Tools";
            // 
            // krtTools
            // 
            this.krtTools.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.krg1,
            this.krg2});
            this.krtTools.Text = "Hệ thống";
            // 
            // krg1
            // 
            this.krg1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.krgt1});
            // 
            // krgt1
            // 
            this.krgt1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton3,
            this.kryptonRibbonGroupButton1,
            this.kryptonRibbonGroupButton2});
            // 
            // kryptonRibbonGroupButton1
            // 
            this.kryptonRibbonGroupButton1.ImageLarge = global::Tpbank.ScanApp.Properties.Resources.OpenFolder64;
            this.kryptonRibbonGroupButton1.ImageSmall = global::Tpbank.ScanApp.Properties.Resources.OpenFolder32;
            this.kryptonRibbonGroupButton1.TextLine1 = "Open";
            // 
            // kryptonRibbonGroupButton2
            // 
            this.kryptonRibbonGroupButton2.ImageLarge = global::Tpbank.ScanApp.Properties.Resources.Save64;
            this.kryptonRibbonGroupButton2.ImageSmall = global::Tpbank.ScanApp.Properties.Resources.Save32;
            this.kryptonRibbonGroupButton2.TextLine1 = "Save";
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.ImageLarge = global::Tpbank.ScanApp.Properties.Resources.NewBatch64;
            this.kryptonRibbonGroupButton3.ImageSmall = global::Tpbank.ScanApp.Properties.Resources.NewBatch32;
            this.kryptonRibbonGroupButton3.TextLine1 = "New";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 558);
            this.Controls.Add(this.kryptonRibbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.Text = "TPBanhScan";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab krtTools;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup krg1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup krg2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple krgt1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonContext kRCTool;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
    }
}



