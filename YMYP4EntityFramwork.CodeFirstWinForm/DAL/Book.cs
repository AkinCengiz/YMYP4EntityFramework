﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramwork.CodeFirstWinForm.DAL;
public class Book
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string PublishHouse { get; set; }
	public List<Author> Authors { get; set; }
}
