namespace Validators
{
    public class ValidatorResult
    {
        public bool IsValid { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        public ValidatorResult(bool isValid, string message)
        {
            IsValid = isValid;
            Message = message;
        }
    }
}
