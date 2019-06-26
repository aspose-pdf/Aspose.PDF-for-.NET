// Copyright (c) Aspose 2002-2014. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AsposeVisualStudioPluginPdf.Core
{
    public class AsposeComponents
    {
        public static Dictionary<String, AsposeComponent> list = new Dictionary<string, AsposeComponent>();
        public AsposeComponents()
        {
            list.Clear();
            
            AsposeComponent asposePdf = new AsposeComponent();
            asposePdf.set_downloadUrl("");
            asposePdf.set_downloadFileName("aspose.Pdf.zip");
            asposePdf.set_name(Constants.ASPOSE_COMPONENT);
            asposePdf.set_remoteExamplesRepository("https://github.com/asposepdf/Aspose_Pdf_NET.git");
            list.Add(Constants.ASPOSE_COMPONENT, asposePdf);
        }
    }
}
