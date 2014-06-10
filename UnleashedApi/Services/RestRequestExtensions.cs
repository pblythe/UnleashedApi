using RestSharp;
using System;
using System.ComponentModel;
using UnleashedApi.Models;

namespace UnleashedApi.Services
{
    public static class RestRequestExtensions
    {
        public static void AddParameters(this IRestRequest request, object source)
        {
            if (source == null)
                return;

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            {
                var value = property.GetValue(source);
                if (value != null)
                    request.AddParameter(property.Name, FormatString(value));
            }
        }

        private static string FormatString(object value)
        {
            if (value is DateTime)
                return ((DateTime)value).ToString("yyyy-MM-dd");
            return value.ToString();
        }

        public static IPaginatedList<T> ToPaginatedList<T>(this RequestMetadata<T> metadata)
        {
            if (metadata == null)
                return new PaginatedList<T>();

            if (metadata.Pagination == null)
                return new PaginatedList<T>(metadata.Items);

            var pagination = metadata.Pagination;
            return new PaginatedList<T>(metadata.Items, pagination.NumberOfItems, pagination.NumberOfPages, pagination.PageNumber, pagination.PageSize);
        }
    }
}
