﻿/// <summary>
/// Developer: ShyamSk
/// </summary>

namespace Register.DataManager
{
    internal class CassandraDML
    {
        internal static string InsertStatement = "INSERT INTO userprofile " +
            "(UserId, GCMClientId, ProfileName, ImageUrl,"+
                    "CountryCode, MobileNumber, IsDeleted, CreatedOn) " +
            "values " +
            "(?,?,?,?,?,?,?,?);";
    }
}