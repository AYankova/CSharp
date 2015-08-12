using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class MultimediaDocuments:BinaryDocuments
    {
        public long? Length { get; private set; }

         public override void LoadProperty(string key, string value)
        {
            if (key == "length")
            {
                this.Length = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("length", this.Length));
        }
    }
    

