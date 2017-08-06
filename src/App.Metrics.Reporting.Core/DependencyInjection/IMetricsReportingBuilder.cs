﻿// <copyright file="IMetricsReportingBuilder.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
    // ReSharper restore CheckNamespace
{
    /// <summary>
    ///     Provides extensiblity on App Metrics Reporting
    /// </summary>
    public interface IMetricsReportingBuilder
    {
        IServiceCollection Services { get; }
    }
}