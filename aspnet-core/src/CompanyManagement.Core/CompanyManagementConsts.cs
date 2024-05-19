using CompanyManagement.Debugging;

namespace CompanyManagement
{
    public class CompanyManagementConsts
    {
        public const string LocalizationSourceName = "CompanyManagement";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a79e1fb989a24eb5acf92f12d5d42157";
    }
}
