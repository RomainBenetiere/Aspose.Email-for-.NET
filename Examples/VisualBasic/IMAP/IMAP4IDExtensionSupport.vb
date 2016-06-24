﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Aspose.Email.Outlook.Pst
Imports Aspose.Email
Imports Aspose.Email.Imap
Imports Aspose.Email.Outlook

' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET 
'   API reference when the project is build. Please check https://docs.nuget.org/consume/nuget-faq 
'   for more information. If you do not wish to use NuGet, you can manually download 
'   Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'   install it and then add its reference to this project. For any issues, questions or suggestions 
'   please feel free to contact us using http://www.aspose.com/community/forums/default.aspx            
'

Namespace Aspose.Email.Examples.VisualBasic.Email.IMAP
    Class IMAP4IDExtensionSupport
        Public Shared Sub Run()
            Using client As New ImapClient("imap.gmail.com", 993, "username", "password")
                ' Set SecurityOptions
                client.SecurityOptions = SecurityOptions.Auto

                Console.WriteLine(client.IdSupported.ToString())

                Dim serverIdentificationInfo1 As ImapIdentificationInfo = client.IntroduceClient()
                Dim serverIdentificationInfo2 As ImapIdentificationInfo = client.IntroduceClient(ImapIdentificationInfo.DefaultValue)

                ' Display ImapIdentificationInfo properties
                Console.WriteLine(serverIdentificationInfo1.ToString(), serverIdentificationInfo2.ToString())
                Console.WriteLine(serverIdentificationInfo1.Name)
                Console.WriteLine(serverIdentificationInfo1.Vendor)
                Console.WriteLine(serverIdentificationInfo1.SupportUrl)
                Console.WriteLine(serverIdentificationInfo1.Version)
            End Using
        End Sub
    End Class
End Namespace