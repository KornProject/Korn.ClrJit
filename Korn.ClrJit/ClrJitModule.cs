using Korn.Utils;

namespace Korn.ClrJit;
public unsafe class ClrJitModule
{
    public ClrJitModule()
    {
        Handle = Kernel32.GetModuleHandle("clrjit");

        if (Handle == IntPtr.Zero)
            throw new KornError(
                $"ClrJit->ClrJitModule->.ctor(): the clrjit.dll module not found. ",
                 "This may be due to too early method invocation or specific settings of the target app build or wrong build version of the app");

        getJit = (delegate* unmanaged<CILJit*>)Kernel32.GetProcAddress(Handle, "getJit");
    }

    public readonly nint Handle = Kernel32.GetModuleHandle("clrjit");
    public readonly delegate* unmanaged<CILJit*> getJit;
}