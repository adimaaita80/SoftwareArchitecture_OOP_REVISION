using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesRevision
{
    public class Control : IControl
    {
        public string Type { get; set; }
        public string GetColor()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public string GetText()
        {
            return "Oh my god, not implemented!";
        }

        public string SetColor()
        {
            throw new NotImplementedException();
        }

        public string SetName()
        {
            throw new NotImplementedException();
        }

        public string SetText()
        {
            throw new NotImplementedException();
        }
    }
}
