namespace EnvoiceProject.Models
{
    public class EnvoiceDTO
    {
        #region Company Info
        public string CompanyName { get; set; } = string.Empty;
        public string? CompanyPhone { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyLocation { get; set; }
        #endregion

        #region Customer Info
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        #endregion

        #region Invoice info
         public string InvoiceType { get; set; }=string.Empty;
         public int InvoiceId { get; set; }
         public string InvoiceNumber { get; set; } = string.Empty;
         public string InvoiceReference { get; set; } = string.Empty;
         public string InvoiceDate { get; set; } = string.Empty;
         public decimal InvoiceSubtotal { get; set; }
         public decimal? InvoiceAdditionalCharge { get; set; }
         public string AmountInwords { get; set; }
         public decimal? InvoiceTax { get; set; }
         public decimal InvoiceGrandTotal { get; set; }
        public string? PaymentInfo { get; set; }
        public string? PreparedBy { get; set; }
        public List<ItemDTO> itemList { get; set; }=new List<ItemDTO>();
        public List<TermsDTO>? termList { get; set; }
        #endregion
    }  
    public class ItemDTO
    {
        public int Sn { get; set; }
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Qty { get; set; } 
        public decimal Price { get; set; } 
        public decimal total { get; set; } 

    }    
    public class TermsDTO
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
    }

}
