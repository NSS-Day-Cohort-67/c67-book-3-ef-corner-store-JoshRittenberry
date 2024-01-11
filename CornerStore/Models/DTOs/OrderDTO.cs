using System.ComponentModel.DataAnnotations;

namespace CornerStore.Models;

public class OrderDTO
{
    public int Id { get; set; }
    [Required]
    public int CashierId { get; set; }
    public CashierDTO Cashier { get; set; }
    public decimal Total
    {
        get
        {
            return OrderProducts
                .Sum(op => op.Product.Price);
        }
    }
    public DateTime? PaidOnDate { get; set; }
    public List<OrderProductDTO> OrderProducts { get; set; }
}