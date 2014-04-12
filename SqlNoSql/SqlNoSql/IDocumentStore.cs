﻿// The MIT License (MIT)
//
// Copyright (c) 2014 Bernhard Johannessen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace SqlNoSql
{
    using System.Data;
    using SqlNoSql.Generic;

    /// <summary>
    /// The document store represents the database used for storing JSON or BSON documents.
    /// </summary>
    public interface IDocumentStore
    {
        /// <summary>
        /// Gets a dynamic document collection by its name.
        /// </summary>
        /// <param name="name">The name of the collection</param>
        IDocumentCollection Collection(string name);

        /// <summary>
        /// Gets a document collection for the specified type. The name of the collection is assumed to
        /// be the same as the name of the type.
        /// </summary>
        /// <typeparam name="T">The type that is stored in the collection</typeparam>
        IDocumentCollection<T> Collection<T>();

        /// <summary>
        /// Gets a document collection for the specified type with the specified name.
        /// </summary>
        /// <typeparam name="T">The type stored in the collection</typeparam>
        /// <param name="name">The name of the collection</param>
        IDocumentCollection<T> Collection<T>(string name);

        /// <summary>
        /// Creates a new dynamic collection and returns an instance of it.
        /// </summary>
        /// <param name="name">The name of the collection to create</param>
        IDocumentCollection CreateCollection(string name);

        /// <summary>
        /// Creates a new dynamic collection and returns an instance of it.
        /// </summary>
        /// <param name="name">The name of the collection to create</param>
        /// <param name="format">The document format that is used for storing objects in the database</param>
        IDocumentCollection CreateCollection(string name, StorageFormat format);

        /// <summary>
        /// Creates a new collection for the specified type. The name of the collection that is
        /// created is the same as the name of the type.
        /// </summary>
        /// <typeparam name="T">The type that is stored in the collection</typeparam>
        IDocumentCollection<T> CreateCollection<T>();

        /// <summary>
        /// Creates a new collection for the specified type. The name of the collection that is
        /// created is the same as the name of the type.
        /// </summary>
        /// <typeparam name="T">The type that is stored in the collection</typeparam>
        /// <param name="format">The document format that is used for storing objects in the database</param>
        IDocumentCollection<T> CreateCollection<T>(StorageFormat format);

        /// <summary>
        /// Creates a new collection for the specified type with the specified name and returns an instance of it.
        /// </summary>
        /// <typeparam name="T">The type that is stored in the collection</typeparam>
        /// <param name="name">The name of the collection</param>
        IDocumentCollection<T> CreateCollection<T>(string name);

        /// <summary>
        /// Creates a new collection for the specified type with the specified name and returns an instance of it.
        /// </summary>
        /// <typeparam name="T">The type that is stored in the collection</typeparam>
        /// <param name="name">The name of the collection</param>
        /// <param name="format">The document format that is used for storing objects in the database</param>
        IDocumentCollection<T> CreateCollection<T>(string name, StorageFormat format);

        /// <summary>
        /// Deletes the collection that has the same name as the specified type.
        /// </summary>
        /// <typeparam name="T">The type that is stored in the collection</typeparam>
        void DeleteCollection<T>();

        /// <summary>
        /// Deletes the collection with the specified name.
        /// </summary>
        /// <param name="name">The name of the collection to delete</param>
        void DeleteCollection(string name);
    }
}
