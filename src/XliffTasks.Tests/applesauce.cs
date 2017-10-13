// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.IO;
using XliffTasks.Model;
using XliffTasks.Tasks;
using Xunit;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace XliffTasks.Tests
{
    public class AppleSauceTests
    {
        [Fact]
        public void RewriteHrefOfImageToAbsoluteInDestinyFolder()
        {
            var updateXlf = new UpdateXlf();
            var a = new TaskItem();
            a.ItemSpec = "Resource1.resx";
            a.SetMetadata(MetadataKey.XlfSourceFormat, "Resx");
            
            updateXlf.Sources = new[] { a };
            updateXlf.Languages = new[] { "cs" };
            updateXlf.AllowModification = true;

            updateXlf.Execute();

        }
    }
}
