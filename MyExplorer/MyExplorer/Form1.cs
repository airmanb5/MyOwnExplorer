using System.ComponentModel;

namespace MyExplorer
{
    //Icons für Folder hinzufügen
    //Menü Options/View: Liste oder Details mit Radio-Buttons
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DisplayType { get; private set; } = "list";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TreeViewEventArgs Argument { get; set; }

        public Form1()
        {
            InitializeComponent();

            TreeNode cDrive = new TreeNode("OS (C:)");

            cDrive.Tag = @"C:\";
            cDrive.ImageIndex = 1;
            cDrive.SelectedImageIndex = 2;

            treeView1.Nodes.Add(cDrive);

            imageList.Images.SetKeyName(0, "text");
            imageList.Images.SetKeyName(1, "pdf");
            imageList.Images.SetKeyName(2, "word");
            imageList.Images.SetKeyName(3, "excel");
            imageList.Images.SetKeyName(4, "powerpoint");
            imageList.Images.SetKeyName(5, "code");
            imageList.Images.SetKeyName(6, "audio");
            imageList.Images.SetKeyName(7, "video");
            imageList.Images.SetKeyName(8, "archive");
            imageList.Images.SetKeyName(9, "exe");
            imageList.Images.SetKeyName(10, "file");
            imageList.Images.SetKeyName(11, "folder");

            LoadFolders(@"C:\", cDrive);

            DisplaySelectedFolderAsList(@"C:\");
        }

        public Form1(string displayType)
        {
            this.DisplayType = displayType;

            InitializeComponent();

            TreeNode cDrive = new TreeNode("OS (C:)");

            cDrive.Tag = @"C:\";
            cDrive.ImageIndex = 1;
            cDrive.SelectedImageIndex = 2;

            treeView1.Nodes.Add(cDrive);

            imageList.Images.SetKeyName(0, "text");
            imageList.Images.SetKeyName(1, "pdf");
            imageList.Images.SetKeyName(2, "word");
            imageList.Images.SetKeyName(3, "excel");
            imageList.Images.SetKeyName(4, "powerpoint");
            imageList.Images.SetKeyName(5, "code");
            imageList.Images.SetKeyName(6, "audio");
            imageList.Images.SetKeyName(7, "video");
            imageList.Images.SetKeyName(8, "archive");
            imageList.Images.SetKeyName(9, "exe");
            imageList.Images.SetKeyName(10, "file");
            imageList.Images.SetKeyName(11, "folder");

            LoadFolders(@"C:\", cDrive);

            DisplaySelectedFolderAsList(@"C:\");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Argument = e;

            if (Argument.Action == TreeViewAction.Unknown)
            {
                return;
            }

            if (Argument.Node.Tag is string path)
            {

                RenderFoldersAndFiles();
            }
        }


        public void LoadFolders(string filePath, TreeNode parentNode)
        {
            try
            {
                foreach (string folder in Directory.GetDirectories(filePath))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(folder));

                    node.Tag = folder;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 2;

                    node.Nodes.Add("Loading...");

                    parentNode.Nodes.Add(node);
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }
        }

        public void DisplaySelectedFolderAsList(string filePath)
        {
            listView1.Items.Clear();

            listView1.View = View.Details;

            try
            {
                foreach (string folder in Directory.GetDirectories(filePath))
                {
                    ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(folder));
                    item.SubItems.Add(Directory.GetLastWriteTime(folder).ToString());
                    item.SubItems.Add("File folder");
                    item.SubItems.Add("");

                    listView1.Items.Add(item);
                }

                foreach (string file in Directory.GetFiles(filePath))
                {
                    FileInfo fileInfo = new FileInfo(file);

                    ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(file));
                    item.SubItems.Add(File.GetLastWriteTime(file).ToString());
                    item.SubItems.Add(Path.GetExtension(file));
                    item.SubItems.Add(GetSizeText(fileInfo.Length));

                    listView1.Items.Add(item);
                }

                statusLabel.Text = "Done";
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access to this folder is denied");
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private string GetSizeText(long size)
        {
            if (size < 1000)
            {
                return size + " Bytes";
            }
            else if (size >= 1000 && size < 1000000)
            {
                return size / 1000 + " KB";
            }
            else if (size >= 1000000 && size < 1000000000)
            {
                return size / 1000000 + " MB";
            }
            else
            {
                return size / 1000000000 + " GB";
            }
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wassupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormOptions formOptions = new FormOptions(DisplayType);

            DialogResult result = formOptions.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                DisplayType = formOptions.GetCorrectDisplayType();

                RenderFoldersAndFiles();
            }
        }

        private void DisplaySelectedFolderAsIcons(string filePath)
        {
            listView1.Items.Clear();

            listView1.View = View.LargeIcon;

            try
            {
                foreach (string folder in Directory.GetDirectories(filePath))
                { 
                    ListViewItem item = new ListViewItem(Path.GetFileName(folder));

                    item.ImageKey = "folder";

                    item.Tag = folder;

                    listView1.Items.Add(item);
                }

                foreach (string file in Directory.GetFiles(filePath))
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));

                    GetCorrectIcon(file);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }
        }

        private void GetCorrectIcon(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            ListViewItem item = new ListViewItem(Path.GetFileName(fileName));

            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                    Image image = Image.FromFile(fileName);

                    imageList.Images.Add(image);

                    item.ImageIndex = imageList.Images.Count - 1;
                    break;

                case ".txt":
                    item.ImageKey = "text";
                    break;

                case ".pdf":
                    item.ImageKey = "pdf";
                    break;

                case ".doc":
                case ".docx":
                    item.ImageKey = "word";
                    break;

                case ".xls":
                case ".xlsx":
                    item.ImageKey = "excel";
                    break;

                case ".ppt":
                case ".pptx":
                    item.ImageKey = "powerpoint";
                    break;

                case ".cs":
                case ".cpp":
                case ".py":
                case ".js":
                    item.ImageKey = "code";
                    break;

                case ".mp3":
                case ".wav":
                case ".flac":
                    item.ImageKey = "audio";
                    break;

                case ".mp4":
                case ".mov":
                case ".avi":
                case ".mkv":
                    item.ImageKey = "video";
                    break;

                case ".zip":
                case ".rar":
                case ".7z":
                    item.ImageKey = "archive";
                    break;

                case ".exe":
                    item.ImageKey = "exe";
                    break;


                default:
                    item.ImageKey = "file";
                    break;
            }

            item.Tag = fileName;

            listView1.Items.Add(item);
        }

        private void RenderFoldersAndFiles()
        {
            if (Argument.Node.Tag == null)
            {
                return;
            }

            if (DisplayType == "list")
            {
                DisplaySelectedFolderAsList(Argument.Node.Tag.ToString());
            }

            if (DisplayType == "icons")
            {
                DisplaySelectedFolderAsIcons(Argument.Node.Tag.ToString());
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;

            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "Loading..." && node.Tag is string path)
            {
                node.Nodes.Clear();

                LoadFolders(path, node);
            }
        }
    }
}