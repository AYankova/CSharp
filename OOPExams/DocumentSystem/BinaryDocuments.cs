﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class BinaryDocuments:Document,IDocument
    {
        public long? Size { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
            {
                this.Size = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("size", this.Size));
        }
    }

