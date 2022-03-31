using Comet;

namespace SwapiClient.States
{
    internal class ActualView : BindingObject
    {
        public ActualView(View startView)
        {
            Actual = startView;
        }
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
