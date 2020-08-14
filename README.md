# JSS-Import-Rendering-Prameters-Template
Fixes https://github.com/Sitecore/jss/issues/427

## How to use
* Clone the repo
* Build the app
* Deploy the binary (JSS.AppServices.Import.dll)
* Add a sitecore config include patch to your sitecore instance:
```xml
<pipelines>
    <group groupName="javaScriptServices" patch:source="Sitecore.XA.JSS.Foundation.Presentation.config">
        <pipelines>
            <import>
                <processor type="JSS.AppServices.Import.ExpandRenderingParametersTemplates, JSS.AppServices.Import" patch:instead="processor[@type='Sitecore.JavaScriptServices.AppServices.Pipelines.Import.ExpandRenderingParametersTemplates, Sitecore.JavaScriptServices.AppServices']"/>
            </import>
        </pipelines>
    </group>
</pipelines>
```