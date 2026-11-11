namespace MyExplorer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            statusStrip2 = new StatusStrip();
            treeView1 = new TreeView();
            imageTree = new ImageList(components);
            statusText = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            listView1 = new ListView();
            columnName = new ColumnHeader();
            columnDate = new ColumnHeader();
            columnType = new ColumnHeader();
            columnSize = new ColumnHeader();
            imageList = new ImageList(components);
            menuStrip1 = new MenuStrip();
            ToolStripMenuView = new ToolStripMenuItem();
            toolStripMenuOptions = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusText.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(statusStrip2);
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(statusText);
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Size = new Size(800, 417);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(24, 24);
            statusStrip2.Location = new Point(0, 395);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(266, 22);
            statusStrip2.TabIndex = 1;
            statusStrip2.Text = "statusStrip2";
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageTree;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(266, 417);
            treeView1.TabIndex = 0;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageTree
            // 
            imageTree.ColorDepth = ColorDepth.Depth32Bit;
            imageTree.ImageStream = (ImageListStreamer)resources.GetObject("imageTree.ImageStream");
            imageTree.TransparentColor = Color.Transparent;
            imageTree.Images.SetKeyName(0, "folder");
            imageTree.Images.SetKeyName(1, "3767084.png");
            imageTree.Images.SetKeyName(2, "12075435.png");
            // 
            // statusText
            // 
            statusText.ImageScalingSize = new Size(24, 24);
            statusText.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusText.Location = new Point(0, 385);
            statusText.Name = "statusText";
            statusText.RightToLeft = RightToLeft.Yes;
            statusText.Size = new Size(530, 32);
            statusText.TabIndex = 1;
            statusText.Text = "statusStrip1";
            statusText.ItemClicked += statusStrip1_ItemClicked;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.RightToLeft = RightToLeft.No;
            statusLabel.Size = new Size(17, 25);
            statusLabel.Text = " ";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnDate, columnType, columnSize });
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = imageList;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(530, 417);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 300;
            // 
            // columnDate
            // 
            columnDate.Text = "Date modified";
            columnDate.Width = 250;
            // 
            // columnType
            // 
            columnType.Text = "Type";
            columnType.Width = 150;
            // 
            // columnSize
            // 
            columnSize.Text = "Size";
            columnSize.Width = 100;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "104647.png");
            imageList.Images.SetKeyName(1, "337946.png");
            imageList.Images.SetKeyName(2, "images.png");
            imageList.Images.SetKeyName(3, "304-3045495_export-to-excel-icons-hd-png-download.png");
            imageList.Images.SetKeyName(4, "images (1).png");
            imageList.Images.SetKeyName(5, "2035030-200.png");
            imageList.Images.SetKeyName(6, "1324071.png");
            imageList.Images.SetKeyName(7, "1179133.png");
            imageList.Images.SetKeyName(8, "1773747.png");
            imageList.Images.SetKeyName(9, "1433.png");
            imageList.Images.SetKeyName(10, "free-file-icon-1453-thumb.png");
            imageList.Images.SetKeyName(11, "3767084.png");
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuView });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuView
            // 
            ToolStripMenuView.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuOptions });
            ToolStripMenuView.Name = "ToolStripMenuView";
            ToolStripMenuView.Size = new Size(65, 29);
            ToolStripMenuView.Text = "View";
            ToolStripMenuView.Click += wassupToolStripMenuItem_Click;
            // 
            // toolStripMenuOptions
            // 
            toolStripMenuOptions.Name = "toolStripMenuOptions";
            toolStripMenuOptions.Size = new Size(178, 34);
            toolStripMenuOptions.Text = "Options";
            toolStripMenuOptions.Click += optionsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusText.ResumeLayout(false);
            statusText.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private StatusStrip statusStrip1;
        private ListView listView1;
        private MenuStrip menuStrip1;
        private ColumnHeader columnName;
        private ColumnHeader columnDate;
        private ColumnHeader columnType;
        private ColumnHeader columnSize;
        private StatusStrip statusText;
        private StatusStrip statusStrip2;
        private ToolStripMenuItem ToolStripMenuView;
        private ToolStripStatusLabel statusLabel;
        private ImageList imageTree;
        private ToolStripMenuItem toolStripMenuOptions;
        private ImageList imageList;
    }
}
