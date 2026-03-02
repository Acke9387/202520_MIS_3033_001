using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Rick_And_Morty
{
    public class RickAndMortyAPI
    {
        public List<CharacterInfo> results { get; set; }
    }

    public class CharacterInfo
    {
        public string name { get; set; }

        public string image { get; set; }

        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
