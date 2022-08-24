#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2022 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using ShareX.IndexerLib;
using ShareX.Properties;
using ShareX.UploadersLib;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ShareX
{
    public static class UploadManager
    {
        public static void UploadFile(string filePath, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadFile(string[] files, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        private static bool IsUploadConfirmed(int length)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadFile(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadFolder(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ProcessImageUpload(Bitmap bmp, TaskSettings taskSettings)
        {
            throw new UploadingDisabledException();
        }

        public static void ProcessTextUpload(string text, TaskSettings taskSettings)
        {
            throw new UploadingDisabledException();
        }

        public static void ProcessFilesUpload(string[] files, TaskSettings taskSettings)
        {
            throw new UploadingDisabledException();
        }

        public static void ClipboardUpload(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ClipboardUploadWithContentViewer(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ClipboardUploadMainWindow(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ShowTextUploadDialog(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void DragDropUpload(IDataObject data, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadURL(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ShowShortenURLDialog(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void RunImageTask(Bitmap bmp, TaskSettings taskSettings, bool skipQuickTaskMenu = false, bool skipAfterCaptureWindow = false)
        {
            throw new UploadingDisabledException();
        }

        public static void RunImageTask(TaskMetadata metadata, TaskSettings taskSettings, bool skipQuickTaskMenu = false, bool skipAfterCaptureWindow = false)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadImage(Bitmap bmp, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadImage(Bitmap bmp, ImageDestination imageDestination, FileDestination imageFileDestination, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadText(string text, TaskSettings taskSettings = null, bool allowCustomText = false)
        {
            throw new UploadingDisabledException();
        }

        public static void UploadImageStream(Stream stream, string fileName, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ShortenURL(string url, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ShortenURL(string url, UrlShortenerType urlShortener)
        {
            throw new UploadingDisabledException();
        }

        public static void ShareURL(string url, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void ShareURL(string url, URLSharingServices urlSharingService)
        {
            throw new UploadingDisabledException();
        }

        public static void DownloadFile(string url, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void DownloadAndUploadFile(string url, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        private static void DownloadFile(string url, bool upload, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void IndexFolder(TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }

        public static void IndexFolder(string folderPath, TaskSettings taskSettings = null)
        {
            throw new UploadingDisabledException();
        }
    }
}