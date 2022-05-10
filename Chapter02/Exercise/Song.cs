using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Song {

        //曲のタイトル
        public String Title { get; set; }

        //アーティスト名
        public String ArtistName { get; set; }

        //演奏時間
        public int Length { get; set; }

        //コンストラクタ
        public Song(String Title, String ArtistName, int Length)
        {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;
        }
    }
}
