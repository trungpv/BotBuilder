﻿using System;
using System.Linq;

namespace Microsoft.Bot.Connector
{
    /// <summary>
    /// Synchronous request to invoke an operation
    /// </summary>
    public interface IInvokeActivity : IActivity
    {
        /// <summary>
        /// Name of the operation to invoke
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Open-ended value 
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Reference to another conversation or activity
        /// </summary>
        Models.Address RelatesTo { get; set; }
    }
}
