using System.ComponentModel.DataAnnotations;

namespace Mubee.Models
{
    public class MembershipType
    {
        private byte id;
        private short signUpFee;
        private byte durationInMonths;
        private byte discountRate;

        public byte Id
        {
            get { return id; }
            set { id = value; }
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