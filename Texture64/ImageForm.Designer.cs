using System;

namespace Texture64
{
   partial class ImageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.vScrollBarOffset = new System.Windows.Forms.VScrollBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCodec = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripAlpha = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripScale = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bgColorButton = new System.Windows.Forms.ToolStripButton();
            this.SwapRedBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAbout = new System.Windows.Forms.ToolStripButton();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.colorDialogBg = new System.Windows.Forms.ColorDialog();
            this.groupBoxPalette = new System.Windows.Forms.GroupBox();
            this.checkExtPalette = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericSplitOffset = new System.Windows.Forms.NumericUpDown();
            this.numericSplitLength = new System.Windows.Forms.NumericUpDown();
            this.numericPalette = new System.Windows.Forms.NumericUpDown();
            this.paletteFileLabel = new System.Windows.Forms.Label();
            this.loadPaletteButton = new System.Windows.Forms.Button();
            this.splitMinusButton = new System.Windows.Forms.Button();
            this.splitPlusButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitPaletteCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gvContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gvExport = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvSetPaletteBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.gvSetPaletteAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericOffset = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelColorA = new System.Windows.Forms.Label();
            this.labelColorB = new System.Windows.Forms.Label();
            this.labelColorG = new System.Windows.Forms.Label();
            this.labelColorR = new System.Windows.Forms.Label();
            this.labelColorHex = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gviewPalette = new Texture64.GraphicsViewer();
            this.graphicsViewerCustom = new Texture64.GraphicsViewer();
            this.graphicsViewer8x16 = new Texture64.GraphicsViewer();
            this.graphicsViewer64x64 = new Texture64.GraphicsViewer();
            this.graphicsViewer64x32 = new Texture64.GraphicsViewer();
            this.graphicsViewer32x64 = new Texture64.GraphicsViewer();
            this.graphicsViewer8x8 = new Texture64.GraphicsViewer();
            this.graphicsViewer16x32 = new Texture64.GraphicsViewer();
            this.graphicsViewer16x16 = new Texture64.GraphicsViewer();
            this.graphicsViewer32x32 = new Texture64.GraphicsViewer();
            this.graphicsViewerMap = new Texture64.GraphicsViewer();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.groupBoxPalette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPalette)).BeginInit();
            this.gvContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripFile,
            this.toolStripStatusLabel1,
            this.statusStripSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1085);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1574, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripFile
            // 
            this.statusStripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripFile.Name = "statusStripFile";
            this.statusStripFile.Size = new System.Drawing.Size(51, 32);
            this.statusStripFile.Text = "File";
            this.statusStripFile.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.statusStripFile.ToolTipText = "File Path";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1436, 32);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusStripSize
            // 
            this.statusStripSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripSize.Name = "statusStripSize";
            this.statusStripSize.Size = new System.Drawing.Size(57, 32);
            this.statusStripSize.Text = "Size";
            this.statusStripSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusStripSize.ToolTipText = "File Size (hex)";
            // 
            // vScrollBarOffset
            // 
            this.vScrollBarOffset.Dock = System.Windows.Forms.DockStyle.Left;
            this.vScrollBarOffset.Enabled = false;
            this.vScrollBarOffset.LargeChange = 256;
            this.vScrollBarOffset.Location = new System.Drawing.Point(0, 50);
            this.vScrollBarOffset.Maximum = 1024;
            this.vScrollBarOffset.Name = "vScrollBarOffset";
            this.vScrollBarOffset.Size = new System.Drawing.Size(17, 1035);
            this.vScrollBarOffset.SmallChange = 4;
            this.vScrollBarOffset.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpen,
            this.toolStripInsert,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripCodec,
            this.toolStripLabel3,
            this.toolStripAlpha,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripScale,
            this.toolStripSeparator4,
            this.bgColorButton,
            this.SwapRedBlue,
            this.toolStripSeparator3,
            this.toolStripAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1574, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(112, 44);
            this.toolStripOpen.Text = "&Open...";
            this.toolStripOpen.ToolTipText = "Open... [Ctrl-O]";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripInsert
            // 
            this.toolStripInsert.Enabled = false;
            this.toolStripInsert.Image = global::Texture64.Properties.Resources.image_import;
            this.toolStripInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInsert.Name = "toolStripInsert";
            this.toolStripInsert.Size = new System.Drawing.Size(112, 44);
            this.toolStripInsert.Text = "&Insert...";
            this.toolStripInsert.ToolTipText = "Insert... [Ctrl-I]";
            this.toolStripInsert.Click += new System.EventHandler(this.toolStripInsert_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.Enabled = false;
            this.toolStripSave.Image = global::Texture64.Properties.Resources.disk_black;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(88, 44);
            this.toolStripSave.Text = "&Save";
            this.toolStripSave.ToolTipText = "Save [Ctrl-S]";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 44);
            this.toolStripLabel2.Text = "Codec:";
            // 
            // toolStripCodec
            // 
            this.toolStripCodec.AutoSize = false;
            this.toolStripCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCodec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripCodec.Items.AddRange(new object[] {
            "RGBA16",
            "RGBA32",
            "IA16",
            "IA8",
            "IA4",
            "I8",
            "I4",
            "CI8",
            "CI4",
            "ONEBPP",
            "RGB565",
            "RGB555",
            "RGB24",
            "RGB8",
            "YUV422",
            "YUV420",
            "GRAYSCALE16",
            "GRAYSCALE8",
            "CMYK",
            "ARGB4444",
            "ARGB1555",
            "RGBA5551",
            "HSV",
            "HSL",
            "LAB",
            "XYZ",
            "BC1",
            "BC2",
            "BC3",
            "ETC1",
            "ETC2",
            "PVRTC",
            "ASTC",
            "RLE",
            "TWOBPP",
            "FOURBPP",
            "S3TC"});
            this.toolStripCodec.Name = "toolStripCodec";
            this.toolStripCodec.Size = new System.Drawing.Size(220, 40);
            this.toolStripCodec.SelectedIndexChanged += new System.EventHandler(this.toolStripCodec_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(80, 44);
            this.toolStripLabel3.Text = "Alpha:";
            // 
            // toolStripAlpha
            // 
            this.toolStripAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripAlpha.DropDownWidth = 65;
            this.toolStripAlpha.Enabled = false;
            this.toolStripAlpha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripAlpha.Items.AddRange(new object[] {
            "Intensity",
            "Binary",
            "Full"});
            this.toolStripAlpha.Name = "toolStripAlpha";
            this.toolStripAlpha.Size = new System.Drawing.Size(75, 50);
            this.toolStripAlpha.SelectedIndexChanged += new System.EventHandler(this.toolStripAlpha_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 44);
            this.toolStripLabel1.Text = "Scale:";
            // 
            // toolStripScale
            // 
            this.toolStripScale.AutoSize = false;
            this.toolStripScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripScale.DropDownWidth = 50;
            this.toolStripScale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripScale.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x"});
            this.toolStripScale.Name = "toolStripScale";
            this.toolStripScale.Size = new System.Drawing.Size(80, 40);
            this.toolStripScale.SelectedIndexChanged += new System.EventHandler(this.toolStripScale_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // bgColorButton
            // 
            this.bgColorButton.Image = global::Texture64.Properties.Resources.color;
            this.bgColorButton.Name = "bgColorButton";
            this.bgColorButton.Size = new System.Drawing.Size(68, 44);
            this.bgColorButton.Text = "&BG";
            this.bgColorButton.ToolTipText = "BG Color [Ctrl-B]";
            this.bgColorButton.Click += new System.EventHandler(this.bgColorButton_Click);
            // 
            // SwapRedBlue
            // 
            this.SwapRedBlue.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.SwapRedBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SwapRedBlue.Image = ((System.Drawing.Image)(resources.GetObject("SwapRedBlue.Image")));
            this.SwapRedBlue.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.SwapRedBlue.Name = "SwapRedBlue";
            this.SwapRedBlue.Size = new System.Drawing.Size(46, 44);
            this.SwapRedBlue.Text = "Swap Red/Blue";
            this.SwapRedBlue.Click += new System.EventHandler(this.SwapRedBlue_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAbout.Image = global::Texture64.Properties.Resources.question;
            this.toolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(46, 44);
            this.toolStripAbout.Text = "About";
            this.toolStripAbout.ToolTipText = "About [F1]";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(102, 6);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(88, 31);
            this.numericUpDownWidth.TabIndex = 10;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "x";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(226, 6);
            this.numericUpDownHeight.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(88, 31);
            this.numericUpDownHeight.TabIndex = 13;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // groupBoxPalette
            // 
            this.groupBoxPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPalette.Controls.Add(this.checkExtPalette);
            this.groupBoxPalette.Controls.Add(this.label15);
            this.groupBoxPalette.Controls.Add(this.numericSplitOffset);
            this.groupBoxPalette.Controls.Add(this.numericSplitLength);
            this.groupBoxPalette.Controls.Add(this.numericPalette);
            this.groupBoxPalette.Controls.Add(this.paletteFileLabel);
            this.groupBoxPalette.Controls.Add(this.loadPaletteButton);
            this.groupBoxPalette.Controls.Add(this.splitMinusButton);
            this.groupBoxPalette.Controls.Add(this.splitPlusButton);
            this.groupBoxPalette.Controls.Add(this.label6);
            this.groupBoxPalette.Controls.Add(this.label5);
            this.groupBoxPalette.Controls.Add(this.splitPaletteCheck);
            this.groupBoxPalette.Controls.Add(this.label4);
            this.groupBoxPalette.Controls.Add(this.gviewPalette);
            this.groupBoxPalette.Location = new System.Drawing.Point(1276, 319);
            this.groupBoxPalette.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxPalette.Name = "groupBoxPalette";
            this.groupBoxPalette.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxPalette.Size = new System.Drawing.Size(286, 665);
            this.groupBoxPalette.TabIndex = 16;
            this.groupBoxPalette.TabStop = false;
            this.groupBoxPalette.Text = "CI Palette:";
            this.groupBoxPalette.Visible = false;
            // 
            // checkExtPalette
            // 
            this.checkExtPalette.AutoSize = true;
            this.checkExtPalette.Location = new System.Drawing.Point(12, 531);
            this.checkExtPalette.Margin = new System.Windows.Forms.Padding(6);
            this.checkExtPalette.Name = "checkExtPalette";
            this.checkExtPalette.Size = new System.Drawing.Size(240, 29);
            this.checkExtPalette.TabIndex = 39;
            this.checkExtPalette.Text = "Use External Palette";
            this.checkExtPalette.UseVisualStyleBackColor = true;
            this.checkExtPalette.CheckedChanged += new System.EventHandler(this.checkExtPalette_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(6, 519);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(276, 4);
            this.label15.TabIndex = 38;
            // 
            // numericSplitOffset
            // 
            this.numericSplitOffset.Enabled = false;
            this.numericSplitOffset.Hexadecimal = true;
            this.numericSplitOffset.Location = new System.Drawing.Point(122, 419);
            this.numericSplitOffset.Margin = new System.Windows.Forms.Padding(6);
            this.numericSplitOffset.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericSplitOffset.Name = "numericSplitOffset";
            this.numericSplitOffset.Size = new System.Drawing.Size(146, 31);
            this.numericSplitOffset.TabIndex = 37;
            this.numericSplitOffset.ValueChanged += new System.EventHandler(this.numericSplitOffset_ValueChanged);
            // 
            // numericSplitLength
            // 
            this.numericSplitLength.Enabled = false;
            this.numericSplitLength.Hexadecimal = true;
            this.numericSplitLength.Location = new System.Drawing.Point(120, 377);
            this.numericSplitLength.Margin = new System.Windows.Forms.Padding(6);
            this.numericSplitLength.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericSplitLength.Name = "numericSplitLength";
            this.numericSplitLength.Size = new System.Drawing.Size(146, 31);
            this.numericSplitLength.TabIndex = 36;
            this.numericSplitLength.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericSplitLength.ValueChanged += new System.EventHandler(this.numericSplitLength_ValueChanged);
            // 
            // numericPalette
            // 
            this.numericPalette.Enabled = false;
            this.numericPalette.Hexadecimal = true;
            this.numericPalette.Location = new System.Drawing.Point(114, 35);
            this.numericPalette.Margin = new System.Windows.Forms.Padding(6);
            this.numericPalette.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericPalette.Name = "numericPalette";
            this.numericPalette.Size = new System.Drawing.Size(154, 31);
            this.numericPalette.TabIndex = 35;
            this.numericPalette.ValueChanged += new System.EventHandler(this.numericPalette_ValueChanged);
            // 
            // paletteFileLabel
            // 
            this.paletteFileLabel.AutoSize = true;
            this.paletteFileLabel.Location = new System.Drawing.Point(6, 625);
            this.paletteFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.paletteFileLabel.Name = "paletteFileLabel";
            this.paletteFileLabel.Size = new System.Drawing.Size(120, 25);
            this.paletteFileLabel.TabIndex = 13;
            this.paletteFileLabel.Text = "Palette File";
            // 
            // loadPaletteButton
            // 
            this.loadPaletteButton.Enabled = false;
            this.loadPaletteButton.Image = ((System.Drawing.Image)(resources.GetObject("loadPaletteButton.Image")));
            this.loadPaletteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadPaletteButton.Location = new System.Drawing.Point(12, 575);
            this.loadPaletteButton.Margin = new System.Windows.Forms.Padding(6);
            this.loadPaletteButton.Name = "loadPaletteButton";
            this.loadPaletteButton.Size = new System.Drawing.Size(254, 44);
            this.loadPaletteButton.TabIndex = 12;
            this.loadPaletteButton.Text = "Load Palette...";
            this.loadPaletteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadPaletteButton.UseVisualStyleBackColor = true;
            this.loadPaletteButton.Click += new System.EventHandler(this.loadPaletteButton_Click);
            // 
            // splitMinusButton
            // 
            this.splitMinusButton.Enabled = false;
            this.splitMinusButton.Image = global::Texture64.Properties.Resources.minus;
            this.splitMinusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitMinusButton.Location = new System.Drawing.Point(12, 471);
            this.splitMinusButton.Margin = new System.Windows.Forms.Padding(6);
            this.splitMinusButton.Name = "splitMinusButton";
            this.splitMinusButton.Size = new System.Drawing.Size(122, 44);
            this.splitMinusButton.TabIndex = 11;
            this.splitMinusButton.Text = "Length";
            this.splitMinusButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitMinusButton.UseVisualStyleBackColor = true;
            this.splitMinusButton.Click += new System.EventHandler(this.splitMinusButton_Click);
            // 
            // splitPlusButton
            // 
            this.splitPlusButton.Enabled = false;
            this.splitPlusButton.Image = global::Texture64.Properties.Resources.plus;
            this.splitPlusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitPlusButton.Location = new System.Drawing.Point(146, 469);
            this.splitPlusButton.Margin = new System.Windows.Forms.Padding(6);
            this.splitPlusButton.Name = "splitPlusButton";
            this.splitPlusButton.Size = new System.Drawing.Size(120, 44);
            this.splitPlusButton.TabIndex = 9;
            this.splitPlusButton.Text = "Length";
            this.splitPlusButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitPlusButton.UseVisualStyleBackColor = true;
            this.splitPlusButton.Click += new System.EventHandler(this.splitPlusButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 381);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Length: 0x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Offset: 0x";
            // 
            // splitPaletteCheck
            // 
            this.splitPaletteCheck.AutoSize = true;
            this.splitPaletteCheck.Location = new System.Drawing.Point(12, 342);
            this.splitPaletteCheck.Margin = new System.Windows.Forms.Padding(6);
            this.splitPaletteCheck.Name = "splitPaletteCheck";
            this.splitPaletteCheck.Size = new System.Drawing.Size(159, 29);
            this.splitPaletteCheck.TabIndex = 4;
            this.splitPaletteCheck.Text = "Split Palette";
            this.splitPaletteCheck.UseVisualStyleBackColor = true;
            this.splitPaletteCheck.CheckedChanged += new System.EventHandler(this.splitPaletteCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Offset: 0x";
            // 
            // gvContextMenuStrip
            // 
            this.gvContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gvContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gvExport,
            this.copyToolStripMenuItem,
            this.gvSetPaletteBefore,
            this.gvSetPaletteAfter});
            this.gvContextMenuStrip.Name = "gvContextMenuStrip";
            this.gvContextMenuStrip.Size = new System.Drawing.Size(287, 156);
            // 
            // gvExport
            // 
            this.gvExport.Image = global::Texture64.Properties.Resources.image_export;
            this.gvExport.Name = "gvExport";
            this.gvExport.Size = new System.Drawing.Size(286, 38);
            this.gvExport.Text = "Export Image...";
            this.gvExport.Click += new System.EventHandler(this.gvExport_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Texture64.Properties.Resources.document_copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.copyToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.gvCopy_Click);
            // 
            // gvSetPaletteBefore
            // 
            this.gvSetPaletteBefore.Image = global::Texture64.Properties.Resources.palette_before;
            this.gvSetPaletteBefore.Name = "gvSetPaletteBefore";
            this.gvSetPaletteBefore.Size = new System.Drawing.Size(286, 38);
            this.gvSetPaletteBefore.Text = "Set Palette Before";
            this.gvSetPaletteBefore.Click += new System.EventHandler(this.gvSetPaletteBefore_Click);
            // 
            // gvSetPaletteAfter
            // 
            this.gvSetPaletteAfter.Image = global::Texture64.Properties.Resources.palette_after;
            this.gvSetPaletteAfter.Name = "gvSetPaletteAfter";
            this.gvSetPaletteAfter.Size = new System.Drawing.Size(286, 38);
            this.gvSetPaletteAfter.Text = "Set Palette After";
            this.gvSetPaletteAfter.Click += new System.EventHandler(this.gvSetPaletteAfter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "0x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "64x64";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "32x64";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Custom:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "16x32";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "16x16";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 390);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "8x8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "64x32";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 287);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "32x32";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 287);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "8x16";
            // 
            // numericOffset
            // 
            this.numericOffset.Enabled = false;
            this.numericOffset.Hexadecimal = true;
            this.numericOffset.Location = new System.Drawing.Point(72, 48);
            this.numericOffset.Margin = new System.Windows.Forms.Padding(6);
            this.numericOffset.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericOffset.Name = "numericOffset";
            this.numericOffset.Size = new System.Drawing.Size(224, 31);
            this.numericOffset.TabIndex = 34;
            this.numericOffset.ValueChanged += new System.EventHandler(this.numericOffset_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewerCustom, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer8x16, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer64x64, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer64x32, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer32x64, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer8x8, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer16x32, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer16x16, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.graphicsViewer32x32, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(308, 56);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(600, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 1023);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownWidth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownHeight);
            this.panel1.Location = new System.Drawing.Point(6, 468);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 36;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColor.Controls.Add(this.labelColorA);
            this.groupBoxColor.Controls.Add(this.labelColorB);
            this.groupBoxColor.Controls.Add(this.labelColorG);
            this.groupBoxColor.Controls.Add(this.labelColorR);
            this.groupBoxColor.Controls.Add(this.labelColorHex);
            this.groupBoxColor.Controls.Add(this.pictureBoxColor);
            this.groupBoxColor.Location = new System.Drawing.Point(1276, 48);
            this.groupBoxColor.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxColor.Size = new System.Drawing.Size(274, 260);
            this.groupBoxColor.TabIndex = 36;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color Info:";
            // 
            // labelColorA
            // 
            this.labelColorA.AutoSize = true;
            this.labelColorA.Location = new System.Drawing.Point(14, 223);
            this.labelColorA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelColorA.Name = "labelColorA";
            this.labelColorA.Size = new System.Drawing.Size(32, 25);
            this.labelColorA.TabIndex = 5;
            this.labelColorA.Text = "A:";
            // 
            // labelColorB
            // 
            this.labelColorB.AutoSize = true;
            this.labelColorB.Location = new System.Drawing.Point(14, 198);
            this.labelColorB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelColorB.Name = "labelColorB";
            this.labelColorB.Size = new System.Drawing.Size(32, 25);
            this.labelColorB.TabIndex = 4;
            this.labelColorB.Text = "B:";
            // 
            // labelColorG
            // 
            this.labelColorG.AutoSize = true;
            this.labelColorG.Location = new System.Drawing.Point(14, 171);
            this.labelColorG.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelColorG.Name = "labelColorG";
            this.labelColorG.Size = new System.Drawing.Size(34, 25);
            this.labelColorG.TabIndex = 3;
            this.labelColorG.Text = "G:";
            // 
            // labelColorR
            // 
            this.labelColorR.AutoSize = true;
            this.labelColorR.Location = new System.Drawing.Point(14, 146);
            this.labelColorR.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelColorR.Name = "labelColorR";
            this.labelColorR.Size = new System.Drawing.Size(33, 25);
            this.labelColorR.TabIndex = 2;
            this.labelColorR.Text = "R:";
            // 
            // labelColorHex
            // 
            this.labelColorHex.AutoSize = true;
            this.labelColorHex.Location = new System.Drawing.Point(14, 113);
            this.labelColorHex.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelColorHex.Name = "labelColorHex";
            this.labelColorHex.Size = new System.Drawing.Size(56, 25);
            this.labelColorHex.TabIndex = 1;
            this.labelColorHex.Text = "Hex:";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColor.Location = new System.Drawing.Point(14, 38);
            this.pictureBoxColor.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(62, 60);
            this.pictureBoxColor.TabIndex = 0;
            this.pictureBoxColor.TabStop = false;
            // 
            // gviewPalette
            // 
            this.gviewPalette.AutoPixelSize = true;
            this.gviewPalette.Codec = Texture64.ColorCodecs.RGBA16;
            this.gviewPalette.ContextMenuStrip = this.gvContextMenuStrip;
            this.gviewPalette.Enabled = false;
            this.gviewPalette.Location = new System.Drawing.Point(12, 83);
            this.gviewPalette.Margin = new System.Windows.Forms.Padding(8);
            this.gviewPalette.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.gviewPalette.Name = "gviewPalette";
            this.gviewPalette.PixScale = 8;
            this.gviewPalette.PixSize = new System.Drawing.Size(16, 16);
            this.gviewPalette.Size = new System.Drawing.Size(256, 246);
            this.gviewPalette.TabIndex = 0;
            this.gviewPalette.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.gviewPalette.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.gviewPalette.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gviewPalette_MouseUp);
            // 
            // graphicsViewerCustom
            // 
            this.graphicsViewerCustom.AutoPixelSize = false;
            this.graphicsViewerCustom.Codec = Texture64.ColorCodecs.RGBA16;
            this.tableLayoutPanel1.SetColumnSpan(this.graphicsViewerCustom, 3);
            this.graphicsViewerCustom.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewerCustom.Enabled = false;
            this.graphicsViewerCustom.Location = new System.Drawing.Point(8, 532);
            this.graphicsViewerCustom.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewerCustom.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewerCustom.Name = "graphicsViewerCustom";
            this.graphicsViewerCustom.PixScale = 2;
            this.graphicsViewerCustom.PixSize = new System.Drawing.Size(128, 128);
            this.graphicsViewerCustom.Size = new System.Drawing.Size(512, 415);
            this.graphicsViewerCustom.TabIndex = 9;
            this.graphicsViewerCustom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewerCustom.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewerCustom.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewerCustom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewerCustom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer8x16
            // 
            this.graphicsViewer8x16.AutoPixelSize = false;
            this.graphicsViewer8x16.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer8x16.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer8x16.Enabled = false;
            this.graphicsViewer8x16.Location = new System.Drawing.Point(424, 320);
            this.graphicsViewer8x16.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer8x16.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer8x16.Name = "graphicsViewer8x16";
            this.graphicsViewer8x16.PixScale = 2;
            this.graphicsViewer8x16.PixSize = new System.Drawing.Size(8, 16);
            this.graphicsViewer8x16.Size = new System.Drawing.Size(32, 62);
            this.graphicsViewer8x16.TabIndex = 32;
            this.graphicsViewer8x16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer8x16.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer8x16.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer8x16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer8x16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer64x64
            // 
            this.graphicsViewer64x64.AutoPixelSize = false;
            this.graphicsViewer64x64.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer64x64.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer64x64.Enabled = false;
            this.graphicsViewer64x64.Location = new System.Drawing.Point(8, 33);
            this.graphicsViewer64x64.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer64x64.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer64x64.Name = "graphicsViewer64x64";
            this.graphicsViewer64x64.PixScale = 2;
            this.graphicsViewer64x64.PixSize = new System.Drawing.Size(64, 64);
            this.tableLayoutPanel1.SetRowSpan(this.graphicsViewer64x64, 3);
            this.graphicsViewer64x64.Size = new System.Drawing.Size(256, 246);
            this.graphicsViewer64x64.TabIndex = 3;
            this.graphicsViewer64x64.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer64x64.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer64x64.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer64x64.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer64x64.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer64x32
            // 
            this.graphicsViewer64x32.AutoPixelSize = false;
            this.graphicsViewer64x32.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer64x32.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer64x32.Enabled = false;
            this.graphicsViewer64x32.Location = new System.Drawing.Point(8, 320);
            this.graphicsViewer64x32.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer64x32.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer64x32.Name = "graphicsViewer64x32";
            this.graphicsViewer64x32.PixScale = 2;
            this.graphicsViewer64x32.PixSize = new System.Drawing.Size(64, 32);
            this.tableLayoutPanel1.SetRowSpan(this.graphicsViewer64x32, 4);
            this.graphicsViewer64x32.Size = new System.Drawing.Size(256, 123);
            this.graphicsViewer64x32.TabIndex = 25;
            this.graphicsViewer64x32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer64x32.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer64x32.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer64x32.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer64x32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer32x64
            // 
            this.graphicsViewer32x64.AutoPixelSize = false;
            this.graphicsViewer32x64.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer32x64.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer32x64.Enabled = false;
            this.graphicsViewer32x64.Location = new System.Drawing.Point(280, 33);
            this.graphicsViewer32x64.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer32x64.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer32x64.Name = "graphicsViewer32x64";
            this.graphicsViewer32x64.PixScale = 2;
            this.graphicsViewer32x64.PixSize = new System.Drawing.Size(32, 64);
            this.tableLayoutPanel1.SetRowSpan(this.graphicsViewer32x64, 3);
            this.graphicsViewer32x64.Size = new System.Drawing.Size(128, 246);
            this.graphicsViewer32x64.TabIndex = 24;
            this.graphicsViewer32x64.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer32x64.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer32x64.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer32x64.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer32x64.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer8x8
            // 
            this.graphicsViewer8x8.AutoPixelSize = false;
            this.graphicsViewer8x8.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer8x8.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer8x8.Enabled = false;
            this.graphicsViewer8x8.Location = new System.Drawing.Point(424, 423);
            this.graphicsViewer8x8.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer8x8.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer8x8.Name = "graphicsViewer8x8";
            this.graphicsViewer8x8.PixScale = 2;
            this.graphicsViewer8x8.PixSize = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel1.SetRowSpan(this.graphicsViewer8x8, 2);
            this.graphicsViewer8x8.Size = new System.Drawing.Size(32, 31);
            this.graphicsViewer8x8.TabIndex = 6;
            this.graphicsViewer8x8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer8x8.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer8x8.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer8x8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer8x8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer16x32
            // 
            this.graphicsViewer16x32.AutoPixelSize = false;
            this.graphicsViewer16x32.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer16x32.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer16x32.Enabled = false;
            this.graphicsViewer16x32.Location = new System.Drawing.Point(424, 33);
            this.graphicsViewer16x32.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer16x32.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer16x32.Name = "graphicsViewer16x32";
            this.graphicsViewer16x32.PixScale = 2;
            this.graphicsViewer16x32.PixSize = new System.Drawing.Size(16, 32);
            this.graphicsViewer16x32.Size = new System.Drawing.Size(64, 123);
            this.graphicsViewer16x32.TabIndex = 27;
            this.graphicsViewer16x32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer16x32.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer16x32.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer16x32.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer16x32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer16x16
            // 
            this.graphicsViewer16x16.AutoPixelSize = false;
            this.graphicsViewer16x16.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer16x16.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer16x16.Enabled = false;
            this.graphicsViewer16x16.Location = new System.Drawing.Point(424, 197);
            this.graphicsViewer16x16.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer16x16.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer16x16.Name = "graphicsViewer16x16";
            this.graphicsViewer16x16.PixScale = 2;
            this.graphicsViewer16x16.PixSize = new System.Drawing.Size(16, 16);
            this.graphicsViewer16x16.Size = new System.Drawing.Size(64, 62);
            this.graphicsViewer16x16.TabIndex = 5;
            this.graphicsViewer16x16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer16x16.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer16x16.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer16x16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer16x16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewer32x32
            // 
            this.graphicsViewer32x32.AutoPixelSize = false;
            this.graphicsViewer32x32.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewer32x32.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewer32x32.Enabled = false;
            this.graphicsViewer32x32.Location = new System.Drawing.Point(280, 320);
            this.graphicsViewer32x32.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewer32x32.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewer32x32.Name = "graphicsViewer32x32";
            this.graphicsViewer32x32.PixScale = 2;
            this.graphicsViewer32x32.PixSize = new System.Drawing.Size(32, 32);
            this.tableLayoutPanel1.SetRowSpan(this.graphicsViewer32x32, 4);
            this.graphicsViewer32x32.Size = new System.Drawing.Size(128, 123);
            this.graphicsViewer32x32.TabIndex = 4;
            this.graphicsViewer32x32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewer32x32.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewer32x32.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewer32x32.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewer32x32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // graphicsViewerMap
            // 
            this.graphicsViewerMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.graphicsViewerMap.AutoPixelSize = true;
            this.graphicsViewerMap.Codec = Texture64.ColorCodecs.RGBA16;
            this.graphicsViewerMap.ContextMenuStrip = this.gvContextMenuStrip;
            this.graphicsViewerMap.Enabled = false;
            this.graphicsViewerMap.Location = new System.Drawing.Point(40, 98);
            this.graphicsViewerMap.Margin = new System.Windows.Forms.Padding(8);
            this.graphicsViewerMap.Mode = Texture64.AlphaMode.AlphaCopyIntensity;
            this.graphicsViewerMap.Name = "graphicsViewerMap";
            this.graphicsViewerMap.PixScale = 1;
            this.graphicsViewerMap.PixSize = new System.Drawing.Size(0, 0);
            this.graphicsViewerMap.Size = new System.Drawing.Size(256, 981);
            this.graphicsViewerMap.TabIndex = 7;
            this.graphicsViewerMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseDown);
            this.graphicsViewerMap.MouseEnter += new System.EventHandler(this.graphicsViewer_MouseEnter);
            this.graphicsViewerMap.MouseLeave += new System.EventHandler(this.graphicsViewer_MouseLeave);
            this.graphicsViewerMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseMove);
            this.graphicsViewerMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsViewer_MouseUp);
            // 
            // ImageForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1127);
            this.Controls.Add(this.groupBoxPalette);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.numericOffset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.graphicsViewerMap);
            this.Controls.Add(this.vScrollBarOffset);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1400, 938);
            this.Name = "ImageForm";
            this.Text = "Texture64";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageForm_FormClosing);
            this.Load += new System.EventHandler(this.ImageForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageForm_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.groupBoxPalette.ResumeLayout(false);
            this.groupBoxPalette.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPalette)).EndInit();
            this.gvContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel statusStripFile;
      private System.Windows.Forms.BindingSource bindingSource1;
      private System.Windows.Forms.VScrollBar vScrollBarOffset;
      private System.Windows.Forms.ToolStripButton toolStripOpen;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private GraphicsViewer graphicsViewer64x64;
      private GraphicsViewer graphicsViewer32x32;
      private GraphicsViewer graphicsViewer16x16;
      private GraphicsViewer graphicsViewer8x8;
      private GraphicsViewer graphicsViewerMap;
      private GraphicsViewer graphicsViewerCustom;
      private System.Windows.Forms.NumericUpDown numericUpDownWidth;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown numericUpDownHeight;
      private System.Windows.Forms.ToolStripComboBox toolStripCodec;
      private System.Windows.Forms.ToolStripLabel toolStripLabel2;
      private System.Windows.Forms.ColorDialog colorDialogBg;
      private System.Windows.Forms.GroupBox groupBoxPalette;
      private GraphicsViewer gviewPalette;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.CheckBox splitPaletteCheck;
      private System.Windows.Forms.Button splitPlusButton;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ToolStripButton bgColorButton;
      private System.Windows.Forms.Button splitMinusButton;
      private System.Windows.Forms.Button loadPaletteButton;
      private System.Windows.Forms.Label paletteFileLabel;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private GraphicsViewer graphicsViewer32x64;
      private GraphicsViewer graphicsViewer64x32;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label9;
      private GraphicsViewer graphicsViewer16x32;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label13;
      private GraphicsViewer graphicsViewer8x16;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.ToolStripButton toolStripInsert;
      private System.Windows.Forms.ToolStripButton toolStripAbout;
      private System.Windows.Forms.ToolStripButton toolStripSave;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
      private System.Windows.Forms.NumericUpDown numericOffset;
      private System.Windows.Forms.NumericUpDown numericPalette;
      private System.Windows.Forms.NumericUpDown numericSplitLength;
      private System.Windows.Forms.NumericUpDown numericSplitOffset;
      private System.Windows.Forms.Label label15;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
      private System.Windows.Forms.ToolStripLabel toolStripLabel1;
      private System.Windows.Forms.ToolStripComboBox toolStripScale;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.ContextMenuStrip gvContextMenuStrip;
      private System.Windows.Forms.ToolStripMenuItem gvExport;
      private System.Windows.Forms.ToolStripMenuItem gvSetPaletteBefore;
      private System.Windows.Forms.ToolStripMenuItem gvSetPaletteAfter;
      private System.Windows.Forms.GroupBox groupBoxColor;
      private System.Windows.Forms.Label labelColorR;
      private System.Windows.Forms.Label labelColorHex;
      private System.Windows.Forms.PictureBox pictureBoxColor;
      private System.Windows.Forms.Label labelColorG;
      private System.Windows.Forms.Label labelColorA;
      private System.Windows.Forms.Label labelColorB;
      private System.Windows.Forms.CheckBox checkExtPalette;
      private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
      private System.Windows.Forms.ToolStripLabel toolStripLabel3;
      private System.Windows.Forms.ToolStripComboBox toolStripAlpha;
      private System.Windows.Forms.ToolStripStatusLabel statusStripSize;
        private System.Windows.Forms.ToolStripButton SwapRedBlue;
    }
}

