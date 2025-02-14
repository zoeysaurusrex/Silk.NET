// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION")]
    public enum ShadowOptimization : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Speed\"")]
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_SPEED")]
        ShadowOptimizationSpeed = 0x0,
        [Obsolete("Deprecated in favour of \"Balanced\"")]
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_BALANCED")]
        ShadowOptimizationBalanced = 0x1,
        [Obsolete("Deprecated in favour of \"Quality\"")]
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_QUALITY")]
        ShadowOptimizationQuality = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_FORCE_DWORD")]
        ShadowOptimizationForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_SPEED")]
        Speed = 0x0,
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_BALANCED")]
        Balanced = 0x1,
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_QUALITY")]
        Quality = 0x2,
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
