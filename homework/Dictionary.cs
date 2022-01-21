using System;

namespace homework
{
    class Dictionary
    {
        private Pair[] Words { get; set; } = new Pair[0];
        
        private class Pair
        {
            public string key;
            public string value;

            public Pair(string key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }


        public void AppendWord(string key, string value)
        {
            if (key is null) throw new ArgumentNullException(nameof(key));
            else if (value is null) throw new ArgumentNullException(nameof(value));

            var newWords = new Pair[Words.Length + 1];

            for (int i = 0; i < Words.Length; i++)
            {
                newWords[i] = Words[i];
            }

            newWords[Words.Length] = new(key, value);
            Words = newWords;
        }

        public string this[string key]
        {
            get
            {
                foreach (var item in Words)
                {
                    if (key.Equals(item.key)) return item.value;
                }

                throw new ArgumentOutOfRangeException(nameof(key), "The word with this translation does not exist in the program!");
            }
            set
            {
                AppendWord(key, value);
            }
        }
    }
}
