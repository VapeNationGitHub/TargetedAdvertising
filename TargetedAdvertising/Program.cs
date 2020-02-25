using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TargetedAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {

            Process.Start("http:\\bereza-irk.ru/shp/index.php?route=product%2Fcategory&path=59");
            Process.Start("https:\\market.yandex.ru/search?text=%D0%B3%D1%80%D0%BE%D0%B1%D1%8B%20%D0%B8%D1%80%D0%BA%D1%83%D1%82%D1%81%D0%BA%D0%B0&rs=eJwzSvKS4xILKE9ySfaLTPctd86PLCyu8op3sbR0lGBUYNBgAMl7FQaHGJtkmpinuvuHBmdkRWSGu2aWS3DA5AssM_x9SpJCKrz8Ki3MdM2zvUPKnR0lWEDyEQwAVjIZ4g%2C%2C&clid=545&lr=63&local-offers-first=0");
            Process.Start("https:\\xn-----7kckmpbdsabf0a2bhdojidcgi0qxa.xn--p1ai/category/groby");
            Process.Start("https:\\irkutsk.promportal.su/category_goods/50801/grobi/");
            Process.Start("https:\\ripme.ru/irkutsk");
            Process.Start("https:\\angelzal13.ru/category/groby");
            Process.Start("https:\\ritline.ru/shop/ritualnye-prinadlezhnosti/groby/?utm_source=yandex&utm_medium=cpc&utm_campaign=46073490&utm_content=8035871924&utm_term=%D0%9A%D1%83%D0%BF%D0%B8%D1%82%D1%8C%20%D0%B3%D1%80%D0%BE%D0%B1%D1%8B%20%D0%BE%D0%BF%D1%82%D0%BE%D0%BC&roistat=direct1_search_8035871924_%D0%9A%D1%83%D0%BF%D0%B8%D1%82%D1%8C%20%D0%B3%D1%80%D0%BE%D0%B1%D1%8B%20%D0%BE%D0%BF%D1%82%D0%BE%D0%BC&roistat_referrer=none&roistat_pos=premium_1");
            Process.Start("https:\\www.ritual-ritorg.ru/groby-lakirovannye/?utm_source=eLama-yandex&utm_campaign=++%D0%A0%D0%BE%D1%81%D1%81%D0%B8%D1%8F+-+%D0%A0%D0%A7&utm_term=%D0%B3%D1%80%D0%BE%D0%B1%D1%8B%20%D0%BE%D0%BF%D1%82%D0%BE%D0%BC%20%D0%BA%D1%83%D0%BF%D0%B8%D1%82%D1%8C&utm_content=cid|24958677|gid|2399882906|aid|3671074286|adp|no|dvc|desktop|pid|8703649870|rid||did|8703649870|pos|premium2|adn|search|crid|0|&utm_medium=cpc&yclid=822693019326118644");
            Process.Start("https:\\irkutsk.tiu.ru/Groby;wholesale");
            Process.Start("https:\\www.ritual-ritorg.ru/groby-lakirovannye/?utm_source=eLama-yandex&utm_campaign=++%D0%A0%D0%BE%D1%81%D1%81%D0%B8%D1%8F+-+%D0%A0%D0%A7&utm_term=%D0%B3%D1%80%D0%BE%D0%B1%D1%8B%20%D0%BE%D0%BF%D1%82%D0%BE%D0%BC%20%D0%BA%D1%83%D0%BF%D0%B8%D1%82%D1%8C&utm_content=cid|24958677|gid|2399882906|aid|3671074286|adp|no|dvc|desktop|pid|8703649870|rid||did|8703649870|pos|premium2|adn|search|crid|0|&utm_medium=cpc&yclid=822695465586547978");
            Process.Start("https:\\ritual-tovar-opt.ru/grobi--kresti/");
            Process.Start("https:\\productcenter.ru/products/r-irkutskaia-obl-170/catalog-groby-3313");
            Process.Start("https:\\russian.alibaba.com/g/china-coffins.html");
            Process.Start("https:\\kassot.com/b2bito/grobyi/irkutsk");
            Process.Start("https:\\fis.ru/Groby");
            Process.Start("http:\\baston-opt.com/shop/Hrobs/");
            Thread.Sleep(6000);

            Process[] processes = Process.GetProcessesByName("chrome"); // Получим все процессы Google Chrome

            foreach (Process process in processes) // В цикле их переберём
            {
               process.Kill(); // завершим процесс
            }        
        }        
    }
}
