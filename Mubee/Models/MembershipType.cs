using System.ComponentModel.DataAnnotations;

namespace Mubee.Models
{
    public class MembershipType
    {
        private byte id;
        private string name;
        private short signUpFee;
        private byte durationInMonths;
        private byte discountRate;

        public byte Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public short SignUpFee
        {
            get { return signUpFee; }
            set { signUpFee = value; }
        }

        public byte DurationInMonths
        {
            get { return durationInMonths; }
            set { durationInMonths = value; }
        }

        public byte DiscountRate

        {
            get { return discountRate; }
            set { discountRate = value; }
        }
    }
}