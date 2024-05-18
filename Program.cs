using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Newtonsoft.Json;
using ApiDataImporter.Models;

class Program
{
    static async Task Main()
    {
        var apiUrl = "http://api.plos.org/search?q=title:DNA";
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic? apiResponse = JsonConvert.DeserializeObject(jsonResponse);
                    var Datas = apiResponse?.response.docs;
                    foreach (var data in Datas)
                    {
                        using (var context = new AppDbContext())
                        {
                            context.Database.EnsureCreated();
                            var tempAuthorDisp = data["author_display"];
                            // List<string> AuthDisp = new List<string>();
                            foreach (var item in tempAuthorDisp)
                            {
                                var authDisp = new Author {
                                    Name=item.ToString()
                                };

                                context.Authors.Add(authDisp);
                                context.SaveChanges();
                                // AuthDisp.Add(item.ToString());
                            }
                            var tempAuthorAbs = data["abstract"];
                            // List<string> AuthAbs = new List<string>();
                            foreach (var item in tempAuthorAbs)
                            {
                                var authAbs = new Abstract
                                {
                                    Content = item.ToString()
                                };

                                context.Abstracts.Add(authAbs);
                                context.SaveChanges();
                                // AuthAbs.Add(item.ToString());
                            }
                            var jsonData = new Article
                            {
                                Id = data.id,
                                Journal = data.journal,
                                Eissn = data.eissn,
                                PublicationDate = data.publication_date,
                                ArticleType = data.article_type,
                                TitleDisplay = data.title_display,
                                Score = data.score
                            };

                            context.Articles.Add(jsonData);
                            context.SaveChanges();
                        }
                    }

                    Console.WriteLine("JSON response stored in SQLite database.");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request Exception: " + e.Message);
            }
        }

    }
}
