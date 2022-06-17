//namespace interfaces;
// This class is representing the simple entity we are going to use
// in our example.
public class Data
{
    public int DataId {get;set;}
    public string DataDescrition {get;set;}
}

// This class is the first kind of the parent Data class.
public class EmployeeData  : Data
{
    public string EmployeeName { get; set; }    
}

// This class is the second kind of the parent Data class.
public class AssetData : Data
{
    public int AssetId { get; set; }
    public string AssetName { get; set; }
}