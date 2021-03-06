﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Filters
{
    /// <summary>
    /// Abstract implementation of the <see cref="ILogFilter"/> interface.
    /// </summary>
    public abstract class LogFilter : ILogFilter
    {
        private string name;

        /// <summary>
        /// Initializes a new instance of <see cref="LogFilter"/>.
        /// </summary>
        /// <param name="name">The name for the log filter.</param>
        protected LogFilter(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Test to see if a message meets the criteria to be processed. 
        /// </summary>
        /// <param name="log">Log entry to test.</param>
        /// <returns><b>true</b> if the message passes through the filter and should be logged, <b>false</b> otherwise.</returns>
        public abstract bool Filter(LogEntry log);

        /// <summary>
        /// Gets the name of the log filter
        /// </summary>
        public string Name
        {
            get { return name; }
        }
    }
}
