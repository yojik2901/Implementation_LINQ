﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_LINQ
{
    class WhereHelperEnumerable<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _source;
        private readonly Func<T, bool> _predicate;

        public WhereHelperEnumerable(IEnumerable<T> source, Func<T, bool> predicate)
        {
            _source = source;
            _predicate = predicate;
        }
        public IEnumerator<T> GetEnumerator()
        {
            IEnumerator<T> sourceEnumerator = _source.GetEnumerator();
            return new WhereHelperEnumerator<T>(sourceEnumerator, _predicate);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
