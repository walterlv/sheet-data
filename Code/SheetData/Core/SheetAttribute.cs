using System;

namespace Walterlv.Data.Sheeting
{
    /// <summary>
    /// Specifies the column header info corresponding to this property.
    /// <remarks>This Class cannot be inherited.</remarks>
    /// 
    /// <para>
    /// 指示此属性对应的列标题信息。
    /// <remarks>此类型不可被继承。</remarks>
    /// </para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SheetHeaderAttribute : Attribute
    {
        internal string Header { get; private set; }

        internal Type ConverterType { get; private set; }

        /// <param name="header">
        /// The column header name corresponding to this property.
        /// 
        /// <para>
        /// 此属性对应的列标题名称。
        /// </para>
        /// </param>
        public SheetHeaderAttribute(string header)
        {
            Header = header;
        }

        /// <param name="converter">
        /// The TypeConverter of this property.
        /// 
        /// <para>
        /// 此属性的类型转换器。
        /// </para>
        /// </param>
        public SheetHeaderAttribute(Type converter)
        {
            ConverterType = converter;
        }

        /// <param name="header">
        /// The column header name corresponding to this property.
        /// 
        /// <para>
        /// 此属性对应的列标题名称。
        /// </para>
        /// </param>
        /// <param name="converter">
        /// The TypeConverter of this property.
        /// 
        /// <para>
        /// 此属性的类型转换器。
        /// </para>
        /// </param>
        public SheetHeaderAttribute(string header, Type converter)
        {
            Header = header;
            ConverterType = converter;
        }
    }
}
