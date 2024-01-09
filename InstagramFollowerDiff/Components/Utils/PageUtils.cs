using Microsoft.AspNetCore.Components;

namespace InstagramFollowerDiff.Components.Utils
{
    public static class PageUtils
    {

        public static void ReloadPage(this NavigationManager manager)
        {
            manager.NavigateTo(manager.Uri, true);
        }
    }
}
