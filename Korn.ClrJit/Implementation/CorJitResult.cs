namespace Korn.ClrJit;
public enum CorJitResult
{
    CORJIT_OK = 0,
    CORJIT_BADCODE = unchecked((int)0x80000001),
    CORJIT_OUTOFMEM = unchecked((int)0x80000002),
    CORJIT_INTERNALERROR = unchecked((int)0x80000003),
    CORJIT_SKIPPED = unchecked((int)0x80000004),
    CORJIT_RECOVERABLEERROR = unchecked((int)0x80000005),
    CORJIT_IMPLLIMITATION = unchecked((int)0x80000006),
};