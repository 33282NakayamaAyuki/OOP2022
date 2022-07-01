using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSReader {
    public partial class Form1 : Form {

        IEnumerable<string> xTitle,xLink;

        public Form1()
        {
            InitializeComponent();
        }

private void btRssGet_Click(object sender, EventArgs e)
        {
            using (var wc = new WebClient())
            {
                //var stream = wc.OpenRead("https://news.yahoo.co.jp/rss/media/jomo/all.xml");
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);

                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var data in xTitle)
                {
                    lbRssTitle.Items.Add(data);
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e)
        {

            if (lbRssTitle.SelectedIndex != -1)
            {
                int index = lbRssTitle.SelectedIndex;

                var url = xLink.ElementAt(index);

                wbBrowser.Navigate(url);
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            wbBrowser.GoBack();
        }

        private void btAdvance_Click(object sender, EventArgs e)
        {
            wbBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
