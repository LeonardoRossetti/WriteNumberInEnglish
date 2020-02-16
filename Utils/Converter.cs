using System;

namespace TestUnleashed.Utils
{
    public class Converter
    {
        public static string WriteExtensive(decimal value)
        {
            if (value <= 0 | value >= 1000000000000000)
                return "Value is not supported.";
            else
            {
                string strValue = value.ToString("000000000000000.00");
                string extensiveValue = string.Empty;
                for (int i = 0; i <= 15; i += 3)
                {
                    extensiveValue += WriteExtensiveValue(Convert.ToDecimal(strValue.Substring(i, 3)));
                    if (i == 0 & extensiveValue != string.Empty)
                    {
                        if (Convert.ToInt32(strValue.Substring(0, 3)) >= 1)
                            extensiveValue += " TRILLION" + ((Convert.ToDecimal(strValue.Substring(3, 12)) > 0) ? " AND " : string.Empty);
                    }
                    else if (i == 3 & extensiveValue != string.Empty)
                    {
                        if (Convert.ToInt32(strValue.Substring(3, 3)) >= 1)
                            extensiveValue += " BILLION" + ((Convert.ToDecimal(strValue.Substring(6, 9)) > 0) ? " AND " : string.Empty);
                    }
                    else if (i == 6 & extensiveValue != string.Empty)
                    {
                        if (Convert.ToInt32(strValue.Substring(6, 3)) >= 1)
                            extensiveValue += " MILLION" + ((Convert.ToDecimal(strValue.Substring(9, 6)) > 0) ? " AND " : string.Empty);
                    }
                    else if (i == 9 & extensiveValue != string.Empty)
                        if (Convert.ToInt32(strValue.Substring(9, 3)) > 0)
                            extensiveValue += " THOUSAND" + ((Convert.ToDecimal(strValue.Substring(12, 3)) > 0) ? " AND " : string.Empty);
                    if (i == 12)
                    {
                        if (extensiveValue.Length > 8)
                            if (extensiveValue.Substring(extensiveValue.Length - 6, 6) == "BILLION" | extensiveValue.Substring(extensiveValue.Length - 6, 6) == "MILLION")
                                extensiveValue += " ";
                        if (Convert.ToInt64(strValue.Substring(0, 15)) == 1)
                            extensiveValue += " DOLLAR";
                        else if (Convert.ToInt64(strValue.Substring(0, 15)) > 1)
                            extensiveValue += " DOLLARS";
                        if (Convert.ToInt32(strValue.Substring(16, 2)) > 0 && extensiveValue != string.Empty)
                            extensiveValue += " AND ";
                    }
                    if (i == 15)
                        if (Convert.ToInt32(strValue.Substring(16, 2)) == 1)
                            extensiveValue += " CENT";
                        else if (Convert.ToInt32(strValue.Substring(16, 2)) > 1)
                            extensiveValue += " CENTS";
                }
                return extensiveValue;
            }
        }
        static string WriteExtensiveValue(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string result = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));
                if (a == 1) result += (b + c == 0) ? "HUNDRED" : "ONE HUNDRED";
                else if (a == 2) result += "TWO HUNDRED";
                else if (a == 3) result += "THREE HUNDRED";
                else if (a == 4) result += "FOUR HUNDRED";
                else if (a == 5) result += "FIVE HUNDRED";
                else if (a == 6) result += "SIX HUNDRED";
                else if (a == 7) result += "SEVEN HUNDRED";
                else if (a == 8) result += "EIGHT HUNDRED";
                else if (a == 9) result += "NINE HUNDRED";
                if (b == 1)
                {
                    if (c == 0) result += ((a > 0) ? " AND " : string.Empty) + "TEN";
                    else if (c == 1) result += ((a > 0) ? " AND " : string.Empty) + "ELEVEN";
                    else if (c == 2) result += ((a > 0) ? " AND " : string.Empty) + "TWELVE";
                    else if (c == 3) result += ((a > 0) ? " AND " : string.Empty) + "THIRTEEN";
                    else if (c == 4) result += ((a > 0) ? " AND " : string.Empty) + "FOURTEEN";
                    else if (c == 5) result += ((a > 0) ? " AND " : string.Empty) + "FIFTEEN";
                    else if (c == 6) result += ((a > 0) ? " AND " : string.Empty) + "SIXTEEN";
                    else if (c == 7) result += ((a > 0) ? " AND " : string.Empty) + "SEVENTEEN";
                    else if (c == 8) result += ((a > 0) ? " AND " : string.Empty) + "EIGHTEEN";
                    else if (c == 9) result += ((a > 0) ? " AND " : string.Empty) + "NINETEEN";
                }
                else if (b == 2) result += ((a > 0) ? " AND " : string.Empty) + "TWENTY";
                else if (b == 3) result += ((a > 0) ? " AND " : string.Empty) + "THIRTY";
                else if (b == 4) result += ((a > 0) ? " AND " : string.Empty) + "FORTY";
                else if (b == 5) result += ((a > 0) ? " AND " : string.Empty) + "FIFTY";
                else if (b == 6) result += ((a > 0) ? " AND " : string.Empty) + "SIXTY";
                else if (b == 7) result += ((a > 0) ? " AND " : string.Empty) + "SEVENTY";
                else if (b == 8) result += ((a > 0) ? " AND " : string.Empty) + "EIGHTY";
                else if (b == 9) result += ((a > 0) ? " AND " : string.Empty) + "NINETY";
                if (strValor.Substring(1, 1) != "1" & c != 0 & result != string.Empty) result += " ";
                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) result += "ONE";
                    else if (c == 2) result += "TWO";
                    else if (c == 3) result += "THREE";
                    else if (c == 4) result += "FOUR";
                    else if (c == 5) result += "FIVE";
                    else if (c == 6) result += "SIX";
                    else if (c == 7) result += "SEVEN";
                    else if (c == 8) result += "EIGHT";
                    else if (c == 9) result += "NINE";
                return result;
            }
        }
    }
}
