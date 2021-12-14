using Comet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapiClient
{
    internal class PeopleView : View
    {
        public PeopleView()
        {

        }

        [Body]
        View body() => new VStack {
            Create(),
            
        };


        private VStack Create() {
            var stack = new VStack();
            stack.Add(new Button { });
            return stack;
        }
    }
}
