namespace STARAS.BusinessLayer.Utilities.Constants
{
    public class Constants
    {
        // PAGING
        public const int DefaultPaging = 50;
        public const int LimitPaging = 100;

        // API END POINT 
        public const string RootEndPoint = "/api";
        public const string ApiVersion = "/v1";
        public const string ApiEndpoint = RootEndPoint + ApiVersion;
        public const string BrandEndpoint = ApiEndpoint + "/brands";
    }
}
