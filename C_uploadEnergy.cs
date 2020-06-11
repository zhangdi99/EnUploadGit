using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 重点用能数据上传
{
    class C_uploadEnergy
    {
        public string deviceid = "";
        public string enterpriseCode = "";
        public List<energyData> data;
    }

}

//{
//"deviceId": "0ef6ecea08bf84c7b639c3e9b84ed546", // 从服务地址发布平台获取(必
//填)
//"enterpriseCode": "91330000573973053F", // (必填)
//"data": [ // (全部属性均必填)
//{
//"dataCode": "04-01-0000-040200-30",
//"dataValue": 123.45,//数据项的值，数据单位按“NECC-NHJC-02”要求
//"inputType": 1,
//"statType": 1,//数据采集频率， 0 实时、 1 日、 2 月、 3 年
//"statDate": "2014-10-09 00:00:00",//数据统计周期的起始时间
//"uploadDate": "2014-10-10 21:58:46",
//"scope": 1,
//"valid": true
//},
//{
//"dataCode": "04-02-0000-040200-30",
//"dataValue": 234.56,//数据项的值，数据单位按“NECC-NHJC-02”要求
//"inputType": 1,
//"statType": 1,//数据采集频率， 0 实时、 1 日、 2 月、 3 年
//"statDate": "2014-10-09 00:00:00",//数据统计周期的起始时间
//"uploadDate": "2014-10-10 21:58:46",
//"scope": 1,
//"valid": true
//}
//],
//}