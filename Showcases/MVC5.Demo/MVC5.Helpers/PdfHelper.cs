using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace MVC5.Helpers
{
    public static class PdfHelper
    {
        public static void ImportEntityList<TSource>(this Aspose.Pdf.Table table, IList<TSource> data)
        {
            var headRow = table.Rows.Add();

            var props = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                headRow.Cells.Add(prop.GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute dd ? dd.Name : prop.Name);
            }

            foreach (var item in data)
            {
                // Add row to table
                var row = table.Rows.Add();
                // Add table cells
                foreach (var t in props)
                {
                    var dataItem = t.GetValue(item, null);
                    if (t.GetCustomAttribute(typeof(DataTypeAttribute)) is DataTypeAttribute dataType)
                        switch (dataType.DataType)
                    {

                        case DataType.Currency:
                            row.Cells.Add(string.Format("{0:C}", dataItem));
                            break;
                        case DataType.Date:
                            var dateTime = (DateTime)dataItem;
                            if (t.GetCustomAttribute(typeof(DisplayFormatAttribute)) is DisplayFormatAttribute df)
                                {
                                row.Cells.Add(string.IsNullOrEmpty(df.DataFormatString)
                                    ? dateTime.ToShortDateString()
                                    : string.Format(df.DataFormatString, dateTime));
                            }
                            break;
                        default:
                            row.Cells.Add(dataItem.ToString());
                            break;
                    }
                    else
                    {
                        row.Cells.Add(dataItem.ToString());
                    }
                }
            }
        }
        public static void ImportGroupedData<TKey, TValue>(this Aspose.Pdf.Table table, IEnumerable<GroupViewModel<TKey, TValue>> groupedData)
        {
            var headRow = table.Rows.Add();
            var props = typeof(TValue).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                headRow.Cells.Add(prop.GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute dd ? dd.Name : prop.Name);
            }

            foreach (var group in groupedData)
            {
                // Add group row to table
                var row = table.Rows.Add();
                var cell = row.Cells.Add(group.Key.ToString());
                cell.ColSpan = props.Length;
                cell.BackgroundColor = Aspose.Pdf.Color.DarkGray;
                cell.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.White;

                foreach (var item in group.Values)
                {
                    // Add data row to table
                    var dataRow = table.Rows.Add();
                    // Add cells
                    foreach (var t in props)
                    {
                        var dataItem = t.GetValue(item, null);

                        if (t.GetCustomAttribute(typeof(DataTypeAttribute)) is DataTypeAttribute dataType)
                            switch (dataType.DataType)
                        {
                            case DataType.Currency:
                                dataRow.Cells.Add(string.Format("{0:C}", dataItem));
                                break;
                            case DataType.Date:
                                var dateTime = (DateTime)dataItem;
                                if (t.GetCustomAttribute(typeof(DisplayFormatAttribute)) is DisplayFormatAttribute df)
                                    {
                                    dataRow.Cells.Add(string.IsNullOrEmpty(df.DataFormatString)
                                        ? dateTime.ToShortDateString()
                                        : string.Format(df.DataFormatString, dateTime));
                                }
                                break;
                            default:
                                dataRow.Cells.Add(dataItem.ToString());
                                break;
                        }
                        else
                        {
                            dataRow.Cells.Add(dataItem.ToString());
                        }
                    }
                }
            }
        }
    }
}
