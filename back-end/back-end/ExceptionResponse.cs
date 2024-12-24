namespace back_end
{
    public class ExceptionResponse
    {
        public string ErrorMessage { get; set; }
        public IEnumerable<ValidationError>? ValidationErrors { get; set; }

        public ExceptionResponse(string message)
        {
            ErrorMessage = message;
        }
    }

    public class ValidationError
    {
        public required string PropertyName { get; set; }
        public required string ErrorMessage { get; set; }
    }
}
