﻿using System.Collections.Generic;
using Bing.Offices.Abstractions.Imports;

namespace Bing.Offices.Imports
{
    /// <summary>
    /// 导入选项配置
    /// </summary>
    public class ImportOptions : IImportOptions
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        public string FileUrl { get; set; }

        /// <summary>
        /// 工作表索引
        /// </summary>
        public int SheetIndex { get; set; } = 0;

        /// <summary>
        /// 是否支持多工作表模式
        /// </summary>
        public bool MultiSheet { get; set; } = false;

        /// <summary>
        /// 表头行索引
        /// </summary>
        public int HeaderRowIndex { get; set; } = 0;

        /// <summary>
        /// 数据行索引
        /// </summary>
        public int DataRowIndex { get; set; } = 1;

        /// <summary>
        /// 最大列长度
        /// </summary>
        public int MaxColumnLength { get; set; } = 100;

        /// <summary>
        /// 启用空行模式。启用时，行内遇到空行将抛出异常错误信息
        /// </summary>
        public bool EnabledEmptyLine { get; set; }

        /// <summary>
        /// 映射字典
        /// </summary>
        public IDictionary<string, string> MappingDictionary { get; set; }

        /// <summary>
        /// 校验模式
        /// </summary>
        public ValidateMode ValidateMode { get; set; } = ValidateMode.StopOnFirstFailure;

        /// <summary>
        /// 自定义导入提供程序
        /// </summary>
        public IExcelImportProvider CustomImportProvider { get; set; }
    }
}
