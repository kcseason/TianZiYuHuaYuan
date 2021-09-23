using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianZiYuHuaYuan.Entity
{
    class Person
    {
        public string PersonName { get; set; } // 名字
        public string PesonType { get; set; } // 人物类别
        public string PositionType { get; set; } // 人物职别
        public int Level { get; set; } // 等级
        public int Qulification { get; set; } // 总资质 
        public int Properties { get; set; } // 总属性
        public int Force { get; set; } // 武力
        public int Intelligence { get; set; } // 智力
        public int Politics { get; set; } // 政治
        public int Command { get; set; } // 统率
        public int FiveStar { get; set; } // 5星数量
        public int SixStar { get; set; } // 6星数量
        public int SevenStar { get; set; } // 7星数量
        public int EightStar { get; set; } // 8星数量
    }

    public enum PesonType
    {

    }
}
