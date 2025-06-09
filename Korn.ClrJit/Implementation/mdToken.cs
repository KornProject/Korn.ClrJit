namespace Korn.ClrJit;
public struct mdToken
{
    public mdToken(int token) => Token = token;

    public int Token;

    public static implicit operator nint(mdToken token) => token.Token;
}