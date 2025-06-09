namespace Korn.ClrJit;
public unsafe struct CILJit
{
    nint* vtable;
    // int __fastcall CILJit::compileMethod(CILJit *this, ICorJitInfo *compHnd, CORINFO_METHOD_INFO *methodInfo, __int64 flags, unsigned __int8 **entryAddress, unsigned int *nativeSizeOfCode)
    public delegate* unmanaged<CILJit*, ICorJitInfo*, CORINFO_METHOD_INFO*, long, byte**, int*, CorJitResult> compileMethod => (delegate* unmanaged<CILJit*, ICorJitInfo*, CORINFO_METHOD_INFO*, long, byte**, int*, CorJitResult>)vtable[0];
    // void __fastcall CILJit::ProcessShutdownWork(CILJit *this, ICorStaticInfo *statInfo)
    public delegate* unmanaged<void> ProcessShutdownWork => (delegate* unmanaged<void>)vtable[1];
    // void __fastcall CILJit::getVersionIdentifier(CILJit *this, _GUID *versionIdentifier)
    public delegate* unmanaged<void> getVersionIdentifier => (delegate* unmanaged<void>)vtable[2];
    // void __fastcall JitHashTable<unsigned int, JitSmallPrimitiveKeyFuncs<unsigned int>, unsigned __int64*, CompAllocator, JitHashTableBehavior>::Node::operator delete(CompIAllocator*this,void* p)
    public delegate* unmanaged<void> delete => (delegate* unmanaged<void>)vtable[3];

    public static CILJit* getJit()
    {
        var module = new ClrJitModule();
        return module.getJit();
    }
}