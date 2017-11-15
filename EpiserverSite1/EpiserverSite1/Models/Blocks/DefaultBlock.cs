using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "DefaultBlock", GUID = "daf82455-33e7-4949-932e-b3e1d1b645df", Description = "")]
    public class DefaultBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual int Size { get; set; }

    }
}