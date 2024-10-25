

using System;

namespace IndexerTask.Models
{
    internal class StringList
    {
        private string[] Cities;

        public StringList(string[] initCity)
        {
            Cities = initCity;
        }


        public int this[string cityName]
        {
            get
            {
                for (int i = 0; i < Cities.Length; i++)
                {
                    if (Cities[i] == cityName)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}
