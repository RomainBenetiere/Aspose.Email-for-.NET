﻿using Aspose.Email.Mapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email.Knowledge.Base
{
    class GetAttachmentsFromMSGFile
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_KnowledgeBase();

            // Load mail message
            MapiMessage msg = MapiMessage.FromFile(dataDir + "message3.msg");

            // ExStart:GetAttachmentsFromMSGFile
            // Iterate through the Attachments collection
            foreach (MapiAttachment att in msg.Attachments)
            {
                try
                {
                    // Show the name of the attachment on screen and Save to local drive/folder	
                    Console.WriteLine(att.LongFileName);
                    att.Save(att.LongFileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            // ExEnd:GetAttachmentsFromMSGFile
        }
    }
}
