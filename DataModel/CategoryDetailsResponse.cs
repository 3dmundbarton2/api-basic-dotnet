namespace api_basic_dotnet.DataModel;

public class CategoryDetailsResponse
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public bool CanListAuctions { get; set; }
    public bool CanListClassifieds { get; set; }
    public bool CanRelist { get; set; }
    public int DefaultDuration { get; set; }
    public List<int> AllowedDurations { get; set; }
    public Fees Fees { get; set; }
    public int FreePhotoCount { get; set; }
    public int MaximumPhotoCount { get; set; }
    public List<Charity> Charities { get; set; }
    public List<Promotion> Promotions { get; set; }
    public List<object> EmbeddedContentOptions { get; set; }
    public int MaximumTitleLength { get; set; }
    public int AreaOfBusiness { get; set; }
    public int DefaultRelistDuration { get; set; }
    public bool CanHaveSecondCategory { get; set; }
    public bool CanBeSecondCategory { get; set; }
    public bool CanUseCounterOffers { get; set; }
}
public class SuccessFeeTier
{
    public int MinimumTierPrice { get; set; }
    public double? PercentageFee { get; set; }
}

public class Promotion
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public int MinimumPhotoCount { get; set; }
    public double? OriginalPrice { get; set; }
    public double? GoodFor2RelistsFee { get; set; }
    public bool? Recommended { get; set; }
}

public class Fees
{
    public double Bundle { get; set; }
    public double EndDate { get; set; }
    public double Feature { get; set; }
    public double Gallery { get; set; }
    public double Reserve { get; set; }
    public double Subtitle { get; set; }
    public double TenDays { get; set; }
    public double Withdrawal { get; set; }
    public double HighVolume { get; set; }
    public double MaximumSuccessFee { get; set; }
    public List<SuccessFeeTier>? SuccessFeeTiers { get; set; }
    public double SecondCategory { get; set; }
}

public class Charity
{
    public int CharityType { get; set; }
    public string? ImageSource { get; set; }
    public string? DarkModeImageSource { get; set; }
    public string? Description { get; set; }
    public string? Tagline { get; set; }
}