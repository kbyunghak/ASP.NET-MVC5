using MVC01.Models.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Models.Northwind
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public object ProductID { get; set; }

        [Required (ErrorMessage="Product name is required.")]
        [Display(Name = "Product Name")]
        //[StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        //[RegularExpression(@"^[a-zA-Z+#\-.0-9]{1,5}$", ErrorMessage = "The number of words can not exceed 3 words.")]
        [ExcludeWords(3, ErrorMessage = "There are too many words in {0}, The number of words must not exceed 3 words.")]
        //[ExcludeChar("/.,!@#$%", ErrorMessage = "Name contains invalid character.")]
        public object ProductName { get; set; }

        [Required(ErrorMessage = "Unit price is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public object UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        public object ReorderLevel { get; set; }

        [Display(Name = "Category")]
        [UIHint("_CategoryDropDown")]
        public object CategoryID { get; set; }

        [Display(Name = "Supplier")]
        [UIHint("_SupplierDropDown")]
        public object SupplierID { get; set; }

        [HiddenInput(DisplayValue = false)]
        [ScaffoldColumn(false)]
        public object UnitsInStock { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name ="Units On Order")]
        public object UnitsOnOrder { get; set; }

        [ScaffoldColumn(false)]
        public object QuantityPerUnit { get; set; }

        [ScaffoldColumn(false)]
        public object Discontinued { get; set; }


    }
}