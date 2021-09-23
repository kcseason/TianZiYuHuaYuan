using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianZiYuHuaYuan.Entity
{
    class Business
    {
        public bool ReturnMoney { get; set; } // 是否生产银两
        public bool ReturnFood { get; set; } // 是否生产粮草
        public bool ReturnSoldier { get; set; } // 是否生产士兵
        public List<Person> Persons { get; set; } // 驻扎人物要求
        public int LevelSum1 { get; set; } // 条件一
        public decimal MoneyAdd1 { get; set; } // 银两加成
        public decimal FoodAdd1 { get; set; } // 粮草加成
        public decimal SoldierAdd1 { get; set; } // 士兵加成
        public int LevelSum2 { get; set; } // 条件二
        public decimal MoneyAdd2 { get; set; }  // 银两加成
        public decimal FoodAdd2 { get; set; } // 粮草加成
        public decimal SoldierAdd2 { get; set; } // 士兵加成
        public int LevelSum3 { get; set; } // 条件三
        public decimal MoneyAdd3 { get; set; } // 银两加成
        public decimal FoodAdd3 { get; set; } // 粮草加成
        public decimal SoldierAdd3 { get; set; } // 士兵加成
        public int LevelSum4 { get; set; } // 条件四
        public decimal MoneyAdd4 { get; set; } // 银两加成
        public decimal FoodAdd4 { get; set; } // 粮草加成
        public decimal SoldierAdd4 { get; set; } // 士兵加成
        public int Star { get; set; } // 要求星级
        public int StarSum { get; set; } // 满足数量
        public decimal MoneyAdd5 { get; set; } // 银两加成
        public decimal FoodAdd5 { get; set; } // 粮草加成
        public decimal SoldierAdd5 { get; set; } // 士兵加成
        public int GetMoney { get; set; } // 获取银两总量
        public int GetFood { get; set; } // 获取粮草总量
        public int GetSoldier { get; set; } // 获取士兵总量

    }
}
