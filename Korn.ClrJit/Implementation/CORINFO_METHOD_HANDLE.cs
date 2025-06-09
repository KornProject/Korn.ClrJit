namespace Korn.ClrJit;
public struct CORINFO_METHOD_HANDLE
{
    public CORINFO_METHOD_HANDLE(nint handle) => Handle = handle;

    public nint Handle;

    public static implicit operator nint(CORINFO_METHOD_HANDLE handle) => handle.Handle;
}