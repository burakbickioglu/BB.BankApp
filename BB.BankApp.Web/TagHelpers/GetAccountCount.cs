﻿using System.Linq;
using BB.BankApp.Web.Data.Context;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BB.BankApp.Web.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount:TagHelper
    {
        public int ApplicationUserId { get; set; }
        private readonly BankContext _context;

        public GetAccountCount(BankContext context)
        {
            _context = context;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _context.Accounts.Count(x=>x.ApplicationUserId == ApplicationUserId);
            var html = $"<span class='badge bg-danger'>{accountCount}</span>";
            output.Content.SetHtmlContent(html);
        }
    }
}
