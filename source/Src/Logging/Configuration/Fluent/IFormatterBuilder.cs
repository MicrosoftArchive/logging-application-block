﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Fluent
{
    /// <summary>
    /// Interface for builder classes used to configure <see cref="ILogFormatter"/> instances.
    /// </summary>
    public interface IFormatterBuilder
    {
        /// <summary>
        /// Returns the <see cref="FormatterData"/> instance that contains the configuration for an <see cref="ILogFormatter"/> instance.
        /// </summary>
        FormatterData GetFormatterData();
    }
}
