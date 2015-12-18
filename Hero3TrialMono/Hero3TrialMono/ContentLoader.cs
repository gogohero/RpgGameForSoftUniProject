using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hero3TrialMono
{
    using System.Xml.Schema;
    using Interfaces;
    using Microsoft.Xna.Framework.Content;


    public class ContentLoader 
    {
        private ContentManager content;

        public ContentLoader(ContentManager content)
        {
            this.Content = content;
        }

        public ContentManager Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

    }
}
