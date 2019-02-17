﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
	public class EmployeeModel
	{
		[Display(Name = "Employee ID")]
		[Range(100000, 999999, ErrorMessage = "You need to enter a valid Id.")]
		public int EmployeeId { get; set; }

		[Display(Name ="First Name")]
		[Required(ErrorMessage ="You need to give us your first name.")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		[Required(ErrorMessage = "You need to give us your last name.")]
		public string LastName { get; set; }

		[DataType(DataType.EmailAddress)]
		[Display(Name = "Email Address")]
		[Required(ErrorMessage = "You need to give us your email address.")]
		public string EmailAddress { get; set; }

		[Display(Name = "Confirm Email")]
		[Compare("EmailAddress", ErrorMessage = "The email and confirm email must match.")]
		public string ConfirmEmail { get; set; }

		[Display(Name = "Password")]
		[Required(ErrorMessage = "You must have a password.")]
		[DataType(DataType.Password)]
		[StringLength(100, MinimumLength =10, ErrorMessage ="You need to provide a long enougt password.")]
		public string Password { get; set; }

		[Display(Name ="Confirm Password")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage ="Password and confirm password must match")]
		public string ConfirmPassword { get; set; }
	}
}