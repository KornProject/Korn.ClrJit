namespace Korn.ClrJit;
public enum CorInfoSigInfoFlags : byte
{
    CORINFO_SIGFLAG_IS_LOCAL_SIG = 0x01,
    CORINFO_SIGFLAG_IL_STUB = 0x02,
    // unused = 0x04,
    CORINFO_SIGFLAG_FAT_CALL = 0x08,
};