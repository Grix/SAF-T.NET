using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.IO.Compression;

namespace Softcash.SAFT
{
    public class AuditFileHelper
    {
        /// <summary>
        /// Private constructor because we don't want/need people to instantiate this class as it only contains static helper functions.
        /// </summary>
        private AuditFileHelper() { }

        /// <summary>
        /// Deserializes Auditfile
        /// </summary>
        /// <param name="filePath">The path where the file will be read</param>
        /// <returns></returns>
        public static Auditfile.AuditFile Deserialize(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Auditfile.AuditFile));
                return (Auditfile.AuditFile)xs.Deserialize(reader);
            }
        }

        /// <summary>
        /// Serializes Auditfile
        /// </summary>
        /// <param name="auditfile">The auditfile object to serialize</param>
        /// <param name="filePath">The path where the file will be written</param>
        /// <param name="compression">Optional: When true file will be compressed into Zip file. Default: false</param>
        public static void Serialize(Auditfile.AuditFile auditfile, string filePath, bool compression = false)
        {
            var xmlFile = new FileInfo(filePath);
            var xml = new XmlSerializer(typeof(Auditfile.AuditFile));
            if (compression)
            {
                var zipFile = new FileInfo("SAF-T Export_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".zip");
                using (FileStream zipStream = zipFile.Open(FileMode.Create))
                {
                    using (ZipArchive zip = new ZipArchive(zipStream, ZipArchiveMode.Create))
                    {
                        ZipArchiveEntry entry = zip.CreateEntry(xmlFile.Name);
                        using (var writer = new StreamWriter(entry.Open()))
                        {
                            xml.Serialize(writer, auditfile);
                        }
                    }
                }
            }
            else
            {
                using (TextWriter writer = new StreamWriter(xmlFile.Open(FileMode.Create)))
                {
                    xml.Serialize(writer, auditfile);
                }
            }
        }

        /// <summary>
        /// Generates a filename string according to spec.
        /// </summary>
        /// <param name="organizationNumber">The organization number</param>
        /// <param name="currentFile">Optional: Current file of Multi-File export</param>
        /// <param name="totalFiles">Optional: Total files in Multi-File export</param>
        /// <returns>Generated filename string</returns>
        public static string MakeFilename(string organizationNumber, int currentFile = 1, int totalFiles = 1)
        {
            StringBuilder str = new StringBuilder();
            str.Append("SAF-T Cash Register_");                                     // Type of file
            str.Append(organizationNumber.Replace(" ", "") + "_");                  // Organization number/identifier, trimmed 
            string currentTime = DateTime.Now.ToString("yyyyMMddHHmmss");           // Date and Time in the format specified by SAF-T
            str.Append(currentTime);                                                // Append current time
            if (totalFiles > 1) str.Append("_" + currentFile + "_" + totalFiles);   // Current export file and total amount of export files (Multi file export)
            str.Append(".xml");
            return str.ToString();
        }

        /// <summary>
        /// Generates a filename string according to spec.
        /// </summary>
        /// <param name="auditfile">Auditfile object to get Organization Number from</param>
        /// <param name="currentFile">Optional: Current file of Multi-File export</param>
        /// <param name="totalFiles">Optional: Total files in Multi-File export</param>
        /// <returns>Generated filename string</returns>
        public static string MakeFilename(Auditfile.auditfile auditfile, int currentFile = 1, int totalFiles = 1)
        {
            return MakeFilename(auditfile.company.companyIdent, currentFile, totalFiles);
        }

        /// <summary>
        /// Generate PostalAddress object from a string
        /// Example: STREETNAME 1, 1234 CITY, REGION
        /// </summary>
        /// <param name="str">Standard postal string, Example: STREETNAME 1, 1234 CITY, REGION</param>
        /// <param name="countrycode">Optional: Defaults to CountryCode.NO</param>
        /// <returns>PostalAddress object generated from string</returns>
        public static Auditfile.PostalAddress PostalAddressFromString(string str, Auditfile.Countrycode countrycode = Auditfile.Countrycode.NO) // STREETNAME 1, 1234 CITY, REGION
        {
            var arr = str.Split(',').Select((i) => { return i.Trim(); }).ToArray<string>();
            Auditfile.PostalAddress address = new Auditfile.PostalAddress();

            var numIndex = arr[0].LastIndexOf(" ");
            address.streetname = arr[0].Substring(0, numIndex);
            address.number = arr[0].Substring(numIndex, arr[0].Length - numIndex);

            numIndex = arr[1].IndexOf(" ");
            address.postalCode = arr[1].Substring(0, numIndex);
            address.city = arr[1].Substring(numIndex, arr[1].Length - numIndex);

            address.region = arr[2];

            address.country = countrycode;

            return address;
        }
    }
}
