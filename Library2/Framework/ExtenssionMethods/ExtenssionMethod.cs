using System.Security.Cryptography;
using System.Text;

namespace System
{
    public static class ExtenssionMethod
    {
        public static int ToInt(this TextBox textBox)
        {
            if (textBox.Text.Trim() == "") return 0;
            return Convert.ToInt32(textBox.Text.Trim());
        }
        public static long ToLong(this TextBox textBox)
        {
            if (textBox.Text.Trim() == "") return 0;
            return Convert.ToInt64(textBox.Text.Trim());
        }

        public static int ToInt(this object Str) => Convert.ToInt32(Str);

        public static int ToInt(this ComboBox combobox)
        {
            if (combobox.SelectedIndex == -1) return 0;
            return Convert.ToInt32(combobox);

        }
        public static string Hash(this string str)
        {
            var alg = SHA1.Create();
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(str);
            byte[] bufferHashed = alg.ComputeHash(buffer);
            return Convert.ToBase64String(bufferHashed);
        }
    }
}
