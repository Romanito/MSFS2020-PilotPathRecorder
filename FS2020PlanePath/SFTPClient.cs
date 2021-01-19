using System.IO;
using Renci.SshNet;

namespace FS2020PlanePath
{
    // Basic wrapper class for SSH.Net SFTP operations
    public static class SFTPClient
    {
        public static void UploadFile(string fileName)
        {
            FTPSettings ftpSettings = new FTPSettings();

            using (var client = new SftpClient(ftpSettings.Host, ftpSettings.Port, ftpSettings.UserName, ftpSettings.Password))
            {
                client.Connect();
                client.ChangeDirectory(ftpSettings.Path);

                using (var fileStream = new FileStream(fileName, FileMode.Open))
                {
                    client.BufferSize = 4 * 1024;
                    client.UploadFile(fileStream, Path.GetFileName(fileName));
                }
            }
        }
    }
}
