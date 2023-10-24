namespace PetsFile.Application.Common.Config
{
    public class MatchingOptions
    {
        public const string Matching = "Matching";

        public int NumberOfPetsToFetch { get; init; }
    }
}
//DapperConnectionProvider(IConfiguration configuration)
// bez iconfig tylko zrobić jak matching options