using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;

namespace IMDBparser
{
    public partial class FormMain : Form
    {
            private List<Film> GetParseFilms()
            {
                List<Film> films = new List<Film>();

                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                string htmlData = webClient.DownloadString("https://www.imdb.com/chart/top");

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(htmlData);

                HtmlNode tableNode = doc.DocumentNode.SelectSingleNode("//tbody[@class='lister-list']");

                HtmlNodeCollection tableRows = tableNode.SelectNodes("tr");

                for (int i = 0; i < tableRows.Count; i++)
                {
                    string data = tableRows[i].InnerHtml;

                    int a = 5;

                    string place = tableRows[i].SelectSingleNode("td[@class='titleColumn']").InnerText;
                    place = place.TrimStart();
                    place = place.Remove(place.IndexOf('.'));

                    string name = tableRows[i].SelectSingleNode("td[@class='titleColumn']/a").InnerText;

                    string creationYear = tableRows[i].SelectSingleNode("td[@class='titleColumn']/span").InnerText;
                    creationYear = creationYear.TrimStart('(').TrimEnd(')');

                    string rating = tableRows[i].SelectSingleNode("td[@class='ratingColumn imdbRating']/strong").InnerText;
                    rating = rating.Replace('.', ',');

                    films.Add(new Film()
                    {
                        Place = int.Parse(place),
                        Name = name,
                        CreationYear = int.Parse(creationYear),
                        Rating = double.Parse(rating)
                    });

                }

                return films;
            }

        public FormMain()
        {
            InitializeComponent();
        }

        private async void buttonParseFilmsTable_Click(object sender, EventArgs e)
        {
            dataGridViewFilmsTable.DataSource = null;
            dataGridViewFilmsTable.DataSource = await Task<List<Film>>.Factory.StartNew(GetParseFilms);
        }
    }
}
