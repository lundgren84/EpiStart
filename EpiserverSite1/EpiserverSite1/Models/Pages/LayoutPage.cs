using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "LayoutPage", GUID = "34962673-2a61-472e-b693-91bdfa342011", Description = "")]
    public class LayoutPage : PageData
    {
        [Display(
        Name = "Heading",
        Description = "Bla bla",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString MainBody { get; set; }


        public virtual ContentArea contArea { get; set; }

    }
}