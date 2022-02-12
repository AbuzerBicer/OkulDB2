using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brans:IEntity
    {
        public byte BransID { get; set; }
        public string BransAdi { get; set; }
    }
}
