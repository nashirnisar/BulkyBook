﻿using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using static System.Collections.Specialized.BitVector32;
using System;

ModelBinderAttribute 

<form method="post">
	<div class= "border p-3 mt-4" >
		< div class= "row pb-2" >
			< h2 class= "text-primary" > Create Category </ h2 >
			< hr />
		</ div >
		@*< div asp - validation - summary = "All" ></ div > *@
		< div class= "mb-3" >
			< label asp -for= "Name" ></ label >
			< input asp -for= "Name" class= "form-control" />
			< span asp - validation -for= "Name" class= "text-danger" ></ span >
		</ div >
		< div class= "mb-3" >
			< label asp -for= "DisplayOrder" ></ label >
			< input asp -for= "DisplayOrder" class= "form-control" />
			< span asp - validation -for= "DisplayOrder" class= "text-danger" ></ span >
		</ div >
		< button type = "submit" class= "btn btn-primary" style = "width:150px" > Create </ button >
		< a asp - controller = "Category" asp - action = "Index" class= "btn btn-secondary" style = "width:150px" >
			Back to List
		</a>
	</div>
</form>

@section Scripts{
	@{
		<partial name = "_ValidationScriptsPartial" />
	}
}