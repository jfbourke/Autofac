﻿// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autofac.Test.Scenarios.Dependencies;

public class DependsByCtor
{
    public DependsByCtor(DependsByProp o)
    {
        Dep = o;
    }

    public DependsByProp Dep { get; private set; }
}
