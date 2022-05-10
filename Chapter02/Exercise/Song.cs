using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Song {

        public Song(String Title, String ArtistName, int Length)
        {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;
        }

        public String Title { get; set; }

        public String ArtistName { get; set; }

        public int Length { get; set; }

    }
    
}
