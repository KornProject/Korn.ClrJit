namespace Korn.ClrJit;
public unsafe struct CORINFO_SIG_INFO
{
    public CorInfoCallConv callConv;
    public CORINFO_CLASS_STRUCT* retTypeClass;
    public CORINFO_CLASS_STRUCT* retTypeSigClass;
    public byte _retType;
    public CorInfoSigInfoFlags flags;
    public ushort numArgs;
    public CORINFO_SIG_INST sigInst;
    public CORINFO_ARG_LIST_STRUCT* args;
    public byte* pSig;
    public uint cbSig;
    public MethodSignatureInfo* methodSignature;
    public CORINFO_MODULE_STRUCT* scope;
    public mdToken token;

    public CorInfoType retType { get => (CorInfoType)_retType; set => _retType = (byte)value; }
    public CorInfoCallConv getCallConv() => callConv & CorInfoCallConv.CORINFO_CALLCONV_MASK;
    public bool hasThis() => (callConv & CorInfoCallConv.CORINFO_CALLCONV_HASTHIS) != 0;
    public bool hasExplicitThis() => (callConv & CorInfoCallConv.CORINFO_CALLCONV_EXPLICITTHIS) != 0;
    public bool hasImplicitThis() => (callConv & (CorInfoCallConv.CORINFO_CALLCONV_HASTHIS | CorInfoCallConv.CORINFO_CALLCONV_EXPLICITTHIS)) == CorInfoCallConv.CORINFO_CALLCONV_HASTHIS;
    public uint totalILArgs() => (uint)(numArgs + (hasImplicitThis() ? 1 : 0));
    public bool isVarArg() => (getCallConv() == CorInfoCallConv.CORINFO_CALLCONV_VARARG) || (getCallConv() == CorInfoCallConv.CORINFO_CALLCONV_NATIVEVARARG);
    public bool hasTypeArg() => (callConv & CorInfoCallConv.CORINFO_CALLCONV_PARAMTYPE) != 0;
}