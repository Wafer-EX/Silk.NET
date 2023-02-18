// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.EXT
{
    [Extension("EXT_pbuffer")]
    public unsafe partial class ExtPbuffer : NativeExtension<WGL>
    {
        public const string ExtensionName = "EXT_pbuffer";
        [NativeApi(EntryPoint = "wglCreatePbufferEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePbuffer([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iWidth, [Flow(FlowDirection.In)] int iHeight, [Flow(FlowDirection.In)] int* piAttribList);

        [NativeApi(EntryPoint = "wglCreatePbufferEXT", Convention = CallingConvention.Winapi)]
        public partial nint CreatePbuffer([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iWidth, [Flow(FlowDirection.In)] int iHeight, [Flow(FlowDirection.In)] in int piAttribList);

        [NativeApi(EntryPoint = "wglDestroyPbufferEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DestroyPbuffer([Flow(FlowDirection.In)] nint hPbuffer);

        [NativeApi(EntryPoint = "wglGetPbufferDCEXT", Convention = CallingConvention.Winapi)]
        public partial nint GetPbufferDC([Flow(FlowDirection.In)] nint hPbuffer);

        [NativeApi(EntryPoint = "wglQueryPbufferEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryPbuffer([Flow(FlowDirection.In)] nint hPbuffer, [Flow(FlowDirection.In)] int iAttribute, [Flow(FlowDirection.Out)] int* piValue);

        [NativeApi(EntryPoint = "wglQueryPbufferEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryPbuffer([Flow(FlowDirection.In)] nint hPbuffer, [Flow(FlowDirection.In)] int iAttribute, [Flow(FlowDirection.Out)] out int piValue);

        [NativeApi(EntryPoint = "wglReleasePbufferDCEXT", Convention = CallingConvention.Winapi)]
        public partial int ReleasePbufferDC([Flow(FlowDirection.In)] nint hPbuffer, [Flow(FlowDirection.In)] nint hDC);

        public ExtPbuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}
