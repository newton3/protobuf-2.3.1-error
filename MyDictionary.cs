using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ProtoBuf;

namespace protobuf
{
    [ProtoContract(UseProtoMembersOnly = true, IgnoreListHandling = true)]
    public class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        [ProtoMember(1, OverwriteList = true)]
        public IDictionary<TKey, TValue> dictLegacy { get; set; } = new Dictionary<TKey, TValue>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dictLegacy.GetEnumerator();
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            dictLegacy.Add(item);
        }

        public void Clear()
        {
            dictLegacy.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return dictLegacy.Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            dictLegacy.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return dictLegacy.Remove(item);
        }

        public int Count => dictLegacy.Count;

        public bool IsReadOnly => dictLegacy.IsReadOnly;

        public bool ContainsKey(TKey key)
        {
            return dictLegacy.ContainsKey(key);
        }

        public void Add(TKey key, TValue value)
        {
            dictLegacy.Add(key, value);
        }

        public bool Remove(TKey key)
        {
            return dictLegacy.Remove(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return dictLegacy.TryGetValue(key, out value);
        }

        public TValue this[TKey key]
        {
            get { return dictLegacy[key]; }
            set { dictLegacy[key] = value; }
        }

        public ICollection<TKey> Keys => dictLegacy.Keys;

        public ICollection<TValue> Values => dictLegacy.Values;
    }
}
