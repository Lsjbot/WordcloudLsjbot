using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using WordcloudLsjbot;


namespace WordCloudUI
{
    public partial class FormWordcloud : Form
    {
        string title = "";
        string folder = "";
        Color backgroundcolor = Color.FromArgb(240, 240, 200); //ljusgul //Color.FromArgb(254,243,237); //ljusrosa
        Color word1color = Color.FromArgb(27, 69, 145);
        Color word2color = Color.FromArgb(214, 33, 40);
        Color? wordcolor = null;// Color.FromArgb(225, 182, 191); //ljusrosa
        public FormWordcloud()
        {
            InitializeComponent();
        }

        public void memo(string s)
        {
            richTextBox1.AppendText(s + "\n");
            richTextBox1.ScrollToCaret();
        }

        private SKColor colorconvert(Color c)
        {
            return new SKColor(c.R, c.G, c.B);
        }

        private void MakeCloud(string title)
        {
            int xsize = util.tryconvert(TBwidth.Text);
            int ysize = util.tryconvert(TBheight.Text);
            var wcc = new WordcloudLsjbot.WordCloudClass(xsize, ysize,CBbackpage.Checked,100000,CBtitspecial.Checked);

            if (CBtext.Checked)
            {
                openFileDialog1.Title = "Text file:";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    wcc.AddTextfile(openFileDialog1.FileName);
                }
            }
            else if (CBfile.Checked)
            {
                openFileDialog1.Title = "Weight file:";

            }

            wcc.SetFontSize(util.tryconvert(TBminfont.Text), util.tryconvert(TBmaxfont.Text));
            wcc.SetBackgroundColor(colorconvert(backgroundcolor));
            wcc.SetSpecialColors(colorconvert(word1color),colorconvert(word2color));
            wcc.SetSpacing(util.tryconvert(TBxspace.Text), util.tryconvert(TByspace.Text));
            string shape = "rectangle";
            if (RBcircle.Checked)
                shape = "circle";
            else if (RBellipse.Checked)
                shape = "ellipse";
            else if (RBtriangle.Checked)
                shape = "triangle";
            wcc.SetShape(shape);
            if (wordcolor != null)
                wcc.SetSpecificWordColor(colorconvert((Color)wordcolor));
            else
            {
                wcc.SetColorRange(
                util.tryconvert(TBminh.Text), util.tryconvert(TBmaxh.Text),
                util.tryconvert(TBmins.Text), util.tryconvert(TBmaxs.Text),
                util.tryconvert(TBminv.Text), util.tryconvert(TBmaxv.Text));
            }
            int nw = 0;
            int skip = CBbackpage.Checked ? 2 : 0;
            int nfail = wcc.Arrange();
            memo("nfail = " + nfail);
            SKBitmap bitmap = wcc.Draw(title);
            //wcc.DrawToFile(title, imagefile, bitmap);
            pictureBox1.Width = xsize;
            pictureBox1.Height = ysize;
            using (var stream = new MemoryStream())
            {
                bitmap.Encode(stream, SKEncodedImageFormat.Png, 100);
                stream.Seek(0, SeekOrigin.Begin);
                var image = Image.FromStream(stream);
                pictureBox1.Image = image;// new Bitmap(new System.IO.MemoryStream(data.ToArray()));
                //image.Save(imagefile);
            }
        }


        char[] trimchars = " .-,;:'?!0123456789()".ToCharArray();
        private string cookkey(string rawkey)
        {
            return rawkey.Trim(trimchars).ToLower();//.Replace(" ","_");
        }




        private void Wordcloudbutton_Click(object sender, EventArgs e)
        {
            fill_blacklist();
            //var frequencies = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> fdict;
            Dictionary<string, Dictionary<string, Dictionary<string, double>>> linkdict;

            string titstring = TBcloudtitle.Text;
            if (String.IsNullOrEmpty(titstring))
                titstring = "Word cloud by Lsjbot";
            MakeCloud(titstring);

        }

        public List<string> blacklist = new List<string>();

        public void fill_blacklist()
        {
            if (blacklist.Count > 0)
                return;

            blacklist.Add("the");
            blacklist.Add("and");
            blacklist.Add("of");
            blacklist.Add("in");
            blacklist.Add("to");
            blacklist.Add("a");
            blacklist.Add("for");
            blacklist.Add("with");
            blacklist.Add("is");
            blacklist.Add("as");
            blacklist.Add("that");
            blacklist.Add("on");
            blacklist.Add("this");
            blacklist.Add("were");
            blacklist.Add("was");
            blacklist.Add("are");
            blacklist.Add("by");
            blacklist.Add("from");
            blacklist.Add("study");
            blacklist.Add("an");
            blacklist.Add("be");
            blacklist.Add("i");
            blacklist.Add("at");
            blacklist.Add("their");
            blacklist.Add("we");
            blacklist.Add("between");
            blacklist.Add("data");

            blacklist.Add("care");
            blacklist.Add("or");
            blacklist.Add("it");
            blacklist.Add("how");
            blacklist.Add("have");
            blacklist.Add("can");
            blacklist.Add("used");

            blacklist.Add("which");
            blacklist.Add("using");
            blacklist.Add("results");
            blacklist.Add("research");

            blacklist.Add("has");
            blacklist.Add("more");
            blacklist.Add("also");
            blacklist.Add("not");
            blacklist.Add("these");

            blacklist.Add("use");
            blacklist.Add("analysis");



            blacklist.Add("during");

            blacklist.Add("=");

            blacklist.Add("all");
            blacklist.Add("but");
            blacklist.Add("they");

            blacklist.Add("both");
            blacklist.Add("two");

            blacklist.Add("been");
            blacklist.Add("one");
            blacklist.Add("such");


            blacklist.Add("when");

            blacklist.Add("about");





            blacklist.Add("there");
            blacklist.Add("time");

            blacklist.Add("well");
            blacklist.Add("three");
            blacklist.Add("than");

            blacklist.Add("among");
            blacklist.Add("other");

            blacklist.Add("into");

            blacklist.Add("what");

            blacklist.Add("aim");
            blacklist.Add("however");


            blacklist.Add("through");
            blacklist.Add("had");


            blacklist.Add("new");
            blacklist.Add("after");
            blacklist.Add("important");
            blacklist.Add("our");

            blacklist.Add("higher");

            blacklist.Add("findings");
            blacklist.Add("most");


            blacklist.Add("while");


            blacklist.Add("who");
            blacklist.Add("its");






            blacklist.Add("found");
            blacklist.Add("within");
            blacklist.Add("where");
            blacklist.Add("may");
            blacklist.Add("no");
            blacklist.Add("show");
            blacklist.Add("further");
            blacklist.Add("over");
            blacklist.Add("some");

            blacklist.Add("–");
            blacklist.Add("&amp");
            blacklist.Add("across");
            blacklist.Add("är");
            blacklist.Add("att");
            blacklist.Add("av");
            blacklist.Add("being");
            blacklist.Add("could");
            blacklist.Add("de");
            blacklist.Add("den");
            blacklist.Add("det");
            blacklist.Add("different");
            blacklist.Add("do");
            blacklist.Add("due");
            blacklist.Add("each");
            blacklist.Add("en");
            blacklist.Add("et");
            blacklist.Add("ett");
            blacklist.Add("first");
            blacklist.Add("för");
            blacklist.Add("four");
            blacklist.Add("från");
            blacklist.Add("har");
            blacklist.Add("high");
            blacklist.Add("hur");
            blacklist.Add("if");
            blacklist.Add("kan");
            blacklist.Add("key");
            blacklist.Add("la");
            blacklist.Add("large");
            blacklist.Add("less");
            blacklist.Add("made");
            blacklist.Add("main");
            blacklist.Add("many");
            blacklist.Add("med");
            blacklist.Add("men");
            blacklist.Add("needs");
            blacklist.Add("och");
            blacklist.Add("often");
            blacklist.Add("olika");
            blacklist.Add("om");
            blacklist.Add("only");
            blacklist.Add("out");
            blacklist.Add("own");
            blacklist.Add("på");
            blacklist.Add("per");
            blacklist.Add("several");
            blacklist.Add("should");
            blacklist.Add("showed");
            blacklist.Add("shows");
            blacklist.Add("som");
            blacklist.Add("them");
            blacklist.Add("those");
            blacklist.Add("thus");
            blacklist.Add("till");
            blacklist.Add("under");
            blacklist.Add("way");
            blacklist.Add("will");
            blacklist.Add("inte");
            blacklist.Add("också");
            blacklist.Add("även");
            blacklist.Add("dock");
            blacklist.Add("så");
            blacklist.Add("därför");
            blacklist.Add("endast");
            blacklist.Add("särskilt");
            blacklist.Add("t.ex.");
            blacklist.Add("bl.a.");
            blacklist.Add("mer");
            blacklist.Add("det");
            blacklist.Add("detta");
            blacklist.Add("ett");
            blacklist.Add("Ett");
            blacklist.Add("den");
            blacklist.Add("denna");
            blacklist.Add("Den");
            blacklist.Add("en");
            blacklist.Add("En");
            blacklist.Add("någon");
            blacklist.Add("de");
            blacklist.Add("dessa");
            blacklist.Add("De");
            blacklist.Add("alla");
            blacklist.Add("samma");
            blacklist.Add("när");
            blacklist.Add("där");
            blacklist.Add("hur");
            blacklist.Add("som");
            blacklist.Add("vad");
            blacklist.Add("vilket");
            blacklist.Add("att");
            blacklist.Add("annat");
            blacklist.Add("sådant");
            blacklist.Add("sådan");
            blacklist.Add("annan");
            blacklist.Add("sådana");
            blacklist.Add("andra");
            blacklist.Add("olika");
            blacklist.Add("vissa");
            blacklist.Add("nya");
            blacklist.Add("nya");
            blacklist.Add("och");
            blacklist.Add("eller");
            blacklist.Add("som");
            blacklist.Add("samt");
            blacklist.Add("än");
            blacklist.Add("men");
            blacklist.Add("fall");
            blacklist.Add("år");
            blacklist.Add("krav");
            blacklist.Add("barn");
            blacklist.Add("stycket");
            blacklist.Add("år");
            blacklist.Add("beslut");
            blacklist.Add("sätt");
            blacklist.Add("a");
            blacklist.Add("avsnitt");
            blacklist.Add("förslag");
            blacklist.Add("arbete");
            blacklist.Add("uppgifter");
            blacklist.Add("bestämmelser");
            blacklist.Add("åtgärder");
            blacklist.Add("personer");
            blacklist.Add("procent");
            blacklist.Add("regler");
            blacklist.Add("myndigheter");
            blacklist.Add("frågor");
            blacklist.Add("lagen");
            blacklist.Add("regeringen");
            blacklist.Add("artikel");
            blacklist.Add("lag");
            blacklist.Add("verksamhet");
            blacklist.Add("information");
            blacklist.Add("rätt");
            blacklist.Add("del");
            blacklist.Add("tid");
            blacklist.Add("if");
            blacklist.Add("myndighet");
            blacklist.Add("möjlighet");
            blacklist.Add("Ds");
            blacklist.Add("Sverige");
            blacklist.Add("the");
            blacklist.Add("det");
            blacklist.Add("Det");
            blacklist.Add("detta");
            blacklist.Add("Detta");
            blacklist.Add("den");
            blacklist.Add("man");
            blacklist.Add("de");
            blacklist.Add("sig");
            blacklist.Add("i");
            blacklist.Add("av");
            blacklist.Add("för");
            blacklist.Add("till");
            blacklist.Add("om");
            blacklist.Add("på");
            blacklist.Add("med");
            blacklist.Add("enligt");
            blacklist.Add("från");
            blacklist.Add("I");
            blacklist.Add("vid");
            blacklist.Add("inom");
            blacklist.Add("under");
            blacklist.Add("genom");
            blacklist.Add("mot");
            blacklist.Add("mellan");
            blacklist.Add("För");
            blacklist.Add("efter");
            blacklist.Add("över");
            blacklist.Add("Enligt");
            blacklist.Add("hos");
            blacklist.Add("utan");
            blacklist.Add("sin");
            blacklist.Add("sina");
            blacklist.Add("två");
            blacklist.Add("första");
            blacklist.Add("andra");
            blacklist.Add("att");
            blacklist.Add("om");
            blacklist.Add("Om");
            blacklist.Add("se");
            blacklist.Add("vara");
            blacklist.Add("kunna");
            blacklist.Add("ha");
            blacklist.Add("få");
            blacklist.Add("är");
            blacklist.Add("har");
            blacklist.Add("kan");
            blacklist.Add("ska");
            blacklist.Add("skall");
            blacklist.Add("får");
            blacklist.Add("bör");
            blacklist.Add("gäller");
            blacklist.Add("innebär");
            blacklist.Add("kommer");
            blacklist.Add("måste");
            blacklist.Add("avser");
            blacklist.Add("blir");
            blacklist.Add("finns");
            blacklist.Add("avses");
            blacklist.Add("anges");
            blacklist.Add("skulle");
            blacklist.Add("var");
            blacklist.Add("vi");
            blacklist.Add("fick");
            blacklist.Add("ganska");
            blacklist.Add("kanske");
            blacklist.Add("dem");
            blacklist.Add("många");
            blacklist.Add("bara");
            blacklist.Add("våra");
            blacklist.Add("tredje");
            blacklist.Add("blivit");
            blacklist.Add("ju");
            blacklist.Add("nog");
            blacklist.Add("något");
            blacklist.Add("mycket");
            blacklist.Add("gör");
            blacklist.Add("om");
            blacklist.Add("g");
            blacklist.Add("n");
            blacklist.Add("f");
            blacklist.Add("lite");
            blacklist.Add("bra");
            blacklist.Add("här");
            blacklist.Add("o");
            blacklist.Add("vårt");
            blacklist.Add("något");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((sender as Button).Text.Contains("background"))
                    backgroundcolor = colorDialog1.Color;
                else if ((sender as Button).Text.Contains("title"))
                    word1color = colorDialog1.Color;
                else if ((sender as Button).Text.Contains("author"))
                    word2color = colorDialog1.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBfile_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CBfile, "File with each line containing\nword<tab>weight"); // you can change the first parameter (textbox3) on any control you wanna focus
        }
    }
}
