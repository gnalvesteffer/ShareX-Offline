using System;
using System.Windows.Forms;

namespace ShareX
{
    internal class UploadingDisabledException : InvalidOperationException
    {
        public UploadingDisabledException()
        {
            MessageBox.Show("UploadManager operation prevented.", "UPLOAD PREVENTED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
