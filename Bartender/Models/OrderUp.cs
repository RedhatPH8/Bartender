using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
	public class OrderUp
	{
		public int OrderId { get; set; }

		[Required]
		[Display(Name = "Drink Type")]
		public DrinkType DrinkType { get; set; }

		[Required]
		[Display(Name = "Ordered By")]
		public string Patron { get; set; }
	}
	public enum DrinkType
	{
		[Display(Name = "Black and Tan")] BlackandTan = 1,
		[Display(Name = "Bloody Mary")] BloodyMary,
		[Display(Name = "Gin and Tonic")] GinAndTonic,
		[Display(Name = "GreatfulDead")] GreatfulDead,
		[Display(Name = "Highball")] Highball,
		[Display(Name = "Jack And Coke")] JackandCoke,
		[Display(Name = "Long Island")] LongIsland,
		[Display(Name = "Margarita")] Margarita,
		[Display(Name = "Martini")] Martini,
		[Display(Name = "Old Fashioned")] OldFashioned
	}
}
