using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramework.InheritanceWinForm.DAL;
public class Employee : Person
{
	public decimal Salary { get; set; }
	public string Department { get; set; }
}
