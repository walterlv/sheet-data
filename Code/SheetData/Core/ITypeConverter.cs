namespace Walterlv.Data.Sheeting
{
    /// <summary>
    /// 表示一个类支持其值与字符串之间的转换。
    /// </summary>
    public interface ITypeConverter
    {
        /// <summary>
        /// 将此类型转换到字符串。
        /// </summary>
        /// <param name="value">此类型的一个实例。</param>
        /// <returns>类型转换到的字符串。</returns>
        string ConvertFrom(object value);

        /// <summary>
        /// 从字符串转换到此类型。
        /// </summary>
        /// <param name="value">要转换到的此类型的字符串。</param>
        /// <returns>此类型的一个实例。</returns>
        object ConvertTo(string value);
    }

    /// <summary>
    /// 表示一个类支持其值与字符串之间的转换。
    /// </summary>
    public interface ITypeConverter<T>
    {
        /// <summary>
        /// 将此类型转换到字符串。
        /// </summary>
        /// <param name="value">此类型的一个实例。</param>
        /// <returns>类型转换到的字符串。</returns>
        string ConvertFrom(T value);

        /// <summary>
        /// 从字符串转换到此类型。
        /// </summary>
        /// <param name="value">要转换到的此类型的字符串。</param>
        /// <returns>此类型的一个实例。</returns>
        T ConvertTo(string value);
    }
}
