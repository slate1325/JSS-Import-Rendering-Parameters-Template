namespace JSS.AppServices.Import
{
    using Sitecore.JavaScriptServices.AppServices.Models;

    public class ExpandRenderingParametersTemplates : Sitecore.JavaScriptServices.AppServices.Pipelines.Import.ExpandRenderingParametersTemplates
    {
        private readonly string StandardRenderingParametersTemplate = "{8CA06D6A-B353-44E8-BC31-B528C7306971}";

        protected override TemplateDef CreateTemplateDefFromRenderingParametersDefs(RenderingDef rendering)
        {
            var result = base.CreateTemplateDefFromRenderingParametersDefs(rendering);

            result.Inherits = new[] { StandardRenderingParametersTemplate };

            return result;
        }
    }
}