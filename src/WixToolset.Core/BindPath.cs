// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Core
{
    using WixToolset.Extensibility.Data;

    /// <summary>
    /// Bind path representation.
    /// </summary>
    internal class BindPath : IBindPath
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public BindStage Stage { get; set; }
    }
}
