using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.Utilities.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ClassNameFriendlyAttribute : Attribute
    {
        public string FriendlyName { get; set; }

        public ClassNameFriendlyAttribute(string friendlyName)
        {
            this.FriendlyName = friendlyName;
        }

    }
}
