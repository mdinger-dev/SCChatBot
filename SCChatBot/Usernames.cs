using System;
using System.Collections.Generic;

namespace SCChatBot
{
    static class Usernames
    {
        public static void DictionaryAdd(this Dictionary<String, int> dictionary, string key, int value)
        {
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, value);
        }
    }
}
