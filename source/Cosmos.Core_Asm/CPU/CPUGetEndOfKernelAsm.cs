using XSharp.Assembler;
using XSharp.Common;

namespace Cosmos.Core_Asm
{
    public class CPUGetEndOfKernelAsm : AssemblerMethod
    {
        public override void AssembleNew(Assembler aAssembler, object aMethodInfo)
        {
            XS.Push("_end_code");
        }
    }
}
