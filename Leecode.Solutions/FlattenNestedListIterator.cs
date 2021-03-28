using System;
using System.Collections;
using System.Collections.Generic;

namespace Leecode.Solutions
{
    public class FlattenNestedListIterator
    {
        private readonly IList<INestedInteger> _nestedList;
        private List<int> _vals;
        private IEnumerable<int> cur;

        public FlattenNestedListIterator(IList<INestedInteger> nestedList)
        {
            this._vals = new List<int>();
            this._nestedList = nestedList;
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }

        public int Next()
        {
            throw new NotImplementedException();
        }

        private void GetInt(IEnumerable<INestedInteger> nesteds)
        {
            foreach (var nested in nesteds)
            {
                if(nested.IsInteger())
                    this._vals.Add(nested.GetInteger());
                else
                {
                    GetInt(nested.GetList());
                }
            }
        }
    }
    
    public interface INestedInteger
    {
        bool IsInteger();
        int GetInteger();
        IList<INestedInteger> GetList();
    }

    /// <summary>
    /// This is the interface that allows for creating nested lists.
    /// You should not implement it, or speculate about its implementation
    /// </summary>
    public class NestedInteger : INestedInteger
    {

        public NestedInteger()
        {
            
        }
        /// <summary>
        /// @return true if this NestedInteger holds a single integer, rather than a nested list.
        /// </summary>
        /// <returns></returns>
        public bool IsInteger()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// @return the single integer that this NestedInteger holds, if it holds a single integer
        /// </summary>
        /// <returns>Return null if this NestedInteger holds a nested list</returns>
        public int GetInteger()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// @return the nested list that this NestedInteger holds, if it holds a nested list
        /// </summary>
        /// <returns>Return null if this NestedInteger holds a single integer</returns>
        public IList<INestedInteger> GetList()
        {
            throw new System.NotImplementedException();
        }
    }
}