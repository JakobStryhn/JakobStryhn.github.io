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
                LocalizationNamePath = "Home"
            },
            new Route
            {
                MaterialIcon = "Assignment",
                SubPath = "resume",
                LocalizationNamePath = "Resume"
            },
            new Route
            {
                MaterialIcon = "Code",
                SubPath = "projects",
                LocalizationNamePath = "Projects"
            },
            new Route
            {
                MaterialIcon = "Developer_Board",
                SubPath = "components",
                LocalizationNamePath = "ComponentLibrary"
            },
            new Route
            {
                MaterialIcon = "Playground",
                SubPath = "playground",
                LocalizationNamePath = "Playground"
            },
            new Route
            {
                MaterialIcon = "Grocery",
                SubPath = "kombucha",
                LocalizationNamePath = "Kombucha"
            },
            new Route
            {
                MaterialIcon = "Breakfast_Dining",
                SubPath = "baking",
                LocalizationNamePath = "Baking"
            }
            ]);
    }
}
