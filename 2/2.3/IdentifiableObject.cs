using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>(idents);
        }

        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }

        public string FirstId
        {
            get
            {
                string identifier = "";
                identifier = _identifiers[0];
                return identifier;
            }
        }

        public void AddIdentifier(string id)
        {

            _identifiers.Add(id);
        }

    }
}
