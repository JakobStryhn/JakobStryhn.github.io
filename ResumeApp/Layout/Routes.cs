using System.Collections.Immutable;

namespace ResumeApp.Layout
{
    public class RouteConfig {
        public const string HOME = "/"; 
    }

    public class Route
    {
        public string? MaterialIcon { get; init; }
        public required string SubPath { get; init; }
        public required string LocalizationNamePath { get; init; }
        public required bool IsPublished { get; init; }
    }

    public record AppRoutes(ImmutableArray<Route> Routes);
    public static class AppRouteConfig
    {
        public static AppRoutes NavigationMenuRoutes { get; } = new AppRoutes(
        [
            new Route
            {
                MaterialIcon = "Arrow_Back",
                SubPath = HOME,
                LocalizationNamePath = "NavLink_Home",
                IsPublished = true
            },

            new Route
            {
                MaterialIcon = "Account_Box",
                SubPath = "Contact",
                LocalizationNamePath = "NavLink_Contact",
                IsPublished = true
            },
            new Route
            {
                MaterialIcon = "Assignment",
                SubPath = "resume",
                LocalizationNamePath = "NavLink_Resume",
                IsPublished = true
            },
            new Route
            {
                MaterialIcon = "Code",
                SubPath = "projects",
                LocalizationNamePath = "NavLink_Projects",
                IsPublished = false,
            },
            new Route
            {
                MaterialIcon = "Toys",
                SubPath = "toybox",
                LocalizationNamePath = "NavLink_Toybox",
                IsPublished = true,
            },
            new Route
            {
                MaterialIcon = "Developer_Board",
                SubPath = "components",
                LocalizationNamePath = "NavLink_Components",
                IsPublished = false
            },
            new Route
            {
                MaterialIcon = "Grocery",
                SubPath = "kombucha",
                LocalizationNamePath = "NavLink_Kombucha",
                IsPublished = false
            },
            new Route
            {
                MaterialIcon = "Breakfast_Dining",
                SubPath = "baking",
                LocalizationNamePath = "NavLink_Baking",
                IsPublished = false
            }
            ]);

        public static AppRoutes HeaderRoutes { get; } = new AppRoutes(
        [
            new Route {
                SubPath = "",
                LocalizationNamePath = "Header_Home",
                IsPublished = true
            },
            new Route {
                SubPath = "resume",
                LocalizationNamePath = "Header_Resume",
                IsPublished = true
            },
            new Route {
                SubPath = "Contact",
                LocalizationNamePath = "Header_Contact",
                IsPublished = true
            },
            new Route
            {
                MaterialIcon = "Code",
                SubPath = "playground",
                LocalizationNamePath = "Header_Playground",
                IsPublished = true,
            },
        ]);
    }
}
