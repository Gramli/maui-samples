using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Comet;
using SwapiClient.States;

namespace SwapiClient
{
	public class MainPage : View
	{

		[State]
		readonly CometRide comet = new();

		[State]
		readonly ActualView viewState = new();

		[Body]
		View body()
			=> new VStack {
				new Text(()=> $"({comet.Rides}) rides taken:{comet.CometTrain}")   
					.Frame(width:300)
					.LineBreakMode(LineBreakMode.CharacterWrap),

				new Button("Ride the Comet! ☄️", ()=>{
					comet.Rides++;
				})
					.Frame(height:44)
					.Margin(8)
					.Color(Colors.White)
					.Background(Colors.Green)
				.RoundedBorder(color:Colors.Blue)
				.Shadow(Colors.Grey,4,2,2),
				new 
				new Button("Previous", () => {
					viewState.Actual = viewState.Previous;
                }),
				viewState.Actual,
			};

		public class CometRide : BindingObject
		{
			public int Rides
			{
				get => GetProperty<int>();
				set => SetProperty(value);
			}

			public string CometTrain
			{
				get
				{
					return "☄️".Repeat(Rides);
				}
			}
		}
	}
}

