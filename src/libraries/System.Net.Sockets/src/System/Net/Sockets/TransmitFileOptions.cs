// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Versioning;

namespace System.Net.Sockets
{
    [Flags]
    public enum TransmitFileOptions
    {
        UseDefaultWorkerThread = 0x00,
        Disconnect = 0x01,
        ReuseSocket = 0x02,
        [SupportedOSPlatform("windows7.0")]
        WriteBehind = 0x04,
        [SupportedOSPlatform("windows7.0")]
        UseSystemThread = 0x10,
        [SupportedOSPlatform("windows7.0")]
        UseKernelApc = 0x20,
    };
}
