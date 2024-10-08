﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace AntDesign.Docs
{
    public class DemoMenuItem
    {
        public float Order { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public string Cover { get; set; }

        public DemoMenuItem[] Children { get; set; }
    }
}
