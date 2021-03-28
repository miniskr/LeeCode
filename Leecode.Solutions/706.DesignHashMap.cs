using System;
using System.Collections;
using System.Collections.Generic;

namespace Leecode.Solutions
{
    public class DesignHashMap : IDesignHashMap
    {
        private readonly Dictionary<int, int> _dic;

        public DesignHashMap()
        {
            this._dic = new Dictionary<int, int>();
        }

        public void Put(int key, int value)
        {
            if (this.Get(key) == -1)
                this._dic.Add(key, value);
            else
                this._dic[key] = value;
        }

        public int Get(int key)
        {
            if (this._dic.ContainsKey(key))
                return this._dic[key];
            else
                return -1;
        }

        public void Remove(int key)
        {
            if (this._dic.ContainsKey(key))
                this._dic.Remove(key);
        }
    }
}