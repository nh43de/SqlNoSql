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
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public interface IDocumentCollection : IEnumerable
    {
        dynamic this[Guid key] { get; set; }
        dynamic Find(Guid key);
        dynamic Find(Func<dynamic, bool> filter);
        KeyValuePair<Guid, dynamic> FindWithKey(Func<dynamic, bool> filter);
        ICollection<dynamic> Filter(Func<dynamic, bool> filter);
        ICollection<KeyValuePair<Guid, dynamic>> FilterWithKeys(Func<dynamic, bool> filter);
        void AddOrUpdate(Guid key, dynamic item);
        void Remove(Guid key);
    }
}
