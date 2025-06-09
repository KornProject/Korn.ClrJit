namespace Korn.ClrJit;
public unsafe struct CORINFO_METHOD_INFO
{
    public CORINFO_METHOD_HANDLE ftn;
    public CORINFO_MODULE_HANDLE scope;
    public byte* ILCode;
    public uint ILCodeSize;
    public uint maxStack;
    public uint EHcount;
    public CorInfoOptions options;
    public CorInfoRegionKind regionKind;
    public CORINFO_SIG_INFO args;
    public CORINFO_SIG_INFO locals;
}