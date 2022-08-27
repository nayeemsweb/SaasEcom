namespace Ecommerce.Web.Areas.Customer.Models
{
    public class PageModel
    {
        public string PageTitle { get; set; }
        public string BreadcrumbImageUrl { get; set; }
        public string  PageContent { get; set; }


        public PageModel()
        {
            BreadcrumbImageUrl = "/EcommerceTheme/img/blog/details/details-pic.jpg";
        }

    }
}
