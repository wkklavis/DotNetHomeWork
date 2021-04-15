using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    [Serializable]
   public  class CommodityInfo : IComparable
    {
        public Int32 CommodityNo { get; set; }
        public String CommodityName { get; set; }
        public Double CommodityPrice { get; set; }

        public CommodityInfo(Int32 commodityNo, string commodityName, double commodityPrice)
        {
            CommodityNo = commodityNo;
            CommodityName = commodityName;
            CommodityPrice = commodityPrice;
        }

        public CommodityInfo()
        {
        }

        public int CompareTo(object obj)//实现默认InfoNo排序
        {
            CommodityInfo info = obj as CommodityInfo;
            if (info == null) throw new System.ArgumentException();
            else return CommodityNo.CompareTo(info.CommodityNo);
        }
        public override string ToString()
        {
            return $"商品{CommodityName} 编号{CommodityNo} 价格{CommodityPrice}";
        }
    }
}
