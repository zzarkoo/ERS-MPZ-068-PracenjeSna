namespace Shared;

// Pojednostavljen rezultat operacije prema obrascu iz nastavnog primera.
public sealed class Result
{
    private Result(bool isSuccess, AppError? error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public AppError? Error { get; }

    public static Result Success() => new(true, null);
    public static Result Failure(string code, string message) => new(false, new AppError(code, message));
}
