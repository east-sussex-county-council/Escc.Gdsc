
namespace EsccWebTeam.Gdsc
{
    /// <summary>
    /// Information about a street address, including the address itself in several "standard" formats. 
    /// To be used where legacy formats are required (eg AddressPoint, until NLPG is available).
    /// </summary>
    public class AddressInfo
    {
        #region Fields

        private SimpleAddress simpleAddress;
        private AddressValidationType validationType;
        private string verificationCode;
        private int easting;
        private int northing;
        private BS7666Address bs7666Address;
        private AddressPointAddress addressPointAddress;
        private int addressId;

        #endregion

        #region Constructors

        /// <summary>
        /// Information about a street address, including the address itself in several "standard" formats
        /// </summary>
        public AddressInfo()
        {
            this.simpleAddress = new SimpleAddress();
            this.bs7666Address = new BS7666Address();
            this.addressPointAddress = new AddressPointAddress();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the unique versioned identifier for the address
        /// </summary>
        public int Id
        {
            get { return this.addressId; }
            set { this.addressId = value; }
        }

        /// <summary>
        /// Gets or sets the Citizen's address in ADDRESS-POINT PAF-based format
        /// </summary>
        public AddressPointAddress AddressPointAddress
        {
            get
            {
                return this.addressPointAddress;
            }
            set
            {
                this.addressPointAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets the Citizen's address in BS7666 format
        /// </summary>
        public BS7666Address BS7666Address
        {
            get
            {
                return this.bs7666Address;
            }
            set
            {
                this.bs7666Address = value;
            }
        }


        /// <summary>
        /// Gets or sets GIS northing coordinate for the Citizen's address
        /// </summary>
        /// <remarks>Recommended to set the GridEasting and GridNorthing of the BS7666Address instead, since that format will be used in future.</remarks>
        public int Northing
        {
            get
            {
                return this.northing;
            }
            set
            {
                this.northing = value;
            }
        }

        /// <summary>
        /// Gets or sets GIS easting coordinate for the Citizen's address
        /// </summary>
        /// <remarks>Recommended to set the GridEasting and GridNorthing of the BS7666Address instead, since that format will be used in future.</remarks>
        public int Easting
        {
            get
            {
                return this.easting;
            }
            set
            {
                this.easting = value;
            }
        }

        /// <summary>
        /// Gets or sets the code which must be confirmed to verify the Citizen's address
        /// </summary>
        public string VerificationCode
        {
            get
            {
                return this.verificationCode;
            }
            set
            {
                this.verificationCode = value;
            }
        }

        /// <summary>
        /// Gets or sets method of validation for Citizen's current address
        /// </summary>
        public AddressValidationType ValidationType
        {
            get
            {
                return this.validationType;
            }
            set
            {
                this.validationType = value;
            }
        }

        /// <summary>
        /// Gets or sets an e-GIF compliant Simple Address. Wherever possible use the BS7666Address or AddressPointAddress to generate a Simple Address instead.
        /// </summary>
        public SimpleAddress SimpleAddress
        {
            get
            {
                return this.simpleAddress;
            }
            set
            {
                this.simpleAddress = value;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Adds a space to the expected place in the middle of a postcode which has been entered without spaces
        /// </summary>
        /// <param name="postcode"></param>
        /// <returns></returns>
        public static string AddSpaceToPostcode(string postcode)
        {
            if (postcode != null)
            {
                postcode = postcode.Replace(" ", "");

                if (postcode.Length == 6)
                {
                    postcode = postcode.Insert(3, " ");
                }
                else if (postcode.Length == 7)
                {
                    postcode = postcode.Insert(4, " ");
                }
            }

            return postcode;
        }

        #endregion
    }
}
