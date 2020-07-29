using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsImpl
{
    public class Class1
    {
        public void d() {

            using (StreamReader reader = new StreamReader(fileName))
            {
                jsonText = reader.ReadToEnd();
            }
        }
    }
}
