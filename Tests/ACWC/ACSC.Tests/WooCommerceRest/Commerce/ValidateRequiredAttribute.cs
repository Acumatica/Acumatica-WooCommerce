using System;
using System.ComponentModel;
using System.Reflection;

namespace ACSC.Tests.ShopifyRest.Commerce
{
    public abstract class ValidateAttribute : Attribute
	{
		// Token: 0x0600054B RID: 1355
		public abstract object Validate(Type type, PropertyInfo property, object value);
	}

    // Token: 0x020000A2 RID: 162
    public class ValidateRequiredAttribute : ValidateAttribute
    {
        // Token: 0x1700016E RID: 366
        // (get) Token: 0x0600054D RID: 1357 RVA: 0x000182FA File Offset: 0x000164FA
        // (set) Token: 0x0600054E RID: 1358 RVA: 0x00018302 File Offset: 0x00016502
        public bool AutoDefault { get; set; }

        // Token: 0x1700016F RID: 367
        // (get) Token: 0x0600054F RID: 1359 RVA: 0x0001830B File Offset: 0x0001650B
        // (set) Token: 0x06000550 RID: 1360 RVA: 0x00018313 File Offset: 0x00016513
        public string DefaultValue { get; set; } = " ";

        // Token: 0x17000170 RID: 368
        // (get) Token: 0x06000551 RID: 1361 RVA: 0x0001831C File Offset: 0x0001651C
        // (set) Token: 0x06000552 RID: 1362 RVA: 0x00018324 File Offset: 0x00016524
        public TypeCode ValueType { get; set; } = TypeCode.String;

        // Token: 0x06000553 RID: 1363 RVA: 0x00018330 File Offset: 0x00016530
        public override object Validate(Type type, PropertyInfo property, object value)
        {
            if (value == null || (value is string && string.IsNullOrEmpty(value as string)))
            {
                string text = this.DefaultValue;
                if (text == null && this.AutoDefault)
                {
                    text = " ";
                }
                if (text != null)
                {
                    value = Convert.ChangeType(text, this.ValueType);
                }
                if (value == null || (value is string && string.IsNullOrEmpty(value as string)))
                {
                    throw new Exception($"{this.GetPropertyDescription(property) ?? property.Name} is required for the integration and cannot be empty. Please provide a value for {this.GetClassDescription(type) ?? type.Name}.");
                }
            }
            return value;
        }

        // Token: 0x06000554 RID: 1364 RVA: 0x000183D4 File Offset: 0x000165D4
        private string GetClassDescription(Type type)
        {
            DescriptionAttribute[] array = (DescriptionAttribute[])type.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (array.Length == 0)
            {
                return null;
            }
            return array[0].Description;
        }

        // Token: 0x06000555 RID: 1365 RVA: 0x00018408 File Offset: 0x00016608
        private string GetPropertyDescription(PropertyInfo propertyInfo)
        {
            object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (customAttributes.Length != 0)
            {
                return ((DescriptionAttribute)customAttributes[0]).Description;
            }
            return null;
        }

        // Token: 0x04000539 RID: 1337
        public const string FILLER = " ";
    }
}