namespace FIT.WinForms.Helpers
{
    public static class Ekstenzije
    {
        public static bool IsSet(this string sadrzaj)
        {
            return !string.IsNullOrWhiteSpace(sadrzaj);
        }
    }
}
