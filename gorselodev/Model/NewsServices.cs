﻿using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gorselodev.Model
{
    public class NewsServices
    {
        public static async Task<string> GetNews(string rss)
        {
            string api = $"https://api.rss2json.com/v1/api.json?rss_url={rss}";

            HttpClient client = new HttpClient();
            using HttpResponseMessage response = await client.GetAsync(api);

            response.EnsureSuccessStatusCode();
            string http = await response.Content.ReadAsStringAsync();

            //XmlSerializer serializer = new XmlSerializer(typeof(Rss));

            //using (StringReader reader = new StringReader(xml))
            //{
            //    var test = (Rss)serializer.Deserialize(reader);
            //}

            return http;
        }
    }

    public class Enclosure
    {
        public string link { get; set; }
        public string type { get; set; }
    }

    public class Feed
    {
        public string url { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }

    public class Item
    {
        public string title { get; set; }
        public string pubDate { get; set; }
        public string link { get; set; }
        public string guid { get; set; }
        public string author { get; set; }
        public string thumbnail { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public Enclosure enclosure { get; set; }
        public List<object> categories { get; set; }
    }

    public class HaberRoot
    {
        public string status { get; set; }
        public Feed feed { get; set; }
        public List<Item> items { get; set; }
    }


}
