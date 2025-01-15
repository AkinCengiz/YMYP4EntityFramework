using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramwork.CodeFirstWinForm.DAL;
public class Order
{
	public int Id { get; set; }
	public DateTime OrderDate { get; set; }
	public decimal Total { get; set; }
	public int UserId { get; set; }
	public User User { get; set; }

}
