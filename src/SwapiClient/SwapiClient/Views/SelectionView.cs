using Comet;

namespace SwapiClient.Views
{
    internal class SelectionView : View
    {
        public SelectionView()
        {

        }

        [Body]
        View body() 
            => new VStack {
            new Button("People") { },
            new Button("Starships") { }
        };
    }
}
