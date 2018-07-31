namespace TpBank.Core.Componet.ScanEngine
{
    partial class Scan_TCSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan_TCSV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainTwainContent = new Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain();
            this.dynamicDotNetTwain = new Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain();
            this.picboxNext = new System.Windows.Forms.PictureBox();
            this.picboxLast = new System.Windows.Forms.PictureBox();
            this.picboxPrevious = new System.Windows.Forms.PictureBox();
            this.tbxTotalImageNum = new System.Windows.Forms.TextBox();
            this.picboxFirst = new System.Windows.Forms.PictureBox();
            this.cbxViewMode = new System.Windows.Forms.ComboBox();
            this.tbxCurrentImageIndex = new System.Windows.Forms.TextBox();
            this.lbDiv = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rdbColor = new System.Windows.Forms.RadioButton();
            this.rdbBw = new System.Windows.Forms.RadioButton();
            this.lbSelectSource = new System.Windows.Forms.Label();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.cbDuplex = new System.Windows.Forms.CheckBox();
            this.cbInsert1 = new System.Windows.Forms.CheckBox();
            this.btScan = new System.Windows.Forms.Button();
            this.btSubmitScan = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbInsert2 = new System.Windows.Forms.CheckBox();
            this.btSubmitLoad = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.GrbTool = new System.Windows.Forms.GroupBox();
            this.lbGeneral = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picboxDeleteAll = new System.Windows.Forms.PictureBox();
            this.lbSwitch = new System.Windows.Forms.Label();
            this.picboxDelete = new System.Windows.Forms.PictureBox();
            this.picboxZoomIn = new System.Windows.Forms.PictureBox();
            this.picboxHand = new System.Windows.Forms.PictureBox();
            this.picboxRight = new System.Windows.Forms.PictureBox();
            this.picboxPoint = new System.Windows.Forms.PictureBox();
            this.picboxLeft = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbReshape = new System.Windows.Forms.Label();
            this.picboxRotateRight = new System.Windows.Forms.PictureBox();
            this.picboxZoomOut = new System.Windows.Forms.PictureBox();
            this.picboxRotateLeft = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFirst)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbAction.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrbTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDeleteAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRotateRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRotateLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dynamicDotNetTwain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 634);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GrbTool);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(720, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(237, 634);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picboxNext);
            this.panel3.Controls.Add(this.picboxLast);
            this.panel3.Controls.Add(this.picboxPrevious);
            this.panel3.Controls.Add(this.tbxTotalImageNum);
            this.panel3.Controls.Add(this.picboxFirst);
            this.panel3.Controls.Add(this.cbxViewMode);
            this.panel3.Controls.Add(this.tbxCurrentImageIndex);
            this.panel3.Controls.Add(this.lbDiv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 567);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 67);
            this.panel3.TabIndex = 2;
            // 
            // mainTwainContent
            // 
            this.mainTwainContent.AnnotationFillColor = System.Drawing.Color.White;
            this.mainTwainContent.AnnotationPen = null;
            this.mainTwainContent.AnnotationTextColor = System.Drawing.Color.Black;
            this.mainTwainContent.AnnotationTextFont = null;
            this.mainTwainContent.AutoSize = true;
            this.mainTwainContent.BackColor = System.Drawing.SystemColors.Window;
            this.mainTwainContent.BorderStyle = Dynamsoft.DotNet.TWAIN.Enums.DWTWndBorderStyle.SingleFlat;
            this.mainTwainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTwainContent.IfShowCancelDialogWhenImageTransfer = false;
            this.mainTwainContent.IfShowPrintUI = false;
            this.mainTwainContent.IfThrowException = false;
            this.mainTwainContent.Location = new System.Drawing.Point(200, 0);
            this.mainTwainContent.LogLevel = ((short)(0));
            this.mainTwainContent.Name = "mainTwainContent";
            this.mainTwainContent.PDFConvertMode = Dynamsoft.DotNet.TWAIN.Enums.EnumPDFConvertMode.enumCM_DEFAULT;
            this.mainTwainContent.PDFMarginBottom = ((uint)(0u));
            this.mainTwainContent.PDFMarginLeft = ((uint)(0u));
            this.mainTwainContent.PDFMarginRight = ((uint)(0u));
            this.mainTwainContent.PDFMarginTop = ((uint)(0u));
            this.mainTwainContent.PDFXConformance = ((uint)(0u));
            this.mainTwainContent.ProductFamily = "Dynamic .NET TWAIN (.NET Framewor";
            this.mainTwainContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTwainContent.Size = new System.Drawing.Size(520, 567);
            this.mainTwainContent.TabIndex = 81;
            // 
            // dynamicDotNetTwain
            // 
            this.dynamicDotNetTwain.AnnotationFillColor = System.Drawing.Color.White;
            this.dynamicDotNetTwain.AnnotationPen = null;
            this.dynamicDotNetTwain.AnnotationTextColor = System.Drawing.Color.Black;
            this.dynamicDotNetTwain.AnnotationTextFont = null;
            this.dynamicDotNetTwain.AutoSize = true;
            this.dynamicDotNetTwain.BackColor = System.Drawing.Color.Silver;
            this.dynamicDotNetTwain.BorderStyle = Dynamsoft.DotNet.TWAIN.Enums.DWTWndBorderStyle.SingleFlat;
            this.dynamicDotNetTwain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dynamicDotNetTwain.IfShowCancelDialogWhenImageTransfer = false;
            this.dynamicDotNetTwain.IfShowPrintUI = false;
            this.dynamicDotNetTwain.IfThrowException = false;
            this.dynamicDotNetTwain.Location = new System.Drawing.Point(0, 0);
            this.dynamicDotNetTwain.LogLevel = ((short)(0));
            this.dynamicDotNetTwain.Name = "dynamicDotNetTwain";
            this.dynamicDotNetTwain.PDFConvertMode = Dynamsoft.DotNet.TWAIN.Enums.EnumPDFConvertMode.enumCM_DEFAULT;
            this.dynamicDotNetTwain.PDFMarginBottom = ((uint)(0u));
            this.dynamicDotNetTwain.PDFMarginLeft = ((uint)(0u));
            this.dynamicDotNetTwain.PDFMarginRight = ((uint)(0u));
            this.dynamicDotNetTwain.PDFMarginTop = ((uint)(0u));
            this.dynamicDotNetTwain.PDFXConformance = ((uint)(0u));
            this.dynamicDotNetTwain.ProductFamily = "Dynamic .NET TWAIN (.NET Framewor";
            this.dynamicDotNetTwain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dynamicDotNetTwain.Size = new System.Drawing.Size(200, 634);
            this.dynamicDotNetTwain.TabIndex = 82;
            // 
            // picboxNext
            // 
            this.picboxNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picboxNext.Image = ((System.Drawing.Image)(resources.GetObject("picboxNext.Image")));
            this.picboxNext.Location = new System.Drawing.Point(296, 24);
            this.picboxNext.Name = "picboxNext";
            this.picboxNext.Size = new System.Drawing.Size(50, 25);
            this.picboxNext.TabIndex = 80;
            this.picboxNext.TabStop = false;
            this.picboxNext.Tag = "Next Image";
            // 
            // picboxLast
            // 
            this.picboxLast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picboxLast.Image = ((System.Drawing.Image)(resources.GetObject("picboxLast.Image")));
            this.picboxLast.Location = new System.Drawing.Point(351, 24);
            this.picboxLast.Name = "picboxLast";
            this.picboxLast.Size = new System.Drawing.Size(50, 25);
            this.picboxLast.TabIndex = 79;
            this.picboxLast.TabStop = false;
            this.picboxLast.Tag = "Last Image";
            // 
            // picboxPrevious
            // 
            this.picboxPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picboxPrevious.Image = ((System.Drawing.Image)(resources.GetObject("picboxPrevious.Image")));
            this.picboxPrevious.Location = new System.Drawing.Point(92, 24);
            this.picboxPrevious.Name = "picboxPrevious";
            this.picboxPrevious.Size = new System.Drawing.Size(50, 25);
            this.picboxPrevious.TabIndex = 81;
            this.picboxPrevious.TabStop = false;
            this.picboxPrevious.Tag = "Previous Image";
            // 
            // tbxTotalImageNum
            // 
            this.tbxTotalImageNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxTotalImageNum.Enabled = false;
            this.tbxTotalImageNum.Location = new System.Drawing.Point(230, 26);
            this.tbxTotalImageNum.Name = "tbxTotalImageNum";
            this.tbxTotalImageNum.ReadOnly = true;
            this.tbxTotalImageNum.Size = new System.Drawing.Size(61, 20);
            this.tbxTotalImageNum.TabIndex = 85;
            this.tbxTotalImageNum.Text = "0";
            // 
            // picboxFirst
            // 
            this.picboxFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picboxFirst.Image = ((System.Drawing.Image)(resources.GetObject("picboxFirst.Image")));
            this.picboxFirst.Location = new System.Drawing.Point(37, 24);
            this.picboxFirst.Name = "picboxFirst";
            this.picboxFirst.Size = new System.Drawing.Size(50, 25);
            this.picboxFirst.TabIndex = 78;
            this.picboxFirst.TabStop = false;
            this.picboxFirst.Tag = "First Image";
            // 
            // cbxViewMode
            // 
            this.cbxViewMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxViewMode.FormattingEnabled = true;
            this.cbxViewMode.Items.AddRange(new object[] {
            "1 x 1",
            "2 x 2",
            "3 x 3",
            "4 x 4",
            "5 x 5"});
            this.cbxViewMode.Location = new System.Drawing.Point(406, 26);
            this.cbxViewMode.Name = "cbxViewMode";
            this.cbxViewMode.Size = new System.Drawing.Size(75, 21);
            this.cbxViewMode.TabIndex = 82;
            // 
            // tbxCurrentImageIndex
            // 
            this.tbxCurrentImageIndex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxCurrentImageIndex.Enabled = false;
            this.tbxCurrentImageIndex.Location = new System.Drawing.Point(147, 26);
            this.tbxCurrentImageIndex.Name = "tbxCurrentImageIndex";
            this.tbxCurrentImageIndex.ReadOnly = true;
            this.tbxCurrentImageIndex.Size = new System.Drawing.Size(61, 20);
            this.tbxCurrentImageIndex.TabIndex = 84;
            this.tbxCurrentImageIndex.Text = "0";
            this.tbxCurrentImageIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDiv
            // 
            this.lbDiv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDiv.AutoSize = true;
            this.lbDiv.BackColor = System.Drawing.Color.Transparent;
            this.lbDiv.Location = new System.Drawing.Point(213, 30);
            this.lbDiv.Name = "lbDiv";
            this.lbDiv.Size = new System.Drawing.Size(12, 13);
            this.lbDiv.TabIndex = 83;
            this.lbDiv.Text = "/";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(231, 289);
            this.tabControl1.TabIndex = 125;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbAction);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(223, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.btnRefresh);
            this.grbAction.Controls.Add(this.rdbColor);
            this.grbAction.Controls.Add(this.rdbBw);
            this.grbAction.Controls.Add(this.lbSelectSource);
            this.grbAction.Controls.Add(this.cbxSource);
            this.grbAction.Controls.Add(this.cbDuplex);
            this.grbAction.Controls.Add(this.cbInsert1);
            this.grbAction.Controls.Add(this.btScan);
            this.grbAction.Controls.Add(this.btSubmitScan);
            this.grbAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAction.Location = new System.Drawing.Point(5, 11);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(203, 244);
            this.grbAction.TabIndex = 0;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Action";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(167, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRefresh.Size = new System.Drawing.Size(29, 22);
            this.btnRefresh.TabIndex = 91;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // rdbColor
            // 
            this.rdbColor.AutoSize = true;
            this.rdbColor.Location = new System.Drawing.Point(106, 75);
            this.rdbColor.Name = "rdbColor";
            this.rdbColor.Size = new System.Drawing.Size(54, 19);
            this.rdbColor.TabIndex = 90;
            this.rdbColor.Text = "Color";
            this.rdbColor.UseVisualStyleBackColor = true;
            // 
            // rdbBw
            // 
            this.rdbBw.AutoSize = true;
            this.rdbBw.Checked = true;
            this.rdbBw.Location = new System.Drawing.Point(6, 75);
            this.rdbBw.Name = "rdbBw";
            this.rdbBw.Size = new System.Drawing.Size(45, 19);
            this.rdbBw.TabIndex = 89;
            this.rdbBw.TabStop = true;
            this.rdbBw.Text = "BW";
            this.rdbBw.UseVisualStyleBackColor = true;
            // 
            // lbSelectSource
            // 
            this.lbSelectSource.AutoSize = true;
            this.lbSelectSource.BackColor = System.Drawing.Color.Transparent;
            this.lbSelectSource.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectSource.Location = new System.Drawing.Point(5, 19);
            this.lbSelectSource.Name = "lbSelectSource";
            this.lbSelectSource.Size = new System.Drawing.Size(83, 15);
            this.lbSelectSource.TabIndex = 84;
            this.lbSelectSource.Text = "Select Source :";
            // 
            // cbxSource
            // 
            this.cbxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSource.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(6, 39);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(191, 22);
            this.cbxSource.TabIndex = 84;
            // 
            // cbDuplex
            // 
            this.cbDuplex.AutoSize = true;
            this.cbDuplex.Location = new System.Drawing.Point(7, 107);
            this.cbDuplex.Name = "cbDuplex";
            this.cbDuplex.Size = new System.Drawing.Size(151, 19);
            this.cbDuplex.TabIndex = 88;
            this.cbDuplex.Text = "Cho phép Scan hai mặt";
            this.cbDuplex.UseVisualStyleBackColor = true;
            // 
            // cbInsert1
            // 
            this.cbInsert1.AutoSize = true;
            this.cbInsert1.Location = new System.Drawing.Point(7, 129);
            this.cbInsert1.Name = "cbInsert1";
            this.cbInsert1.Size = new System.Drawing.Size(97, 19);
            this.cbInsert1.TabIndex = 2;
            this.cbInsert1.Text = "Insert Image";
            this.cbInsert1.UseVisualStyleBackColor = true;
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(6, 154);
            this.btScan.Name = "btScan";
            this.btScan.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btScan.Size = new System.Drawing.Size(194, 39);
            this.btScan.TabIndex = 0;
            this.btScan.Text = "Scan";
            this.btScan.UseVisualStyleBackColor = true;
            // 
            // btSubmitScan
            // 
            this.btSubmitScan.Location = new System.Drawing.Point(6, 199);
            this.btSubmitScan.Name = "btSubmitScan";
            this.btSubmitScan.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btSubmitScan.Size = new System.Drawing.Size(194, 39);
            this.btSubmitScan.TabIndex = 1;
            this.btSubmitScan.Text = "Submit";
            this.btSubmitScan.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(229, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load From Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbInsert2);
            this.groupBox1.Controls.Add(this.btSubmitLoad);
            this.groupBox1.Controls.Add(this.btLoad);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // cbInsert2
            // 
            this.cbInsert2.AutoSize = true;
            this.cbInsert2.Location = new System.Drawing.Point(6, 32);
            this.cbInsert2.Name = "cbInsert2";
            this.cbInsert2.Size = new System.Drawing.Size(97, 19);
            this.cbInsert2.TabIndex = 2;
            this.cbInsert2.Text = "Insert Image";
            this.cbInsert2.UseVisualStyleBackColor = true;
            // 
            // btSubmitLoad
            // 
            this.btSubmitLoad.Location = new System.Drawing.Point(6, 116);
            this.btSubmitLoad.Name = "btSubmitLoad";
            this.btSubmitLoad.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btSubmitLoad.Size = new System.Drawing.Size(191, 39);
            this.btSubmitLoad.TabIndex = 1;
            this.btSubmitLoad.Text = "Submit";
            this.btSubmitLoad.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(6, 68);
            this.btLoad.Name = "btLoad";
            this.btLoad.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btLoad.Size = new System.Drawing.Size(191, 39);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            // 
            // GrbTool
            // 
            this.GrbTool.Controls.Add(this.lbGeneral);
            this.GrbTool.Controls.Add(this.label4);
            this.GrbTool.Controls.Add(this.picboxDeleteAll);
            this.GrbTool.Controls.Add(this.lbSwitch);
            this.GrbTool.Controls.Add(this.picboxDelete);
            this.GrbTool.Controls.Add(this.picboxZoomIn);
            this.GrbTool.Controls.Add(this.picboxHand);
            this.GrbTool.Controls.Add(this.picboxRight);
            this.GrbTool.Controls.Add(this.picboxPoint);
            this.GrbTool.Controls.Add(this.picboxLeft);
            this.GrbTool.Controls.Add(this.label3);
            this.GrbTool.Controls.Add(this.lbReshape);
            this.GrbTool.Controls.Add(this.picboxRotateRight);
            this.GrbTool.Controls.Add(this.picboxZoomOut);
            this.GrbTool.Controls.Add(this.picboxRotateLeft);
            this.GrbTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbTool.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbTool.Location = new System.Drawing.Point(3, 292);
            this.GrbTool.Name = "GrbTool";
            this.GrbTool.Size = new System.Drawing.Size(231, 339);
            this.GrbTool.TabIndex = 131;
            this.GrbTool.TabStop = false;
            this.GrbTool.Text = "Tools";
            // 
            // lbGeneral
            // 
            this.lbGeneral.AutoSize = true;
            this.lbGeneral.BackColor = System.Drawing.Color.White;
            this.lbGeneral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneral.Location = new System.Drawing.Point(40, 16);
            this.lbGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeneral.Name = "lbGeneral";
            this.lbGeneral.Size = new System.Drawing.Size(47, 15);
            this.lbGeneral.TabIndex = 124;
            this.lbGeneral.Text = "General";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 130;
            this.label4.Text = "Delete && Delete All";
            // 
            // picboxDeleteAll
            // 
            this.picboxDeleteAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("picboxDeleteAll.Image")));
            this.picboxDeleteAll.Location = new System.Drawing.Point(122, 282);
            this.picboxDeleteAll.Name = "picboxDeleteAll";
            this.picboxDeleteAll.Size = new System.Drawing.Size(62, 35);
            this.picboxDeleteAll.TabIndex = 38;
            this.picboxDeleteAll.TabStop = false;
            this.picboxDeleteAll.Tag = "Delete All";
            // 
            // lbSwitch
            // 
            this.lbSwitch.AutoSize = true;
            this.lbSwitch.BackColor = System.Drawing.Color.White;
            this.lbSwitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSwitch.Location = new System.Drawing.Point(40, 135);
            this.lbSwitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSwitch.Name = "lbSwitch";
            this.lbSwitch.Size = new System.Drawing.Size(73, 15);
            this.lbSwitch.TabIndex = 127;
            this.lbSwitch.Text = "Move Image";
            // 
            // picboxDelete
            // 
            this.picboxDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxDelete.Image = ((System.Drawing.Image)(resources.GetObject("picboxDelete.Image")));
            this.picboxDelete.Location = new System.Drawing.Point(39, 282);
            this.picboxDelete.Name = "picboxDelete";
            this.picboxDelete.Size = new System.Drawing.Size(62, 35);
            this.picboxDelete.TabIndex = 36;
            this.picboxDelete.TabStop = false;
            this.picboxDelete.Tag = "Delete Current Image";
            // 
            // picboxZoomIn
            // 
            this.picboxZoomIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("picboxZoomIn.Image")));
            this.picboxZoomIn.Location = new System.Drawing.Point(39, 223);
            this.picboxZoomIn.Name = "picboxZoomIn";
            this.picboxZoomIn.Size = new System.Drawing.Size(62, 35);
            this.picboxZoomIn.TabIndex = 32;
            this.picboxZoomIn.TabStop = false;
            this.picboxZoomIn.Tag = "Zoom In";
            // 
            // picboxHand
            // 
            this.picboxHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxHand.Image = ((System.Drawing.Image)(resources.GetObject("picboxHand.Image")));
            this.picboxHand.Location = new System.Drawing.Point(43, 34);
            this.picboxHand.Name = "picboxHand";
            this.picboxHand.Size = new System.Drawing.Size(60, 36);
            this.picboxHand.TabIndex = 125;
            this.picboxHand.TabStop = false;
            this.picboxHand.Tag = "Move";
            // 
            // picboxRight
            // 
            this.picboxRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRight.Image = ((System.Drawing.Image)(resources.GetObject("picboxRight.Image")));
            this.picboxRight.Location = new System.Drawing.Point(122, 159);
            this.picboxRight.Name = "picboxRight";
            this.picboxRight.Size = new System.Drawing.Size(62, 35);
            this.picboxRight.TabIndex = 28;
            this.picboxRight.TabStop = false;
            this.picboxRight.Tag = "Move Right";
            // 
            // picboxPoint
            // 
            this.picboxPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxPoint.Image = ((System.Drawing.Image)(resources.GetObject("picboxPoint.Image")));
            this.picboxPoint.Location = new System.Drawing.Point(123, 34);
            this.picboxPoint.Name = "picboxPoint";
            this.picboxPoint.Size = new System.Drawing.Size(61, 36);
            this.picboxPoint.TabIndex = 126;
            this.picboxPoint.TabStop = false;
            this.picboxPoint.Tag = "Select";
            // 
            // picboxLeft
            // 
            this.picboxLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxLeft.Image = ((System.Drawing.Image)(resources.GetObject("picboxLeft.Image")));
            this.picboxLeft.Location = new System.Drawing.Point(41, 159);
            this.picboxLeft.Name = "picboxLeft";
            this.picboxLeft.Size = new System.Drawing.Size(62, 35);
            this.picboxLeft.TabIndex = 26;
            this.picboxLeft.TabStop = false;
            this.picboxLeft.Tag = "Move Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 128;
            this.label3.Text = "Zoom";
            // 
            // lbReshape
            // 
            this.lbReshape.AutoSize = true;
            this.lbReshape.BackColor = System.Drawing.Color.White;
            this.lbReshape.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReshape.Location = new System.Drawing.Point(44, 74);
            this.lbReshape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReshape.Name = "lbReshape";
            this.lbReshape.Size = new System.Drawing.Size(41, 15);
            this.lbReshape.TabIndex = 39;
            this.lbReshape.Text = "Rotate";
            // 
            // picboxRotateRight
            // 
            this.picboxRotateRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("picboxRotateRight.Image")));
            this.picboxRotateRight.Location = new System.Drawing.Point(43, 94);
            this.picboxRotateRight.Name = "picboxRotateRight";
            this.picboxRotateRight.Size = new System.Drawing.Size(62, 35);
            this.picboxRotateRight.TabIndex = 21;
            this.picboxRotateRight.TabStop = false;
            this.picboxRotateRight.Tag = "Rotate Right";
            // 
            // picboxZoomOut
            // 
            this.picboxZoomOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("picboxZoomOut.Image")));
            this.picboxZoomOut.Location = new System.Drawing.Point(122, 223);
            this.picboxZoomOut.Name = "picboxZoomOut";
            this.picboxZoomOut.Size = new System.Drawing.Size(62, 35);
            this.picboxZoomOut.TabIndex = 34;
            this.picboxZoomOut.TabStop = false;
            this.picboxZoomOut.Tag = "Zoom Out";
            // 
            // picboxRotateLeft
            // 
            this.picboxRotateLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("picboxRotateLeft.Image")));
            this.picboxRotateLeft.Location = new System.Drawing.Point(124, 94);
            this.picboxRotateLeft.Name = "picboxRotateLeft";
            this.picboxRotateLeft.Size = new System.Drawing.Size(62, 35);
            this.picboxRotateLeft.TabIndex = 23;
            this.picboxRotateLeft.TabStop = false;
            this.picboxRotateLeft.Tag = "Rotate Left";
            // 
            // Scan_TCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTwainContent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Scan_TCSV";
            this.Size = new System.Drawing.Size(957, 634);
            this.Load += new System.EventHandler(this.MainScanBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFirst)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbAction.ResumeLayout(false);
            this.grbAction.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrbTool.ResumeLayout(false);
            this.GrbTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDeleteAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRotateRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRotateLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain mainTwainContent;
        private Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain dynamicDotNetTwain;
        private System.Windows.Forms.PictureBox picboxNext;
        private System.Windows.Forms.PictureBox picboxLast;
        private System.Windows.Forms.PictureBox picboxPrevious;
        private System.Windows.Forms.TextBox tbxTotalImageNum;
        private System.Windows.Forms.PictureBox picboxFirst;
        private System.Windows.Forms.ComboBox cbxViewMode;
        private System.Windows.Forms.TextBox tbxCurrentImageIndex;
        private System.Windows.Forms.Label lbDiv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rdbColor;
        private System.Windows.Forms.RadioButton rdbBw;
        private System.Windows.Forms.Label lbSelectSource;
        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.CheckBox cbDuplex;
        private System.Windows.Forms.CheckBox cbInsert1;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.Button btSubmitScan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbInsert2;
        private System.Windows.Forms.Button btSubmitLoad;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.GroupBox GrbTool;
        private System.Windows.Forms.Label lbGeneral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picboxDeleteAll;
        private System.Windows.Forms.Label lbSwitch;
        private System.Windows.Forms.PictureBox picboxDelete;
        private System.Windows.Forms.PictureBox picboxZoomIn;
        private System.Windows.Forms.PictureBox picboxHand;
        private System.Windows.Forms.PictureBox picboxRight;
        private System.Windows.Forms.PictureBox picboxPoint;
        private System.Windows.Forms.PictureBox picboxLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbReshape;
        private System.Windows.Forms.PictureBox picboxRotateRight;
        private System.Windows.Forms.PictureBox picboxZoomOut;
        private System.Windows.Forms.PictureBox picboxRotateLeft;
    }
}
