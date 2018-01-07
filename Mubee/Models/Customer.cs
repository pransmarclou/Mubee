using System.ComponentModel.DataAnnotations;

namespace Mubee.Models
{
    public class Customer
    {
        private int id;
        private string name;
        private bool isSubscribedToNewsletter;
        private MembershipType membershipType;
        private byte membershipTypeId;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        [StringLength(255)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsSubscribedToNewsletter
        {
            get { return isSubscribedToNewsletter; }
            set { isSubscribedToNewsletter = value; }
        }

        public MembershipType MembershipType
        {
            get { return membershipType; }
            set { membershipType = value; }
        }

        public byte MembershipTypeId
        {
            get { return membershipTypeId; }
            set { membershipTypeId = value; }
        }
    }
}