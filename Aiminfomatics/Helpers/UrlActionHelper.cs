using System;
using System.Linq;
using System.Reflection;
using CMS.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Aiminfomatics.Helpers
{
	public static class UrlActionHelper
	{
        public static string KenticoAction(this IUrlHelper helper, string relativaUrl, object values = default)
        {
            if (helper == null)
            {
                throw new ArgumentNullException(nameof(helper));
            }
            var url = relativaUrl;

            foreach (var property in values?.GetType()?.GetProperties() ?? Enumerable.Empty<PropertyInfo>())
            {
                var value = property.GetValue(values);
                if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                {
                    url = URLHelper.AddParameterToUrl(url, property.Name, property.GetValue(values).ToString());
                }
            }
            return url;
        }
    }
}
