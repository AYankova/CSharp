﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class PDFDocument:EncryptableDocument
    {
        public long? NumberOfPages { get; private set; }

         public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.NumberOfPages = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        }
    }
    

