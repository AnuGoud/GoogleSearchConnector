using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using GoogleDriveSearchConnector.Models;
using System.Collections.Generic;
using System.IO;

namespace GoogleDriveSearchConnector.Data
{
    public static class CsvDataLoader
    {
        public static List<GoogleDriveProperties> LoadDataFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Configuration.RegisterClassMap<AppliancePartMap>();
                return new List<GoogleDriveProperties>(csv.GetRecords<GoogleDriveProperties>());
            }
        }
    }

    public class ApplianceListConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            var appliances = text.Split(';');
            return new List<string>(appliances);
        }
    }

    public class AppliancePartMap : ClassMap<GoogleDriveProperties>
    {
        public AppliancePartMap()
        {
            Map(m => m.RowID);
            //Map(m => m.FileID);
            Map(m => m.FileName);
            Map(m => m.Owner);
          //  Map(m => m.OwnerEmail);
            Map(m => m.LastModifyingUser);
           // Map(m => m.LastModifyingUserEmail);
            //Map(m => m.ModifiedTime);
            //Map(m => m.CreatedTime);
            //Map(m => m.Size);
//Map(m => m.FilePath);
            // Map(m => m.Appliances).TypeConverter<ApplianceListConverter>();
        }
    }
}