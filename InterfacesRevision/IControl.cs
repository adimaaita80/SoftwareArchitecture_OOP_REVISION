using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesRevision
{
    public interface IControl
    {
        string Type { get; set; }
        string SetName();
        string GetName();
        string SetText();
        string GetText();
        string SetColor();
        string GetColor();
    }
}
