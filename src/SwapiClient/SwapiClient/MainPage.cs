using Comet;
using SwapiClient.States;
using SwapiClient.Views;

namespace SwapiClient
{
    public class MainPage : View
	{

		[State]
		readonly ActualView viewState = new(new SelectionView());

		[Body]
		View body()
			=> new VStack {
				new Button("Previous", () => {
					viewState.Actual = viewState.Previous;
                }),
				viewState.Actual,
			};
	}
}

