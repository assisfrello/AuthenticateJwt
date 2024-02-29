namespace AuthenticateJwt.Models;

public class LoginResponseViewModel : IAsyncResult
{
    public object? AsyncState { get; }
    public WaitHandle AsyncWaitHandle { get; }
    public bool CompletedSynchronously { get; }
    public bool IsCompleted { get; }
}