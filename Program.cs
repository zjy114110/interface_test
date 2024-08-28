// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
//#region 异步TASK
//async Task<string> aaAsync()
//{
//    string a = "Async:" + Thread.CurrentThread.ManagedThreadId.ToString();
//    return a;
//}
//var test = await aaAsync();
//Console.WriteLine(test);
//#endregion
//#region 接口测试
//test aa = new cod1();
//cod1 bb = new cod1();
//jkou2 jkou2 = new wbclas();
//var b = aa.test1();
//bb.test2();
//Console.WriteLine(b);
//Console.ReadLine();
//Console.WriteLine(jkou2.wbjk());
//Console.WriteLine("Hello, World!");
//Console.ReadLine();
//test aa1 = new cod1();
//aa.a = "11";
//var bb1 = new testobj();

//bb1.test1 = "22";
//Console.WriteLine((string)bb1.test1 + '_' + aa.a);
//Console.ReadLine();
//var a1 = Convert.ToDateTime("2023-01-07 14:37:18");
//var b2 = a1.AddDays((double)(3 * 31));
//var ccc = "{\"applyNumber\":" + bb + ",\"type\":\"E0\"}";

//Console.WriteLine(ccc);


//#endregion
//#region IsNullOrWhiteSpace 用法
//string abc = null + "";
//var cc1 = string.IsNullOrWhiteSpace(abc);

//Console.WriteLine(cc1 + ":" + abc);
//#endregion
//#region overried
//Parent childOne = new ChildOne();
//Parent childTwo = new ChildTwo();
////调用Parent.F()
//childOne.F();
//childTwo.F();
////实现多态
//childOne.G();
//childTwo.G();
//Parent load = new Parent();
////重载(overload)
//Console.WriteLine(load.Add(1, 2));
//Console.WriteLine(load.Add(3.4f, 4.5f));
//Console.Read();
//#endregion


//var a = new testself().a;
//Console.WriteLine(a);
// DateTime.TryParse("2023-01-09 13:59:29",out var datatime );

//   var AA= datatime.ToString("yyyyMMdd");
//var s1 = "MES_BOX_MI_1";
//if(s1.Substring(0,10)== "MES_BOX_MI")
//{
//    var s2 = "1".PadLeft(6, '0');
//}

//var a1 = 600000.2;
//double b = 0;
//double e1 = 0;
//for (int i = 0;i<(240-60);i++)
//{
//    var c = (a1 -i* 3333.33)* 0.051335 / 12+3333.33;
//    b += c;
//}
//for (int i = 0; i < (240 - 60); i++)
//{
//    var c = (a1 - i * 3333.33) * 0.043/ 12 + 3333.33;
//    e1+= c;
//}
//var d1 = 4795.99 * (240 - 59);
//var a32 = b-e1;]
var abcdg = "-1";
var ef = abcdg.IndexOf("-");
//var time = DateTime(1970, 1, 1, 8, 0, 0).AddSeconds(1543843735000);

var cs11 = "12345未岚大陆";
var cs22 = cs11.Contains("未岚大陆");

var pd1 = false;
var bcde = pd1 ? "1" : "2";
var abcd = new Array[10];
MD5 md5 = MD5.Create();
var url = "https://openapi.kwaixiaodian.com/";
var orderurl = "open/order/cursor/list";
var appKey = "ks664843898699381195";
var appSecret = "EJZs27OUSG1LzYSGcfuYBw";
var signSecret = "c2862261ecafe34cdd37e2015f4a5ced";
var timetamp= DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
DateTime time2 =DateTime.Parse( "2024-03-20 00:00:00");
StringBuilder data= new StringBuilder();
var begintime = ConvertDateTimeToInt(time2).ToString();
var endtime = ConvertDateTimeToInt(DateTime.Parse("2024-03-22 00:00:00")).ToString();
var md5data = "";
mesg tokenmesg= new mesg();
ordreq ordreq = new ordreq()
    {
  orderViewStatus="1",
  pageSize="10",
  sort="1",
  queryType= "1",
  beginTime= begintime,
  endTime= endtime,
  cpsType= "1",
  cursor=" "
};
var listdata= JsonConvert.SerializeObject(ordreq);
accesstoken();
//tokenmesg.access_token = "ChFvYXV0aC5hY2Nlc3NUb2tlbhJAcMQfxTU-5In3dbiQ7OLgn3Hu6Dw9OD7ldNudkCQ9U8OxyHopxy9D4e0Z-H3TdojI-8mZTlS-2k5NQrCKpL33BhoSABLjfh7yTTy1DilVdTWhRIBwIiBPik6iD-ZTpLWuWaou-ISrw0lgQ_1-h0bWua1gJz2wHSgFMAE";
data.Append("access_token=").Append(tokenmesg.access_token).Append("&appkey=").Append(appKey).Append("&method=open.order.cursor.list").Append("&param=").Append(listdata).Append("&signMethod=MD5&timestamp=").Append(timetamp).
    Append("&version=1").Append("").Append("&signSecret=").Append(signSecret);
var data1 = "access_token=ChFvYXV0aC5hY2Nlc3NUb2tlbhJwE_LdDCCgvMpfdL922u5ccjQHVES-K3nWYnJR3nmK8QPZ05rCnX6xqEgpuBAHSVpIJuan9WjsVKF3Qv4C6S-QcHAI90paSGarXI5ae7HZcFHHFBCDKQ17IaYc89U3XdjTlo6eesm0pD8hX2RRzuHz1hoSzj-H-jvzSB-XTbR7Zv-PlxPEIiAdqllRyfE10EUe4GxW1WK1CKrzxV92FhRhLWVLoEvrhygFMAE&appkey=ks664843898699381195&method=open.order.cursor.list&" +
    "param={\"orderViewStatus\": \"1\",\r\n  \"pageSize\": \"10\",\r\n  \"sort\": \"1\",\r\n  \"queryType\": \"1\",\r\n  \"beginTime\": \"1710864000000\",\r\n  \"endTime\": \"1711036800000\", \r\n  \"cpsType\": \"1\",\r\n  \"cursor\": \" \"\r\n}&signMethod=MD5&timestamp=1710986605991&version=1&signSecret=c2862261ecafe34cdd37e2015f4a5ced";
byte[] strbt = Encoding.UTF8.GetBytes(data.ToString());
var sing = md5.ComputeHash(strbt);
string lastmd5 = "";
foreach (var item in sing)
{
    lastmd5 += item.ToString("x2"); //x2表示将10进制转换为16进制，用0填充对齐
}
//code();
Root root = new Root();
GETORDLIST();
var BBCC = 1;
void accesstoken()
{
    var url = "https://openapi.kwaixiaodian.com/oauth2/access_token?app_id="+appKey+ "&grant_type=client_credentials&app_secret="+ appSecret;

    System.Net.WebRequest httpReq = System.Net.WebRequest.Create(url);
    System.Net.WebResponse httpRes = httpReq.GetResponse();
    Stream responseStream = httpRes.GetResponseStream();
    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
    string responseText = reader.ReadToEnd();
    tokenmesg = JsonConvert.DeserializeObject<mesg>(responseText);
}
// 使用accesstoken


void code()
{
    var url = "https://open.kwaixiaodian.com/oauth/authorize?app_id=ks664843898699381195&redirect_uri=https://www.ninebot.com&scope=merchant_order&response_type=code";
    System.Net.WebRequest httpReq = System.Net.WebRequest.Create(url);
    System.Net.WebResponse httpRes = httpReq.GetResponse();
    Stream responseStream = httpRes.GetResponseStream();
    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
    string responseText = reader.ReadToEnd();
}
void GETORDLIST()
{
    var url = "https://openapi.kwaixiaodian.com/open/order/cursor/list?access_token="+ tokenmesg.access_token+ "&method=open.order.cursor.list&param="+ listdata+ "&sign="+ lastmd5 + "&appkey="+ appKey+ "&version=1&signMethod=MD5&timestamp="+ timetamp+ "&uid=3697555668";
    System.Net.WebRequest httpReq = System.Net.WebRequest.Create(url);
    System.Net.WebResponse httpRes = httpReq.GetResponse();
    Stream responseStream = httpRes.GetResponseStream();
    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
    string responseText = reader.ReadToEnd();
    root = JsonConvert.DeserializeObject<Root>(responseText);

}
static long ConvertDateTimeToInt(System.DateTime time)
{
    System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
    long t = (time.Ticks - startTime.Ticks) / 10000;  //除10000调整为13位  
    return t;
}

var time = "2024-01-24 00:00:00";
var time1 = time.Replace("-", "").Substring(0,8);
var aa = new
{
    root = new
    {
        a=new { b=1}
    }
};
var url1 = new Uri("http://apigateway-test.segway-ninebot.com:8081/restcloud/fms/v1/S021");
var  _apiGatewayHeader = new Dictionary<string, string> { { "appkey", "632a787e5dddd864681e959b" } };
var abec = new json1 { tes = "1" };
var bcd =new ReturnModelxin { claimId = "1" ,resultMsg="2"};
var yz = new Dictionary<string, object> { { "11", "123" }, { "12", "456" } };
var yz1=new List<Dictionary<string, object>>();
yz1.Add(yz);
string jsonString = JsonConvert.SerializeObject(aa);
string pd="1" ;
var cs1 = !string.IsNullOrEmpty(pd) ?"1": "2";
double b = 1.0 / 4.0;
var a11 =Math.Ceiling(b);
var a22 = Math.Round(11.1);
var a = Convert.ToInt32("1");
var str1 = "AA.00.0012.17*九号电动滑板车-D28U-美洲-深;美规+欧规+澳规";
var c1 =str1.IndexOf("_");
var c3=str1.Substring(0, c1+1);
var c2=str1.Substring(c1+1,str1.Length-c1-1);

string MstKeys = @"测试*test";//PASS_48_VC169_VM109_VBAT1237,&01GYA8565C0580_RBA4G22L8E0124";
var b1 = MstKeys.Length;
string[] strArr = MstKeys.Split(new string[] { "\\" }, StringSplitOptions.None);
//var RouteKey = strArr[0];
//var ProcessKey = strArr[1];
//var LocationKeys = strArr[2];
//var strWorkLineID = strArr[3];

var a2 = "12334_".Contains("1");

try
{
    Uri newUri = new Uri("https://mes-cs-demo.segway-ninebot.com/");
    System.Net.WebRequest httpReq = System.Net.WebRequest.Create(newUri);
    System.Net.WebResponse httpRes = httpReq.GetResponse();

}
catch(Exception e)
{
    var a3=e.Message;
}
Console.ReadLine();
class Parent
{
    public void F()
    {
        Console.WriteLine("Parent.F()");
    }
    public virtual void G() //抽象方法
    {
        Console.WriteLine("Parent.G()");
    }
    public int Add(int x, int y)
    {
        return x + y;
    }
    public float Add(float x, float y) //重载(overload)Add函数
    {
        return x + y;
    }
}
class ChildOne : Parent //子类一继承父类
{
    new public void F() //重写(overwrite)父类函数
    {
        Console.WriteLine("ChildOne.F()");
    }
    public override void G() //覆写(override)父类虚函数,主要实现多态
    {
        Console.WriteLine("ChildOne.G()");
    }
}

class ChildTwo : Parent //子类二继承父类
{
    new public void F()
    {
        Console.WriteLine("ChildTwo.F()");
    }
    public override void G()
    {
        Console.WriteLine("ChildTwo.G()");
    }
}

interface test
{
    string a { get; set; }
    string test1();

}


class cod1 : test
{
    public string test1()
    {
        var a = 1;
        return a.ToString();
    }
    public void test2()
    {
        var b = 2;
    }
    public string a { get; set; }
}

class testobj
{
   public  object test1
    {
        get;set;
    }
}

class testself
{
    public string a { get; set; }
    public testself()
    {
        a = "1";
    }
}

public class json1
{
    public string tes { get; set; }
}
public class ReturnModelxin
{
    public string claimId { get; set; }
    public int returnCode { get; set; }//0失败，1成功
    public string resultMsg { get; set; }
}

public class mesg
{
    public string result {  get; set; }
    public string access_token { get; set; }

    public string expires_in { get; set; }


}
public class ordreq
{
    /// <summary>
    /// 
    /// </summary>
    public string orderViewStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string pageSize { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sort { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string queryType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string beginTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string endTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cpsType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cursor { get; set; }
}

public class OrderSellerRoleInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int roleId { get; set; }
    /// <summary>
    /// 九号电动旗舰店
    /// </summary>
    public string roleName { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int roleType { get; set; }
}

public class OrderBaseInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int discountFee { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string buyerNick { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int payTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> orderLabels { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string remark { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int remindShipmentSign { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int oid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sellerOpenId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int expressFee { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public OrderSellerRoleInfo orderSellerRoleInfo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string buyerImage { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int payType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int multiplePiecesNo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int validPromiseShipmentTimeStamp { get; set; }
    /// <summary>
    /// 九号电动旗舰店
    /// </summary>
    public string sellerNick { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> disableDeliveryReasonCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int recvTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string buyerOpenId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int cpsType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int promiseTimeStampOfDelivery { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int refundTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int riskCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int updateTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int theDayOfDeliverGoodsTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int commentStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int sendTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int preSale { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int coType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int createTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int totalFee { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<int> allActivityType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int sellerDelayPromiseTimeStamp { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string payChannel { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int remindShipmentTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int activityType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string priorityDelivery { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int status { get; set; }
}

public class OrderAddress
{
    /// <summary>
    /// 
    /// </summary>
    public int districtCode { get; set; }
    /// <summary>
    /// 西区街道
    /// </summary>
    public string town { get; set; }
    /// <summary>
    /// 惠州市
    /// </summary>
    public string city { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int townCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int cityCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int provinceCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string encryptedMobile { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string encryptedConsignee { get; set; }
    /// <summary>
    /// 卢
    /// </summary>
    public string desensitiseConsignee { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string encryptedAddress { get; set; }
    /// <summary>
    /// 广东省
    /// </summary>
    public string province { get; set; }
    /// <summary>
    /// 惠阳区
    /// </summary>
    public string district { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string desensitiseMobile { get; set; }
    /// <summary>
    /// ****路与龙海**路交叉口西南侧光弘科枝**期地下室快**
    /// </summary>
    public string desensitiseAddress { get; set; }
}

public class CategoryInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int itemCid { get; set; }
    /// <summary>
    /// 电动摩托车（物流配送）
    /// </summary>
    public string categoryName { get; set; }
}

public class ItemExtra
{
    /// <summary>
    /// 
    /// </summary>
    public CategoryInfo categoryInfo { get; set; }
}

public class OrderItemInfo
{
    /// <summary>
    /// 
    /// </summary>
    public string itemPicUrl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int itemType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int discountFee { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int originalPrice { get; set; }
    /// <summary>
    /// Ninebot九号电动M95C电动摩托车9号智能电瓶车长续航【门店自提】
    /// </summary>
    public string itemTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int orderItemId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int num { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public ItemExtra itemExtra { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string warehouseCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int itemId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int relItemId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int relSkuId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int price { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string itemLinkUrl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string skuNick { get; set; }
    /// <summary>
    /// 如图黑色字体区域+100元
    /// </summary>
    public string skuDesc { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string goodsCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int skuId { get; set; }
}

public class OrderNote
{
    /// <summary>
    /// 
    /// </summary>
    public List<string> sellerNote { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> orderNoteInfo { get; set; }
}

public class OrderDeliveryInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int deliveryNum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string enableAppendPackage { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int totalPackageNum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int maxPackageNum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int packageNum { get; set; }
}

public class OrderListItem
{
    /// <summary>
    /// 
    /// </summary>
    public OrderBaseInfo orderBaseInfo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> orderRefundList { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public OrderAddress orderAddress { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> orderLogisticsInfo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public OrderItemInfo orderItemInfo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public OrderNote orderNote { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public OrderDeliveryInfo orderDeliveryInfo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> subOrderInfo { get; set; }
}

public class Data
{
    /// <summary>
    /// 
    /// </summary>
    public string cursor { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<OrderListItem> orderList { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pageSize { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public long beginTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public long endTime { get; set; }
}

public class Root
{
    /// <summary>
    /// 
    /// </summary>
    public int result { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string msg { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string error_msg { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Data data { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string requestId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sub_msg { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sub_code { get; set; }
}

public class FactoryView
{
    /// <summary>
    /// 
    /// </summary>
    public string factory { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string factoryBatchId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string snParamsFile { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string maintainStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string materialStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string purchaseType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string qualityTesting { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string stockLocation { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string purchaseGroup { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string lvorm { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string fromList { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string quota { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string deliveryTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string deliveryStrict { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string deliveryShort { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string deliveryLocation { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string minQuantity { get; set; }
}

public class Data1
{
    /// <summary>
    /// 
    /// </summary>
    public string materialCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string materialType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string materialGroup { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string newMaterialCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string measure { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string warranty { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string vehicleColor { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string specNo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string specVersion { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string centralPurchasing { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string productGroup { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string packagingGroup { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string externalMaterialGroup { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string productSeries { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string productType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string drawingVersion { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string goodsCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string project { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string materialVersion { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string drawingNo { get; set; }
    /// <summary>
    /// PLM_吴春霞_(已禁用)_(已禁用)
    /// </summary>
    public string materialApplicant { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string materialDescribe { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string materialDescribeEn { get; set; }
    /// <summary>
    /// 3-One C；1；pin间距：1_接插件型号1_接插件使用方式(接线/接板)：1_额定电压：1_额定电流：1_使用温度：1_防水等级：1
    /// </summary>
    public string elaborate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string materialDescribeLe { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string purchaseTypeVote { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string productCategory { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string twoLevelCategory { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string stage { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string threeLevelCategory { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string oneLevelCategory { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DateTime materialErsda { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DateTime materialLaeda { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string mstae { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string mbrsh { get; set; }
    /// <summary>
    /// 线束接插件-接插件
    /// </summary>
    public string ewbez { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string lvorm { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string zeifo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string ztx { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string tboxCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string tboxDescribe { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string snDescribe { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string mtposMara { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string orderUnit { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string umren { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string umrez { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string certifiedModel { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string netWeight { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string weight { get; set; }
    /// <summary>
    /// 九号单轮平衡车One系列
    /// </summary>
    public string seriesNameCn { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string seriesNameEn { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string typeNameCn { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string typeNameEn { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string productModel { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string subseries { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string subseriesCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<FactoryView> factoryView { get; set; }
}

public class Root1
{
    /// <summary>
    /// 
    /// </summary>
    public string msg { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int errcode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<Data1> data { get; set; }
}


