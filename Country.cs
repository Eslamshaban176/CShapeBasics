namespace EnumAlternative;

public class Country
{
    public string Name { get; private set; }
    public string Code { get;  private set; }
    public int PhoneCode { get; private set; }

    public static readonly Country Egypt = new Country(20, "Egypt", "EGY");
    public static readonly Country Algeria = new Country(213, "Algeria", "ALG");
    public static readonly Country Bahrain = new Country(973, "Bahrain", "BHR");
    public static readonly Country Comoros = new Country(213, "Comoros", "COM");
    public static readonly Country Djibouti = new Country(253, "Djibouti", "DJI");
    public static readonly Country Iraq = new Country(964, "Iraq", "IRQ");
    public static readonly Country Jordan = new Country(962, "Jordan", "JOR");
    public static readonly Country Kuwait = new Country(965, "Kuwait", "KWT");
    public static readonly Country Lebanon = new Country(961, "Lebanon", "LBN");
    public static readonly Country Libya = new Country(218, "Libya", "LBY");
    public static readonly Country Mauritania = new Country(222, "Mauritania", "MRT");
    public static readonly Country Morocco = new Country(212, "Morocco", "MOR");
    public static readonly Country Oman = new Country(968, "Oman", "OMN");
    public static readonly Country Palestine = new Country(970, "Palestine", "PSE");
    public static readonly Country Qatar = new Country(974, "Qatar", "QAT");
    public static readonly Country Saudi_Arabia = new Country(966, "Saudi Arabia", "KSA");
    public static readonly Country Somalia = new Country(252, "Somalia", "SOM");
    public static readonly Country Sudan = new Country(249, "Sudan", "SDN");
    public static readonly Country Syria = new Country(963, "Syria", "SYR");
    public static readonly Country Tunisia = new Country(216, "Tunisia", "TUN");
    public static readonly Country United_Arab_Emirates = new Country(971, "United Arab Emirates", "UAE");
    public static readonly Country Yemen = new Country(967, "Yemen", "YEM");

    private Country(int phoneCode, string name, string code)
    {
        Name = name;
        Code = code;
        PhoneCode = phoneCode;
    }

    private static readonly List<Country> _countries = new()
    {
        Egypt, Algeria, Bahrain, Comoros, Djibouti, Iraq, Jordan, Kuwait, Lebanon, Libya, Mauritania, Morocco
        , Oman, Palestine, Qatar, Saudi_Arabia, Somalia, Sudan, Syria, Tunisia, United_Arab_Emirates, Yemen
    };

    public static IEnumerable<Country> GetCountries() => _countries;
    public static Country GetCountryByCode(string code) => _countries.FirstOrDefault(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
    public static Country GetCountryByName(string name) => _countries.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    public static Country GetCountryByPhoneCode(int phoneCode) => _countries.FirstOrDefault(c => c.PhoneCode == phoneCode);
    public override string ToString() => $"{Name} ({Code}) +{PhoneCode}";
}