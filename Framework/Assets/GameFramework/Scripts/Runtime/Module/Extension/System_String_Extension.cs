//--------------------------------------------------
// Motion Framework
// Copyright©2018-2021 何冠峰
// Licensed under the MIT license
//--------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace System
{
	public static partial class System_String_Extension
	{
		/// <summary>
		/// 移除首个字符
		/// </summary>
		public static string RemoveFirstChar(this System.String str)
		{
			if (string.IsNullOrEmpty(str))
				return str;
			return str.Substring(1);
		}

		/// <summary>
		/// 移除末尾字符
		/// </summary>
		public static string RemoveLastChar(this System.String str)
		{
			if (string.IsNullOrEmpty(str))
				return str;
			return str.Substring(0, str.Length - 1);
		}

		/// <summary>
		/// 移除后缀名
		/// </summary>
		public static string RemoveExtension(this System.String str)
		{
			if (string.IsNullOrEmpty(str))
				return str;

			int index = str.LastIndexOf(".");
			if (index == -1)
				return str;
			else
				return str.Remove(index); //"assets/config/test.unity3d" --> "assets/config/test"
		}

        /// <summary>
        /// 字符串转换成数字数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str">内容</param>
        /// <param name="split">分割符合,如','</param>
        /// <param name="convertHandler">分割类型,如float.Parse</param>
        /// <returns></returns>
        public static List<T> ParseToList<T>(this System.String str, char split, Converter<string, T> convertHandler)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var array = str.Split(split);

            if (array.Length > 0)
            {
                var list = new List<T>(array.Length);
                for (int i = 0, len = array.Length; i < len; i++)
                {
                    list.Add(convertHandler(array[i]));
                }
                return list;
            }
            return null;
        }

        /// <summary>
        /// 文本添加颜色
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="colorSymbol"></param>
        /// <returns></returns>
        public static string WrapColor(this System.String txt, System.String colorSymbol)
        {
            return $"<color=#{colorSymbol}>{txt}</color>";
        }

        public static string WrapColor(this System.Int32 val, System.String colorSymbol)
        {
            return WrapColor(val.ToString(), colorSymbol);
        }

        public static string WrapColor(this System.String txt, Color color)
        {
            return WrapColor(txt, ColorExt.ColorToHexStr(color));
        }
    }
}