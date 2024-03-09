namespace SocialStock.Models;

public class Comment
{
    public int Id { get; set; }
    
    public string Title { get; set; } = String.Empty;
    
    public string Content { get; set; } = String.Empty;
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    
    public int? StockId { get; set; }
    
    //Navigation property
    // This will allow us to dot into the Stock later (????)
    //to be able to access the other side of the model
    public Stock? Stock { get; set; }
}