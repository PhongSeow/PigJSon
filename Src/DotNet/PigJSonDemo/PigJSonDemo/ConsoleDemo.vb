Imports PigJSonLib
Imports PigCmdLib

Public Class ConsoleDemo
    Private pjAssemble As PigJSon
    Private pjParse As PigJSon
    Public JSonKey As String
    Public JSonStr As String
    Public PigConsole As New PigConsole

    Public Sub Main()
        Do While True
            Console.WriteLine("*******************")
            Console.WriteLine("Main menu")
            Console.WriteLine("*******************")
            Console.WriteLine("Press Q to Exit")
            Console.WriteLine("Press A to Assemble Demo")
            Console.WriteLine("Press B to Show JSon Value")
            Console.WriteLine("Press C to New PigJSon")
            Console.WriteLine("Press D to UnlockEndSymbol")
            Console.WriteLine("*******************")
            Select Case Console.ReadKey(True).Key
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
                        Select Case Console.ReadKey(True).Key
                            Case ConsoleKey.Q
                                Exit Do
                            Case ConsoleKey.A
                                Console.WriteLine("#################")
                                Me.SimpleTextElements("Simple text elements")
                                Console.WriteLine("#################")
                            Case ConsoleKey.B
                                Console.WriteLine("#################")
                                Me.SimpleMultipleDataElements("Simple multiple data types elements")
                                Console.WriteLine("#################")
                            Case ConsoleKey.C
                                Console.WriteLine("#################")
                                Me.SimpleArrayElements("Simple array elements")
                                Console.WriteLine("#################")
                            Case ConsoleKey.D
                                Console.WriteLine("#################")
                                Me.ComplexArrayElements("complex array elements")
                                Console.WriteLine("#################")
                        End Select
                    Loop
                Case ConsoleKey.B
                    Console.WriteLine("#################")
                    Me.PigConsole.GetLine("Input JSonKey", Me.JSonKey)
                    Console.WriteLine(Me.JSonKey & "=" & pjParse.GetStrValue(Me.JSonKey))
                    If pjParse.LastErr <> "" Then Console.WriteLine(Me.JSonKey & " error = " & pjParse.LastErr)
                    Console.WriteLine("#################")
                Case ConsoleKey.C
                    Console.WriteLine("#################")
                    Console.WriteLine("New PigJSon")
                    Console.WriteLine("#################")
                    Me.PigConsole.GetLine("Input JSon", Me.JSonStr)
                    Dim oPigJSon As New PigJSon(Me.JSonStr)
                    If oPigJSon.LastErr <> "" Then
                        Console.WriteLine(oPigJSon.LastErr)
                    Else
                        oPigJSon.ParseJSON()
                        If oPigJSon.LastErr <> "" Then
                            Console.WriteLine(oPigJSon.LastErr)
                        Else
                            Console.WriteLine("New and ParseJSON OK")
                            Console.WriteLine("MainJSonStr=" & oPigJSon.MainJSonStr)
                        End If
                    End If
                Case ConsoleKey.D
                    Console.WriteLine("#################")
                    Console.WriteLine("UnlockEndSymbol")
                    Console.WriteLine("#################")
                    Console.WriteLine("Input JSon:")
                    Dim strJSon As String = Console.ReadLine
                    Dim oPigJSon As New PigJSon(strJSon)
                    If oPigJSon.LastErr <> "" Then
                        Console.WriteLine(oPigJSon.LastErr)
                    Else
                        oPigJSon.ParseJSON()
                        If oPigJSon.LastErr <> "" Then
                            Console.WriteLine(oPigJSon.LastErr)
                        Else
                            Console.WriteLine("New and ParseJSON OK")
                            Console.WriteLine("MainJSonStr=" & oPigJSon.MainJSonStr)
                            Console.WriteLine("UnlockEndSymbol")
                            oPigJSon.UnlockEndSymbol()
                            If oPigJSon.LastErr <> "" Then
                                Console.WriteLine(oPigJSon.LastErr)
                            Else
                                Console.WriteLine("OK")
                                oPigJSon.AddEle("aaaa", "bbbb")
                                oPigJSon.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
                                Console.WriteLine("Re ParseJSON")
                                oPigJSon.ParseJSON()
                                If oPigJSon.LastErr <> "" Then
                                    Console.WriteLine(oPigJSon.LastErr)
                                Else
                                    Console.WriteLine("OK")
                                    Console.WriteLine(oPigJSon.MainJSonStr)
                                End If
                            End If
                        End If
                    End If
            End Select
        Loop
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub SimpleTextElements(Sender As String)
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

    Public Sub SimpleArrayElements(Sender As String)
        Dim strDisplay As String = ""
        strDisplay &= vbCrLf & "***" & Sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
        strDisplay &= "pjArray = New PigJSon" & vbCrLf
        strDisplay &= "With pjArray" & vbCrLf
        strDisplay &= vbTab & "'In this way, the content of the array element will be escaped." & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""Google"", True)" & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""GitHub"")" & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""Apache"")" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""TotalSites"", 3, True)" & vbCrLf
        strDisplay &= vbTab & ".AddOneArrayEle(""SitesList"", pjArray.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetIntValue(""TotalSites"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SitesList[0]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SitesList[1]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SitesList[2]""))" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

        Dim pjArray As PigJSon
        pjArray = New PigJSon
        With pjArray
            .AddEle("", "Google", True)
            .AddEle("", "GitHub")
            .AddEle("", "Apache")
        End With
        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("TotalSites", 3, True)
            .AddOneArrayEle("SitesList", pjArray.MainJSonStr)
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            If .ParseJSON() = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetIntValue("TotalSites").ToString & vbCrLf
                strDisplay &= .GetStrValue("SitesList[0]") & vbCrLf
                strDisplay &= .GetStrValue("SitesList[1]") & vbCrLf
                strDisplay &= .GetStrValue("SitesList[2]") & vbCrLf
                strDisplay &= "```" & vbCrLf
            End If
        End With
        Console.WriteLine(strDisplay)
    End Sub

    Public Sub ComplexArrayElements(Sender As String)
        Dim strDisplay As String = ""
        strDisplay &= vbCrLf & "***" & Sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
        strDisplay &= "pjOneCompany = New PigJSon" & vbCrLf
        strDisplay &= "pjArray = New PigJSon" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Name"", ""Company products"", True)" & vbCrLf
        strDisplay &= vbTab & ".AddArrayEleBegin(""CompanyProductList"")" & vbCrLf
        strDisplay &= vbTab & "With pjArray" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Windows"", True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""SQL Server"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Office"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Azure"")" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & "With pjOneCompany" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddOneArrayEle(""ProductList"", pjArray.MainJSonStr, True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle(""CompanyName"", ""Microsoft"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & ".AddArrayEleValue(pjOneCompany.MainJSonStr, True)" & vbCrLf
        strDisplay &= vbTab & "With pjArray" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Chrome"", True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""YouTube"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Android"")" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & "With pjOneCompany" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle(""CompanyName"", ""Google"", True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddOneArrayEle(""ProductList"", pjArray.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & ".AddArrayEleValue(pjOneCompany.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.ArrayEndFlag)" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""TotalCompanies"", 2)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""Name""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetIntValue(""TotalCompanies"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[0].CompanyName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[0].ProductList[2]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[0].ProductList[3]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[1].CompanyName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[1].ProductList[1]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[1].ProductList[2]""))" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

        Dim pjOneCompany As PigJSon

        Dim pjArray As PigJSon
        pjOneCompany = New PigJSon
        pjArray = New PigJSon
        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("Name", "Company products", True)
            .AddArrayEleBegin("CompanyProductList")
            With pjArray
                .Reset()
                .AddEle("", "Windows", True)
                .AddEle("", "SQL Server")
                .AddEle("", "Office")
                .AddEle("", "Azure")
            End With
            With pjOneCompany
                .Reset()
                .AddOneArrayEle("ProductList", pjArray.MainJSonStr, True)
                .AddEle("CompanyName", "Microsoft")
                .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            End With
            .AddArrayEleValue(pjOneCompany.MainJSonStr, True)
            With pjArray
                .Reset()
                .AddEle("", "Chrome", True)
                .AddEle("", "YouTube")
                .AddEle("", "Android")
            End With
            With pjOneCompany
                .Reset()
                .AddEle("CompanyName", "Google", True)
                .AddOneArrayEle("ProductList", pjArray.MainJSonStr)
                .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            End With
            .AddArrayEleValue(pjOneCompany.MainJSonStr)
            .AddSymbol(PigJSon.xpSymbolType.ArrayEndFlag)
            .AddEle("TotalCompanies", 2)
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            If .ParseJSON() = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetStrValue("Name") & vbCrLf
                strDisplay &= .GetIntValue("TotalCompanies").ToString & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[0].CompanyName") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[0].ProductList[2]") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[0].ProductList[3]") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[1].CompanyName") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[1].ProductList[1]") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[1].ProductList[2]") & vbCrLf
                strDisplay &= "```" & vbCrLf
            End If
        End With
        Console.WriteLine(strDisplay)
    End Sub

    Public Sub SimpleMultipleDataElements(Sender As String)
        Dim strDisplay As String = ""
        strDisplay &= vbCrLf & "***" & Sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteName"", ""Seow Phong Web Site"", True)    'The first element needs to be explicitly specified" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteUrl"", ""http://www.seowphong.com"")  'The default is not the first element" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Describe"", ""A website for free software"" & vbCrLf & "" and shareware"") 'The text contains a carriage return" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Rank"", 168)" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""VisitPerDay"", CDec(168.88))" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""VisitTimeStr"", ""8/8/2020"")" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""VisitTime"", Now)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteUrl""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""Describe""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetIntValue(""Rank"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetDecValue(""VisitPerDay"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""VisitTimeStr""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetDateValue(""VisitTime"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetDateValue(""VisitTime"", True).ToString)" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified
            .AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element
            .AddEle("Describe", "A website for free software" & vbCrLf & " and shareware")  'The text contains a carriage return
            .AddEle("Rank", 168)
            .AddEle("VisitPerDay", CDec(168.88))
            .AddEle("VisitTimeStr", "8/8/2020")
            .AddEle("VisitTime", Now)
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            If .ParseJSON() = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetStrValue("SiteName") & vbCrLf
                strDisplay &= .GetStrValue("SiteUrl") & vbCrLf
                strDisplay &= .GetStrValue("Describe") & vbCrLf
                strDisplay &= .GetIntValue("Rank").ToString & vbCrLf
                strDisplay &= .GetDecValue("VisitPerDay").ToString & vbCrLf
                strDisplay &= .GetStrValue("VisitTimeStr") & vbCrLf
                strDisplay &= .GetDateValue("VisitTime").ToString & vbCrLf
                strDisplay &= .GetDateValue("VisitTime", True).ToString & vbCrLf
                strDisplay &= "```" & vbCrLf
            End If
        End With
        Console.WriteLine(strDisplay)
    End Sub

End Class
