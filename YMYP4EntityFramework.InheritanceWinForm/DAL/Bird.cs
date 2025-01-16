using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramework.InheritanceWinForm.DAL;
public class Bird : Animal
{
	public decimal WingsLength { get; set; }
	public int FootNumber { get; set; }
}
