// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Microsoft.OData.Edm;

namespace Microsoft.AspNetCore.OData.Formatter.Deserialization
{
    /// <summary>
    /// Represents a factory that creates an <see cref="ODataDeserializer"/>.
    /// </summary>
    public abstract class ODataDeserializerProvider
    {
        /// <summary>
        /// Gets an <see cref="ODataDeserializer"/> for the given type.
        /// </summary>
        /// <param name="type">The CLR type.</param>
        /// <param name="request">The request being deserialized.</param>
        /// <returns>An <see cref="ODataDeserializer"/> that can deserialize the given type.</returns>
        public abstract ODataDeserializer GetODataDeserializer(Type type, HttpRequest request);

        /// <summary>
        /// Gets the <see cref="ODataEdmTypeDeserializer"/> for the given EDM type.
        /// </summary>
        /// <param name="edmType">The EDM type.</param>
        /// <param name="isDelta">Is delta</param>
        /// <returns>An <see cref="ODataEdmTypeDeserializer"/> that can deserialize the given EDM type.</returns>
        public abstract ODataEdmTypeDeserializer GetEdmTypeDeserializer(IEdmTypeReference edmType, bool isDelta = false);
    }
}
