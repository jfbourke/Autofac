﻿// This software is part of the Autofac IoC container
// Copyright © 2016 Autofac Contributors
// https://autofac.org
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

namespace Autofac.Builder
{
    /// <summary>
    /// Internal metadata keys.
    /// </summary>
    internal static class MetadataKeys
    {
        /// <summary>
        /// Key containing the registration order.
        /// </summary>
        internal const string RegistrationOrderMetadataKey = "__RegistrationOrder";

        /// <summary>
        /// Key containing a value indicating whether the registration has been auto activated.
        /// </summary>
        internal const string AutoActivated = "__AutoActivated";

        /// <summary>
        /// Key containing a value indicating whether the registration should be started on activation.
        /// </summary>
        internal const string StartOnActivatePropertyKey = "__StartOnActivate";

        /// <summary>
        /// Key containing the container build options.
        /// </summary>
        internal const string ContainerBuildOptions = "__ContainerBuildOptions";

        // TODO: Change the registration builder event handler to not use these.
        #pragma warning disable SA1600 // Elements should be documented
        internal const string RegisteredPropertyKey = "__RegisteredKey";

        internal const string RegistrationSourceAddedPropertyKey = "__RegistrationSourceAddedKey";

        internal const string InternalRegisteredPropertyKey = "__InternalRegisteredKey";

        internal const string InternalRegistrationSourceAddedPropertyKey = "__InternalRegistrationSourceAddedKey";
        #pragma warning restore SA1600 // Elements should be documented
    }
}
