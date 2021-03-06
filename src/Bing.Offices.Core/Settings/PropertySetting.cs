﻿using System.Collections.Generic;
using System.Linq;
using Bing.Offices.Abstractions.Settings;

namespace Bing.Offices.Settings
{
    /// <summary>
    /// 属性设置
    /// </summary>
    public sealed class PropertySetting : IPropertySetting
    {
        /// <summary>
        /// 列索引
        /// </summary>
        public int Index { get; internal set; }

        /// <summary>
        /// 列标题
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// 列格式化程序
        /// </summary>
        public string Formatter { get; internal set; }

        /// <summary>
        /// 是否忽略属性
        /// </summary>
        public bool Ignored { get; internal set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public object DefaultValue { get; internal set; }

        /// <summary>
        /// 是否动态列
        /// </summary>
        public bool IsDynamicColumn { get; internal set; }

        /// <summary>
        /// 动态列
        /// </summary>
        public IList<string> DynamicColumns { get; internal set; }

        /// <summary>
        /// 设置动态列
        /// </summary>
        /// <param name="dynamicColumns">动态列</param>
        public void SetDynamicColumn(IList<string> dynamicColumns)
        {
            if(!dynamicColumns.Any())
                return;
            DynamicColumns = dynamicColumns;
        }
    }
}
