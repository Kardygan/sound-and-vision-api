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
                FirstName = (dataRecord["FirstName"] is DBNull) ? null : (string)dataRecord["FirstName"],
                LastName = (dataRecord["LastName"] is DBNull) ? null : (string)dataRecord["LastName"],
                Email = (string)dataRecord["Email"],
                Password = null,
                Picture = (string)dataRecord["Picture"],
                Location = (dataRecord["Location"] is DBNull) ? null : (string)dataRecord["Location"],
                Bio = (dataRecord["Bio"] is DBNull) ? null : (string)dataRecord["Bio"],
                RegistrationDate = (DateTime)dataRecord["RegistrationDate"],
                IsActive = (bool)dataRecord["IsActive"],
                RoleId = (int)dataRecord["RoleId"]
            };
        }
    }
}
