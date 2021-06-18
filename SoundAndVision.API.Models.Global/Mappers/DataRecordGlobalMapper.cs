using SoundAndVision.API.Models.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SoundAndVision.API.Models.Global.Mappers
{
    internal static class DataRecordGlobalMapper
    {
        // User mapper.
        internal static User ToUserGlobal(this IDataRecord dataRecord)
        {
            return new User()
            {
                Id = (int)dataRecord["Id"],
                Username = (string)dataRecord["Username"],
                FirstName = (dataRecord["FirstName"] != DBNull.Value) ? (string)dataRecord["FirstName"] : null,
                LastName = (dataRecord["LastName"] != DBNull.Value) ? (string)dataRecord["LastName"] : null,
                Email = (string)dataRecord["Email"],
                Password = null,
                Picture = (string)dataRecord["Picture"],
                Location = (dataRecord["Location"] != DBNull.Value) ? (string)dataRecord["Location"] : null,
                Bio = (dataRecord["Bio"] != DBNull.Value) ? (string)dataRecord["Bio"] : null,
                RegistrationDate = (DateTime)dataRecord["RegistrationDate"],
                IsActive = (bool)dataRecord["IsActive"],
                RoleId = (int)dataRecord["RoleId"]
            };
        }
    }
}
