using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MarfulApi.Model
{
    public class InfulonserFollowInfulonser
    {
       
        public int Id { set; get; }
        
        public int? FollowId { set; get; }
        public int FollowedId { set; get; }
        public virtual Infulonser? Follow { set; get; }
        public virtual Infulonser? Followed { set; get; }
    }
}
