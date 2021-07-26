using System;

namespace ACSC.Tests.EntityValidators
{
    public class CompareResult
    {
        public CompareResult(Exception e)
        {
            ValidationException = e;
        }
        public CompareResult(string property, string expectedValue, string actualValue)
        {
            Property = property;
            ExpectedValue = expectedValue;
            ActualValue = actualValue;
        }

        public string Property { get; set; }
        public string ExpectedValue { get; set; }
        public string ActualValue { get; set; }
        public Exception ValidationException { get; set; }

        public override string ToString()
        {
            if (ValidationException != null)
            {
                return ValidationException.Message;
            }
                
            return $"Property: {Property}, Expected: {ExpectedValue}, Actual: {ActualValue}";
        }
    }
}