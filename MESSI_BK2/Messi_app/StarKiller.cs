using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Messi_app
{
    public partial class StarKiller : Form
    {
        public StarKiller()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string ruta;
            ruta = (@".\StarKiller\");

            txtDesc.Clear();
            txtImg.Clear();
            
            XElement infor = null;
            
            infor = XElement.Load("Info.xml");
            foreach (XElement xEle in infor.Descendants("textDetail").Take(1))
                txtDesc.Text = xEle.Value;
            foreach (XElement xEle in infor.Descendants("title").Take(1))
                txtImg.Text = xEle.Value;
            foreach (XElement xEle in infor.Descendants("imageDetail").Take(1))
                PicPeque.ImageLocation = ruta + xEle.Value;
            PicPeque.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            string ruta;
            ruta = (@".\StarKiller\");

            txtDesc.Clear();
            txtImg.Clear();

            XElement infor = null;
            infor = XElement.Load("Info.xml");
            foreach (XElement xEle in infor.Descendants("textDetail").Take(2))
                txtDesc.Text = xEle.Value;
            foreach (XElement xEle in infor.Descendants("title").Take(2))
                txtImg.Text = xEle.Value;
            foreach (XElement xEle in infor.Descendants("imageDetail").Take(2))
                PicPeque.ImageLocation = ruta + xEle.Value;
            PicPeque.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            string ruta;
            ruta = (@".\StarKiller\");

            txtDesc.Clear();
            txtImg.Clear();
            XElement infor = null;
            infor = XElement.Load("Info.xml");
            foreach(XElement xEle in infor.Descendants("textDetail").Reverse().Take(1))
            txtDesc.Text = xEle.Value;
            foreach (XElement xEle in infor.Descendants("title").Reverse().Take(1))
                txtImg.Text = xEle.Value;
            foreach (XElement xEle in infor.Descendants("imageDetail").Reverse().Take(1))
                PicPeque.ImageLocation = ruta + xEle.Value;
            PicPeque.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
