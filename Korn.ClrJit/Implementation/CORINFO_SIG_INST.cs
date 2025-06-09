namespace Korn.ClrJit;
public unsafe struct CORINFO_SIG_INST
{
    public uint classInstCount;
    public CORINFO_CLASS_STRUCT** classInst; // (representative, not exact) instantiation for class type variables in signature
    public uint methInstCount;
    public CORINFO_CLASS_STRUCT** methInst; // (representative, not exact) instantiation for method type variables in signature
}