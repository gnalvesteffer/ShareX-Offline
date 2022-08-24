using System;
using System.Windows.Forms;

namespace ShareX
{
    internal class UploadingDisabledException : InvalidOperationException
    {
        public UploadingDisabledException() : base("Upload operations disabled in this build.")
        {
            MessageBox.Show("UploadManager operation prevented.", Program.Title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
