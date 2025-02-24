﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramwork.CodeFirstWinForm.DAL;
public class ProductFeature
{
	public int Id { get; set; }
	public string Color { get; set; }
	public decimal Width { get; set; }
	public decimal Height { get; set; }
	public int ProductId { get; set; }
	public virtual Product Product { get; set; }

}
