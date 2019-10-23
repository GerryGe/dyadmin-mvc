using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using Dychar.Dyadmin.Authorization;

namespace Dychar.Dyadmin.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class DyadminNavigationProvider : NavigationProvider
    {
        public const string MenuName = "Dyadmin";
        public override void SetNavigation(INavigationProviderContext context)
        {
            var mainMenu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            mainMenu
                .AddItem(new MenuItemDefinition(
                        PageNames.Host.Dashboard,
                        L("HomePage"),
                        url: "Home",
                        icon: "fa fa-home",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Host_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                    PageNames.Host.Tenants,
                    L("Tenants"),
                    url: "Tenants",
                    icon: "fa fa-cubes",
                    permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenants)
                    )
                )
                //.AddItem(new MenuItemDefinition(
                //        PageNames.Host.Editions,
                //        L("Editions"),
                //        url: "AppAreaName/Editions",
                //        icon: "flaticon-app",
                //        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Editions)
                //    )
                //)
                .AddItem(new MenuItemDefinition(
                        PageNames.Tenant.Dashboard,
                        L("HomePage"),
                        url: "Home",
                        icon: "fa fa-desktop",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenant_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                        PageNames.Common.Administration,
                        L("Administration"),
                        icon: "fa fa-gear"
                    )
                //.AddItem(new MenuItemDefinition(
                //            PageNames.Common.OrganizationUnits,
                //            L("OrganizationUnits"),
                //            url: "AppAreaName/OrganizationUnits",
                //            icon: "flaticon-map",
                //            permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_OrganizationUnits)
                //        )
                //    )
                .AddItem(new MenuItemDefinition(
                            PageNames.Common.Roles,
                            L("Roles"),
                            url: "Roles",
                            icon: "fa fa-key",
                            permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Roles)
                        )
                    ).AddItem(new MenuItemDefinition(
                            PageNames.Common.Users,
                            L("Users"),
                            url: "Users",
                            icon: "fa fa-user",
                            permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Users)
                        )
                    )
                /*
                .AddItem(new MenuItemDefinition(
                        PageNames.Common.Languages,
                        L("Languages"),
                        url: "AppAreaName/Languages",
                        icon: "flaticon-tabs",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Languages)
                    )
                ).AddItem(new MenuItemDefinition(
                        PageNames.Common.AuditLogs,
                        L("AuditLogs"),
                        url: "AppAreaName/AuditLogs",
                        icon: "flaticon-folder-1",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_AuditLogs)
                    )
                ).AddItem(new MenuItemDefinition(
                        PageNames.Host.Maintenance,
                        L("Maintenance"),
                        url: "AppAreaName/Maintenance",
                        icon: "flaticon-lock",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Host_Maintenance)
                    )
                ).AddItem(new MenuItemDefinition(
                        PageNames.Tenant.SubscriptionManagement,
                        L("Subscription"),
                        url: "AppAreaName/SubscriptionManagement",
                        icon: "flaticon-refresh",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Tenant_SubscriptionManagement)
                    )
                ).AddItem(new MenuItemDefinition(
                        PageNames.Common.UiCustomization,
                        L("VisualSettings"),
                        url: "AppAreaName/UiCustomization",
                        icon: "flaticon-medical",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_UiCustomization)
                    )
                ).AddItem(new MenuItemDefinition(
                        PageNames.Host.Settings,
                        L("Settings"),
                        url: "AppAreaName/HostSettings",
                        icon: "flaticon-settings",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Host_Settings)
                    )
                )
                .AddItem(new MenuItemDefinition(
                        PageNames.Tenant.Settings,
                        L("Settings"),
                        url: "AppAreaName/Settings",
                        icon: "flaticon-settings",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Administration_Tenant_Settings)
                    )
                )*/
                )
                //.AddItem(new MenuItemDefinition(
                //        PageNames.Common.DemoUiComponents,
                //        L("DemoUiComponents"),
                //        url: "AppAreaName/DemoUiComponents",
                //        icon: "flaticon-shapes",
                //        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_DemoUiComponents)
                //    )
                //)
                .AddItem(
                        new MenuItemDefinition(
                            PageNames.Common.About,
                            L("About"),
                            url: "About",
                            icon: "fa fa-info-circle"
                        )
                    );


            //    context.Manager.MainMenu
            //        .AddItem(
            //            new MenuItemDefinition(
            //                PageNames.Home,
            //                L("HomePage"),
            //                url: "",
            //                icon: "fa fa-home",
            //                requiresAuthentication: true
            //            )
            //        ).AddItem(
            //            new MenuItemDefinition(
            //                PageNames.Tenants,
            //                L("Tenants"),
            //                url: "Tenants",
            //                icon: "fa fa-cubes",
            //                requiredPermissionName: PermissionNames.Pages_Tenants
            //            )
            //        ).AddItem(
            //            new MenuItemDefinition(
            //                PageNames.Users,
            //                L("Users"),
            //                url: "Users",
            //                icon: "fa fa-user",
            //                requiredPermissionName: PermissionNames.Pages_Users
            //            )
            //        ).AddItem(
            //            new MenuItemDefinition(
            //                PageNames.Roles,
            //                L("Roles"),
            //                url: "Roles",
            //                icon: "fa fa-key",
            //                requiredPermissionName: PermissionNames.Pages_Roles
            //            )
            //        )
            //        .AddItem(
            //            new MenuItemDefinition(
            //                PageNames.About,
            //                L("About"),
            //                url: "About",
            //                icon: "fa fa-info-circle"
            //            )
            //        ).AddItem(
            //            new MenuItemDefinition(
            //                "MultiLevelMenu",
            //                L("MultiLevelMenu"),
            //                icon: "fa fa-navicon"
            //            ).AddItem(
            //                new MenuItemDefinition(
            //                    "DyAdmin",
            //                    new FixedLocalizableString("DyAdmin")
            //                ).AddItem(
            //                    new MenuItemDefinition(
            //                        PageNames.Home,
            //                        new FixedLocalizableString("Home"),
            //                        url: ""
            //                    )
            //                ).AddItem(
            //                    new MenuItemDefinition(
            //                        PageNames.Users,
            //                        new FixedLocalizableString("Users"),
            //                        url: "Users"
            //                    )
            //                ).AddItem(
            //                    new MenuItemDefinition(
            //                        PageNames.Roles,
            //                        new FixedLocalizableString("Roles"),
            //                        url: "Roles"
            //                    )
            //                ).AddItem(
            //                    new MenuItemDefinition(
            //                        "AspNetBoilerplateDocuments",
            //                        new FixedLocalizableString("Documents"),
            //                        url: "https://aspnetboilerplate.com/Pages/Documents?ref=abptmpl"
            //                    )
            //                )
            //            )
            //        );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, DyadminConsts.LocalizationSourceName);
        }
    }
}
