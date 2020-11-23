﻿using IL2CPU.API.Attribs;
using System;
namespace Cosmos.Core_Plugs.Interop
{
    [Plug("Interop+Kernel32, System.Private.CoreLib")]
    class Kernel32Impl
    {
        [PlugMethod(Signature = "System_Int32__Interop_Kernel32_LCMapStringEx_System_String__System_UInt32__System_Char___System_Int32__System_Void___System_Int32__System_Void___System_Void___System_IntPtr_")]
        public static unsafe int LCMapStringEx(string aString, uint aUint, char* aChar, int aInt, object aObject, int aInt2, object aObject2,
            object aObject3, IntPtr aIntPtr)
        {
            throw new NotImplementedException();
        }

        [PlugMethod(Signature = "System_Int32__Interop_Kernel32_CompareStringOrdinal_System_Char___System_Int32__System_Char___System_Int32__System_Boolean_")]
        public static unsafe int CompareStringOrdinal(char* aStrA, int aLengthA, char* aStrB, int aLengthB, bool aIgnoreCase)
        {
            if (aIgnoreCase)
            {
                throw new NotImplementedException();
            }
            if (aLengthA < aLengthB)
            {
                return -1;
            }
            else if (aLengthA > aLengthB)
            {
                return 1;
            }
            for (int i = 0; i < aLengthA; i++)
            {
                if (aStrA[i] < aStrB[i])
                {
                    return -1;
                }
                else if (aStrA[i] < aStrB[i])
                {
                    return 1;
                }
            }
            return 0;
        }

        [PlugMethod(Signature = "System_Int32__Interop_Kernel32_CompareStringEx_System_Char___System_UInt32__System_Char___System_Int32__System_Char___System_Int32__System_Void___System_Void___System_IntPtr_")]
        public static unsafe int CompareStringEx(char* aChar, uint aUint, char* aChar1, int aInt, char* aChar2, int aInt2, object aObject,
            object aObject1, IntPtr aIntPtr)
        {
            throw new NotImplementedException();
        }
    }
}