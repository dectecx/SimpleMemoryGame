using System.Drawing;

namespace MemoryGame.Models.Enum
{
    /// <summary>
    /// 牌池
    /// </summary>
    public static class CardEnum
    {
        public static Bitmap 卡牌背面 = Properties.Resources.卡牌背面;
        public static Bitmap 圖片1 = Properties.Resources.圖片1;
        public static Bitmap 圖片2 = Properties.Resources.圖片2;
        public static Bitmap 圖片3 = Properties.Resources.圖片3;
        public static Bitmap 圖片4 = Properties.Resources.圖片4;
        public static Bitmap 圖片5 = Properties.Resources.圖片5;
        public static Bitmap 圖片6 = Properties.Resources.圖片6;
        public static Bitmap 圖片7 = Properties.Resources.圖片7;
        public static Bitmap 圖片8 = Properties.Resources.圖片8;
        public static Bitmap[] GetCards = new Bitmap[]
        {
            圖片1,
            圖片2,
            圖片3,
            圖片4,
            圖片5,
            圖片6,
            圖片7,
            圖片8
        };
    }
}
