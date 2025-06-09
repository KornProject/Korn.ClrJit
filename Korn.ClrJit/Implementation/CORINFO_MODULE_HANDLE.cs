namespace Korn.ClrJit;
public struct CORINFO_MODULE_HANDLE
{
    public CORINFO_MODULE_HANDLE(nint handle) => Handle = handle;

    public nint Handle;

    public static implicit operator nint(CORINFO_MODULE_HANDLE handle) => handle.Handle;
}