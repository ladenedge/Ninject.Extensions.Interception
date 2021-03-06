// -------------------------------------------------------------------------------------------------
// <copyright file="IMethodInterceptorRegistry.cs" company="Ninject Project Contributors">
//   Copyright (c) 2007-2010 Enkari, Ltd. All rights reserved.
//   Copyright (c) 2010-2017 Ninject Project Contributors. All rights reserved.
//
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   You may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Ninject.Extensions.Interception.Registry
{
    using System;
    using System.Reflection;

    using Ninject.Components;

    /// <summary>
    /// Provides a registry of <see cref="IInterceptor"/> and <see cref="MethodInfo"/> bindings for interception.
    /// </summary>
    public interface IMethodInterceptorRegistry : INinjectComponent
    {
        /// <summary>
        /// Adds the specified interceptor for the given method.
        /// </summary>
        /// <param name="method">The method to bind the interceptor to.</param>
        /// <param name="interceptor">The interceptor to add.</param>
        void Add(MethodInfo method, IInterceptor interceptor);

        /// <summary>
        /// Determines whether the registry contains interceptors for the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        /// <c>true</c> if the registry contains interceptors for the specified type; otherwise, <c>false</c>.
        /// </returns>
        bool Contains(Type type);

        /// <summary>
        /// Gets the method interceptors bindings associated with the given type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///     <see cref="MethodInfo"/> and <see cref="IInterceptor"/> bindings for the given type.
        /// </returns>
        MethodInterceptorCollection GetMethodInterceptors(Type type);
    }
}