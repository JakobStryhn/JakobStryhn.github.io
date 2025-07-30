using System.Collections.Immutable;

namespace ResumeApp.Layout
{
    public class RouteConfig
    {
        public const string HOME = "/";
        public const string CONTACT = "/contact";
        public const string RESUME = "/resume";
        public const string PROJECTS = "/projects";
        public const string ABOUT = "/About";
        public const string PLAYGROUND = "/playground";
        public const string TOYBOX = "/toybox";
        public const string COMPONENTS = "/components";
        public const string KOMBUCHA = "/kombucha";
        public const string BAKING = "/baking";
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
                SubPath = RouteConfig.HOME,
                LocalizationNamePath = "NavLink_Home",
                IsPublished = true
            },

            new Route
            {
                MaterialIcon = "Account_Box",
                SubPath = RouteConfig.CONTACT,
                LocalizationNamePath = "NavLink_Contact",
                IsPublished = false
            },
            new Route
            {
                MaterialIcon = "Assignment",
                SubPath = RouteConfig.RESUME,
                LocalizationNamePath = "NavLink_Resume",
                IsPublished = false
            },
            new Route
            {
                MaterialIcon = "Code",
                SubPath = RouteConfig.PROJECTS,
                LocalizationNamePath = "NavLink_Projects",
                IsPublished = false,
            },
            new Route
            {
                MaterialIcon = "Toys",
                SubPath = RouteConfig.TOYBOX,
                LocalizationNamePath = "NavLink_Toybox",
                IsPublished = true,
            },
            new Route
            {
                MaterialIcon = "Developer_Board",
                SubPath = RouteConfig.COMPONENTS,
                LocalizationNamePath = "NavLink_Components",
                IsPublished = false
            },
            new Route
            {
                MaterialIcon = "Grocery",
                SubPath = RouteConfig.KOMBUCHA,
                LocalizationNamePath = "NavLink_Kombucha",
                IsPublished = false
            },
            new Route
            {
                MaterialIcon = "Breakfast_Dining",
                SubPath = RouteConfig.BAKING,
                LocalizationNamePath = "NavLink_Baking",
                IsPublished = false
            }
            ]);

        public static AppRoutes HeaderRoutes { get; } = new AppRoutes(
        [
            new Route {
                SubPath = RouteConfig.HOME,
                LocalizationNamePath = "Header_Home",
                IsPublished = true
            },
            new Route {
                SubPath = RouteConfig.RESUME,
                LocalizationNamePath = "Header_Resume",
                IsPublished = true
            },
            new Route
            {
                MaterialIcon = "Code",
                SubPath = RouteConfig.PROJECTS,
                LocalizationNamePath = "NavLink_Projects",
                IsPublished = false,
            },
            new Route {
                SubPath = RouteConfig.CONTACT,
                LocalizationNamePath = "Header_Contact",
                IsPublished = true
            },
            new Route
            {
                MaterialIcon = RouteConfig.PLAYGROUND,
                SubPath = "playground",
                LocalizationNamePath = "Header_Playground",
                IsPublished = true,
            },
        ]);
    }
}
