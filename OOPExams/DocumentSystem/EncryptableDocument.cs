using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class EncryptableDocument:BinaryDocuments,IEncryptable
    {
        public bool IsEncrypted { get; private set; }
     
        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.IsEncrypted)
            {
                result.Append(string.Format("{0}", this.GetType().Name));
                result.Append("[encrypted]");
                return result.ToString();
            }
            else
            {
                return base.ToString();
            }
        }
    }
