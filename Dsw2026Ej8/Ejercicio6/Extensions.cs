using System;

namespace EJ08_RizzaNicolasMatias.Problema6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }

            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}