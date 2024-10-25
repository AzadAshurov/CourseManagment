namespace CourseManagment
{
    internal static class Helper
    {
        public static bool NameCheck(this string name)
        {
            name = name.Trim();
            if (string.IsNullOrEmpty(name) || name.Length <= 3 || name.Length <= 25)
            {
                return false;
            }
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
        public static string StringCorrector(this string str)
        {
            str = str.Trim();
            str = str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
            return str;

        }
    }
}
