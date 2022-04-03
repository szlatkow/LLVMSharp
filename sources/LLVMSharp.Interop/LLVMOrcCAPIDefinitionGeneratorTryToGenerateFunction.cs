// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-14.0.0/llvm/include/llvm-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace LLVMSharp.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("LLVMErrorRef")]
    public unsafe delegate LLVMOpaqueError* LLVMOrcCAPIDefinitionGeneratorTryToGenerateFunction([NativeTypeName("LLVMOrcDefinitionGeneratorRef")] LLVMOrcOpaqueDefinitionGenerator* GeneratorObj, void* Ctx, [NativeTypeName("LLVMOrcLookupStateRef *")] LLVMOrcOpaqueLookupState** LookupState, LLVMOrcLookupKind Kind, [NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD, LLVMOrcJITDylibLookupFlags JDLookupFlags, [NativeTypeName("LLVMOrcCLookupSet")] LLVMOrcCLookupSetElement* LookupSet, [NativeTypeName("size_t")] UIntPtr LookupSetSize);
}
