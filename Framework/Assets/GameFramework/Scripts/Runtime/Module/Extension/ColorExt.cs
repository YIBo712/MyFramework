using UnityEngine;

public static class ColorExt 
{


    public static Color HexStrToColor(string hex)
    {
        Color color;
        ColorUtility.TryParseHtmlString($"#{hex}", out color);
        return color;
    }

    public static string ColorToHexStr(Color color)
    {
        return ColorUtility.ToHtmlStringRGB(color); 
    }







    #region 颜色转换备用方法

    //public static Color HexStrToColor(string hex)
    //{
    //    return hex.Length > 6 ? ParseColor32(hex, 0) : ParseColor24(hex, 0);
    //}


    //public static string ColorToHexStr(Color color)
    //{
    //    int i = 0xFFFFFF & (ColorToInt(color) >> 8);
    //    return DecimalToHex24(i);
    //}


    //    static public Color ParseColor24(string text, int offset = 0)
    //    {
    //        int r = (HexToDecimal(text[offset]) << 4) | HexToDecimal(text[offset + 1]);
    //        int g = (HexToDecimal(text[offset + 2]) << 4) | HexToDecimal(text[offset + 3]);
    //        int b = (HexToDecimal(text[offset + 4]) << 4) | HexToDecimal(text[offset + 5]);
    //        float f = 1f / 255f;
    //        return new Color(f * r, f * g, f * b);
    //    }


    //    static public bool ParseColor24(ref string text, int offset, out Color c)
    //    {
    //        var d0 = HexToDecimal(text[offset], -1);
    //        var d1 = HexToDecimal(text[offset + 1], -1);
    //        var d2 = HexToDecimal(text[offset + 2], -1);

    //        var d3 = HexToDecimal(text[offset + 3], -1);
    //        var d4 = HexToDecimal(text[offset + 4], -1);
    //        var d5 = HexToDecimal(text[offset + 5], -1);

    //        var dec = (d0 | d1 | d2 | d3 | d4 | d5);
    //        if (dec == -1) { c = Color.white; return false; }

    //        int r = (d0 << 4) | d1;
    //        int g = (d2 << 4) | d3;
    //        int b = (d4 << 4) | d5;
    //        float f = 1f / 255f;
    //        c = new Color(f * r, f * g, f * b);
    //        return true;
    //    }


    //    static public Color ParseColor32(string text, int offset)
    //    {
    //        int r = (HexToDecimal(text[offset]) << 4) | HexToDecimal(text[offset + 1]);
    //        int g = (HexToDecimal(text[offset + 2]) << 4) | HexToDecimal(text[offset + 3]);
    //        int b = (HexToDecimal(text[offset + 4]) << 4) | HexToDecimal(text[offset + 5]);
    //        int a = (HexToDecimal(text[offset + 6]) << 4) | HexToDecimal(text[offset + 7]);
    //        float f = 1f / 255f;
    //        return new Color(f * r, f * g, f * b, f * a);
    //    }


    //    static public bool ParseColor32(ref string text, int offset, out Color c)
    //    {
    //        var d0 = HexToDecimal(text[offset], -1);
    //        var d1 = HexToDecimal(text[offset + 1], -1);
    //        var d2 = HexToDecimal(text[offset + 2], -1);
    //        var d3 = HexToDecimal(text[offset + 3], -1);

    //        var d4 = HexToDecimal(text[offset + 4], -1);
    //        var d5 = HexToDecimal(text[offset + 5], -1);
    //        var d6 = HexToDecimal(text[offset + 6], -1);
    //        var d7 = HexToDecimal(text[offset + 7], -1);

    //        var dec = (d0 | d1 | d2 | d3 | d4 | d5 | d6 | d7);
    //        if (dec == -1) { c = Color.white; return false; }

    //        int r = (d0 << 4) | d1;
    //        int g = (d2 << 4) | d3;
    //        int b = (d4 << 4) | d5;
    //        int a = (d6 << 4) | d7;
    //        float f = 1f / 255f;
    //        c = new Color(f * r, f * g, f * b, f * a);
    //        return true;
    //    }

    //    static public int HexToDecimal(char ch, int defVal = 0xF)
    //    {
    //        switch (ch)
    //        {
    //            case '0': return 0x0;
    //            case '1': return 0x1;
    //            case '2': return 0x2;
    //            case '3': return 0x3;
    //            case '4': return 0x4;
    //            case '5': return 0x5;
    //            case '6': return 0x6;
    //            case '7': return 0x7;
    //            case '8': return 0x8;
    //            case '9': return 0x9;
    //            case 'a':
    //            case 'A': return 0xA;
    //            case 'b':
    //            case 'B': return 0xB;
    //            case 'c':
    //            case 'C': return 0xC;
    //            case 'd':
    //            case 'D': return 0xD;
    //            case 'e':
    //            case 'E': return 0xE;
    //            case 'f':
    //            case 'F': return 0xF;
    //        }
    //        return defVal;
    //    }


    //    static public string DecimalToHex24(int num)
    //    {
    //        num &= 0xFFFFFF;
    //#if UNITY_FLASH
    //		StringBuilder sb = new StringBuilder();
    //		sb.Append(DecimalToHexChar((num >> 20) & 0xF));
    //		sb.Append(DecimalToHexChar((num >> 16) & 0xF));
    //		sb.Append(DecimalToHexChar((num >> 12) & 0xF));
    //		sb.Append(DecimalToHexChar((num >> 8) & 0xF));
    //		sb.Append(DecimalToHexChar((num >> 4) & 0xF));
    //		sb.Append(DecimalToHexChar(num & 0xF));
    //		return sb.ToString();
    //#else
    //        return num.ToString("X6");
    //#endif
    //    }

    //    static public int ColorToInt(Color c)
    //    {
    //        int retVal = 0;
    //        retVal |= Mathf.RoundToInt(c.r * 255f) << 24;
    //        retVal |= Mathf.RoundToInt(c.g * 255f) << 16;
    //        retVal |= Mathf.RoundToInt(c.b * 255f) << 8;
    //        retVal |= Mathf.RoundToInt(c.a * 255f);
    //        return retVal;
    //    }


    #endregion


}
