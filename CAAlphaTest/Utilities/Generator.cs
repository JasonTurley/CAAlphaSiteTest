using System.Collections.Generic;

namespace CAAlphaTest.Utilities
{
    public class Generator
    {
        public string GenerateEmail()
        {
            return "random@mailinator.com";
        }

        public string GeneratePassword()
        {
            return "$Password-1234";
        }

        public string GenerateFirstName()
        {
            return "D'ævis-Kováčevic";
        }

        public string GenerateLastName()
        {
            return "Airást Oćkr-Schülr";
        }

        public List<string> GenerateAddress()
        {
            List<string> address = new List<string>
            {
                "3033 Wilson Blvd, Suite 500",     // Addr line 1
                "Arlington",            // City
                "Virginia",             // State
                "22201"                 // Zip code
            };

            return address;
        }

        public string GeneratePhoneNumber()
        {
            return "703-898-1234";
        }

        public string GenerateMyEmail()
        {
            return "jturley@commonapp.org";
        }

        public string GenerateMyPassword()
        {
            return "@AirForce1";
        }
    }
}