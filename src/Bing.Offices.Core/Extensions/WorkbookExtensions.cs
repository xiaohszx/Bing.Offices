﻿using System.Collections.Generic;
using Bing.Offices.Abstractions.Metadata.Excels;

namespace Bing.Offices.Extensions
{
    /// <summary>
    /// 工作簿(<see cref="IWorkbook"/>) 扩展
    /// </summary>
    public static class WorkbookExtensions
    {
        /// <summary>
        /// 获取结果
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="workbook">工作簿</param>
        /// <param name="sheetIndex">工作表索引</param>
        public static IEnumerable<T> GetResult<T>(this IWorkbook workbook, int sheetIndex)
        {
            var sheet = workbook.GetSheetAt(sheetIndex);
            return sheet.GetBody().Convert<T>();
        }

        /// <summary>
        /// 获取结果
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="workbook">工作簿</param>
        public static IEnumerable<T> GetResult<T>(this IWorkbook workbook)
        {
            var list = new List<T>();
            foreach (var sheet in workbook.Sheets)
                list.AddRange(sheet.GetBody().Convert<T>());
            return list;
        }
    }
}
