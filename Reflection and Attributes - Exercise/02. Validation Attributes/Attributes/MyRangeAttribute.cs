namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int maximumValue;
        private readonly int minimumValue;

        public MyRangeAttribute(int minimumValue, int maximumValue)
        {
            this.minimumValue = minimumValue;
            this.maximumValue = maximumValue;
        }

        public override bool IsValid(object obj)
        {
            int value = (int)obj;

            return value >= minimumValue && value <= maximumValue;
        }
    }
}