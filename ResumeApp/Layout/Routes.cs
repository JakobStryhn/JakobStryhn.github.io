namespace ResumeApp.Layout
{
    public class Route
    {
        public required string MaterialIcon { get; set; }
        public required string SubPath { get; set; }
        public required string LocalizationNamePath { get; set; }
    }

    public record AppRoutes(IReadOnlyList<Route> Routes);
    public static class AppRouteConfig
    {
        public static AppRoutes CurrentRoutes { get; } = new AppRoutes(
        [
            new Route
            {
                MaterialIcon = "Cottage",
                SubPath = "",
                LocalizationNamePath = "NavLink_Home"
            }
            ]);
    }
}
