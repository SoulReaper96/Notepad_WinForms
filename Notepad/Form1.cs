using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Clear();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                NotepadRTB.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, NotepadRTB.Text);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Redo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Paste();
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Select();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.SelectAll();
        }

        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadRTB.Text = System.DateTime.Now.ToString();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                NotepadRTB.Font = fontDialog1.Font;
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NotepadRTB.ForeColor = colorDialog1.Color;
            }
        }

        private void PageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NotepadRTB.BackColor = colorDialog1.Color;
            }
        }

        private void ZoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = NotepadRTB.Font.Size;
            currentSize += 2.0F;
            NotepadRTB.Font = new Font(NotepadRTB.Font.Name, currentSize, NotepadRTB.Font.Style, NotepadRTB.Font.Unit);

        }

        private void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = NotepadRTB.Font.Size;
            currentSize -= 2.0F;
            NotepadRTB.Font = new Font(NotepadRTB.Font.Name, currentSize, NotepadRTB.Font.Style, NotepadRTB.Font.Unit);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad 1.0 " + Environment.NewLine + "By: Pierre Joubert", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
