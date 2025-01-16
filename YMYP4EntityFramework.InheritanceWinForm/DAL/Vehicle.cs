using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramework.InheritanceWinForm.DAL;
public class Vehicle
{
	public int Id { get; set; }
	public string Brand { get; set; }
	public string Color { get; set; }
	public decimal Weight{ get; set; }
	public decimal Length { get; set; }
}
