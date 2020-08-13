namespace JSS.AppServices.Import
{
    using Sitecore.JavaScriptServices.AppServices.Models;

    public class ExpandRenderingParametersTemplates : Sitecore.JavaScriptServices.AppServices.Pipelines.Import.ExpandRenderingParametersTemplates
    {
        protected override TemplateDef CreateTemplateDefFromRenderingParametersDefs(RenderingDef rendering)
        {
            var result = base.CreateTemplateDefFromRenderingParametersDefs(rendering);

            result.Inherits = new[] { Sitecore.TemplateIDs.StandardTemplate.ToString() };

            return result;
        }
    }
}