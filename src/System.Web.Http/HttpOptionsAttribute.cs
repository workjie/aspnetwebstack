﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections.ObjectModel;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;

namespace System.Web.Http
{
    /// <summary>
    /// Specifies that an action supports the OPTIONS HTTP method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class HttpOptionsAttribute : HttpVerbAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpOptionsAttribute" /> class.
        /// </summary>
        public HttpOptionsAttribute()
            : base(HttpMethod.Options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpOptionsAttribute" /> class.
        /// </summary>
        /// <param name="routeTemplate">The route template describing the URI pattern to match against.</param>
        public HttpOptionsAttribute(string routeTemplate)
            : base(HttpMethod.Options, routeTemplate)
        {
        }
    }
}
