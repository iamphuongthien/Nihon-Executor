using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OCOP_SuaAnSinh.Utilities
{
    public class Helper
    {
        public static string ConvertToUnSign(string s)
        {
            Regex r = new Regex("(?:[^a-z0-9.-]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);

            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            string t = regex.Replace(temp, String.Empty)
                .Replace('\u0111', 'd')
                .Replace('\u0110', 'D')
                .Replace('\u0110', 'D')
                .Replace(" ", "-").ToLower();
            return r.Replace(t, String.Empty);
        }
    }
}
