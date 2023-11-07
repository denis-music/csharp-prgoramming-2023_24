namespace FIT.WinForms.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(TextBox textBox, ErrorProvider err, string name)
        {
            if (!textBox.Text.IsSet())
            {
                err.SetError(textBox, Resursi.Get(name));
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
