using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Keoma_Converter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Point _mouseLoc;
        private string cmd;

        private void OperationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OperationComboBox.SelectedIndex)
            {
                case 0:
                    PathTxtBox.Enabled = false;
                    UploadBtn.Enabled = false;
                    StartBtn.Enabled = false;
                    QualityTxtBox.Enabled = true;
                    OptionalLabel.Visible = false;
                    PathTxtBox.PlaceholderText = "Select Operation";
                    break;
                case 1:
                    PathTxtBox.Enabled = true;
                    UploadBtn.Enabled = true;
                    QualityTxtBox.Enabled = true;
                    LossLessCheckBox.Enabled = true;
                    OptionalLabel.Visible = false;
                    PathTxtBox.PlaceholderText = "Upload or Drop a .jpg, .jpeg, .png, .tiff, .webp image";
                    break; 
                case 2:
                    PathTxtBox.Enabled = true;
                    UploadBtn.Enabled = true;
                    PathTxtBox.PlaceholderText = "Upload or Drop a .webp image";
                    QualityTxtBox.Enabled = false;
                    LossLessCheckBox.Enabled = false;
                    OptionalLabel.Visible = false;
                    break;
                case 3:
                    PathTxtBox.Enabled = true;
                    UploadBtn.Enabled = true;
                    PathTxtBox.PlaceholderText = "Upload or Drop a .gif image";
                    OptionalLabel.Visible = true;
                    LossLessCheckBox.Enabled = false;
                    QualityTxtBox.Enabled = true;
                    break;
            }
        }
        private void PathTxtBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropedImg = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string img = dropedImg[0];

            switch (OperationComboBox.SelectedIndex)
            {
                case 0:
                    PathTxtBox.Enabled = false;
                    UploadBtn.Enabled = false;
                    StartBtn.Enabled = false;
                    break;
                case 1:
                    CwebpOperation(img);
                    break;
                case 2:
                    DwebpOperation(img);
                    break;
                case 3:
                    GifOperation(img);
                    break;
            }

        }
        private void CwebpOperation(string img)
        {
            FileInfo dropImageInfo = new FileInfo(img);
            img = dropImageInfo.FullName;
            if (
                dropImageInfo.Extension.ToLower() == ".jpg" ||
                dropImageInfo.Extension.ToLower() == ".jpeg" ||
                dropImageInfo.Extension.ToLower() == ".png" ||
                dropImageInfo.Extension.ToLower() == ".tiff" ||
                dropImageInfo.Extension.ToLower() == ".webp"
               )
            {
                PathTxtBox.Text = img;
                UploadBtn.Enabled = true;
                StartBtn.Enabled = true;
                OperationComboBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DwebpOperation(string img)
        {
            FileInfo dropImageInfo = new FileInfo(img);
            img = dropImageInfo.FullName;
            if (
                 dropImageInfo.Extension.ToLower() == ".webp"
               )
            {
                PathTxtBox.Text = img;
                UploadBtn.Enabled = true;
                StartBtn.Enabled = true;
                OperationComboBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GifOperation(string img)
        {
            FileInfo dropImageInfo = new FileInfo(img);
            img = dropImageInfo.FullName;
            if (
                 dropImageInfo.Extension.ToLower() == ".gif"
               )
            {
                PathTxtBox.Text = img;
                UploadBtn.Enabled = true;
                StartBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UploadBtn_Click(object sender, EventArgs e)
        {

            switch (OperationComboBox.SelectedIndex)
            {
                case 0:
                    PathTxtBox.Enabled = false;
                    UploadBtn.Enabled = false;
                    StartBtn.Enabled = false;
                    break;
                case 1:
                    CwebpOperationUpload();
                    break;
                case 2:
                    DwebpOperationUpload();
                    break;
                case 3:
                    GifOperationUpload();
                    break;
            }
        }
        private void CwebpOperationUpload()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select Image";
            fd.Filter = "Image | *.JPG;*.JPEG;*.PNG;*.TIFF;*.WEBP";
            fd.Multiselect = false;

            if(fd.ShowDialog() == DialogResult.OK){
                string img = fd.FileName;
                PathTxtBox.Text = img;
                StartBtn.Enabled = true;
                OperationComboBox.Enabled = false;
            }
        }

        private void DwebpOperationUpload()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select Image";
            fd.Filter = "Image | *.WEBP";
            fd.Multiselect = false;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string img = fd.FileName;
                PathTxtBox.Text = img;
                StartBtn.Enabled = true;
                OperationComboBox.Enabled = false;
            }
        }

        private void GifOperationUpload()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select Image";
            fd.Filter = "Image | *.GIF";
            fd.Multiselect = false;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                string img = fd.FileName;
                GifOperation(img);
                StartBtn.Enabled = true;
                OperationComboBox.Enabled = false;
            }
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            switch (OperationComboBox.SelectedIndex)
            {
                case 0:
                    PathTxtBox.Enabled = false;
                    UploadBtn.Enabled = false;
                    StartBtn.Enabled = false;
                    break;
                case 1:
                    StartCompress();
                    break;
                case 2:
                    StartDecompress();
                    break;
                case 3:
                    StartGifToWebp();
                    break;
            }
        }


        private void StartCompress()
        {

            if (QualityTxtBox.Text.Trim() == "" || OutputTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Fill all Inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int toCompressImgQuality = Convert.ToInt32(QualityTxtBox.Text);
                    string toCompressImgOutput = OutputTxtBox.Text;
                    string toCompressImg = PathTxtBox.Text;

                    if (toCompressImgQuality < 0 || toCompressImgQuality > 100)
                    {
                        MessageBox.Show("Invalid Quality Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        QualityTxtBox.ResetText();
                    }
                    else
                    {
                        if (LossLessCheckBox.Checked)
                        {
                            cmd = $"(cd bin)&(cwebp -q {toCompressImgQuality} -lossless \"{toCompressImg}\" -o ../output/{toCompressImgOutput}.webp)";
                        }
                        else
                        {
                            cmd = $"(cd bin)&(cwebp \"{toCompressImg}\" -q {toCompressImgQuality} -o ../output/{toCompressImgOutput}.webp)";
                        }
                        StartProcess();
                    }


                }
                catch
                {
                    MessageBox.Show("Invalid Quality Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QualityTxtBox.ResetText();
                }
            }
        }
        private void StartDecompress()
        {
            string toDecompressImg = PathTxtBox.Text;
            string toDecompressImgOutput = OutputTxtBox.Text;

            if (OutputTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Fill Output Name Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = $"(cd bin)&(dwebp \"{toDecompressImg}\" -o ../output/{toDecompressImgOutput}.png)";
                StartProcess();
            }
        }

        private void StartGifToWebp()
        {
            if(QualityTxtBox.Text.Trim().Length > 0)
            {
                try
                {
                    if(OutputTxtBox.Text == "")
                    {
                        MessageBox.Show("Fill Output Name Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string toConvertGif = PathTxtBox.Text;
                        int gifQuality = Convert.ToInt32(QualityTxtBox.Text.Trim());
                        string gifOutput = OutputTxtBox.Text;
                        cmd = $"(cd bin)&(gif2webp -q {gifQuality} \"{toConvertGif}\" -o ../output/{gifOutput}.webp)";
                        StartProcess();
                    }
                }
                catch 
                {
                    MessageBox.Show("Invalid Quality Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QualityTxtBox.ResetText();
                }
            }
            else
            {
                if (OutputTxtBox.Text == "")
                {
                    MessageBox.Show("Fill Output Name Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string toConvertGif = PathTxtBox.Text;
                    string gifOutput = OutputTxtBox.Text;
                    cmd = $"(cd bin)&(gif2webp \"{toConvertGif}\" -o ../output/{gifOutput}.webp)";
                    StartProcess();
                }

            }

        }
        private void StartProcess()
        {
            Process ps = new Process();
            ProcessStartInfo startInfo= new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.WindowStyle= ProcessWindowStyle.Hidden;
            startInfo.Arguments = @"/C " + cmd;
            ps.StartInfo = startInfo;
            ps.Start();
            ps.WaitForExit();
            if(ps.ExitCode != 0)
            {
                MessageBox.Show("Convertion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Convertion Sucessful!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void PathTxtBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        private void CrossLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void ResetFields()
        {
            PathTxtBox.ResetText();
            QualityTxtBox.ResetText();
            OutputTxtBox.ResetText();
            OperationComboBox.SelectedIndex = 0;
            OperationComboBox.Enabled = true;
            PathTxtBox.PlaceholderText = "Select Operation";
            LossLessCheckBox.Checked = false;
            OptionalLabel.Visible = false;
        }
    }
}
