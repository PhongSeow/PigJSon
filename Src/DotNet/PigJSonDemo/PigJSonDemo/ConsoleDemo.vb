Imports PigJSonLib

Public Class ConsoleDemo
    Private pjAssemble As PigJSon
    Private pjParse As PigJSon
    Private strJSonKey As String

    Public Sub Main()
        Do While True
            Console.WriteLine("*******************")
            Console.WriteLine("Main menu")
            Console.WriteLine("*******************")
            Console.WriteLine("Press Q to Exit")
            Console.WriteLine("Press A to Assemble Demo")
            Console.WriteLine("Press B to Parse JSon")
            Console.WriteLine("Press C to Show JSon Value")
            Console.WriteLine("*******************")
            Select Case Console.ReadKey().Key
                Case ConsoleKey.Q
                    Exit Do
                Case ConsoleKey.A
                    Do While True
                        Console.WriteLine("*******************")
                        Console.WriteLine("Menu Assemble Demo")
                        Console.WriteLine("*******************")
                        Console.WriteLine("Press Q to Up")
                        Console.WriteLine("Press A to Simple text elements")
                        Console.WriteLine("Press B to Simple multiple data types elements")
                        Console.WriteLine("Press C to Simple array elements")
                        Console.WriteLine("Press D to complex array elements")
                        Console.WriteLine("*******************")
                        Select Case Console.ReadKey().Key
                            Case ConsoleKey.Q
                                Exit Do
                            Case ConsoleKey.A
                                Console.WriteLine("#################")
                                Me.SimpleElements("Simple text elements")
                                Console.WriteLine("#################")
                            Case ConsoleKey.B
                            Case ConsoleKey.C
                            Case ConsoleKey.D
                        End Select
                    Loop
                Case ConsoleKey.B
                Case ConsoleKey.C
            End Select
        Loop
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub SimpleElements(Sender As String)
        Dim strRet As String
        Dim strDisplay As String = ""
        strDisplay &= vbCrLf & "***" & Sender & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteName"", ""Seow Phong Web Site"", True)    'The first element needs to be explicitly specified" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteUrl"", ""http://www.seowphong.com"")  'The default is not the first element" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Describe"", ""A website for free software"" & vbCrLf & "" and shareware"") 'The text contains a carriage return" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteUrl""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""Describe""))" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified
            .AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element
            .AddEle("Describe", "A website for free software" & vbCrLf & " and shareware")  'The text contains a carriage return
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            strRet = .ParseJSON()
            If strRet = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetStrValue("SiteName") & vbCrLf
                strDisplay &= .GetStrValue("SiteUrl") & vbCrLf
                strDisplay &= .GetStrValue("Describe") & vbCrLf
                strDisplay &= "```" & vbCrLf
            Else
                strDisplay &= strRet & vbCrLf
            End If
        End With
        Console.WriteLine(strDisplay)
    End Sub

End Class
