// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-12.0.0/llvm/include/llvm-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace LLVMSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="LLVMOpaqueModule" /> struct.</summary>
    public static unsafe class LLVMOpaqueModuleTests
    {
        /// <summary>Validates that the <see cref="LLVMOpaqueModule" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<LLVMOpaqueModule>(), Is.EqualTo(sizeof(LLVMOpaqueModule)));
        }

        /// <summary>Validates that the <see cref="LLVMOpaqueModule" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(LLVMOpaqueModule).IsLayoutSequential, Is.True);
        }

        /// <summary><see cref="LLVMOpaqueModule" /> struct should have the correct size of 1.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(LLVMOpaqueModule), Is.EqualTo(1), "LLVMOpaqueModule struct should have the correct size 1");
        }
    }
}
