using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persitance.StammiReg.Persitance.Entities;

public class Meet
{
    [Key]
    public int MeetID { get; set; }
    
    [Column(TypeName = "TEXT")]
    public string MeetName { get; set; }
    
    public DateTime Date { get; set; }
    
    public string Location { get; set; }
    
    public  int Capacity { get; set; }
}