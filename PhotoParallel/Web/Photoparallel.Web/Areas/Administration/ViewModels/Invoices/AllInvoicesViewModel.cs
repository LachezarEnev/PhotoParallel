namespace Photoparallel.Web.Areas.Administration.ViewModels.Invoices
{
    public class AllInvoicesViewModel
    {
        public int Id { get; set; }

        public int TotalAmount { get; set; }

        public string InvoiceNumber { get; set; }

        public string IssuedOn { get; set; }
    }
}
