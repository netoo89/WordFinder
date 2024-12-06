namespace WordFinderApp.Constants
{
    public static class ErrorConstants
    {
        public const string NullMatrixError = "The matrix has no assigned value";
        public const string InvalidNumberOfRowsError = "The matrix has more rows than expected";
        public const string InvalidNumberOfColumnsError = "At least one of the rows have more characters than expected";
        public const string RowsDifferentLengthError = "Not all rows have the same length";

        public const string NullWordStreamError = "Word stream is null";
    }
}