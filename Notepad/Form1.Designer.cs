namespace Notepad
{
    partial class Notepad
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            UndoToolStripMenuItem = new ToolStripMenuItem();
            RedoToolStripMenuItem = new ToolStripMenuItem();
            CutToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem = new ToolStripMenuItem();
            PasteToolStripMenuItem = new ToolStripMenuItem();
            SelectToolStripMenuItem = new ToolStripMenuItem();
            SelectAllToolStripMenuItem = new ToolStripMenuItem();
            DateTimeToolStripMenuItem = new ToolStripMenuItem();
            FormatToolStripMenuItem = new ToolStripMenuItem();
            FontToolStripMenuItem = new ToolStripMenuItem();
            ColorToolStripMenuItem = new ToolStripMenuItem();
            pageColorToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            NotepadRTB = new RichTextBox();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Turquoise;
            menuStrip1.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, zoomInToolStripMenuItem, zoomOutToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(624, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(42, 20);
            FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(107, 22);
            NewToolStripMenuItem.Text = "New";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(107, 22);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(107, 22);
            SaveToolStripMenuItem.Text = "Save";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(107, 22);
            ExitToolStripMenuItem.Text = "Exit";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UndoToolStripMenuItem, RedoToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, SelectToolStripMenuItem, SelectAllToolStripMenuItem, DateTimeToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(44, 20);
            EditToolStripMenuItem.Text = "Edit";
            // 
            // UndoToolStripMenuItem
            // 
            UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            UndoToolStripMenuItem.Size = new Size(136, 22);
            UndoToolStripMenuItem.Text = "Undo";
            UndoToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
            // 
            // RedoToolStripMenuItem
            // 
            RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            RedoToolStripMenuItem.Size = new Size(136, 22);
            RedoToolStripMenuItem.Text = "Redo";
            RedoToolStripMenuItem.Click += RedoToolStripMenuItem_Click;
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.Size = new Size(136, 22);
            CutToolStripMenuItem.Text = "Cut";
            CutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.Size = new Size(136, 22);
            CopyToolStripMenuItem.Text = "Copy";
            CopyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.Size = new Size(136, 22);
            PasteToolStripMenuItem.Text = "Paste";
            PasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // SelectToolStripMenuItem
            // 
            SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            SelectToolStripMenuItem.Size = new Size(136, 22);
            SelectToolStripMenuItem.Text = "Select";
            SelectToolStripMenuItem.Click += SelectToolStripMenuItem_Click;
            // 
            // SelectAllToolStripMenuItem
            // 
            SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            SelectAllToolStripMenuItem.Size = new Size(136, 22);
            SelectAllToolStripMenuItem.Text = "Select All";
            SelectAllToolStripMenuItem.Click += SelectAllToolStripMenuItem_Click;
            // 
            // DateTimeToolStripMenuItem
            // 
            DateTimeToolStripMenuItem.Name = "DateTimeToolStripMenuItem";
            DateTimeToolStripMenuItem.Size = new Size(136, 22);
            DateTimeToolStripMenuItem.Text = "Date/Time";
            DateTimeToolStripMenuItem.Click += DateTimeToolStripMenuItem_Click;
            // 
            // FormatToolStripMenuItem
            // 
            FormatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontToolStripMenuItem, ColorToolStripMenuItem, pageColorToolStripMenuItem });
            FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            FormatToolStripMenuItem.Size = new Size(63, 20);
            FormatToolStripMenuItem.Text = "Format";
            // 
            // FontToolStripMenuItem
            // 
            FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            FontToolStripMenuItem.Size = new Size(142, 22);
            FontToolStripMenuItem.Text = "Font Style";
            FontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // ColorToolStripMenuItem
            // 
            ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            ColorToolStripMenuItem.Size = new Size(142, 22);
            ColorToolStripMenuItem.Text = "Font Color";
            ColorToolStripMenuItem.Click += ColorToolStripMenuItem_Click;
            // 
            // pageColorToolStripMenuItem
            // 
            pageColorToolStripMenuItem.Name = "pageColorToolStripMenuItem";
            pageColorToolStripMenuItem.Size = new Size(142, 22);
            pageColorToolStripMenuItem.Text = "Page Color";
            pageColorToolStripMenuItem.Click += PageColorToolStripMenuItem_Click;
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(83, 20);
            zoomInToolStripMenuItem.Text = "Zoom In +";
            zoomInToolStripMenuItem.Click += ZoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(90, 20);
            zoomOutToolStripMenuItem.Text = "Zoom Out -";
            zoomOutToolStripMenuItem.Click += ZoomOutToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(57, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // NotepadRTB
            // 
            NotepadRTB.BackColor = Color.LightGray;
            NotepadRTB.Dock = DockStyle.Fill;
            NotepadRTB.Location = new Point(0, 24);
            NotepadRTB.Name = "NotepadRTB";
            NotepadRTB.Size = new Size(624, 417);
            NotepadRTB.TabIndex = 1;
            NotepadRTB.Text = "";
            // 
            // Notepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(624, 441);
            Controls.Add(NotepadRTB);
            Controls.Add(menuStrip1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(640, 480);
            Name = "Notepad";
            Text = "Notepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem FormatToolStripMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem UndoToolStripMenuItem;
        private ToolStripMenuItem RedoToolStripMenuItem;
        private ToolStripMenuItem CutToolStripMenuItem;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem PasteToolStripMenuItem;
        private ToolStripMenuItem SelectAllToolStripMenuItem;
        private ToolStripMenuItem DateTimeToolStripMenuItem;
        private ToolStripMenuItem FontToolStripMenuItem;
        private ToolStripMenuItem ColorToolStripMenuItem;
        private RichTextBox NotepadRTB;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem SelectToolStripMenuItem;
        private ToolStripMenuItem pageColorToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
