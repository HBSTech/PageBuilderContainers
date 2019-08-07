﻿using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace PageBuilderContainers
{
    /// <summary>
    /// Base instance of the IPageBuilderContainerProperties, you can have your widget model inherit this instead of implementing yourself.
    /// </summary>
    public class PageBuilderSectionProperties : IPageBuilderContainerProperties, ISectionProperties
    {
        [EditingComponent(PageBuilderContainerSelectorComponent.IDENTIFIER, Order = 990, Label = "Container Name")]
        public string ContainerName { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 991, Label = "Container Title", Tooltip = "Container must have {% ContainerTitle %}")]
        public string ContainerTitle { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 992, Label = "Container CSS Class", Tooltip = "Container must have {% ContainerCSSClass %}")]
        public string ContainerCSSClass { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 993, Label = "Container Custom Content", Tooltip = "Container must have {% ContainerCustomContent %}")]
        public string ContainerCustomContent { get; set; }
    }

    
}
