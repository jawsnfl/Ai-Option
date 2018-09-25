﻿using System;
using System.Reflection;
using System.Runtime;
using EventFlow;
using EventFlow.Extensions;

namespace AiOption
{
    public static class AiOption
    {
        public static Assembly AiOptionAssembly => typeof(AiOption).Assembly;

        public static IEventFlowOptions AddAiOptionsDomain(this IEventFlowOptions options) {
            return options.AddDefaults(AiOptionAssembly);
        }
    }
}