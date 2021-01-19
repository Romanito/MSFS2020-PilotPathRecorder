using System;

namespace FS2020PlanePath
{
    /// <summary>
    /// DB access class for FTP settings
    /// </summary>
    public class FTPSettings
    {
        private readonly FS2020_SQLLiteDB FlightPathDB = new FS2020_SQLLiteDB();

        public string Host
        {
            get => FlightPathDB.GetTableOption("FTPHost");
            set => FlightPathDB.WriteTableOption("FTPHost", value);
        }

        public ushort Port
        {
            get => Convert.ToUInt16(FlightPathDB.GetTableOption("FTPPort"));
            set => FlightPathDB.WriteTableOption("FTPPort", value.ToString());
        }

        public string Path
        {
            get => FlightPathDB.GetTableOption("FTPPath");
            set => FlightPathDB.WriteTableOption("FTPPath", value);
        }

        public string UserName
        {
            get => FlightPathDB.GetTableOption("FTPUserName");
            set => FlightPathDB.WriteTableOption("FTPUserName", value);
        }

        public string Password
        {
            get => FlightPathDB.GetTableOption("FTPPassword");
            set => FlightPathDB.WriteTableOption("FTPPassword", value);
        }

        public bool UseSFTP
        {
            get => Convert.ToBoolean(FlightPathDB.GetTableOption("FTPUseSFTP"));
            set => FlightPathDB.WriteTableOption("FTPUseSFTP", value.ToString());
        }
    }
}
