using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CTS
{
    class KeyboardStates {
        // Author: Ben Fairlamb
        // Purpose: Control Keyboard State
        // limitations: There are more than one enter that corespont to different keys

        // Fields
        private List<KeyValuePair<Key, KeyValuePair<bool, bool>>> isActive;
        private List<Key> keys;

        // Properties

        // Constructor
        public KeyboardStates()
        {
            isActive = new List<KeyValuePair<Key, KeyValuePair<bool, bool>>>();
            keys = new List<Key>();
            foreach (Key key in Enum.GetValues(Key.A.GetType()))
            {
                if (key != Key.None)
                {
                    isActive.Add(new KeyValuePair<Key, KeyValuePair<bool, bool>>(key, new KeyValuePair<bool, bool>(false, false)));
                    keys.Add(key);
                }
            }
        }

        // Methods

        public void Update()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                isActive[i] = new KeyValuePair<Key, KeyValuePair<bool, bool>>(keys[i],
                    new KeyValuePair<bool, bool>(isActive[i].Value.Value, Keyboard.IsKeyDown(keys[i])));
            }
        }

        public bool IsKeyActive(Key key)
        {
            int i = keys.IndexOf(key);
            return !isActive[i].Value.Key && isActive[i].Value.Value;
        }

        /// <summary>
        /// Put break in here and press key to identify keycode
        /// </summary>
        public void IdentifyKey()
        {
            Key keycode;
            bool found = false;

            for (int i = 0; i < keys.Count; i++)
            {
                if (isActive[i].Value.Value)
                {
                    keycode = isActive[i].Key;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                // Insert break here
                int i = 1;
            }
        }
    }
}
