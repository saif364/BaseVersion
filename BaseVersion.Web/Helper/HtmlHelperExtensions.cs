using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

public static class HtmlHelperExtensions
{
    public static IHtmlContent DisplayLabelFor<TModel, TValue>(this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression)
    {
        var memberExpression = expression.Body as MemberExpression;

        if (memberExpression == null)
        {
            throw new ArgumentException("Expression must be a member expression.");
        }
        var modelType = typeof(TModel);
        var memberName = memberExpression.Member.Name;
        var memberInfo = modelType.GetProperty(memberName);
        var isRequired = memberInfo?.GetCustomAttributes(typeof(RequiredAttribute), false).Any() ?? false;

        var nullableAttributeBesideStringtype = -1;
        if ((bool)memberInfo?.CustomAttributes.Any())
        {
            nullableAttributeBesideStringtype = (int)(memberInfo?.CustomAttributes.Where(attr => attr.AttributeType.Name == "NullableAttribute").ToList().Count);
        }
        var dateNullable = memberInfo.PropertyType.Name.Contains("Nullable");

        //var label = htmlHelper.LabelFor(expression, new { @class = "control-label" }).GetString();

        // for space in name 
        var displayAttribute = memberInfo?.GetCustomAttributes(typeof(DisplayAttribute),false).Cast<DisplayAttribute>().FirstOrDefault();
        string displayName = displayAttribute?.Name ?? string.Empty;

        if (string.IsNullOrEmpty(displayName))
        {
            displayName = Regex.Replace(memberName, "([a-z])([A-Z])", "$1 $2");
        }

        var label = $"<label for=\"{memberName}\" class=\"control-label\">{displayName}</label>";

        //


        if (isRequired || (dateNullable == false && (bool)memberInfo?.CustomAttributes.Any() == false) || nullableAttributeBesideStringtype == 0)
        {
            return new HtmlString($"{label} <span style=\"color: red;\">*</span>");
        }

        return new HtmlString(label);
    }


    private static string GetString(this IHtmlContent content)
    {
        using (var writer = new System.IO.StringWriter())
        {
            content.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
            return writer.ToString();
        }
    }
}
