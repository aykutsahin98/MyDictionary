﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyList<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyList()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKeys = keys;
            TValue[] _tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }
    }
   
}
