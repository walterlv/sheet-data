using System;

namespace Walterlv.Data.Sheeting
{
    /// <summary>
    /// Specifies the column header's order of a sheet. This attribute affects the corresponding relationship between properties and sheet headers.
    /// <remarks>This Class cannot be inherited.</remarks>
    /// 
    /// <para>
    /// 指示表格的列标题顺序。在没有指定列标题的表格中，此属性会影响到属性与表格对应关系的正确性。
    /// <remarks>此类型不可被继承。</remarks>
    /// </para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SheetHeadersAttribute : Attribute
    {
        internal string[] Headers { get; private set; }

        /// <param name="headers">
        /// Specifies column headers in order. If a column header does not correspond to any property, please fill in it with null or "".
        /// 
        /// <para>
        /// 按顺序指定列标题。如果某个列标题不对应任何属性，请将其填写为 null 或 ""。
        /// </para>
        /// </param>
        public SheetHeadersAttribute(params string[] headers)
        {
            Headers = headers;
        }
    }
}
