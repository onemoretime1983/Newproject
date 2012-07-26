using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class NewClass
    {
        private int charNum;
        private string nameofProject;
        public int CharNum
        {
            get { return charNum; }
            set { charNum = value;}
        }
        public string NameOfProject
        {
            get { return nameofProject;}
            set { nameofProject = value;}
        }
    }
}