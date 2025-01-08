using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramework.DatabaseFirstWF;
public class Product
{
	public int Id { get; set; }
	public string Name { get; set; }
	public short Stock { get; set; }
	public decimal Price { get; set; }
	public int CategoryId { get; set; }


	//public string ProductPrint()
	//{
	//	return this.Name;
	//}

	//public void IncrementStock()
	//{
	//	this.Stock++;
	//}

	//public decimal KDV()
	//{
	//	return this.Price * 0.2m;
	//}
}

//ProductId
//ProductName

//CategoryId
//CategoryName
