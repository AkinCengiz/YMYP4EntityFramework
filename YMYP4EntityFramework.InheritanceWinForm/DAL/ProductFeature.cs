﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramework.InheritanceWinForm.DAL;
public class ProductFeature
{
	public int Id { get; set; }
	public string Color { get; set; }
	public int Width { get; set; }
	public int Height { get; set; }
	public int ProductId { get; set; }
}
