using HtmlAgilityPack;

namespace AddToCal.Logic
{
    public static class HtmlNodeHelpers
    {
        public static string GetInnerText(HtmlNode htmlNode)
        {
            return htmlNode == null ? string.Empty : htmlNode.InnerText;
        }

        public static string GetAttributeValue(HtmlNode e, string attribute)
        {
            return e == null ? string.Empty : e.Attributes[attribute].Value;
        }

    }
}
