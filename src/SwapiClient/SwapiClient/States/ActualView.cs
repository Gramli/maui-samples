using Comet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapiClient.States
{
    internal class ActualView : BindingObject
    {
        public View Actual
        {
            get => GetProperty<View>();
            set => SetProperty(value);
        }

        public View Previous
        {
            get => GetProperty<View>();
            set => SetProperty(value);
        }
    }
}
