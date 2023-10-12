using Aspose.PDF.Editor.AppResources.Editor;

namespace Aspose.PDF.Editor.ViewModel;

public class EditorViewModel
{
    private const string DefaultName = "PDF";

    public string CanonicalTag { get; set; }

    public string Title { get; protected set; }

    public string TitleSub { get; protected set; }

    public string PageTitle { get; protected set; }

    public string MetaDescription { get; protected set; }

    /// <summary>
    /// The full address of the application without query string ready for localization (e.g., /pdf{locale}/conversion)
    /// </summary>
    public string AppRouteTemplate
    {
        get
        {
            const string addIt = "";
            char[] charToTrim = { '/', '\\' };
            return "/pdf{0}/" + addIt.TrimEnd(charToTrim);
        }
    }

    public string this[string key] => RecheckLocalizedValue(Localize(key)) ?? $"NoKey:{"Editor" + key}";

    public EditorViewModel()
    {
        SetTitles();
    }

    public string Localize(string key) => SeoResources.ResourceManager.GetString(key);

    private string RecheckLocalizedValue(string value)
    {
        if (value == null) return null;

        if (value.Contains("{"))
            value = string.Format(value, DefaultName);

        if (value.Contains("href=") && !value.Contains("nofollow"))
            value = value.Replace("href=", "rel=\"nofollow noreferrer\" href=");
        else if (value.Contains("href=") && value.Contains("nofollow") && !value.Contains("nofollow noreferrer"))
            value = value.Replace("nofollow", "nofollow noreferrer");

        return value;
    }

    private string GetCanonicalUrl()
    {
        return $"https://localhost:5031/{AppRouteTemplate}";
    }

    private void SetTitles()
    {
        Title = Localize("Title");
        TitleSub = Localize("TitleSub");
        PageTitle = Localize("PageTitle");
        MetaDescription = Localize("MetaDescription");
        //cannonical links
        CanonicalTag = $"<link rel=\"canonical\" href=\"{GetCanonicalUrl()}\"/>";
    }
}