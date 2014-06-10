﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.OptionsModel;

namespace Microsoft.AspNet.Mvc.Test
{
    public class MockMvcOptionsAccessor : IOptionsAccessor<MvcOptions>
    {
	    public MockMvcOptionsAccessor()
	    {
            Options = new MvcOptions();
	    }

        public MvcOptions Options { get; private set; }
    }
}