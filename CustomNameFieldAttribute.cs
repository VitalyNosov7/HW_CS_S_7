namespace HW_7
{
    [AttributeUsage(AttributeTargets.Property)]
    class CustomNameFieldAttribute : Attribute
    {
        public string OriginalFieldName { get; set; }
        public string CustomFieldName { get; set; }
        public CustomNameFieldAttribute(string originalFieldName, string customFieldName)
        {
            OriginalFieldName = originalFieldName;
            CustomFieldName = customFieldName;
        }
    }
}