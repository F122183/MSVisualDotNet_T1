// Mario Nikolov
// F122183

namespace UniversityManager.Interfaces
{
    public interface IDisplayable
    {
        /// <summary>
        /// Retrieves a string containing detailed information about the current role.
        /// </summary>
        /// <returns>A string that provides information about the current role. The format and content of the string may vary
        /// depending on the implementation.</returns>
        string GetRoleInfo();
    }
}
