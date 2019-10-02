﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebVella.TagHelpers.Models
{
	public class WvKeyStringList
	{
		[JsonProperty(PropertyName = "key")]
		public string Key { get; set; } = "";

		[JsonProperty(PropertyName = "values")]
		public List<string> Values { get; set; } = new List<string>();
	}
}
