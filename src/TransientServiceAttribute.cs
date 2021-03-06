﻿// <copyright file="TransientServiceAttribute.cs" company="TanvirArjel">
// Copyright (c) TanvirArjel. All rights reserved.
// </copyright>

using System;
using Microsoft.Extensions.DependencyInjection;

namespace TanvirArjel.Extensions.Microsoft.DependencyInjection
{
    /// <summary>
    /// The services containing this <c>Attribute</c> will automatically be registered in <see cref="IServiceCollection"/>
    /// with <see cref="ServiceLifetime.Transient"/> lifetime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, AllowMultiple = false)]
    public sealed class TransientServiceAttribute : Attribute
    {
    }
}
