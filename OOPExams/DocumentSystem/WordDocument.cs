﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class WordDocument:OfficeDocument,IEditable
    {
        public long? Chars { get; private set; }

         public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.Chars = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("chars", this.Chars));
        }
        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
    

