﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMYP4EntityFramwork.CodeFirstWinForm.DAL;
public class Author
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public List<Book> Books { get; set; }
}
